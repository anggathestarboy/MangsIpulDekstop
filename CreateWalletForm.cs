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
    public partial class CreateWalletForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string ApiUrl = "https://mangsipul.alwaysdata.net/api/wallets";

        public CreateWalletForm()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async void btnSimpanWallet_Click(object sender, EventArgs e)
        {
            string walletName = txtNamaWallet.Text.Trim();

            if (string.IsNullOrEmpty(walletName) || walletName == "Contoh: Dompet Utama, Tabungan, Dana Darurat")
            {
                MessageBox.Show("Nama wallet wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSimpanWallet.Enabled = false;
            btnSimpanWallet.Text = "Menyimpan...";

            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Sesi Anda telah berakhir. Silakan login kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var requestData = new { name = walletName };
                string json = JsonSerializer.Serialize(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                
                var response = await client.PostAsync(ApiUrl, content);
                string responseJson = await response.Content.ReadAsStringAsync();
                
                using (JsonDocument doc = JsonDocument.Parse(responseJson))
                {
                    string message = doc.RootElement.TryGetProperty("message", out var msgProp) ? msgProp.GetString() : "Gagal menyimpan wallet.";
                    
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(message, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNamaWallet.Text = "";
                        txtNamaWallet.ForeColor = Color.Gray;
                        txtNamaWallet.Text = "Contoh: Dompet Utama, Tabungan, Dana Darurat";
                    }
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSimpanWallet.Enabled = true;
                btnSimpanWallet.Text = "Simpan Wallet";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Assuming there's a WalletListForm. If not, maybe go to Dashboard?
            // For now, I'll try to follow the pattern. 
            // If WalletListForm doesn't exist, I might need to create it or just go back to Dashboard.
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void txtNamaWallet_Enter(object sender, EventArgs e)
        {
            if (txtNamaWallet.Text == "Contoh: Dompet Utama, Tabungan, Dana Darurat")
            {
                txtNamaWallet.Text = "";
                txtNamaWallet.ForeColor = Color.Black;
            }
        }

        private void txtNamaWallet_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaWallet.Text))
            {
                txtNamaWallet.Text = "Contoh: Dompet Utama, Tabungan, Dana Darurat";
                txtNamaWallet.ForeColor = Color.Gray;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            btnBack_Click(sender, e);
        }
    }
}
