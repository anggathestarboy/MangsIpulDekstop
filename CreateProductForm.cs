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
    public partial class CreateProductForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string BaseUrl = "https://mangsipul.alwaysdata.net/";
        private const string ApiUrl = BaseUrl + "api/products";
        private const string CategoryApiUrl = BaseUrl + "api/categories";
        private string selectedImagePath = string.Empty;

        public CreateProductForm()
        {
            InitializeComponent();
            LoadUserInfo();
            LoadCategories();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async void LoadCategories()
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
                        cmbCategory.DataSource = categoryResponse.Data.Data;
                        cmbCategory.DisplayMember = "Name";
                        cmbCategory.ValueMember = "Id";
                    }
                }
                else
                {
                    // Fallback to manual if API fails
                    List<Category> fallbackCategories = new List<Category>
                    {
                        new Category { Id = 1, Name = "Makroni" },
                        new Category { Id = 2, Name = "Seblak Kering" },
                        new Category { Id = 3, Name = "Keripik" },
                        new Category { Id = 4, Name = "Basreng" }
                    };
                    cmbCategory.DataSource = fallbackCategories;
                    cmbCategory.DisplayMember = "Name";
                    cmbCategory.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat kategori: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbProductImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Pilih Gambar Produk";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pbProductImage.Image = Image.FromFile(selectedImagePath);
                    lblImageClickInfo.Text = Path.GetFileName(selectedImagePath);
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Nama menu wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Silakan pilih kategori!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPrice.Text) || !decimal.TryParse(txtPrice.Text, out _))
                {
                    MessageBox.Show("Harga harus berupa angka valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtStock.Text) || !int.TryParse(txtStock.Text, out _))
                {
                    MessageBox.Show("Stok harus berupa angka valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(selectedImagePath))
                {
                    MessageBox.Show("Silakan pilih gambar produk!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Prepare request
                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent(txtName.Text), "title");
                    content.Add(new StringContent(txtDescription.Text), "description");
                    content.Add(new StringContent((cmbCategory.SelectedItem as Category).Id.ToString()), "category_id");
                    content.Add(new StringContent(txtStock.Text), "stock");
                    content.Add(new StringContent(txtPrice.Text), "price");

                    // Add Image file
                    byte[] imageData = File.ReadAllBytes(selectedImagePath);
                    var imageContent = new ByteArrayContent(imageData);
                    imageContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("image/" + Path.GetExtension(selectedImagePath).TrimStart('.').ToLower());
                    content.Add(imageContent, "img", Path.GetFileName(selectedImagePath));

                    // Auth Token
                    string token = TokenManager.LoadToken();
                    client.DefaultRequestHeaders.Clear();
                    if (!string.IsNullOrEmpty(token))
                    {
                        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    }

                    // Send POST request
                    var response = await client.PostAsync(ApiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBack_Click(null, null);
                    }
                    else
                    {
                        string error = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Gagal menambahkan produk: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Close(); // Use Close instead of Hide for the current form to free resources
        }

        private void pnlFormCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
