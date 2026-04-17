using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class EditProductForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://mangsipul.alwaysdata.net/";
        private const string imageUrl = "https://mangsipul.alwaysdata.net/storage/";
        private const string ApiUrl = BaseUrl + "api/products";
        private const string CategoryApiUrl = BaseUrl + "api/categories";
        private int productId;
        private Product currentProduct;
        private List<Category> categories = new List<Category>();
        private string selectedImagePath = string.Empty;
        private bool _isInitialLoad = true;

        public EditProductForm(int id)
        {
            InitializeComponent();
            this.productId = id;
            InitializeForm();
            LoadUserInfo();
        }

        private async void InitializeForm()
        {
            _isInitialLoad = true;
            await LoadCategories();
            await LoadProductData();
            _isInitialLoad = false;
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async Task LoadProductData()
        {
            try
            {
                // Typically /api/products/{id}, but using list search if needed
                var response = await client.GetAsync($"{ApiUrl}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var productResponse = JsonSerializer.Deserialize<ProductResponse>(json);
                    
                    currentProduct = productResponse?.Data?.Data?.Find(p => p.Id == productId);

                    if (currentProduct != null)
                    {
                        PopulateForm();
                    }
                    else
                    {
                        MessageBox.Show("Produk tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCategories()
        {
            try
            {
                var response = await client.GetAsync(CategoryApiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var categoryResponse = JsonSerializer.Deserialize<CategoryResponse>(json);
                    
                    if (categoryResponse?.Data?.Data != null)
                    {
                        categories = categoryResponse.Data.Data;
                        cmbCategory.DataSource = null;
                        cmbCategory.DataSource = categories;
                        cmbCategory.DisplayMember = "Name";
                        cmbCategory.ValueMember = "Id";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading categories: {ex.Message}");
            }
        }

        private async void PopulateForm()
        {
            txtName.Text = currentProduct.Title;
            txtPrice.Text = currentProduct.Price.ToString();
            txtStock.Text = currentProduct.Stock.ToString();
            txtDescription.Text = currentProduct.Description;
            
            // Set Category
            if (categories != null)
            {
                for (int i = 0; i < cmbCategory.Items.Count; i++)
                {
                    if ((cmbCategory.Items[i] as Category).Id == currentProduct.CategoryId)
                    {
                        cmbCategory.SelectedIndex = i;
                        break;
                    }
                }
            }

            // Load Existing Image
            if (!string.IsNullOrEmpty(currentProduct.Img))
            {
                try
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(imageUrl + currentProduct.Img);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        pbProductImage.Image = Image.FromStream(ms);
                    }
                }
                catch { }
            }
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Pilih Gambar Produk Baru";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pbProductImage.Image = Image.FromFile(selectedImagePath);
                    lblImageClickInfo.Text = Path.GetFileName(selectedImagePath);
                }
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Nama menu wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Many APIs handle PUT with multipart differently. 
                // We'll use POST with _method=PUT or pure PUT depending on backend requirements.
                // Standard approach for Laravel/PHP backends with files is POST + _method=PUT
                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent(txtName.Text), "title");
                    content.Add(new StringContent(txtDescription.Text ?? ""), "description");
                    content.Add(new StringContent((cmbCategory.SelectedItem as Category).Id.ToString()), "category_id");
                    content.Add(new StringContent(txtStock.Text), "stock");
                    content.Add(new StringContent(txtPrice.Text), "price");
                    content.Add(new StringContent("PUT"), "_method"); // Laravel compatibility for multipart PUT

                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {
                        byte[] imageData = File.ReadAllBytes(selectedImagePath);
                        var imageContent = new ByteArrayContent(imageData);
                        imageContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("image/" + Path.GetExtension(selectedImagePath).TrimStart('.').ToLower());
                        content.Add(imageContent, "img", Path.GetFileName(selectedImagePath));
                    }

                    string token = TokenManager.LoadToken();
                    client.DefaultRequestHeaders.Clear();
                    if (!string.IsNullOrEmpty(token))
                    {
                        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    }

                    // We use POST with _method=PUT for multipart support
                    var response = await client.PostAsync($"{ApiUrl}/{productId}", content);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Produk berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBack_Click(null, null);
                    }
                    else
                    {
                        try
                        {
                            var errorData = JsonSerializer.Deserialize<JsonElement>(responseContent);
                            string errorMessage = "";

                            if (errorData.TryGetProperty("errors", out var errorsProp))
                            {
                                // Join all validation errors if they exist
                                List<string> errs = new List<string>();
                                foreach (var prop in errorsProp.EnumerateObject())
                                {
                                    foreach (var detail in prop.Value.EnumerateArray())
                                    {
                                        errs.Add(detail.GetString());
                                    }
                                }
                                errorMessage = string.Join("\n", errs);
                            }
                            else if (errorData.TryGetProperty("message", out var msgProp))
                            {
                                errorMessage = msgProp.GetString();
                            }
                            else
                            {
                                errorMessage = "Terjadi kesalahan tidak diketahui.";
                            }
                            
                            MessageBox.Show(errorMessage, "Gagal (422/Validation)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        catch
                        {
                            MessageBox.Show($"Gagal memperbarui produk: {response.ReasonPhrase}\n{responseContent}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            btnBack_Click(sender, e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductListForm listForm = new ProductListForm();
            listForm.Show();
            this.Hide();
        }
    }
}
