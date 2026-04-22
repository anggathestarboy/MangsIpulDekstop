using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class WalletDetailForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private int _walletId;
        private string _baseUrl = "https://mangsipul.alwaysdata.net/api/wallets";

        public WalletDetailForm(int walletId)
        {
            InitializeComponent();
            _walletId = walletId;
            LoadUserInfo();
            
            // Default filter: last 1 month as per image
            dtpStart.Value = DateTime.Now.AddMonths(-1);
            dtpEnd.Value = DateTime.Now;

            // Customize DataGridView behavior
            dgvTransactions.CellFormatting += DgvTransactions_CellFormatting;

            // Edit Wallet Name on double click
            lblWalletName.DoubleClick += LblWalletName_DoubleClick;
            lblWalletName.Cursor = Cursors.Hand;

            FetchWalletDetail();
        }

        private async void LblWalletName_DoubleClick(object sender, EventArgs e)
        {
            InputDialog dialog = new InputDialog("Ubah Nama Wallet", "Masukkan nama wallet baru:", lblWalletName.Text);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string newName = dialog.InputText.Trim();
                if (!string.IsNullOrEmpty(newName))
                {
                    await UpdateWalletName(newName);
                }
            }
        }

        private async Task UpdateWalletName(string newName)
        {
            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Sesi Anda telah berakhir. Silakan login kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var requestData = new { name = newName };
                string json = JsonSerializer.Serialize(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                string url = $"{_baseUrl}/{_walletId}";
                var response = await client.PutAsync(url, content);
                
                if (response.IsSuccessStatusCode)
                {
                    lblWalletName.Text = newName;
                    MessageBox.Show("Nama wallet berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string responseJson = await response.Content.ReadAsStringAsync();
                    string errorMessage = "Gagal memperbarui nama wallet.";
                    
                    try
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseJson))
                        {
                            if (doc.RootElement.TryGetProperty("message", out var msgProp))
                            {
                                errorMessage = msgProp.GetString();
                            }
                        }
                    }
                    catch { }

                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async void FetchWalletDetail()
        {
            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token)) return;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                string url = $"{_baseUrl}/{_walletId}?start_date={dtpStart.Value:yyyy-MM-dd}&end_date={dtpEnd.Value:yyyy-MM-dd}";

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    using (JsonDocument doc = JsonDocument.Parse(json))
                    {
                        var root = doc.RootElement;
                        var wallet = root.GetProperty("wallet");
                        
                        // Top Summary Section
                        lblWalletName.Text = wallet.GetProperty("name").GetString();
                        lblBalance.Text = "Rp " + wallet.GetProperty("balance").GetDecimal().ToString("N0");
                        
                        decimal mIn = ParseDecimal(wallet.GetProperty("money_in"));
                        decimal mOut = ParseDecimal(wallet.GetProperty("money_out"));
                        decimal diff = ParseDecimal(wallet.GetProperty("difference"));

                        lblMoneyIn.Text = "Rp " + mIn.ToString("N0");
                        lblMoneyOut.Text = "Rp " + mOut.ToString("N0");
                        lblDifference.Text = "Rp " + diff.ToString("N0");

                        // Transaction List
                        dgvTransactions.Rows.Clear();
                        var transactions = root.GetProperty("transactions");
                        foreach (var trans in transactions.EnumerateArray())
                        {
                            string tName = trans.GetProperty("description").GetString(); // In image it looks like name is desc or type name
                            var mType = trans.GetProperty("money_type");
                            string typeName = mType.GetProperty("name").GetString();
                            string typeCategory = mType.GetProperty("type").GetString(); // income / expense
                            decimal amount = trans.GetProperty("amount").GetDecimal();
                            string dateStr = trans.GetProperty("date").GetString();
                            DateTime date = DateTime.Parse(dateStr);

                            dgvTransactions.Rows.Add(
                                date.ToString("dd MMM yyyy"),
                                typeCategory == "income" ? "Pemasukan" : "Pengeluaran",
                                typeName,
                                "Rp " + amount.ToString("N0")
                            );

                            int rowIndex = dgvTransactions.Rows.Count - 1;
                            dgvTransactions.Rows[rowIndex].Tag = typeCategory; // Store type for formatting
                        }

                        // Footer Summary
                        lblIncomeSummary.Text = "Total Income: Rp " + mIn.ToString("N0");
                        lblExpenseSummary.Text = "Total Expense: Rp " + mOut.ToString("N0");
                        lblNetSummary.Text = "Net: Rp " + diff.ToString("N0");
                        lblNetSummary.ForeColor = diff >= 0 ? Color.Green : Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data detail wallet: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ParseDecimal(JsonElement prop)
        {
            if (prop.ValueKind == JsonValueKind.String)
            {
                string val = prop.GetString();
                if (decimal.TryParse(val, out decimal res)) return res;
            }
            else if (prop.ValueKind == JsonValueKind.Number)
            {
                return prop.GetDecimal();
            }
            return 0;
        }

        private void DgvTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Format Tipe column (index 1) as badge
            if (e.ColumnIndex == 1)
            {
                string type = dgvTransactions.Rows[e.RowIndex].Tag?.ToString();
                if (type == "income")
                {
                    e.CellStyle.BackColor = Color.FromArgb(220, 252, 231); // Light Green
                    e.CellStyle.ForeColor = Color.FromArgb(21, 128, 61);   // Dark Green
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(254, 226, 226); // Light Red
                    e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);   // Dark Red
                }
            }

            // Format Amount column (index 3) color
            if (e.ColumnIndex == 3)
            {
                string type = dgvTransactions.Rows[e.RowIndex].Tag?.ToString();
                e.CellStyle.ForeColor = (type == "income") ? Color.Green : Color.Red;
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FetchWalletDetail();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WalletListForm listForm = new WalletListForm();
            listForm.Show();
            this.Hide();
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
