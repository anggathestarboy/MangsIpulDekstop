using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    public partial class SidebarControl : UserControl
    {
        private bool isProdukExpanded = false;

        public SidebarControl()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            try 
            { 
                pbSidebarLogo.ImageLocation = "https://mangsipul.vercel.app/logo.png"; 
            } 
            catch { }
        }

        private void btnMenuProduk_Click(object sender, EventArgs e)
        {
            isProdukExpanded = !isProdukExpanded;
            if (isProdukExpanded)
            {
                pnlSubProduk.Visible = true;
                pnlSubProduk.Height = 140;
                btnMenuProduk.Text = "🍔 Produk             v";
            }
            else
            {
                pnlSubProduk.Visible = false;
                pnlSubProduk.Height = 0;
                btnMenuProduk.Text = "🍔 Produk             >";
            }
        }

        private void btnSubProdukList_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is ProductListForm))
            {
                ProductListForm productList = new ProductListForm();
                productList.Show();
                this.ParentForm.Hide();
            }
        }

        private void btnSubProdukTambah_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is CreateProductForm))
            {
                CreateProductForm createForm = new CreateProductForm();
                createForm.Show();
                this.ParentForm.Hide();
            }
        }

        private void btnSubProdukTerhapus_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is TrashedProductForm))
            {
                TrashedProductForm trashedForm = new TrashedProductForm();
                trashedForm.Show();
                this.ParentForm.Hide();
            }
        }

   

        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is Dashboard))
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.ParentForm.Hide();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            TokenManager.ClearSession();
            
            MessageBox.Show("Anda telah logout.", "Logout",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.ParentForm != null)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.ParentForm.Close();
            }
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e) { }
    }
}
