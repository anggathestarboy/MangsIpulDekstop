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
    public partial class RatingListForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string ApiUrl = "https://mangsipul.alwaysdata.net/api/ratings-admin";
        private int currentPage = 1;
        private bool _isLoading = false;

        public RatingListForm()
        {
            InitializeComponent();
            LoadData(1);
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async Task LoadData(int page = 1)
        {
            if (_isLoading) return;

            try
            {
                _isLoading = true;
                currentPage = page;

                string url = $"{ApiUrl}?page={page}";

                // Reset and set Authorization header
                client.DefaultRequestHeaders.Remove("Authorization");
                string token = TokenManager.LoadToken();
                if (!string.IsNullOrEmpty(token))
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                }

                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var ratingResponse = JsonSerializer.Deserialize<RatingResponse>(json);

                    if (ratingResponse != null && ratingResponse.Data != null)
                    {
                        DisplayRatings(ratingResponse.Data);
                        UpdatePagination(ratingResponse);
                    }
                }
                else
                {
                    MessageBox.Show("Gagal mengambil data rating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isLoading = false;
            }
        }

        private void DisplayRatings(List<Rating> ratings)
        {
            flpRatings.Controls.Clear();

            foreach (var rating in ratings)
            {
                Panel card = CreateRatingCard(rating);
                flpRatings.Controls.Add(card);
            }
        }

        private Panel CreateRatingCard(Rating rating)
        {
            Panel card = new Panel();
            card.Size = new Size(flpRatings.Width - 40, 100);
            card.BackColor = Color.White;
            card.Margin = new Padding(0, 0, 0, 15);
            card.Padding = new Padding(20);

            // Shadow/Border simulation
            card.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.FromArgb(229, 231, 235), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(229, 231, 235), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(229, 231, 235), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(229, 231, 235), 1, ButtonBorderStyle.Solid);
            };

            // Username
            Label lblUser = new Label();
            lblUser.Text = rating.User?.Username ?? "Anonymous";
            lblUser.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblUser.AutoSize = true;
            lblUser.Location = new Point(20, 15);
            card.Controls.Add(lblUser);

            // Separator dot
            Label lblDot = new Label();
            lblDot.Text = "•";
            lblDot.Font = new Font("Segoe UI", 10);
            lblDot.ForeColor = Color.Gray;
            lblDot.AutoSize = true;
            lblDot.Location = new Point(lblUser.Right + 5, 15);
            card.Controls.Add(lblDot);

            // Stars
            Label lblStars = new Label();
            lblStars.ForeColor = Color.FromArgb(255, 193, 7); // Kuning/Gold
            lblStars.Font = new Font("Segoe UI", 12);
            lblStars.AutoSize = true;
            lblStars.Location = new Point(lblDot.Right + 5, 13);
            
            string stars = "";
            for (int i = 1; i <= 5; i++)
            {
                stars += (i <= rating.RatingValue) ? "★" : "☆";
            }
            lblStars.Text = stars;
            card.Controls.Add(lblStars);

            // Comment
            Label lblComment = new Label();
            lblComment.Text = rating.Comment;
            lblComment.Font = new Font("Segoe UI", 9);
            lblComment.ForeColor = Color.FromArgb(75, 85, 99);
            lblComment.AutoSize = false;
            lblComment.Size = new Size(card.Width - 100, 40);
            lblComment.Location = new Point(20, 45);
            card.Controls.Add(lblComment);

            // Rating Badge (e.g., 5/5)
            Label lblBadge = new Label();
            lblBadge.Text = $"{rating.RatingValue}/5";
            lblBadge.Font = new Font("Segoe UI", 8);
            lblBadge.ForeColor = Color.FromArgb(107, 114, 128);
            lblBadge.BackColor = Color.FromArgb(243, 244, 246);
            lblBadge.TextAlign = ContentAlignment.MiddleCenter;
            lblBadge.Size = new Size(40, 25);
            lblBadge.Location = new Point(card.Width - 60, 15);
            card.Controls.Add(lblBadge);

            return card;
        }

        private void UpdatePagination(RatingResponse data)
        {
            lblPaginationInfo.Text = $"Halaman {data.CurrentPage} dari {data.LastPage}";

            btnPrev.Enabled = data.PrevPageUrl != null;
            btnNext.Enabled = data.NextPageUrl != null;

            // Clear events before adding new ones
            btnPrev.Click -= BtnPrev_Click;
            btnNext.Click -= BtnNext_Click;

            btnPrev.Click += BtnPrev_Click;
            btnNext.Click += BtnNext_Click;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            LoadData(currentPage - 1);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            LoadData(currentPage + 1);
        }
    }
}
