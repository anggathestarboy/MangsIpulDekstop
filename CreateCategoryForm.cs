using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MangsIpulAsli.Models;

namespace MangsIpulAsli
{
    public partial class CreateCategoryForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string ApiUrl = "https://mangsipul.alwaysdata.net/api/categories";

        public CreateCategoryForm()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async void btnSimpanKategori_Click(object sender, EventArgs e)
        {
            string categoryName = txtNamaKategori.Text.Trim();

            if (string.IsNullOrEmpty(categoryName) || categoryName == "Contoh: Makanan Ringan, Minuman, dll")
            {
                MessageBox.Show("Nama kategori wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnSimpanKategori.Enabled = false;
            btnSimpanKategori.Text = "Menyimpan...";

            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token))
                {
                    MessageBox.Show("Sesi Anda telah berakhir. Silakan login kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var requestData = new { name = categoryName };
                string json = JsonSerializer.Serialize(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                
                var response = await client.PostAsync(ApiUrl, content);
                string responseJson = await response.Content.ReadAsStringAsync();
                
                using (JsonDocument doc = JsonDocument.Parse(responseJson))
                {
                    string message = doc.RootElement.GetProperty("message").GetString();
                    
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(message, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNamaKategori.Text = "";
                        txtNamaKategori.ForeColor = Color.Gray;
                        txtNamaKategori.Text = "Contoh: Makanan Ringan, Minuman, dll";
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
                btnSimpanKategori.Enabled = true;
                btnSimpanKategori.Text = "Simpan Kategori";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CategoryListForm listForm = new CategoryListForm();
            listForm.Show();
            this.Hide();
        }

        private void txtNamaKategori_Enter(object sender, EventArgs e)
        {
            if (txtNamaKategori.Text == "Contoh: Makanan Ringan, Minuman, dll")
            {
                txtNamaKategori.Text = "";
                txtNamaKategori.ForeColor = Color.Black;
            }
        }

        private void txtNamaKategori_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaKategori.Text))
            {
                txtNamaKategori.Text = "Contoh: Makanan Ringan, Minuman, dll";
                txtNamaKategori.ForeColor = Color.Gray;
            }
        }

        private void lblNamaKategoriTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
