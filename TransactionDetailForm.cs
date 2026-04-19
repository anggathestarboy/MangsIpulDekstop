using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class TransactionDetailForm : Form
    {
        private Transaction _transaction;
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://mangsipul.alwaysdata.net/";

        public TransactionDetailForm(Transaction transaction)
        {
            _transaction = transaction;
            InitializeComponent();
            SetupUI();
            LoadData();
        }

        private void SetupUI()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            dgvItems.RowTemplate.Height = 40;
            dgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);
            dgvItems.EnableHeadersVisualStyles = false;

            // Configure action panel based on status
            ConfigureActions();
        }

        private void ConfigureActions()
        {
            pnlApproveReject.Visible = false;
            pnlStatusUpdate.Visible = false;
            lblReadOnly.Visible = false;

            string status = _transaction.Status?.ToLower();

            if (status == "pending_admin")
            {
                pnlApproveReject.Visible = true;
            }
            else if (status == "pending")
            {
                lblReadOnly.Visible = true;
                lblReadOnly.Text = "Status: Menunggu Pembayaran (Read Only)";
            }
            else
            {
                pnlStatusUpdate.Visible = true;
                cmbUpdateStatus.Items.Clear();
                cmbUpdateStatus.Items.Add("Sedang Dikirim");
                cmbUpdateStatus.Items.Add("Sudah Diterima");
                
                // Set current status in combo if applicable
                if (status == "sedang_dikirim") cmbUpdateStatus.SelectedIndex = 0;
                else if (status == "sudah_diterima") cmbUpdateStatus.SelectedIndex = 1;
            }
        }

        private void LoadData()
        {
            lblOrderId.Text = "Order ID: #" + _transaction.Id;
            lblDate.Text = "Tanggal: " + _transaction.CreatedAt.ToString("dd MMM yyyy HH:mm");
            lblCustomerName.Text = _transaction.PaymentProfile?.Name ?? "N/A";
            lblCustomerEmail.Text = _transaction.PaymentProfile?.User?.Email ?? "N/A";
            lblCustomerPhone.Text = _transaction.PaymentProfile?.PhoneNumber ?? "N/A";
            lblAddress.Text = $"{_transaction.PaymentProfile?.Address}, {_transaction.PaymentProfile?.Village}, {_transaction.PaymentProfile?.District}, {_transaction.PaymentProfile?.Regencie}, {_transaction.PaymentProfile?.Province}";
            lblTotalPrice.Text = "Rp " + _transaction.TotalPrice.ToString("N0");
            lblCurrentStatus.Text = "Status Saat Ini: " + _transaction.Status;

            dgvItems.Rows.Clear();
            if (_transaction.Details != null)
            {
                foreach (var detail in _transaction.Details)
                {
                    dgvItems.Rows.Add(
                        detail.Product?.Title ?? "Unknown Product",
                        detail.Qty,
                        "Rp " + detail.Product?.Price.ToString("N0"),
                        "Rp " + detail.SubPrice.ToString("N0")
                    );
                }
            }
        }

        private async void btnApprove_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtFinalPrice.Text, out decimal finalPrice))
            {
                MessageBox.Show("Masukkan harga final yang valid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var data = new { final_price = finalPrice };
                string json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                string url = $"{BaseUrl}api/transaction/{_transaction.Id}/approve";
                var response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Transaksi berhasil disetujui.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Gagal menyetujui transaksi: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnReject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin menolak transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                string url = $"{BaseUrl}api/transaction/{_transaction.Id}/reject";
                var response = await client.PostAsync(url, null);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Transaksi telah ditolak.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menolak transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (cmbUpdateStatus.SelectedIndex < 0) return;

            string newStatus = cmbUpdateStatus.SelectedItem.ToString().ToLower().Replace(" ", "_");
            
            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var data = new { status = newStatus };
                string json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Use PATCH and the singular /transaction/{id} endpoint
                string url = $"{BaseUrl}api/transaction/{_transaction.Id}";
                
                var request = new HttpRequestMessage(new HttpMethod("PATCH"), url)
                {
                    Content = content
                };

                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Status berhasil diperbarui.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Gagal memperbarui status: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
