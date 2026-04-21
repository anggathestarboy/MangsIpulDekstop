using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class WalletListForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string ApiUrl = "https://mangsipul.alwaysdata.net/api/wallets";
        private const string MoneyTypesUrl = "https://mangsipul.alwaysdata.net/api/money-types";
        private const string WalletMoneyUrl = "https://mangsipul.alwaysdata.net/api/wallet-money";
        private List<MonthlyProfit> monthlyProfits = new List<MonthlyProfit>();
        private List<WalletItem> wallets = new List<WalletItem>();
        private List<MoneyTypeItem> moneyTypes = new List<MoneyTypeItem>();

        public WalletListForm()
        {
            InitializeComponent();
            LoadUserInfo();
            FetchWalletData();
            FetchMoneyTypes();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async void FetchWalletData()
        {
            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Sesi Anda telah berakhir. Silakan login kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(ApiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    using (JsonDocument doc = JsonDocument.Parse(json))
                    {
                        var root = doc.RootElement;
                        
                        // Parse monthly profit for chart
                        if (root.TryGetProperty("monthly_profit", out var profitArray))
                        {
                            monthlyProfits.Clear();
                            foreach (var item in profitArray.EnumerateArray())
                            {
                                monthlyProfits.Add(new MonthlyProfit
                                {
                                    Month = item.GetProperty("month").GetInt32(),
                                    Profit = item.GetProperty("profit").GetDecimal()
                                });
                            }
                            pnlChart.Invalidate(); // Redraw chart
                        }

                        // Parse wallets for dropdown
                        if (root.TryGetProperty("wallets", out var walletsArray))
                        {
                            wallets.Clear();
                            cbWallet.Items.Clear();
                            flpWallets.Controls.Clear();
                            int index = 0;
                            foreach (var item in walletsArray.EnumerateArray())
                            {
                                var wallet = new WalletItem
                                {
                                    Id = item.GetProperty("id").GetInt32(),
                                    Name = item.GetProperty("name").GetString(),
                                    Balance = item.GetProperty("balance").GetDecimal()
                                };
                                wallets.Add(wallet);
                                cbWallet.Items.Add(wallet.Name);

                                // Create card
                                CreateWalletCard(wallet, index++);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching wallet data: {ex.Message}");
            }
        }

        private void CreateWalletCard(WalletItem wallet, int index)
        {
            Panel card = new Panel();
            card.Size = new Size(450, 200);
            card.Margin = new Padding(0, 0, 20, 20);
            card.BackColor = (index % 2 == 0) ? Color.FromArgb(249, 115, 22) : Color.FromArgb(26, 86, 219); // Orange vs Blue
            
            // Apply rounded corners would be nice but let's stick to standard for now or just set Region
            // For simplicity, standard panel

            Label lblName = new Label();
            lblName.Text = wallet.Name;
            lblName.Font = new Font("Segoe UI Bold", 16F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 20);
            card.Controls.Add(lblName);

            Label lblBalance = new Label();
            lblBalance.Text = "Rp " + wallet.Balance.ToString("N0");
            lblBalance.Font = new Font("Segoe UI Bold", 18F, FontStyle.Bold);
            lblBalance.ForeColor = Color.White;
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(20, 60);
            card.Controls.Add(lblBalance);

            Button btnDetail = new Button();
            btnDetail.Text = "Detail →";
            btnDetail.FlatStyle = FlatStyle.Flat;
            btnDetail.FlatAppearance.BorderSize = 0;
            btnDetail.BackColor = Color.White;
            btnDetail.ForeColor = card.BackColor;
            btnDetail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDetail.Size = new Size(100, 40);
            btnDetail.Location = new Point(20, 130);
            btnDetail.Cursor = Cursors.Hand;
            btnDetail.Tag = wallet.Id;
            btnDetail.Click += (s, e) => {
                int walletId = (int)((Button)s).Tag;
                WalletDetailForm detailForm = new WalletDetailForm(walletId);
                detailForm.Show();
                this.Hide();
            };
            card.Controls.Add(btnDetail);

            // Icon placeholder (using a label with an emoji or symbol)
            Label lblIcon = new Label();
            lblIcon.Text = "💳";
            lblIcon.Font = new Font("Segoe UI", 40F);
            lblIcon.ForeColor = Color.FromArgb(100, 255, 255, 255); // Semi-transparent white
            lblIcon.AutoSize = true;
            lblIcon.Location = new Point(350, 80);
            card.Controls.Add(lblIcon);

            flpWallets.Controls.Add(card);
        }

        private async void FetchMoneyTypes()
        {
            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(MoneyTypesUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    using (JsonDocument doc = JsonDocument.Parse(json))
                    {
                        var root = doc.RootElement;
                        if (root.TryGetProperty("money_types", out var typesArray))
                        {
                            moneyTypes.Clear();
                            cbTipeTransaksi.Items.Clear();
                            foreach (var item in typesArray.EnumerateArray())
                            {
                                var type = new MoneyTypeItem
                                {
                                    Id = item.GetProperty("id").GetInt32(),
                                    Name = item.GetProperty("name").GetString()
                                };
                                moneyTypes.Add(type);
                                cbTipeTransaksi.Items.Add(type.Name);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching money types: {ex.Message}");
            }
        }

        private async void btnSimpanTransaksi_Click(object sender, EventArgs e)
        {
            if (cbWallet.SelectedIndex == -1 || cbTipeTransaksi.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtJumlah.Text))
            {
                MessageBox.Show("Harap isi semua field yang wajib!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtJumlah.Text, out decimal amount))
            {
                MessageBox.Show("Jumlah harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSimpanTransaksi.Enabled = false;
            btnSimpanTransaksi.Text = "Menyimpan...";

            try
            {
                int walletId = wallets[cbWallet.SelectedIndex].Id;
                int typeId = moneyTypes[cbTipeTransaksi.SelectedIndex].Id;
                string dateStr = dtpTanggal.Value.ToString("yyyyMMdd");

                var requestData = new
                {
                    wallet_id = walletId,
                    money_type_id = typeId,
                    amount = (int)amount,
                    description = txtDeskripsi.Text.Trim(),
                    date = int.Parse(dateStr)
                };

                string json = JsonSerializer.Serialize(requestData);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await client.PostAsync(WalletMoneyUrl, content);
                string responseJson = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseJson))
                {
                    string message = doc.RootElement.TryGetProperty("message", out var msgProp) ? msgProp.GetString() : "Gagal menyimpan transaksi.";

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(message, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnReset_Click(null, null);
                        FetchWalletData(); // Refresh chart
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
                btnSimpanTransaksi.Enabled = true;
                btnSimpanTransaksi.Text = "Simpan Transaksi";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbWallet.SelectedIndex = -1;
            cbTipeTransaksi.SelectedIndex = -1;
            txtJumlah.Text = "";
            txtDeskripsi.Text = "";
            dtpTanggal.Value = DateTime.Now;
        }

        private void pnlChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            if (monthlyProfits == null || monthlyProfits.Count == 0) return;

            int width = pnlChart.Width;
            int height = pnlChart.Height;
            int padding = 40;
            int chartWidth = width - (padding * 2);
            int chartHeight = height - (padding * 2);

            // Labels for months
            string[] months = { "Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Agu", "Sep", "Okt", "Nov", "Des" };
            float xStep = chartWidth / 11f;

            decimal maxProfit = monthlyProfits.Max(p => p.Profit);
            decimal minProfit = monthlyProfits.Min(p => p.Profit);
            
            // Adjust max/min to have some breathing room
            float rangePadding = (float)(maxProfit - minProfit) * 0.1f;
            if (rangePadding == 0) rangePadding = 100000;
            float dataMax = (float)maxProfit + rangePadding;
            float dataMin = (float)minProfit - rangePadding;
            float dataRange = dataMax - dataMin;

            // Draw grid lines
            Pen gridPen = new Pen(Color.FromArgb(229, 231, 235), 1) { DashStyle = DashStyle.Dash };
            Font labelFont = new Font("Segoe UI", 8);
            Brush labelBrush = new SolidBrush(Color.FromArgb(107, 114, 128));

            // Horizontal grid lines (3 lines: min, mid, max)
            float[] yValues = { dataMax, (dataMax + dataMin) / 2, dataMin };
            foreach (float val in yValues)
            {
                float y = padding + chartHeight - ((val - dataMin) / dataRange * chartHeight);
                g.DrawLine(gridPen, padding, y, padding + chartWidth, y);
                g.DrawString(val.ToString("N0"), labelFont, labelBrush, 5, y - 7);
            }

            // Draw the line chart
            Pen linePen = new Pen(Color.FromArgb(26, 86, 219), 2);
            Brush dotBrush = new SolidBrush(Color.FromArgb(26, 86, 219));

            PointF[] points = new PointF[monthlyProfits.Count];
            for (int i = 0; i < monthlyProfits.Count; i++)
            {
                float x = padding + (i * xStep);
                float y = padding + chartHeight - (((float)monthlyProfits[i].Profit - dataMin) / dataRange * chartHeight);
                points[i] = new PointF(x, y);

                // Draw month label
                g.DrawString(months[i], labelFont, labelBrush, x - 10, padding + chartHeight + 10);
            }

            if (points.Length > 1)
            {
                g.DrawLines(linePen, points);
            }

            // Draw dots
            foreach (var pt in points)
            {
                g.FillEllipse(dotBrush, pt.X - 4, pt.Y - 4, 8, 8);
            }
        }
    }

    public class MonthlyProfit
    {
        public int Month { get; set; }
        public decimal Profit { get; set; }
    }

    public class WalletItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }

    public class MoneyTypeItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
