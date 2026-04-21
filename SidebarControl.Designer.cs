using System.Drawing;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    partial class SidebarControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenuDashboard = new System.Windows.Forms.Button();
            this.btnMenuProduk = new System.Windows.Forms.Button();
            this.pnlSubProduk = new System.Windows.Forms.Panel();
            this.btnSubProdukTerhapus = new System.Windows.Forms.Button();
            this.btnSubProdukTambah = new System.Windows.Forms.Button();
            this.btnSubProdukList = new System.Windows.Forms.Button();
            this.btnMenuKategori = new System.Windows.Forms.Button();
            this.pnlSubKategori = new System.Windows.Forms.Panel();
            this.btnSubKategoriTambah = new System.Windows.Forms.Button();
            this.btnSubKategoriList = new System.Windows.Forms.Button();
            this.btnMenuPesanan = new System.Windows.Forms.Button();
            this.btnMenuInteraksi = new System.Windows.Forms.Button();
            this.pnlSubInteraksi = new System.Windows.Forms.Panel();
            this.btnSubTestimoni = new System.Windows.Forms.Button();
            this.btnSubPesan = new System.Windows.Forms.Button();
            this.btnMenuPencatatan = new System.Windows.Forms.Button();
            this.pnlSubPencatatan = new System.Windows.Forms.Panel();
            this.btnSubRiwayatWallet = new System.Windows.Forms.Button();
            this.btnSubTipeTransaksi = new System.Windows.Forms.Button();
            this.btnSubBuatWallet = new System.Windows.Forms.Button();
            this.btnSubListWallets = new System.Windows.Forms.Button();
            this.btnMenuPengaturan = new System.Windows.Forms.Button();
            this.pnlSubPengaturan = new System.Windows.Forms.Panel();
            this.btnSubProfil = new System.Windows.Forms.Button();
            this.btnSubPassword = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbSidebarLogo = new System.Windows.Forms.PictureBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlSubProduk.SuspendLayout();
            this.pnlSubKategori.SuspendLayout();
            this.pnlSubInteraksi.SuspendLayout();
            this.pnlSubPencatatan.SuspendLayout();
            this.pnlSubPengaturan.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebarLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.pnlMenu);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(195, 878);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogout.Location = new System.Drawing.Point(0, 837);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(195, 41);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = " Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.Controls.Add(this.btnMenuDashboard);
            this.pnlMenu.Controls.Add(this.btnMenuProduk);
            this.pnlMenu.Controls.Add(this.pnlSubProduk);
            this.pnlMenu.Controls.Add(this.btnMenuKategori);
            this.pnlMenu.Controls.Add(this.pnlSubKategori);
            this.pnlMenu.Controls.Add(this.btnMenuPesanan);
            this.pnlMenu.Controls.Add(this.btnMenuInteraksi);
            this.pnlMenu.Controls.Add(this.pnlSubInteraksi);
            this.pnlMenu.Controls.Add(this.btnMenuPencatatan);
            this.pnlMenu.Controls.Add(this.pnlSubPencatatan);
            this.pnlMenu.Controls.Add(this.btnMenuPengaturan);
            this.pnlMenu.Controls.Add(this.pnlSubPengaturan);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 164);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(195, 673);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnMenuDashboard
            // 
            this.btnMenuDashboard.FlatAppearance.BorderSize = 0;
            this.btnMenuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnMenuDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.btnMenuDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnMenuDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuDashboard.Name = "btnMenuDashboard";
            this.btnMenuDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuDashboard.Size = new System.Drawing.Size(195, 41);
            this.btnMenuDashboard.TabIndex = 0;
            this.btnMenuDashboard.Text = "🏠 Dashboard";
            this.btnMenuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDashboard.UseVisualStyleBackColor = true;
            this.btnMenuDashboard.Click += new System.EventHandler(this.btnMenuDashboard_Click);
            // 
            // btnMenuProduk
            // 
            this.btnMenuProduk.FlatAppearance.BorderSize = 0;
            this.btnMenuProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuProduk.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnMenuProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnMenuProduk.Location = new System.Drawing.Point(0, 41);
            this.btnMenuProduk.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuProduk.Name = "btnMenuProduk";
            this.btnMenuProduk.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuProduk.Size = new System.Drawing.Size(195, 41);
            this.btnMenuProduk.TabIndex = 1;
            this.btnMenuProduk.Text = "🍔 Produk             >";
            this.btnMenuProduk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuProduk.UseVisualStyleBackColor = true;
            this.btnMenuProduk.Click += new System.EventHandler(this.btnMenuProduk_Click);
            // 
            // pnlSubProduk
            // 
            this.pnlSubProduk.Controls.Add(this.btnSubProdukTerhapus);
            this.pnlSubProduk.Controls.Add(this.btnSubProdukTambah);
            this.pnlSubProduk.Controls.Add(this.btnSubProdukList);
            this.pnlSubProduk.Location = new System.Drawing.Point(0, 82);
            this.pnlSubProduk.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubProduk.Name = "pnlSubProduk";
            this.pnlSubProduk.Size = new System.Drawing.Size(195, 0);
            this.pnlSubProduk.TabIndex = 2;
            this.pnlSubProduk.Visible = false;
            // 
            // btnSubProdukTerhapus
            // 
            this.btnSubProdukTerhapus.FlatAppearance.BorderSize = 0;
            this.btnSubProdukTerhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProdukTerhapus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubProdukTerhapus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubProdukTerhapus.Location = new System.Drawing.Point(0, 65);
            this.btnSubProdukTerhapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubProdukTerhapus.Name = "btnSubProdukTerhapus";
            this.btnSubProdukTerhapus.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubProdukTerhapus.Size = new System.Drawing.Size(195, 32);
            this.btnSubProdukTerhapus.TabIndex = 2;
            this.btnSubProdukTerhapus.Text = "Produk Terhapus";
            this.btnSubProdukTerhapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProdukTerhapus.UseVisualStyleBackColor = true;
            this.btnSubProdukTerhapus.Click += new System.EventHandler(this.btnSubProdukTerhapus_Click);
            // 
            // btnSubProdukTambah
            // 
            this.btnSubProdukTambah.FlatAppearance.BorderSize = 0;
            this.btnSubProdukTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProdukTambah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubProdukTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubProdukTambah.Location = new System.Drawing.Point(0, 32);
            this.btnSubProdukTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubProdukTambah.Name = "btnSubProdukTambah";
            this.btnSubProdukTambah.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubProdukTambah.Size = new System.Drawing.Size(195, 32);
            this.btnSubProdukTambah.TabIndex = 1;
            this.btnSubProdukTambah.Text = "Tambah Produk";
            this.btnSubProdukTambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProdukTambah.UseVisualStyleBackColor = true;
            this.btnSubProdukTambah.Click += new System.EventHandler(this.btnSubProdukTambah_Click);
            // 
            // btnSubProdukList
            // 
            this.btnSubProdukList.FlatAppearance.BorderSize = 0;
            this.btnSubProdukList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProdukList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubProdukList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubProdukList.Location = new System.Drawing.Point(0, 0);
            this.btnSubProdukList.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubProdukList.Name = "btnSubProdukList";
            this.btnSubProdukList.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubProdukList.Size = new System.Drawing.Size(195, 32);
            this.btnSubProdukList.TabIndex = 0;
            this.btnSubProdukList.Text = "List Product";
            this.btnSubProdukList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProdukList.UseVisualStyleBackColor = true;
            this.btnSubProdukList.Click += new System.EventHandler(this.btnSubProdukList_Click);
            // 
            // btnMenuKategori
            // 
            this.btnMenuKategori.FlatAppearance.BorderSize = 0;
            this.btnMenuKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuKategori.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnMenuKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnMenuKategori.Location = new System.Drawing.Point(0, 82);
            this.btnMenuKategori.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuKategori.Name = "btnMenuKategori";
            this.btnMenuKategori.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuKategori.Size = new System.Drawing.Size(195, 41);
            this.btnMenuKategori.TabIndex = 3;
            this.btnMenuKategori.Text = "🏷️ Kategori             >";
            this.btnMenuKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuKategori.UseVisualStyleBackColor = true;
            this.btnMenuKategori.Click += new System.EventHandler(this.btnMenuKategori_Click);
            // 
            // pnlSubKategori
            // 
            this.pnlSubKategori.Controls.Add(this.btnSubKategoriTambah);
            this.pnlSubKategori.Controls.Add(this.btnSubKategoriList);
            this.pnlSubKategori.Location = new System.Drawing.Point(0, 123);
            this.pnlSubKategori.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubKategori.Name = "pnlSubKategori";
            this.pnlSubKategori.Size = new System.Drawing.Size(195, 0);
            this.pnlSubKategori.TabIndex = 4;
            this.pnlSubKategori.Visible = false;
            // 
            // btnSubKategoriTambah
            // 
            this.btnSubKategoriTambah.FlatAppearance.BorderSize = 0;
            this.btnSubKategoriTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubKategoriTambah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubKategoriTambah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubKategoriTambah.Location = new System.Drawing.Point(0, 32);
            this.btnSubKategoriTambah.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubKategoriTambah.Name = "btnSubKategoriTambah";
            this.btnSubKategoriTambah.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubKategoriTambah.Size = new System.Drawing.Size(195, 32);
            this.btnSubKategoriTambah.TabIndex = 1;
            this.btnSubKategoriTambah.Text = "Tambah Kategori";
            this.btnSubKategoriTambah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubKategoriTambah.UseVisualStyleBackColor = true;
            this.btnSubKategoriTambah.Click += new System.EventHandler(this.btnSubKategoriTambah_Click);
            // 
            // btnSubKategoriList
            // 
            this.btnSubKategoriList.FlatAppearance.BorderSize = 0;
            this.btnSubKategoriList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubKategoriList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubKategoriList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubKategoriList.Location = new System.Drawing.Point(0, 0);
            this.btnSubKategoriList.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubKategoriList.Name = "btnSubKategoriList";
            this.btnSubKategoriList.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubKategoriList.Size = new System.Drawing.Size(195, 32);
            this.btnSubKategoriList.TabIndex = 0;
            this.btnSubKategoriList.Text = "List Kategori";
            this.btnSubKategoriList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubKategoriList.UseVisualStyleBackColor = true;
            this.btnSubKategoriList.Click += new System.EventHandler(this.btnSubKategoriList_Click);
            // 
            // btnMenuPesanan
            // 
            this.btnMenuPesanan.FlatAppearance.BorderSize = 0;
            this.btnMenuPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPesanan.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnMenuPesanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnMenuPesanan.Location = new System.Drawing.Point(0, 123);
            this.btnMenuPesanan.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuPesanan.Name = "btnMenuPesanan";
            this.btnMenuPesanan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuPesanan.Size = new System.Drawing.Size(195, 41);
            this.btnMenuPesanan.TabIndex = 5;
            this.btnMenuPesanan.Text = "🛒 Pesanan";
            this.btnMenuPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPesanan.UseVisualStyleBackColor = true;
            this.btnMenuPesanan.Click += new System.EventHandler(this.btnMenuPesanan_Click);
            // 
            // btnMenuInteraksi
            // 
            this.btnMenuInteraksi.FlatAppearance.BorderSize = 0;
            this.btnMenuInteraksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInteraksi.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnMenuInteraksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnMenuInteraksi.Location = new System.Drawing.Point(0, 164);
            this.btnMenuInteraksi.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuInteraksi.Name = "btnMenuInteraksi";
            this.btnMenuInteraksi.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuInteraksi.Size = new System.Drawing.Size(195, 41);
            this.btnMenuInteraksi.TabIndex = 6;
            this.btnMenuInteraksi.Text = "💬 Interaksi              >";
            this.btnMenuInteraksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuInteraksi.UseVisualStyleBackColor = true;
            this.btnMenuInteraksi.Click += new System.EventHandler(this.btnMenuInteraksi_Click);
            // 
            // pnlSubInteraksi
            // 
            this.pnlSubInteraksi.Controls.Add(this.btnSubPesan);
            this.pnlSubInteraksi.Controls.Add(this.btnSubTestimoni);
            this.pnlSubInteraksi.Location = new System.Drawing.Point(0, 205);
            this.pnlSubInteraksi.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubInteraksi.Name = "pnlSubInteraksi";
            this.pnlSubInteraksi.Size = new System.Drawing.Size(195, 0);
            this.pnlSubInteraksi.TabIndex = 7;
            this.pnlSubInteraksi.Visible = false;
            // 
            // btnSubTestimoni
            // 
            this.btnSubTestimoni.FlatAppearance.BorderSize = 0;
            this.btnSubTestimoni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTestimoni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubTestimoni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubTestimoni.Location = new System.Drawing.Point(0, 0);
            this.btnSubTestimoni.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubTestimoni.Name = "btnSubTestimoni";
            this.btnSubTestimoni.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubTestimoni.Size = new System.Drawing.Size(195, 32);
            this.btnSubTestimoni.TabIndex = 0;
            this.btnSubTestimoni.Text = "Testimoni";
            this.btnSubTestimoni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubTestimoni.UseVisualStyleBackColor = true;
            this.btnSubTestimoni.Click += new System.EventHandler(this.btnSubTestimoni_Click);
            // 
            // btnSubPesan
            // 
            this.btnSubPesan.FlatAppearance.BorderSize = 0;
            this.btnSubPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPesan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubPesan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubPesan.Location = new System.Drawing.Point(0, 32);
            this.btnSubPesan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubPesan.Name = "btnSubPesan";
            this.btnSubPesan.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubPesan.Size = new System.Drawing.Size(195, 32);
            this.btnSubPesan.TabIndex = 1;
            this.btnSubPesan.Text = "Pesan";
            this.btnSubPesan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubPesan.UseVisualStyleBackColor = true;
            this.btnSubPesan.Click += new System.EventHandler(this.btnSubPesan_Click);
            // 
            // btnMenuPencatatan
            // 
            this.btnMenuPencatatan.FlatAppearance.BorderSize = 0;
            this.btnMenuPencatatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPencatatan.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnMenuPencatatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnMenuPencatatan.Location = new System.Drawing.Point(0, 205);
            this.btnMenuPencatatan.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuPencatatan.Name = "btnMenuPencatatan";
            this.btnMenuPencatatan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuPencatatan.Size = new System.Drawing.Size(195, 41);
            this.btnMenuPencatatan.TabIndex = 8;
            this.btnMenuPencatatan.Text = "💵 Pencatatan          >";
            this.btnMenuPencatatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPencatatan.UseVisualStyleBackColor = true;
            this.btnMenuPencatatan.Click += new System.EventHandler(this.btnMenuPencatatan_Click);
            // 
            // pnlSubPencatatan
            // 
            this.pnlSubPencatatan.Controls.Add(this.btnSubRiwayatWallet);
            this.pnlSubPencatatan.Controls.Add(this.btnSubTipeTransaksi);
            this.pnlSubPencatatan.Controls.Add(this.btnSubBuatWallet);
            this.pnlSubPencatatan.Controls.Add(this.btnSubListWallets);
            this.pnlSubPencatatan.Location = new System.Drawing.Point(0, 246);
            this.pnlSubPencatatan.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubPencatatan.Name = "pnlSubPencatatan";
            this.pnlSubPencatatan.Size = new System.Drawing.Size(195, 0);
            this.pnlSubPencatatan.TabIndex = 11;
            this.pnlSubPencatatan.Visible = false;
            // 
            // btnSubRiwayatWallet
            // 
            this.btnSubRiwayatWallet.FlatAppearance.BorderSize = 0;
            this.btnSubRiwayatWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubRiwayatWallet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubRiwayatWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubRiwayatWallet.Location = new System.Drawing.Point(0, 96);
            this.btnSubRiwayatWallet.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubRiwayatWallet.Name = "btnSubRiwayatWallet";
            this.btnSubRiwayatWallet.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubRiwayatWallet.Size = new System.Drawing.Size(195, 32);
            this.btnSubRiwayatWallet.TabIndex = 3;
            this.btnSubRiwayatWallet.Text = "Riwayat Wallet";
            this.btnSubRiwayatWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubRiwayatWallet.UseVisualStyleBackColor = true;
            // 
            // btnSubTipeTransaksi
            // 
            this.btnSubTipeTransaksi.FlatAppearance.BorderSize = 0;
            this.btnSubTipeTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTipeTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubTipeTransaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubTipeTransaksi.Location = new System.Drawing.Point(0, 64);
            this.btnSubTipeTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubTipeTransaksi.Name = "btnSubTipeTransaksi";
            this.btnSubTipeTransaksi.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubTipeTransaksi.Size = new System.Drawing.Size(195, 32);
            this.btnSubTipeTransaksi.TabIndex = 2;
            this.btnSubTipeTransaksi.Text = "Tipe Transaksi";
            this.btnSubTipeTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubTipeTransaksi.UseVisualStyleBackColor = true;
            this.btnSubTipeTransaksi.Click += new System.EventHandler(this.btnSubTipeTransaksi_Click);
            // 
            // btnSubBuatWallet
            // 
            this.btnSubBuatWallet.FlatAppearance.BorderSize = 0;
            this.btnSubBuatWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubBuatWallet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubBuatWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubBuatWallet.Location = new System.Drawing.Point(0, 32);
            this.btnSubBuatWallet.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubBuatWallet.Name = "btnSubBuatWallet";
            this.btnSubBuatWallet.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubBuatWallet.Size = new System.Drawing.Size(195, 32);
            this.btnSubBuatWallet.TabIndex = 1;
            this.btnSubBuatWallet.Text = "Buat Wallet Baru";
            this.btnSubBuatWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubBuatWallet.UseVisualStyleBackColor = true;
            this.btnSubBuatWallet.Click += new System.EventHandler(this.btnSubBuatWallet_Click);
            // 
            // btnSubListWallets
            // 
            this.btnSubListWallets.FlatAppearance.BorderSize = 0;
            this.btnSubListWallets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubListWallets.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubListWallets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubListWallets.Location = new System.Drawing.Point(0, 0);
            this.btnSubListWallets.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubListWallets.Name = "btnSubListWallets";
            this.btnSubListWallets.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubListWallets.Size = new System.Drawing.Size(195, 32);
            this.btnSubListWallets.TabIndex = 0;
            this.btnSubListWallets.Text = "List Wallets";
            this.btnSubListWallets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubListWallets.UseVisualStyleBackColor = true;
            this.btnSubListWallets.Click += new System.EventHandler(this.btnSubListWallets_Click);
            // 
            // btnMenuPengaturan
            // 
            this.btnMenuPengaturan.FlatAppearance.BorderSize = 0;
            this.btnMenuPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPengaturan.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnMenuPengaturan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnMenuPengaturan.Location = new System.Drawing.Point(0, 246);
            this.btnMenuPengaturan.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuPengaturan.Name = "btnMenuPengaturan";
            this.btnMenuPengaturan.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMenuPengaturan.Size = new System.Drawing.Size(195, 41);
            this.btnMenuPengaturan.TabIndex = 9;
            this.btnMenuPengaturan.Text = "⚙️ Pengaturan           >";
            this.btnMenuPengaturan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuPengaturan.UseVisualStyleBackColor = true;
            this.btnMenuPengaturan.Click += new System.EventHandler(this.btnMenuPengaturan_Click);
            // 
            // pnlSubPengaturan
            // 
            this.pnlSubPengaturan.Controls.Add(this.btnSubPassword);
            this.pnlSubPengaturan.Controls.Add(this.btnSubProfil);
            this.pnlSubPengaturan.Location = new System.Drawing.Point(0, 287);
            this.pnlSubPengaturan.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubPengaturan.Name = "pnlSubPengaturan";
            this.pnlSubPengaturan.Size = new System.Drawing.Size(195, 0);
            this.pnlSubPengaturan.TabIndex = 10;
            this.pnlSubPengaturan.Visible = false;
            // 
            // btnSubProfil
            // 
            this.btnSubProfil.FlatAppearance.BorderSize = 0;
            this.btnSubProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubProfil.Location = new System.Drawing.Point(0, 0);
            this.btnSubProfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubProfil.Name = "btnSubProfil";
            this.btnSubProfil.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubProfil.Size = new System.Drawing.Size(195, 32);
            this.btnSubProfil.TabIndex = 0;
            this.btnSubProfil.Text = "Profil Akun";
            this.btnSubProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubProfil.UseVisualStyleBackColor = true;
            this.btnSubProfil.Click += new System.EventHandler(this.btnSubProfil_Click);
            // 
            // btnSubPassword
            // 
            this.btnSubPassword.FlatAppearance.BorderSize = 0;
            this.btnSubPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnSubPassword.Location = new System.Drawing.Point(0, 32);
            this.btnSubPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubPassword.Name = "btnSubPassword";
            this.btnSubPassword.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.btnSubPassword.Size = new System.Drawing.Size(195, 32);
            this.btnSubPassword.TabIndex = 1;
            this.btnSubPassword.Text = "Ganti Password";
            this.btnSubPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubPassword.UseVisualStyleBackColor = true;
            this.btnSubPassword.Click += new System.EventHandler(this.btnSubPassword_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.pnlLogo.Controls.Add(this.pbSidebarLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(195, 164);
            this.pnlLogo.TabIndex = 0;
            // 
            // pbSidebarLogo
            // 
            this.pbSidebarLogo.Location = new System.Drawing.Point(30, 12);
            this.pbSidebarLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbSidebarLogo.Name = "pbSidebarLogo";
            this.pbSidebarLogo.Size = new System.Drawing.Size(133, 120);
            this.pbSidebarLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSidebarLogo.TabIndex = 0;
            this.pbSidebarLogo.TabStop = false;
            // 
            // SidebarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSidebar);
            this.Name = "SidebarControl";
            this.Size = new System.Drawing.Size(195, 878);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlSubProduk.ResumeLayout(false);
            this.pnlSubKategori.ResumeLayout(false);
            this.pnlSubInteraksi.ResumeLayout(false);
            this.pnlSubPencatatan.ResumeLayout(false);
            this.pnlSubPengaturan.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSidebarLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.Button btnMenuDashboard;
        private System.Windows.Forms.Button btnMenuProduk;
        private System.Windows.Forms.Panel pnlSubProduk;
        private System.Windows.Forms.Button btnSubProdukTerhapus;
        private System.Windows.Forms.Button btnSubProdukTambah;
        private System.Windows.Forms.Button btnSubProdukList;
        private System.Windows.Forms.Button btnMenuKategori;
        private System.Windows.Forms.Panel pnlSubKategori;
        private System.Windows.Forms.Button btnSubKategoriTambah;
        private System.Windows.Forms.Button btnSubKategoriList;
        private System.Windows.Forms.Button btnMenuPesanan;
        private System.Windows.Forms.Button btnMenuInteraksi;
        private System.Windows.Forms.Panel pnlSubInteraksi;
        private System.Windows.Forms.Button btnSubTestimoni;
        private System.Windows.Forms.Button btnSubPesan;
        private System.Windows.Forms.Button btnMenuPencatatan;
        private System.Windows.Forms.Panel pnlSubPencatatan;
        private System.Windows.Forms.Button btnSubListWallets;
        private System.Windows.Forms.Button btnSubBuatWallet;
        private System.Windows.Forms.Button btnSubTipeTransaksi;
        private System.Windows.Forms.Button btnSubRiwayatWallet;
        private System.Windows.Forms.Button btnMenuPengaturan;
        private System.Windows.Forms.Panel pnlSubPengaturan;
        private System.Windows.Forms.Button btnSubProfil;
        private System.Windows.Forms.Button btnSubPassword;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pbSidebarLogo;
    }
}
