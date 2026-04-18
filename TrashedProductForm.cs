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
    public partial class TrashedProductForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://mangsipul.alwaysdata.net/";
        private const string imageUrl = "https://mangsipul.alwaysdata.net/storage/";
        private const string ApiUrl = BaseUrl + "api/products/trashed";
        private bool _isLoading = false;

        public TrashedProductForm()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadUserInfo();

            this.Load += async (s, e) => await LoadData();
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

        private async Task LoadData()
        {
            if (_isLoading) return;

            try
            {
                _isLoading = true;

                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Sesi Anda telah habis. Silakan login kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                
                var response = await client.GetAsync(ApiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var products = JsonSerializer.Deserialize<List<Product>>(json);
                    
                    if (products != null)
                    {
                        dgvProducts.Rows.Clear();
                        DisplayProducts(products);
                    }
                }
                else
                {
                    string errorJson = await response.Content.ReadAsStringAsync();
                    try
                    {
                        var errorObj = JsonSerializer.Deserialize<Dictionary<string, object>>(errorJson);
                        string message = errorObj != null && errorObj.ContainsKey("message") 
                            ? errorObj["message"].ToString() 
                            : "Gagal mengambil data produk terhapus.";
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Gagal mengambil data produk terhapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private async void DisplayProducts(List<Product> products)
        {
            int no = 1;

            foreach (var product in products)
            {
                int rowIndex = dgvProducts.Rows.Add();
                var row = dgvProducts.Rows[rowIndex];

                // Set Tag immediately
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

        private async void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Safety check: Ensure Tag is not null before casting
            if (dgvProducts.Rows[e.RowIndex].Tag == null) return;

            int productId = (int)dgvProducts.Rows[e.RowIndex].Tag;
            
            // Safety check for Cell Value
            var cell = dgvProducts.Rows[e.RowIndex].Cells["colMenu"];
            string productTitle = cell.Value?.ToString() ?? "Produk";

            if (dgvProducts.Columns[e.ColumnIndex].Name == "colRestore")
            {
                var result = MessageBox.Show($"Apakah Anda yakin ingin memulihkan produk '{productTitle}'?", 
                    "Konfirmasi Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    await RestoreProduct(productId);
                }
            }
            else if (dgvProducts.Columns[e.ColumnIndex].Name == "colDelete")
            {
                using (var dialog = new PasswordInputDialog("Konfirmasi Hapus Permanen", $"Masukkan password untuk menghapus '{productTitle}' secara permanen:"))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        await ForceDeleteProduct(productId, dialog.Password);
                    }
                }
            }
        }

        private async Task RestoreProduct(int id)
        {
            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var response = await client.PostAsync($"{BaseUrl}api/products/{id}/restore", null);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produk berhasil dipulihkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadData();
                }
                else
                {
                    await HandleErrorResponse(response, "Gagal memulihkan produk.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ForceDeleteProduct(int id, string password)
        {
            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var data = new { password = password };
                string json = JsonSerializer.Serialize(data);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                // Menggunakan HttpRequestMessage karena DeleteAsync standar tidak mendukung Body
                var request = new HttpRequestMessage(HttpMethod.Delete, $"{BaseUrl}api/products/{id}/force")
                {
                    Content = content
                };

                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produk berhasil dihapus secara permanen.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadData();
                }
                else
                {
                    await HandleErrorResponse(response, "Gagal menghapus produk permanen.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task HandleErrorResponse(HttpResponseMessage response, string defaultMessage)
        {
            string errorJson = await response.Content.ReadAsStringAsync();
            try
            {
                var errorObj = JsonSerializer.Deserialize<Dictionary<string, object>>(errorJson);
                string message = errorObj != null && errorObj.ContainsKey("message") 
                    ? errorObj["message"].ToString() 
                    : defaultMessage;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show(defaultMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
