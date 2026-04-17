using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    public partial class Dashboard : Form
    {
        private bool isProdukExpanded = false;
        private static readonly HttpClient client = new HttpClient();
        private string authToken;
        private string userFullname = "";
        private string userEmail = "";
        private string userRole = "";

        public Dashboard()
        {
            InitializeComponent();
            SetupUI();
            LoadTokenAndUserData();
        }

        private void SetupUI()
        {
            // Navbar and Sidebar are now components
        }

        private async void LoadTokenAndUserData()
        {
            // Load token dari storage
            authToken = TokenManager.LoadToken();

            if (string.IsNullOrEmpty(authToken))
            {
                MessageBox.Show("Session expired. Silakan login kembali.", "Session Expired",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Form1 login = new Form1();
                login.Show();
                this.Close();
                return;
            }

            // Set authorization header
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {authToken}");

            // Tampilkan loading state
            navbarControl1.SetUserInfo("Loading...", "", "");

            // Ambil data user dari API
            await GetUserData();
        }

        private async Task GetUserData()
        {
            try
            {
                // Panggil API /user untuk mendapatkan data user yang login
                var response = await client.GetAsync("https://mangsipul.alwaysdata.net/api/user");
                string responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Parse response manual
                    ParseAndDisplayUserData(responseString);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Session tidak valid. Silakan login kembali.", "Unauthorized",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    TokenManager.ClearSession();

                    Form1 login = new Form1();
                    login.Show();
                    this.Close();
                }
                else
                {
                    // Jika API /user tidak tersedia, gunakan data dari TokenManager
                    UseFallbackUserData();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting user data: {ex.Message}");
                // Fallback: gunakan username dari session
                UseFallbackUserData();
            }
        }

        private void ParseAndDisplayUserData(string responseString)
        {
            try
            {
                // Parse nama user
                if (responseString.Contains("\"name\""))
                {
                    int start = responseString.IndexOf("\"name\"") + 6;
                    start = responseString.IndexOf("\"", start) + 1;
                    int end = responseString.IndexOf("\"", start);
                    if (start > 0 && end > start)
                    {
                        userFullname = responseString.Substring(start, end - start);
                    }
                }

                // Parse email
                if (responseString.Contains("\"email\""))
                {
                    int start = responseString.IndexOf("\"email\"") + 7;
                    start = responseString.IndexOf("\"", start) + 1;
                    int end = responseString.IndexOf("\"", start);
                    if (start > 0 && end > start)
                    {
                        userEmail = responseString.Substring(start, end - start);
                    }
                }

                // Parse role
                if (responseString.Contains("\"role\""))
                {
                    int start = responseString.IndexOf("\"role\"") + 6;
                    start = responseString.IndexOf("\"", start) + 1;
                    int end = responseString.IndexOf("\"", start);
                    if (start > 0 && end > start)
                    {
                        userRole = responseString.Substring(start, end - start);
                    }
                }

                // Tampilkan di UI
                UpdateNavbarUserInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing user data: {ex.Message}");
                UseFallbackUserData();
            }
        }

        private void UseFallbackUserData()
        {
            // Gunakan data dari session jika API /user tidak tersedia
            string savedUsername = TokenManager.LoadUsername();

            if (!string.IsNullOrEmpty(savedUsername))
            {
                userFullname = savedUsername;
                userEmail = $"{savedUsername}@example.com";
                userRole = "Admin";

                UpdateNavbarUserInfo();
            }
            else
            {
                navbarControl1.SetUserInfo("User", "", "");
            }
        }

        private void UpdateNavbarUserInfo()
        {
            string name = !string.IsNullOrEmpty(userFullname) ? userFullname : (TokenManager.LoadUsername() ?? "User");
            navbarControl1.SetUserInfo(name, userEmail, userRole);
        }

        // Method untuk refresh data user (bisa dipanggil jika perlu)
        public async Task RefreshUserData()
        {
            await GetUserData();
        }

        private void card_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, p.Width - 1, p.Height - 1);
            int radius = 15;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                p.Region = new Region(path);

                using (Pen pen = new Pen(Color.FromArgb(229, 231, 235), 1))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        // Optional: Tambahkan method untuk membuat request dengan token
        public static async Task<HttpResponseMessage> AuthorizedGetAsync(string url)
        {
            string token = TokenManager.LoadToken();
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            }
            return await client.GetAsync(url);
        }

        public static async Task<HttpResponseMessage> AuthorizedPostAsync(string url, string jsonData)
        {
            string token = TokenManager.LoadToken();
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            }
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            return await client.PostAsync(url, content);
        }
    }
}