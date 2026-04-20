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
    public partial class ProfileForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string UserApiUrl = "https://mangsipul.alwaysdata.net/api/user";
        private const string UpdateProfileApiUrl = "https://mangsipul.alwaysdata.net/api/update-profile";

        public ProfileForm()
        {
            InitializeComponent();
            LoadUserData();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async void LoadUserData()
        {
            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token)) return;

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var response = await client.GetAsync(UserApiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    using (JsonDocument doc = JsonDocument.Parse(json))
                    {
                        var root = doc.RootElement;
                        // Assuming the API returns user data directly or inside a 'data' key
                        var userElement = root.TryGetProperty("data", out var dataProp) ? dataProp : root;

                        string username = userElement.GetProperty("username").GetString();
                        string email = userElement.GetProperty("email").GetString();

                        txtUsername.Text = username;
                        txtEmail.Text = email;
                        lblDisplayUsername.Text = username;
                        lblDisplayEmail.Text = email;
                        lblAvatarInitial.Text = string.IsNullOrEmpty(username) ? "?" : username.Substring(0, 1).ToUpper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data profil: " + ex.Message);
            }
        }

        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token)) return;

                var updateData = new
                {
                    username = txtUsername.Text.Trim(),
                    email = txtEmail.Text.Trim()
                };

                string jsonBody = JsonSerializer.Serialize(updateData);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var response = await client.PutAsync(UpdateProfileApiUrl, content);
                string responseContent = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Profil berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TokenManager.SaveToken(token, updateData.username);
                    LoadUserData();
                    LoadUserInfo();
                }
                else
                {
                    try
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseContent))
                        {
                            string message = doc.RootElement.TryGetProperty("message", out var msgProp) ? msgProp.GetString() : "Gagal memperbarui profil.";
                            MessageBox.Show(message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        // Fallback if response is not JSON
                        MessageBox.Show($"Gagal memperbarui profil. Status: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
