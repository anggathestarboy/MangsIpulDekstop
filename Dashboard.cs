using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

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
        private List<ChartDataPoint> chartData = new List<ChartDataPoint>();

        public Dashboard()
        {
            InitializeComponent();
            SetupUI();
            LoadTokenAndUserData();
            
            // Set default filter
            cmbChartFilter.SelectedIndex = 0; // Minggu Ini
            
            // Fetch dashboard data
            FetchDashboardData();
        }

        private async void FetchDashboardData()
        {
            // Initial fetch
            await Task.WhenAll(
                FetchDashboardStatsTask(),
                FetchChartDataTask("minggu_ini"),
                FetchLogsTask(),
                FetchWalletsTask()
            );
        }

        private async Task FetchDashboardStatsTask()
        {
            await Task.Run(() => FetchDashboardStats());
        }

        private async Task FetchChartDataTask(string filter)
        {
            await Task.Run(() => FetchChartData(filter));
        }

        private async Task FetchLogsTask()
        {
            try
            {
                string url = "https://mangsipul.alwaysdata.net/api/logs";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var logs = JsonSerializer.Deserialize<List<LogActivity>>(json);
                    this.Invoke((MethodInvoker)delegate { PopulateActivityList(logs); });
                }
            }
            catch (Exception ex) { Console.WriteLine($"Error logs: {ex.Message}"); }
        }

        private async Task FetchWalletsTask()
        {
            try
            {
                string url = "https://mangsipul.alwaysdata.net/api/wallet-latest";
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var wallets = JsonSerializer.Deserialize<List<WalletInfo>>(json);
                    this.Invoke((MethodInvoker)delegate { PopulateWalletList(wallets); });
                }
            }
            catch (Exception ex) { Console.WriteLine($"Error wallets: {ex.Message}"); }
        }

        private void PopulateActivityList(List<LogActivity> logs)
        {
            pnlActivityList.Controls.Clear();
            if (logs == null) return;

            foreach (var log in logs.Take(5))
            {
                Panel pnl = new Panel
                {
                    Size = new Size(pnlActivityList.Width - 25, 50),
                    Margin = new Padding(0, 0, 0, 10),
                    BackColor = Color.FromArgb(249, 250, 251),
                    Cursor = Cursors.Hand,
                    Tag = log
                };
                pnl.Click += LogItem_Click;

                Label lblEntity = new Label
                {
                    Text = log.Entity,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.FromArgb(31, 41, 55),
                    Location = new Point(10, 5),
                    AutoSize = true
                };
                lblEntity.Click += (s, e) => LogItem_Click(pnl, e);

                Label lblDesc = new Label
                {
                    Text = log.Description,
                    Font = new Font("Segoe UI", 8),
                    ForeColor = Color.FromArgb(75, 85, 99),
                    Location = new Point(10, 22),
                    AutoSize = true,
                    MaximumSize = new Size(pnl.Width - 100, 0)
                };
                lblDesc.Click += (s, e) => LogItem_Click(pnl, e);

                Label lblTime = new Label
                {
                    Text = log.CreatedAtDateTime.ToString("dd MMM yyyy, HH.mm"),
                    Font = new Font("Segoe UI", 7),
                    ForeColor = Color.FromArgb(156, 163, 175),
                    Location = new Point(10, 36),
                    AutoSize = true
                };
                lblTime.Click += (s, e) => LogItem_Click(pnl, e);

                pnl.Controls.Add(lblEntity);
                pnl.Controls.Add(lblDesc);
                pnl.Controls.Add(lblTime);
                pnlActivityList.Controls.Add(pnl);
            }
        }

        private void PopulateWalletList(List<WalletInfo> wallets)
        {
            pnlWalletList.Controls.Clear();
            if (wallets == null) return;

            Color[] colors = { Color.FromArgb(59, 130, 246), Color.FromArgb(5, 122, 85), Color.FromArgb(234, 88, 12) };
            int colorIdx = 0;

            foreach (var wallet in wallets.Take(3))
            {
                Panel pnl = new Panel
                {
                    Size = new Size(pnlWalletList.Width - 30, 85),
                    Margin = new Padding(0, 0, 0, 10),
                    BackColor = colors[colorIdx % colors.Length]
                };
                colorIdx++;
                pnl.Paint += (s, e) => {
                    Graphics g = e.Graphics;
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    Rectangle r = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
                    using (GraphicsPath path = GetRoundedRect(r, 12)) { pnl.Region = new Region(path); }
                };

                PictureBox pb = new PictureBox
                {
                    Size = new Size(35, 35),
                    Location = new Point(15, 25),
                    BackColor = Color.White,
                    SizeMode = PictureBoxSizeMode.CenterImage
                };
                pb.Paint += (s, e) => {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillEllipse(Brushes.White, 0, 0, 34, 34);
                    using (Font f = new Font("Segoe UI Emoji", 12)) {
                        e.Graphics.DrawString("👛", f, Brushes.Black, 6, 6);
                    }
                };

                Label lblName = new Label
                {
                    Text = wallet.Name,
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.White,
                    Location = new Point(60, 20),
                    AutoSize = true
                };

                Label lblBalance = new Label
                {
                    Text = $"Rp {wallet.BalanceValue:N0}",
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(60, 40),
                    AutoSize = true
                };

                Button btnDetail = new Button
                {
                    Text = "Detail",
                    Size = new Size(60, 25),
                    Location = new Point(pnl.Width - 75, 30),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.White,
                    ForeColor = pnl.BackColor,
                    Cursor = Cursors.Hand
                };
                btnDetail.FlatAppearance.BorderSize = 0;
                btnDetail.Click += (s, e) => {
                    WalletDetailForm detail = new WalletDetailForm(wallet.Id);
                    detail.Show();
                };

                pnl.Controls.Add(pb);
                pnl.Controls.Add(lblName);
                pnl.Controls.Add(lblBalance);
                pnl.Controls.Add(btnDetail);
                pnlWalletList.Controls.Add(pnl);
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void LogItem_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl == null && sender is Control ctrl) pnl = ctrl.Parent as Panel;
            if (pnl != null && pnl.Tag is LogActivity log)
            {
                MessageBox.Show($"Detail Aktivitas:\n\nEntity: {log.Entity}\nDeskripsi: {log.Description}\nWaktu: {log.CreatedAtDateTime:dd MMMM yyyy, HH.mm}", 
                    "Log Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnDeleteAllLogs_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Apakah Anda yakin ingin menghapus semua log aktivitas?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    var response = await client.DeleteAsync("https://mangsipul.alwaysdata.net/api/logs");
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Semua log berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await FetchLogsTask();
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Gagal menghapus log: {ex.Message}"); }
            }
        }

        private void btnSeeAllActivity_Click(object sender, EventArgs e)
        {
            AllActivityDialog allActivity = new AllActivityDialog();
            allActivity.ShowDialog();
        }

        private void SetupUI()
        {
            // Navbar and Sidebar are now components
            this.DoubleBuffered = true;
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

        private async void FetchDashboardStats()
        {
            try
            {
                string url = "https://mangsipul.alwaysdata.net/api/dashboard/stats";
                var response = await client.GetAsync(url);
                
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var stats = JsonSerializer.Deserialize<DashboardStats>(json);
                    
                    if (stats != null)
                    {
                        lblStatValue1.Text = $"Rp {stats.TotalSalesValue:N0}";
                        lblStatValue2.Text = stats.total_orders.ToString();
                        lblStatValue3.Text = stats.total_products.ToString();
                        lblStatValue4.Text = stats.total_customers.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching stats: {ex.Message}");
            }
        }

        private async void FetchChartData(string filter)
        {
            try
            {
                string url = $"https://mangsipul.alwaysdata.net/api/dashboard/chart?filter={filter}";
                var response = await client.GetAsync(url);
                
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var chartResponse = JsonSerializer.Deserialize<DashboardChartResponse>(json);
                    
                    if (chartResponse != null && chartResponse.Data != null)
                    {
                        chartData = chartResponse.Data;
                        pnlChartContainer.Invalidate(); // Redraw chart
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching chart data: {ex.Message}");
            }
        }

        private void cmbChartFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = "minggu_ini";
            switch (cmbChartFilter.SelectedIndex)
            {
                case 0: filter = "minggu_ini"; break;
                case 1: filter = "bulan_ini"; break;
                case 2: filter = "tahun_ini"; break;
                case 3: filter = "tahun_kemarin"; break;
            }
            FetchChartData(filter);
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

        private void icon_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color bgColor = Color.Orange;
            string iconText = "💰";

            if (pb == pbStatIcon1) { bgColor = Color.FromArgb(255, 120, 0); iconText = "💰"; }
            else if (pb == pbStatIcon2) { bgColor = Color.FromArgb(59, 130, 246); iconText = "🛍️"; }
            else if (pb == pbStatIcon3) { bgColor = Color.FromArgb(16, 185, 129); iconText = "🍔"; }
            else if (pb == pbStatIcon4) { bgColor = Color.FromArgb(168, 85, 247); iconText = "👥"; }

            using (SolidBrush brush = new SolidBrush(bgColor))
            {
                g.FillEllipse(brush, 0, 0, pb.Width - 1, pb.Height - 1);
            }

            using (Font font = new Font("Segoe UI Emoji", 14))
            {
                SizeF size = g.MeasureString(iconText, font);
                g.DrawString(iconText, font, Brushes.White, (pb.Width - size.Width) / 2, (pb.Height - size.Height) / 2);
            }
        }

        private void chartContainer_Paint(object sender, PaintEventArgs e)
        {
            // Call base card paint first for rounding
            card_Paint(sender, e);

            if (chartData == null || chartData.Count == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int paddingLeft = 60;
            int paddingRight = 30;
            int paddingTop = 60;
            int paddingBottom = 40;

            int chartWidth = pnlChartContainer.Width - paddingLeft - paddingRight;
            int chartHeight = pnlChartContainer.Height - paddingTop - paddingBottom;

            decimal maxVal = chartData.Max(d => d.TotalValue);
            if (maxVal == 0) maxVal = 100;
            else maxVal = Math.Ceiling(maxVal / 1000) * 1000; // Round up to nearest 1000

            // Draw Y-axis grid lines and labels
            using (Pen gridPen = new Pen(Color.FromArgb(243, 244, 246), 1))
            using (Font labelFont = new Font("Segoe UI", 9))
            using (SolidBrush labelBrush = new SolidBrush(Color.FromArgb(107, 114, 128)))
            {
                int gridLines = 4;
                for (int i = 0; i <= gridLines; i++)
                {
                    float y = paddingTop + chartHeight - (i * chartHeight / (float)gridLines);
                    g.DrawLine(gridPen, paddingLeft, y, paddingLeft + chartWidth, y);
                    
                    decimal val = maxVal * i / gridLines;
                    string label = val.ToString("N0");
                    g.DrawString(label, labelFont, labelBrush, paddingLeft - 55, y - 7);
                }
            }

            // Draw X-axis labels and collect points
            PointF[] points = new PointF[chartData.Count];
            using (Font labelFont = new Font("Segoe UI", 9))
            using (SolidBrush labelBrush = new SolidBrush(Color.FromArgb(107, 114, 128)))
            {
                for (int i = 0; i < chartData.Count; i++)
                {
                    float x = paddingLeft + (i * chartWidth / (float)(chartData.Count - 1));
                    float y = paddingTop + chartHeight - (float)(chartData[i].TotalValue / maxVal * chartHeight);
                    points[i] = new PointF(x, y);

                    // Draw label
                    SizeF labelSize = g.MeasureString(chartData[i].Label, labelFont);
                    g.DrawString(chartData[i].Label, labelFont, labelBrush, x - labelSize.Width / 2, paddingTop + chartHeight + 10);
                }
            }

            // Draw gradient area under the curve
            if (points.Length > 1)
            {
                using (GraphicsPath areaPath = new GraphicsPath())
                {
                    areaPath.AddLine(points[0].X, paddingTop + chartHeight, points[0].X, points[0].Y);
                    for (int i = 0; i < points.Length - 1; i++)
                    {
                        // Use curve for smoother look
                        float cp1x = points[i].X + (points[i+1].X - points[i].X) / 2;
                        areaPath.AddBezier(points[i], new PointF(cp1x, points[i].Y), new PointF(cp1x, points[i+1].Y), points[i+1]);
                    }
                    areaPath.AddLine(points[points.Length - 1].X, points[points.Length - 1].Y, points[points.Length - 1].X, paddingTop + chartHeight);
                    areaPath.CloseFigure();

                    using (LinearGradientBrush areaBrush = new LinearGradientBrush(
                        new Rectangle(0, paddingTop, 1, chartHeight),
                        Color.FromArgb(150, 255, 120, 0),
                        Color.FromArgb(0, 255, 120, 0),
                        90f))
                    {
                        g.FillPath(areaBrush, areaPath);
                    }
                }

                // Draw the line
                using (Pen linePen = new Pen(Color.FromArgb(255, 120, 0), 3))
                {
                    linePen.LineJoin = LineJoin.Round;
                    // Draw segments to match the curve
                    for (int i = 0; i < points.Length - 1; i++)
                    {
                        float cp1x = points[i].X + (points[i+1].X - points[i].X) / 2;
                        g.DrawBezier(linePen, points[i], new PointF(cp1x, points[i].Y), new PointF(cp1x, points[i+1].Y), points[i+1]);
                    }
                }

                // Draw points
                foreach (var p in points)
                {
                    using (SolidBrush dotBrush = new SolidBrush(Color.FromArgb(255, 120, 0)))
                    {
                        g.FillEllipse(dotBrush, p.X - 5, p.Y - 5, 10, 10);
                        g.FillEllipse(Brushes.White, p.X - 3, p.Y - 3, 6, 6);
                        g.FillEllipse(dotBrush, p.X - 2, p.Y - 2, 4, 4);
                    }
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