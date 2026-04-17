using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        // Class untuk deserialisasi response JSON
        private class LoginResponse
        {
            public string message { get; set; }
            public string token { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            LoadLogo();
            SetupPlaceholders();
            CheckSavedToken(); // Cek apakah sudah ada token tersimpan

            btnLogin.Click += btnLogin_Click;
        }

        // Method untuk cek token yang tersimpan
        private async void CheckSavedToken()
        {
            string savedToken = TokenManager.LoadToken();

            if (!string.IsNullOrEmpty(savedToken) && TokenManager.IsTokenValid())
            {
                try
                {
                    // Tampilkan loading state jika perlu (opsional)
                    
                    // Verifikasi token ke API /user
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {savedToken}");

                    var response = await client.GetAsync("https://mangsipul.alwaysdata.net/api/user");
                    
                    if (response.IsSuccessStatusCode)
                    {
                        // Token valid, langsung ke dashboard
                        Dashboard dash = new Dashboard();
                        dash.Show();
                        this.Hide();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        // Token tidak valid (401), hapus session
                        TokenManager.ClearSession();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error checking token via API: {ex.Message}");
                    // Jika error koneksi, tetap biarkan di halaman login
                }
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validasi username
            if (username == "Masukkan username" || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password == "Masukkan password" || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Logging in...";

            try
            {
                // Menggunakan "username" sesuai API
                string json = $"{{\"username\":\"{username}\",\"password\":\"{password}\"}}";
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://mangsipul.alwaysdata.net/api/login-admin", content);
                string responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // ========== LOGIKA SIMPAN TOKEN ==========
                    try
                    {
                        // Deserialize response JSON
                        var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseString);

                        if (loginResponse != null && !string.IsNullOrEmpty(loginResponse.token))
                        {
                            // Simpan token dan data user
                            TokenManager.SaveToken(loginResponse.token, username);

                            // Set token ke HttpClient header untuk request berikutnya
                            client.DefaultRequestHeaders.Clear();
                            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {loginResponse.token}");

                            MessageBox.Show($"Login berhasil!\n{loginResponse.message}", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Login berhasil, tapi token tidak ditemukan!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show($"Login berhasil, tapi gagal parsing response: {ex.Message}",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    // Buka dashboard
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    // Parse error message
                    string errorMessage = "Login gagal! Periksa username dan password Anda.";

                    try
                    {
                        var errorResponse = JsonSerializer.Deserialize<Dictionary<string, string>>(responseString);
                        if (errorResponse != null && errorResponse.ContainsKey("message"))
                        {
                            errorMessage = errorResponse["message"];
                        }
                    }
                    catch
                    {
                        // Jika parsing gagal, coba manual
                        if (responseString.Contains("\"message\""))
                        {
                            int start = responseString.IndexOf("\"message\"") + 9;
                            start = responseString.IndexOf("\"", start) + 1;
                            int end = responseString.IndexOf("\"", start);
                            if (start > 0 && end > start)
                            {
                                errorMessage = responseString.Substring(start, end - start);
                            }
                        }
                    }

                    MessageBox.Show(errorMessage, "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Reset password field
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Gray;
                    txtPassword.UseSystemPasswordChar = false;
                    if (txtPassword.Text == "")
                    {
                        txtPassword.Text = "Masukkan password";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan koneksi: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Login ➜";
            }
        }

        private void LoadLogo()
        {
            try
            {
                pbLogo.ImageLocation = "https://mangsipul.vercel.app/logo.png";
            }
            catch (Exception)
            {
                pbLogo.BackColor = Color.FromArgb(26, 86, 219);
            }
        }

        private void SetupPlaceholders()
        {
            // Username placeholder
            txtUsername.Enter += (s, e) =>
            {
                if (txtUsername.Text == "Masukkan username")
                {
                    txtUsername.Text = "";
                    txtUsername.ForeColor = Color.Black;
                }
            };

            txtUsername.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Text = "Masukkan username";
                    txtUsername.ForeColor = Color.Gray;
                }
            };

            // Password placeholder
            txtPassword.Enter += (s, e) =>
            {
                if (txtPassword.Text == "Masukkan password")
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Black;
                    txtPassword.UseSystemPasswordChar = true;
                }
            };

            txtPassword.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.Text = "Masukkan password";
                    txtPassword.ForeColor = Color.Gray;
                    txtPassword.UseSystemPasswordChar = false;
                }
            };

            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTitle_Click(object sender, EventArgs e) { }
        private void btnLogin_Click_1(object sender, EventArgs e) { }
    }

    // ========== CLASS TOKEN MANAGER ==========
    public static class TokenManager
    {
        private static readonly string appDataPath;
        private static readonly string tokenFile;
        private static readonly string userFile;

        static TokenManager()
        {
            // Folder untuk menyimpan data session
            appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MangsIpulAsli");
            tokenFile = Path.Combine(appDataPath, "token.dat");
            userFile = Path.Combine(appDataPath, "user.dat");

            // Buat folder jika belum ada
            if (!Directory.Exists(appDataPath))
                Directory.CreateDirectory(appDataPath);
        }

        // Simpan token dan username
        public static void SaveToken(string token, string username)
        {
            try
            {
                // Simpan token dengan enkripsi sederhana
                string encryptedToken = EncryptData(token);
                File.WriteAllText(tokenFile, encryptedToken);

                // Simpan username
                string encryptedUser = EncryptData(username);
                File.WriteAllText(userFile, encryptedUser);

                // Simpan waktu expire (7 hari)
                string expiryFile = Path.Combine(appDataPath, "expiry.dat");
                string expiryDate = DateTime.Now.AddDays(7).Ticks.ToString();
                File.WriteAllText(expiryFile, EncryptData(expiryDate));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving token: {ex.Message}");
            }
        }

        // Load token yang tersimpan
        public static string LoadToken()
        {
            try
            {
                if (File.Exists(tokenFile))
                {
                    string encryptedToken = File.ReadAllText(tokenFile);
                    return DecryptData(encryptedToken);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading token: {ex.Message}");
            }
            return null;
        }

        // Load username yang tersimpan
        public static string LoadUsername()
        {
            try
            {
                if (File.Exists(userFile))
                {
                    string encryptedUser = File.ReadAllText(userFile);
                    return DecryptData(encryptedUser);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading username: {ex.Message}");
            }
            return null;
        }

        // Cek apakah token masih valid (belum expired)
        public static bool IsTokenValid()
        {
            try
            {
                string expiryFile = Path.Combine(appDataPath, "expiry.dat");
                if (File.Exists(expiryFile))
                {
                    string encryptedExpiry = File.ReadAllText(expiryFile);
                    string expiryTicks = DecryptData(encryptedExpiry);
                    long ticks = long.Parse(expiryTicks);
                    DateTime expiryDate = new DateTime(ticks);

                    return DateTime.Now < expiryDate;
                }
            }
            catch { }
            return false;
        }

        // Hapus session (logout)
        public static void ClearSession()
        {
            try
            {
                if (File.Exists(tokenFile)) File.Delete(tokenFile);
                if (File.Exists(userFile)) File.Delete(userFile);
                if (File.Exists(Path.Combine(appDataPath, "expiry.dat")))
                    File.Delete(Path.Combine(appDataPath, "expiry.dat"));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clearing session: {ex.Message}");
            }
        }

        // Enkripsi sederhana (Base64)
        private static string EncryptData(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(bytes);
        }

        // Dekripsi sederhana (Base64)
        private static string DecryptData(string encryptedData)
        {
            byte[] bytes = Convert.FromBase64String(encryptedData);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}