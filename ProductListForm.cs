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
        private bool _isInitialLoad = true;
        private bool _isLoading = false;

        public ProductListForm()
        {
            InitializeComponent();
            SetupDataGridView();
            InitializeForm();
            LoadUserInfo();
        }

        private async void InitializeForm()
        {
            _isInitialLoad = true;
            // Load categories first
            await LoadCategories();
            _isInitialLoad = false;
            
            // Initial data load
            await LoadData(1);
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

        private async Task LoadData(int page = 1)
        {
            if (_isLoading) return;

            try
            {
                _isLoading = true;
                currentPage = page;
                
                // Build URL with parameters
                var queryParams = new List<string>();
                queryParams.Add($"page={page}");
                
                // Add search filter if exists
                if (txtSearch.Text != "Cari menu..." && !string.IsNullOrEmpty(txtSearch.Text))
                {
                    queryParams.Add($"search={Uri.EscapeDataString(txtSearch.Text)}");
                }

                // Add category filter if exists
                if (cmbKategori.SelectedIndex > 0)
                {
                    var selectedCategory = cmbKategori.SelectedItem as Category;
                    // Updated parameter to 'category' as requested
                    queryParams.Add($"category={selectedCategory.Id}");
                }

                string url = $"{ApiUrl}?" + string.Join("&", queryParams);

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var productResponse = JsonSerializer.Deserialize<ProductResponse>(json);
                    
                    if (productResponse != null && productResponse.Data != null)
                    {
                        // Clear rows only when new data is ready
                        dgvProducts.Rows.Clear();
                        DisplayProducts(productResponse.Data.Data);
                        UpdatePagination(productResponse.Data);
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
            finally
            {
                _isLoading = false;
            }
        }

        private async Task LoadCategories()
        {
            try
            {
                var response = await client.GetAsync(BaseUrl + "api/categories");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var categoryResponse = JsonSerializer.Deserialize<CategoryResponse>(json);
                    
                    categories.Clear();
                    categories.Add(new Category { Id = 0, Name = "Semua Kategori" });
                    
                    if (categoryResponse?.Data?.Data != null)
                    {
                        categories.AddRange(categoryResponse.Data.Data);
                    }

                    // Setting DataSource triggers SelectedIndexChanged, 
                    // which is why we use _isInitialLoad flag to prevent double load
                    cmbKategori.DataSource = null;
                    cmbKategori.DataSource = categories;
                    cmbKategori.DisplayMember = "Name";
                    cmbKategori.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading categories: {ex.Message}");
            }
        }

        private async void DisplayProducts(List<Product> products)
        {
            // Already cleared in LoadData
            int no = (currentPage - 1) * 10 + 1;

            foreach (var product in products)
            {
                int rowIndex = dgvProducts.Rows.Add();
                var row = dgvProducts.Rows[rowIndex];

                // Set Tag early
                row.Tag = product.Id;

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
            }
        }

        private async void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvProducts.Rows[e.RowIndex].Tag == null) return;
            int productId = (int)dgvProducts.Rows[e.RowIndex].Tag;
            string productTitle = dgvProducts.Rows[e.RowIndex].Cells["colMenu"].Value?.ToString() ?? "Produk";

            if (dgvProducts.Columns[e.ColumnIndex].Name == "colUpdate")
            {
                EditProductForm editForm = new EditProductForm(productId);
                editForm.Show();
                this.Hide();
            }
            else if (dgvProducts.Columns[e.ColumnIndex].Name == "colDelete")
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
                    await LoadData(currentPage); // Refresh current page
                }
                else
                {
                    string errorJson = await response.Content.ReadAsStringAsync();
                    try
                    {
                        var errorObj = JsonSerializer.Deserialize<Dictionary<string, object>>(errorJson);
                        string message = errorObj != null && errorObj.ContainsKey("message") 
                            ? errorObj["message"].ToString() 
                            : "Gagal menghapus produk.";
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show($"Gagal menghapus produk: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void btnTambahProduk_Click(object sender, EventArgs e)
        {
            CreateProductForm createForm = new CreateProductForm();
            createForm.Show();
            this.Hide();
        }
    }
}
