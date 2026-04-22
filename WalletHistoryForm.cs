using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class WalletHistoryForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string _baseUrl = "https://mangsipul.alwaysdata.net/api/wallet-money";

        public WalletHistoryForm()
        {
            InitializeComponent();
            LoadUserInfo();
            
            // Default filter: last 1 month
            dtpStart.Value = DateTime.Now.AddMonths(-1);
            dtpEnd.Value = DateTime.Now;
            cmbTypeFilter.SelectedIndex = 0; // "Semua"

            dgvHistory.CellFormatting += DgvHistory_CellFormatting;
            dgvHistory.CellContentClick += DgvHistory_CellContentClick;

            FetchHistory();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async void FetchHistory()
        {
            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token)) return;

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                string typeParam = cmbTypeFilter.SelectedItem.ToString();
                string url = $"{_baseUrl}?start_date={dtpStart.Value:yyyy-MM-dd}&end_date={dtpEnd.Value:yyyy-MM-dd}";
                
                if (typeParam != "Semua")
                {
                    url += $"&type={typeParam}";
                }

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var historyResponse = JsonSerializer.Deserialize<WalletMoneyResponse>(json);

                    if (historyResponse?.WalletMoney != null)
                    {
                        DisplayData(historyResponse.WalletMoney);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data riwayat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayData(List<WalletMoney> data)
        {
            dgvHistory.Rows.Clear();
            decimal totalIncome = 0;
            decimal totalExpense = 0;

            foreach (var item in data)
            {
                int rowIndex = dgvHistory.Rows.Add(
                    DateTime.Parse(item.Date).ToString("dd/MM/yy HH:mm"),
                    item.Wallet?.Name ?? "-",
                    item.MoneyType?.Name ?? "-",
                    item.Description,
                    "Rp " + item.Amount.ToString("N0"),
                    item.MoneyType?.Type == "income" ? "Pemasukan" : "Pengeluaran"
                );

                dgvHistory.Rows[rowIndex].Tag = item;

                if (item.MoneyType?.Type == "income")
                    totalIncome += item.Amount;
                else
                    totalExpense += item.Amount;
            }

            lblTotalCount.Text = data.Count.ToString();
            lblTotalIncome.Text = "Rp " + totalIncome.ToString("N0");
            lblTotalExpense.Text = "Rp " + totalExpense.ToString("N0");
        }

        private void DgvHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var item = dgvHistory.Rows[e.RowIndex].Tag as WalletMoney;
            if (item == null) return;

            // Format Amount column (index 4)
            if (e.ColumnIndex == 4)
            {
                e.CellStyle.ForeColor = item.MoneyType?.Type == "income" ? Color.FromArgb(21, 128, 61) : Color.FromArgb(185, 28, 28);
                e.CellStyle.Font = new Font(dgvHistory.Font, FontStyle.Bold);
            }

            // Format Type column (index 5)
            if (e.ColumnIndex == 5)
            {
                if (item.MoneyType?.Type == "income")
                {
                    e.CellStyle.BackColor = Color.FromArgb(220, 252, 231);
                    e.CellStyle.ForeColor = Color.FromArgb(21, 128, 61);
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromArgb(254, 226, 226);
                    e.CellStyle.ForeColor = Color.FromArgb(185, 28, 28);
                }
            }
        }

        private async void DgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Action column is index 6
            if (e.ColumnIndex == 6)
            {
                var item = dgvHistory.Rows[e.RowIndex].Tag as WalletMoney;
                if (item == null) return;

                var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus transaksi ini?", "Konfirmasi Hapus", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    await DeleteTransaction(item.Id, e.RowIndex);
                }
            }
        }

        private async Task DeleteTransaction(int id, int rowIndex)
        {
            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await client.DeleteAsync($"{_baseUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    dgvHistory.Rows.RemoveAt(rowIndex);
                    FetchHistory(); // Refresh summary
                    MessageBox.Show("Transaksi berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            FetchHistory();
        }
    }
}
