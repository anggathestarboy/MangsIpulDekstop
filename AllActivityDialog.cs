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
    public partial class AllActivityDialog : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public AllActivityDialog()
        {
            InitializeComponent();
            FetchAllLogs();
        }

        private async void FetchAllLogs()
        {
            try
            {
                string token = TokenManager.LoadToken();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                string url = "https://mangsipul.alwaysdata.net/api/logs";
                var response = await client.GetAsync(url);
                
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var logs = JsonSerializer.Deserialize<List<LogActivity>>(json);
                    
                    dgvLogs.Rows.Clear();
                    foreach (var log in logs)
                    {
                        dgvLogs.Rows.Add(
                            log.Id,
                            log.Entity,
                            log.Description,
                            log.CreatedAtDateTime.ToString("dd MMM yyyy, HH.mm")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
