using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class ResetPasswordForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string ApiUrl = "https://mangsipul.alwaysdata.net/api/reset-default-password";

        public ResetPasswordForm()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private void TogglePasswordVisibility(TextBox txt, Label btn)
        {
            txt.UseSystemPasswordChar = !txt.UseSystemPasswordChar;
            btn.Text = txt.UseSystemPasswordChar ? "👁" : "👁‍🗨";
        }

        private void btnShowCurrent_Click(object sender, EventArgs e) => TogglePasswordVisibility(txtCurrentPassword, lblShowCurrent);
        private void btnShowNew_Click(object sender, EventArgs e) => TogglePasswordVisibility(txtNewPassword, lblShowNew);
        private void btnShowConfirm_Click(object sender, EventArgs e) => TogglePasswordVisibility(txtConfirmPassword, lblShowConfirm);

        private async void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text) || 
                string.IsNullOrEmpty(txtNewPassword.Text) || 
                string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Konfirmasi password baru tidak cocok!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token)) return;

                var requestBody = new
                {
                    current_password = txtCurrentPassword.Text,
                    password = txtNewPassword.Text,
                    password_confirmation = txtConfirmPassword.Text
                };

                string json = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                // Use SendAsync for PATCH as PatchAsync is not available in older .NET Framework versions
                var request = new HttpRequestMessage(new HttpMethod("PATCH"), ApiUrl)
                {
                    Content = content
                };

                var response = await client.SendAsync(request);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Password berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCurrentPassword.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                }
                else
                {
                    try
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseContent))
                        {
                            string message = doc.RootElement.TryGetProperty("message", out var msgProp) ? msgProp.GetString() : "Gagal mengubah password.";
                            MessageBox.Show(message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"Gagal mengubah password. Status: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLupaPassword_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://mangsipul.vercel.app/forgot-password");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka browser: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
