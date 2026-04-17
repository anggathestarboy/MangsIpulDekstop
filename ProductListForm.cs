using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class ProductListForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://mangsipul.alwaysdata.net/";
        private const string imageUrl = "https://mangsipul.alwaysdata.net/storage/";
        private const string ApiUrl = BaseUrl + "api/products";
        private int currentPage = 1;
        private List<Category> categories = new List<Category>();

        public ProductListForm()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadData();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private void SetupDataGridView()
        {
            dgvProducts.RowTemplate.Height = 80;
            colGambar.ImageLayout = DataGridViewImageCellLayout.Zoom;

          

          
        }

        private async void LoadData(int page = 1)
        {
            try
            {
                currentPage = page;
                string url = $"{ApiUrl}?page={page}";
                
                // Add search filter if exists
                if (txtSearch.Text != "Cari menu..." && !string.IsNullOrEmpty(txtSearch.Text))
                {
                    url += $"&search={txtSearch.Text}";
                }

                // Add category filter if exists
                if (cmbKategori.SelectedIndex > 0)
                {
                    var selectedCategory = cmbKategori.SelectedItem as Category;
                    url += $"&category_id={selectedCategory.Id}";
                }

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var productResponse = JsonSerializer.Deserialize<ProductResponse>(json);
                    
                    if (productResponse != null && productResponse.Data != null)
                    {
                        DisplayProducts(productResponse.Data.Data);
                        UpdatePagination(productResponse.Data);
                        
                        // Load categories for the dropdown if not loaded yet
                        if (categories.Count == 0)
                        {
                            await LoadCategories();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Gagal mengambil data produk.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCategories()
        {
            try
            {
                // Typically there's a category API, but for now we'll extract from products or hardcode 
                // Based on the data provided, let's just add the ones we see and maybe a placeholder
                categories.Clear();
                categories.Add(new Category { Id = 0, Name = "Semua Kategori" });
                
                // Fetch categories from API if available
                var response = await client.GetAsync(BaseUrl + "api/categories");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    // Assuming similar structure
                    var result = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
                    // This is speculative, let's keep it simple for now as the focus is product list
                }

                // For the sake of the demo, let's just add common ones
                categories.Add(new Category { Id = 1, Name = "Makroni" });
                categories.Add(new Category { Id = 3, Name = "Keripik" });
                categories.Add(new Category { Id = 4, Name = "Basreng" });

                cmbKategori.DataSource = null;
                cmbKategori.DataSource = categories;
                cmbKategori.DisplayMember = "Name";
                cmbKategori.ValueMember = "Id";
            }
            catch { }
        }

        private async void DisplayProducts(List<Product> products)
        {
            dgvProducts.Rows.Clear();
            int no = (currentPage - 1) * 10 + 1;

            foreach (var product in products)
            {
                int rowIndex = dgvProducts.Rows.Add();
                var row = dgvProducts.Rows[rowIndex];

                row.Cells["colNo"].Value = no++;
                row.Cells["colMenu"].Value = product.Title;
                row.Cells["colKategori"].Value = product.Category?.Name ?? "-";
                row.Cells["colHarga"].Value = $"Rp {product.Price:N0}";
                row.Cells["colStok"].Value = product.Stock;

                // Load Image
                if (!string.IsNullOrEmpty(product.Img))
                {
                    row.Cells["colGambar"].Value = await LoadImage(imageUrl + product.Img);
                }

           
                row.Tag = product.Id; // Store product ID in row Tag
            }
        }

        private async void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Check if clicked cell is in the Aksi column
            if (dgvProducts.Columns[e.ColumnIndex].Name == "colAksi")
            {
                int productId = (int)dgvProducts.Rows[e.RowIndex].Tag;
                string productTitle = dgvProducts.Rows[e.RowIndex].Cells["colMenu"].Value.ToString();

                // Custom choice dialog using a simple MessageBox or a custom one
                // For simplicity and to avoid creating another form, let's use a Task Dialog if available or simple choice
                var result = MessageBox.Show(
                    $"Pilih aksi untuk '{productTitle}':\n\n[Yes] untuk Edit\n[No] untuk Delete\n[Cancel] untuk Batal",
                    "Aksi Produk",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes) // EDIT
                {
                    EditProductForm editForm = new EditProductForm(productId);
                    editForm.Show();
                    this.Hide();
                }
                else if (result == DialogResult.No) // DELETE
                {
                    var confirmResult = MessageBox.Show(
                        $"Apakah Anda yakin ingin menghapus produk '{productTitle}'?",
                        "Konfirmasi Hapus",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        await DeleteProduct(productId);
                    }
                }
            }
        }

        private async Task DeleteProduct(int id)
        {
            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Sesi Anda telah habis. Silakan login kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var response = await client.DeleteAsync($"{ApiUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(currentPage); // Refresh current page
                }
                else
                {
                    string errorMsg = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Gagal menghapus produk: {response.ReasonPhrase}\n{errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menghapus: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<Image> LoadImage(string url)
        {
            try
            {
                byte[] imageBytes = await client.GetByteArrayAsync(url);
                using (var ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null; // Return default or empty image
            }
        }

        private void UpdatePagination(PaginationData data)
        {
            lblPaginationInfo.Text = $"Menampilkan {data.From}-{data.To} dari {data.Total} menu";

            flpPaginationButtons.Controls.Clear();

            // Next button
            Button btnNext = CreatePaginationButton(">", data.NextPageUrl != null);
            if (data.NextPageUrl != null) btnNext.Click += (s, e) => LoadData(data.CurrentPage + 1);
            flpPaginationButtons.Controls.Add(btnNext);

            // Page numbers (simplified)
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

        // Event handlers for Search and Filter
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Cari menu...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Cari menu...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(1);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.DataSource != null)
            {
                LoadData(1);
            }
        }
    }
}
