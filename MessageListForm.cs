using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class MessageListForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string ApiUrl = "https://mangsipul.alwaysdata.net/api/messages";

        public MessageListForm()
        {
            InitializeComponent();
            LoadData();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async Task LoadData()
        {
            try
            {
                var response = await client.GetAsync(ApiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var messageResponse = JsonSerializer.Deserialize<MessageResponse>(json);

                    if (messageResponse != null && messageResponse.Data != null)
                    {
                        DisplayMessages(messageResponse.Data);
                    }
                }
                else
                {
                    MessageBox.Show("Gagal mengambil data pesan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayMessages(List<MessageData> messages)
        {
            flpMessages.Controls.Clear();

            int no = 1;
            foreach (var msg in messages)
            {
                Panel row = CreateMessageRow(msg, no++);
                flpMessages.Controls.Add(row);
            }
        }

        private Panel CreateMessageRow(MessageData msg, int index)
        {
            Panel row = new Panel();
            row.Size = new Size(flpMessages.Width - 40, 60);
            row.BackColor = Color.White;
            row.Margin = new Padding(0, 0, 0, 1);
            row.Cursor = Cursors.Hand;

            // Border bottom
            row.Paint += (s, e) => {
                e.Graphics.DrawLine(new Pen(Color.FromArgb(243, 244, 246), 1), 0, row.Height - 1, row.Width, row.Height - 1);
            };

            // Column No
            Label lblNo = new Label();
            lblNo.Text = $"#{index}";
            lblNo.Font = new Font("Segoe UI", 9);
            lblNo.ForeColor = Color.FromArgb(107, 114, 128);
            lblNo.AutoSize = false;
            lblNo.Size = new Size(50, row.Height);
            lblNo.TextAlign = ContentAlignment.MiddleCenter;
            lblNo.Location = new Point(0, 0);
            row.Controls.Add(lblNo);

            // Avatar (Nama Initial)
            Panel pnlAvatar = new Panel();
            pnlAvatar.Size = new Size(32, 32);
            pnlAvatar.Location = new Point(60, 14);
            pnlAvatar.BackColor = Color.FromArgb(249, 115, 22); // Orange
            // Rounded avatar
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pnlAvatar.Width, pnlAvatar.Height);
            pnlAvatar.Region = new Region(gp);

            Label lblInitial = new Label();
            lblInitial.Text = string.IsNullOrEmpty(msg.FullName) ? "?" : msg.FullName.Substring(0, 1).ToUpper();
            lblInitial.ForeColor = Color.White;
            lblInitial.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblInitial.TextAlign = ContentAlignment.MiddleCenter;
            lblInitial.Dock = DockStyle.Fill;
            pnlAvatar.Controls.Add(lblInitial);
            row.Controls.Add(pnlAvatar);

            // Full Name
            Label lblName = new Label();
            lblName.Text = msg.FullName;
            lblName.Font = new Font("Segoe UI Semibold", 9);
            lblName.AutoSize = false;
            lblName.Size = new Size(150, row.Height);
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            lblName.Location = new Point(100, 0);
            row.Controls.Add(lblName);

            // Email
            Label lblEmail = new Label();
            lblEmail.Text = "✉ " + msg.Email;
            lblEmail.Font = new Font("Segoe UI", 9);
            lblEmail.ForeColor = Color.FromArgb(107, 114, 128);
            lblEmail.AutoSize = false;
            lblEmail.Size = new Size(200, row.Height);
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            lblEmail.Location = new Point(260, 0);
            row.Controls.Add(lblEmail);

            // Message (Truncated 50 chars)
            Label lblMsg = new Label();
            string displayMsg = msg.Message;
            if (displayMsg.Length > 50) displayMsg = displayMsg.Substring(0, 50) + "...";
            lblMsg.Text = displayMsg;
            lblMsg.Font = new Font("Segoe UI", 9);
            lblMsg.ForeColor = Color.FromArgb(75, 85, 99);
            lblMsg.AutoSize = false;
            lblMsg.Size = new Size(300, row.Height);
            lblMsg.TextAlign = ContentAlignment.MiddleLeft;
            lblMsg.Location = new Point(470, 0);
            row.Controls.Add(lblMsg);

            // Date
            Label lblDate = new Label();
            lblDate.Text = "📅 " + msg.CreatedAt.ToString("d MMM yyyy");
            lblDate.Font = new Font("Segoe UI", 9);
            lblDate.ForeColor = Color.FromArgb(107, 114, 128);
            lblDate.AutoSize = false;
            lblDate.Size = new Size(120, row.Height);
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            lblDate.Location = new Point(780, 0);
            row.Controls.Add(lblDate);

            // Click Events
            Action openDetail = () => ShowMessageDetail(msg.Id);
            row.DoubleClick += (s, e) => openDetail();
            // Assign click to all children to make row feel interactive
            foreach (Control ctrl in row.Controls)
            {
                ctrl.DoubleClick += (s, e) => openDetail();
                ctrl.Click += (s, e) => { /* Visual feedback could go here */ };
            }

            return row;
        }

        private async void ShowMessageDetail(int id)
        {
            try
            {
                var response = await client.GetAsync($"{ApiUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var detailResponse = JsonSerializer.Deserialize<MessageDetailResponse>(json);

                    if (detailResponse != null && detailResponse.Data != null)
                    {
                        var data = detailResponse.Data;
                        using (var detailDialog = new MessageDetailDialog(data))
                        {
                            detailDialog.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat detail: {ex.Message}");
            }
        }
    }
}
