using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    public partial class SidebarControl : UserControl
    {
        private bool isProdukExpanded = false;
        private bool isKategoriExpanded = false;
        private bool isInteraksiExpanded = false;
        private bool isPengaturanExpanded = false;

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

        private void btnMenuPengaturan_Click(object sender, EventArgs e)
        {
            isPengaturanExpanded = !isPengaturanExpanded;
            if (isPengaturanExpanded)
            {
                pnlSubPengaturan.Visible = true;
                pnlSubPengaturan.Height = 70;
                btnMenuPengaturan.Text = "⚙️ Pengaturan           v";
            }
            else
            {
                pnlSubPengaturan.Visible = false;
                pnlSubPengaturan.Height = 0;
                btnMenuPengaturan.Text = "⚙️ Pengaturan           >";
            }
            pnlMenu.PerformLayout();
        }

        private void btnSubProfil_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is ProfileForm))
            {
                ProfileForm profileForm = new ProfileForm();
                profileForm.Show();
                this.ParentForm.Hide();
            }
        }

        private void btnSubPassword_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is ResetPasswordForm))
            {
                ResetPasswordForm resetForm = new ResetPasswordForm();
                resetForm.Show();
                this.ParentForm.Hide();
            }
        }

        private void btnMenuInteraksi_Click(object sender, EventArgs e)
        {
            isInteraksiExpanded = !isInteraksiExpanded;
            if (isInteraksiExpanded)
            {
                pnlSubInteraksi.Visible = true;
                pnlSubInteraksi.Height = 70; // Height for 2 sub-buttons
                btnMenuInteraksi.Text = "💬 Interaksi              v";
            }
            else
            {
                pnlSubInteraksi.Visible = false;
                pnlSubInteraksi.Height = 0;
                btnMenuInteraksi.Text = "💬 Interaksi              >";
            }
            pnlMenu.PerformLayout(); // Force layout refresh for FlowLayoutPanel
        }

        private void btnSubTestimoni_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is RatingListForm))
            {
                RatingListForm ratingList = new RatingListForm();
                ratingList.Show();
                this.ParentForm.Hide();
            }
        }

        private void btnSubPesan_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is MessageListForm))
            {
                MessageListForm messageList = new MessageListForm();
                messageList.Show();
                this.ParentForm.Hide();
            }
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

        private void btnMenuKategori_Click(object sender, EventArgs e)
        {
            isKategoriExpanded = !isKategoriExpanded;
            if (isKategoriExpanded)
            {
                pnlSubKategori.Visible = true;
                pnlSubKategori.Height = 100; // Increased height to ensure children are visible
                btnMenuKategori.Text = "🏷️ Kategori             v";
            }
            else
            {
                pnlSubKategori.Visible = false;
                pnlSubKategori.Height = 0;
                btnMenuKategori.Text = "🏷️ Kategori             >";
            }
            pnlMenu.PerformLayout(); // Force layout refresh for FlowLayoutPanel
        }

        private void btnSubKategoriList_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is CategoryListForm))
            {
                CategoryListForm categoryList = new CategoryListForm();
                categoryList.Show();
                this.ParentForm.Hide();
            }
        }

        private void btnSubKategoriTambah_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is CreateCategoryForm))
            {
                CreateCategoryForm createCategory = new CreateCategoryForm();
                createCategory.Show();
                this.ParentForm.Hide();
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

   

        private void btnMenuPesanan_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null && !(this.ParentForm is TransactionListForm))
            {
                TransactionListForm transactionList = new TransactionListForm();
                transactionList.Show();
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
