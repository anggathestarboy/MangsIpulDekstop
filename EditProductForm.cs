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
        private int productId;
        private Product currentProduct;
        private List<Category> categories = new List<Category>();

        public EditProductForm(int id)
        {
            InitializeComponent();
            this.productId = id;
            LoadData();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async void LoadData()
        {
            try
            {
                // 1. Load Categories first
                await LoadCategories();

                // 2. Load Product Details
                var response = await client.GetAsync($"{ApiUrl}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var productResponse = JsonSerializer.Deserialize<ProductResponse>(json);
                    
                    // Since there's no single product GET endpoint in your description, 
                    // we find it from the list for now. Usually it's /api/products/{id}
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
                MessageBox.Show($"Gagal memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadCategories()
        {
            // Placeholder for categories, same as ProductListForm
            categories.Clear();
            categories.Add(new Category { Id = 1, Name = "Makroni" });
            categories.Add(new Category { Id = 3, Name = "Keripik" });
            categories.Add(new Category { Id = 4, Name = "Basreng" });

            cmbCategory.DataSource = null;
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private async void PopulateForm()
        {
            txtName.Text = currentProduct.Title;
            txtPrice.Text = currentProduct.Price.ToString();
            txtStock.Text = currentProduct.Stock.ToString();
            txtDescription.Text = currentProduct.Description;
            
            // Set Category
            foreach (var cat in categories)
            {
                if (cat.Id == currentProduct.CategoryId)
                {
                    cmbCategory.SelectedItem = cat;
                    break;
                }
            }

            // Load Image
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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Nama dan Harga wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var updateData = new
                {
                    title = txtName.Text,
                    description = txtDescription.Text,
                    category_id = (cmbCategory.SelectedItem as Category).Id,
                    stock = int.Parse(txtStock.Text),
                    price = decimal.Parse(txtPrice.Text)
                };

                string json = JsonSerializer.Serialize(updateData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                // Method PUT as requested
                var response = await client.PutAsync($"{ApiUrl}/{productId}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produk berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBack_Click(null, null);
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Gagal memperbarui produk: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
