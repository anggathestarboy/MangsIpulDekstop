using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;
using System.Linq;

namespace MangsIpulAsli
{
    public partial class TransactionListForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://mangsipul.alwaysdata.net/";
        private const string ApiUrl = BaseUrl + "api/transaction";
        private int currentPage = 1;
        private bool _isLoading = false;

        public TransactionListForm()
        {
            InitializeComponent();
            SetupDataGridView();
            InitializeForm();
            LoadUserInfo();
        }

        private async void InitializeForm()
        {
            await LoadData(1);
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private void SetupDataGridView()
        {
            dgvTransactions.RowTemplate.Height = 60;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.ReadOnly = true;
            
            // Customize appearance to match the image
            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(249, 115, 22);
            dgvTransactions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10);
            dgvTransactions.ColumnHeadersHeight = 40;
            
            dgvTransactions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 247, 237);
            dgvTransactions.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvTransactions.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            
            dgvTransactions.CellFormatting += DgvTransactions_CellFormatting;
            dgvTransactions.CellDoubleClick += DgvTransactions_CellDoubleClick;
        }

        private void DgvTransactions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var transaction = dgvTransactions.Rows[e.RowIndex].Tag as Transaction;
                if (transaction != null)
                {
                    TransactionDetailForm detailForm = new TransactionDetailForm(transaction);
                    if (detailForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh data if something changed
                        _ = LoadData(currentPage);
                    }
                }
            }
        }

        private void DgvTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTransactions.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString().ToLower();
                switch (status)
                {
                    case "pending_admin":
                        e.CellStyle.ForeColor = Color.FromArgb(245, 158, 11); // Amber/Orange
                        e.Value = "🕒 Pending Admin";
                        break;
                    case "sudah_diterima":
                        e.CellStyle.ForeColor = Color.FromArgb(147, 51, 234); // Purple
                        e.Value = "✔ Sudah Diterima";
                        break;
                    case "sedang_dikirim":
                        e.CellStyle.ForeColor = Color.FromArgb(37, 99, 235); // Blue
                        e.Value = "🚚 Sedang Dikirim";
                        break;
                    case "paid":
                        e.CellStyle.ForeColor = Color.FromArgb(22, 163, 74); // Green
                        e.Value = "✔ Paid";
                        break;
                    case "pending":
                        e.CellStyle.ForeColor = Color.FromArgb(202, 138, 4); // Yellow
                        e.Value = "⌛ Pending";
                        break;
                    case "rejected":
                        e.CellStyle.ForeColor = Color.FromArgb(220, 38, 38); // Red
                        e.Value = "✖ Ditolak";
                        break;
                }
            }
        }

        private async Task LoadData(int page = 1)
        {
            if (_isLoading) return;

            try
            {
                _isLoading = true;
                currentPage = page;
                
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Sesi telah berakhir. Silakan login kembali.", "Sesi Berakhir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var queryParams = new List<string>();
                queryParams.Add($"page={page}");
                
                if (txtSearch.Text != "Search by user or product..." && !string.IsNullOrEmpty(txtSearch.Text))
                {
                    queryParams.Add($"search={Uri.EscapeDataString(txtSearch.Text)}");
                }

                if (cmbStatus.SelectedIndex > 0)
                {
                    string status = cmbStatus.SelectedItem.ToString().ToLower().Replace(" ", "_");
                    queryParams.Add($"status={status}");
                }

                string url = $"{ApiUrl}?" + string.Join("&", queryParams);

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var transactionResponse = JsonSerializer.Deserialize<TransactionResponse>(json);
                    
                    if (transactionResponse != null && transactionResponse.Data != null)
                    {
                        dgvTransactions.Rows.Clear();
                        DisplayTransactions(transactionResponse.Data.Data);
                        UpdatePagination(transactionResponse.Data);
                    }
                }
                else
                {
                    MessageBox.Show("Gagal mengambil data transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isLoading = false;
            }
        }

        private void DisplayTransactions(List<Transaction> transactions)
        {
            if (transactions == null) return;

            foreach (var transaction in transactions)
            {
                string customerInfo = transaction.PaymentProfile?.Name ?? "Unknown";
                string customerEmail = transaction.PaymentProfile?.User?.Email ?? "";
                
                int rowIndex = dgvTransactions.Rows.Add(
                    "#" + transaction.Id,
                    customerInfo + "\n" + customerEmail,
                    "Rp " + transaction.TotalPrice.ToString("N0"),
                    transaction.Status,
                    transaction.CreatedAt.ToString("dd MMM yyyy")
                );
                
                // Set tag for identification
                dgvTransactions.Rows[rowIndex].Tag = transaction;
            }
        }

        private void UpdatePagination(TransactionPagination response)
        {
            lblPageInfo.Text = $"Showing {response.From} to {response.To} of {response.Total} entries";
            btnPrev.Enabled = response.CurrentPage > 1;
            btnNext.Enabled = response.CurrentPage < response.LastPage;
            
            lblCurrentPage.Text = response.CurrentPage.ToString();
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                await LoadData(currentPage - 1);
            }
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            await LoadData(currentPage + 1);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Simple debounce using Task.Delay
            string currentText = txtSearch.Text;
            await Task.Delay(500);
            if (currentText == txtSearch.Text && txtSearch.Focused)
            {
                await LoadData(1);
            }
        }

        private async void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IsHandleCreated)
            {
                await LoadData(1);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by user or product...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by user or product...";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}
