using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;
using System.Text;

namespace MangsIpulAsli
{
    public partial class CategoryListForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://mangsipul.alwaysdata.net/";
        private const string ApiUrl = BaseUrl + "api/categories";
        private int currentPage = 1;
        private bool _isLoading = false;

        public CategoryListForm()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadUserInfo();
            LoadData(1);

            dgvCategories.CellContentClick += dgvCategories_CellContentClick;
        }

        private async void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int categoryId = (int)dgvCategories.Rows[e.RowIndex].Tag;
            string categoryName = dgvCategories.Rows[e.RowIndex].Cells["colNamaKategori"].Value.ToString();

            if (dgvCategories.Columns[e.ColumnIndex].Name == "colUpdate")
            {
                using (var inputDialog = new InputDialog("Edit Kategori", "Masukkan nama kategori baru:", categoryName))
                {
                    if (inputDialog.ShowDialog() == DialogResult.OK)
                    {
                        await UpdateCategory(categoryId, inputDialog.InputText);
                    }
                }
            }
            else if (dgvCategories.Columns[e.ColumnIndex].Name == "colDelete")
            {
                var result = MessageBox.Show($"Apakah Anda yakin ingin menghapus kategori '{categoryName}'?", 
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    await DeleteCategory(categoryId);
                }
            }
        }

        private async Task UpdateCategory(int id, string newName)
        {
            try
            {
                string token = TokenManager.LoadToken();
                var requestData = new { name = newName };
                string json = JsonSerializer.Serialize(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                
                var response = await client.PutAsync($"{ApiUrl}/{id}", content);
                string responseJson = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseJson))
                {
                    string message = doc.RootElement.GetProperty("message").GetString();
                    MessageBox.Show(message, response.IsSuccessStatusCode ? "Sukses" : "Error", 
                        MessageBoxButtons.OK, response.IsSuccessStatusCode ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                    
                    if (response.IsSuccessStatusCode) await LoadData(currentPage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kesalahan: {ex.Message}");
            }
        }

        private async Task DeleteCategory(int id)
        {
            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await client.DeleteAsync($"{ApiUrl}/{id}");
                string responseJson = await response.Content.ReadAsStringAsync();

                using (JsonDocument doc = JsonDocument.Parse(responseJson))
                {
                    string message = doc.RootElement.GetProperty("message").GetString();
                    MessageBox.Show(message, response.IsSuccessStatusCode ? "Sukses" : "Error", 
                        MessageBoxButtons.OK, response.IsSuccessStatusCode ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                    
                    if (response.IsSuccessStatusCode) await LoadData(currentPage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kesalahan: {ex.Message}");
            }
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private void SetupDataGridView()
        {
            dgvCategories.RowTemplate.Height = 50;
            // Additional styling to match the image if possible via code
            dgvCategories.EnableHeadersVisualStyles = false;
            dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(249, 115, 22); // Orange
            dgvCategories.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCategories.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvCategories.ColumnHeadersHeight = 40;
        }

        private async Task LoadData(int page = 1)
        {
            if (_isLoading) return;

            try
            {
                _isLoading = true;
                currentPage = page;
                
                var queryParams = new List<string>();
                queryParams.Add($"page={page}");
                
                if (txtSearch.Text != "Cari kategori..." && !string.IsNullOrEmpty(txtSearch.Text))
                {
                    queryParams.Add($"search={Uri.EscapeDataString(txtSearch.Text)}");
                }

                string url = $"{ApiUrl}?" + string.Join("&", queryParams);

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var categoryResponse = JsonSerializer.Deserialize<CategoryResponse>(json);
                    
                    if (categoryResponse != null && categoryResponse.Data != null)
                    {
                        dgvCategories.Rows.Clear();
                        DisplayCategories(categoryResponse.Data.Data);
                        UpdatePagination(categoryResponse.Data);
                    }
                }
                else
                {
                    MessageBox.Show("Gagal mengambil data kategori.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DisplayCategories(List<Category> categories)
        {
            int no = (currentPage - 1) * 10 + 1;

            foreach (var category in categories)
            {
                int rowIndex = dgvCategories.Rows.Add();
                var row = dgvCategories.Rows[rowIndex];

                row.Tag = category.Id;

                row.Cells["colNo"].Value = no++.ToString("D2");
                row.Cells["colNamaKategori"].Value = category.Name;
                row.Cells["colTanggalDibuat"].Value = category.CreatedAt?.ToString("dd MMM yyyy") ?? "-";
                
                // For actions, we just show buttons as per image but no functionality yet
                row.Cells["colUpdate"].Value = "📝"; 
                row.Cells["colDelete"].Value = "🗑️";
            }
        }

        private void UpdatePagination(CategoryData data)
        {
            lblPaginationInfo.Text = $"Menampilkan {data.From ?? 0} dari {data.Total} kategori";
            lblLastUpdated.Text = $"Terakhir diperbarui: {DateTime.Now:M/d/yyyy}";

            flpPaginationButtons.Controls.Clear();

            // Next button
            Button btnNext = CreatePaginationButton(">", data.NextPageUrl != null);
            if (data.NextPageUrl != null) btnNext.Click += (s, e) => LoadData(data.CurrentPage + 1);
            flpPaginationButtons.Controls.Add(btnNext);

            // Page numbers
            for (int i = data.LastPage; i >= 1; i--)
            {
                Button btnPage = CreatePaginationButton(i.ToString(), true, i == data.CurrentPage);
                int pageNum = i;
                btnPage.Click += (s, e) => LoadData(pageNum);
                flpPaginationButtons.Controls.Add(btnPage);
            }

            // Prev button
            Button btnPrev = CreatePaginationButton("<", data.PrevPageUrl != null);
            if (data.PrevPageUrl != null) btnPrev.Click += (s, e) => LoadData(data.CurrentPage - 1);
            flpPaginationButtons.Controls.Add(btnPrev);
        }

        private Button CreatePaginationButton(string text, bool enabled, bool active = false)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(35, 35);
            btn.FlatStyle = FlatStyle.Flat;
            btn.Enabled = enabled;
            
            if (active)
            {
                btn.BackColor = Color.FromArgb(249, 115, 22);
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(107, 114, 128);
            }
            
            btn.FlatAppearance.BorderColor = Color.FromArgb(229, 231, 235);
            return btn;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Cari kategori...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Cari kategori...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(1);
                e.SuppressKeyPress = true;
            }
        }

        private void btnTambahKategori_Click(object sender, EventArgs e)
        {
            CreateCategoryForm createForm = new CreateCategoryForm();
            createForm.Show();
            this.Hide();
        }
    }
}
