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
    public partial class MoneyTypeForm : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string ApiUrl = "https://mangsipul.alwaysdata.net/api/money-types";
        private int _editingId = -1;

        public MoneyTypeForm()
        {
            InitializeComponent();
            LoadUserInfo();
            cbKategori.SelectedIndex = 0; // Default to Expense
            FetchMoneyTypes();
        }

        private void LoadUserInfo()
        {
            string username = TokenManager.LoadUsername() ?? "Admin";
            navbarControl1.SetUserInfo(username, $"{username}@mangsipul.com", "Admin");
        }

        private async void FetchMoneyTypes()
        {
            try
            {
                string token = TokenManager.LoadToken();
                if (string.IsNullOrEmpty(token)) return;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(ApiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    using (JsonDocument doc = JsonDocument.Parse(json))
                    {
                        var root = doc.RootElement;
                        if (root.TryGetProperty("money_types", out var typesArray))
                        {
                            dgvMoneyTypes.Rows.Clear();
                            int no = 1;
                            foreach (var item in typesArray.EnumerateArray())
                            {
                                int id = item.GetProperty("id").GetInt32();
                                string name = item.GetProperty("name").GetString();
                                string type = item.GetProperty("type").GetString();

                                int rowIndex = dgvMoneyTypes.Rows.Add(
                                    no++,
                                    name,
                                    type == "income" ? "Pemasukan" : "Pengeluaran",
                                    "Edit",
                                    "Hapus"
                                );

                                dgvMoneyTypes.Rows[rowIndex].Tag = new { Id = id, Name = name, Type = type };
                                
                                // Color badges
                                var cellType = dgvMoneyTypes.Rows[rowIndex].Cells[2];
                                if (type == "income")
                                {
                                    cellType.Style.BackColor = Color.FromArgb(220, 252, 231);
                                    cellType.Style.ForeColor = Color.FromArgb(21, 128, 61);
                                }
                                else
                                {
                                    cellType.Style.BackColor = Color.FromArgb(254, 226, 226);
                                    cellType.Style.ForeColor = Color.FromArgb(185, 28, 28);
                                }
                            }
                            lblTotalTipe.Text = $"Total {no - 1} tipe terdaftar";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnSimpan_Click(object sender, EventArgs e)
        {
            string name = txtNamaTipe.Text.Trim();
            if (string.IsNullOrEmpty(name) || name == "Contoh: Makanan, Gaji, Transportasi")
            {
                MessageBox.Show("Nama tipe wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string type = cbKategori.SelectedIndex == 0 ? "expense" : "income";
            var data = new { name = name, type = type };
            string json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                
                HttpResponseMessage response;
                if (_editingId == -1)
                {
                    response = await client.PostAsync(ApiUrl, content);
                }
                else
                {
                    response = await client.PutAsync($"{ApiUrl}/{_editingId}", content);
                }

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Berhasil menyimpan tipe transaksi.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    FetchMoneyTypes();
                }
                else
                {
                    MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            _editingId = -1;
            txtNamaTipe.Text = "Contoh: Makanan, Gaji, Transportasi";
            txtNamaTipe.ForeColor = Color.Gray;
            cbKategori.SelectedIndex = 0;
            lblTambahTitle.Text = "Tambah Tipe Transaksi Baru";
            btnSimpan.Text = "Tambah Tipe";
        }

        private void dgvMoneyTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dynamic tag = dgvMoneyTypes.Rows[e.RowIndex].Tag;
            int id = tag.Id;

            if (e.ColumnIndex == 3) // Edit
            {
                _editingId = id;
                txtNamaTipe.Text = tag.Name;
                txtNamaTipe.ForeColor = Color.Black;
                cbKategori.SelectedIndex = tag.Type == "expense" ? 0 : 1;
                lblTambahTitle.Text = "Edit Tipe Transaksi";
                btnSimpan.Text = "Update Tipe";
            }
            else if (e.ColumnIndex == 4) // Hapus
            {
                DeleteMoneyType(id);
            }
        }

        private async void DeleteMoneyType(int id)
        {
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus tipe transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string token = TokenManager.LoadToken();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    var response = await client.DeleteAsync($"{ApiUrl}/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Berhasil menghapus tipe transaksi.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FetchMoneyTypes();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtNamaTipe_Enter(object sender, EventArgs e)
        {
            if (txtNamaTipe.Text == "Contoh: Makanan, Gaji, Transportasi")
            {
                txtNamaTipe.Text = "";
                txtNamaTipe.ForeColor = Color.Black;
            }
        }

        private void txtNamaTipe_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaTipe.Text))
            {
                txtNamaTipe.Text = "Contoh: Makanan, Gaji, Transportasi";
                txtNamaTipe.ForeColor = Color.Gray;
            }
        }
    }
}
