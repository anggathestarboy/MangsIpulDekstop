namespace MangsIpulAsli
{
    partial class CreateWalletForm
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
            this.sidebarControl1 = new MangsIpulAsli.SidebarControl();
            this.navbarControl1 = new MangsIpulAsli.NavbarControl();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTips = new System.Windows.Forms.Panel();
            this.lblTipsContent = new System.Windows.Forms.Label();
            this.lblTipsTitle = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnSimpanWallet = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.lblAboutContent = new System.Windows.Forms.Label();
            this.lblAboutTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtNamaWallet = new System.Windows.Forms.TextBox();
            this.lblNamaWallet = new System.Windows.Forms.Label();
            this.pnlHeaderCard = new System.Windows.Forms.Panel();
            this.lblInformasiWalletSub = new System.Windows.Forms.Label();
            this.lblInformasiWallet = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlTips.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.pnlHeaderCard.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(195, 749);
            this.sidebarControl1.TabIndex = 0;
            // 
            // navbarControl1
            // 
            this.navbarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.navbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarControl1.Location = new System.Drawing.Point(195, 0);
            this.navbarControl1.Name = "navbarControl1";
            this.navbarControl1.Size = new System.Drawing.Size(941, 60);
            this.navbarControl1.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(195, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30);
            this.pnlMain.Size = new System.Drawing.Size(941, 689);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlTips);
            this.pnlContent.Controls.Add(this.pnlCard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(30, 110);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(881, 550);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlTips
            // 
            this.pnlTips.BackColor = System.Drawing.Color.White;
            this.pnlTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTips.Controls.Add(this.lblTipsContent);
            this.pnlTips.Controls.Add(this.lblTipsTitle);
            this.pnlTips.Location = new System.Drawing.Point(0, 410);
            this.pnlTips.Name = "pnlTips";
            this.pnlTips.Size = new System.Drawing.Size(534, 110);
            this.pnlTips.TabIndex = 1;
            // 
            // lblTipsContent
            // 
            this.lblTipsContent.AutoSize = true;
            this.lblTipsContent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipsContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTipsContent.Location = new System.Drawing.Point(15, 40);
            this.lblTipsContent.Name = "lblTipsContent";
            this.lblTipsContent.Size = new System.Drawing.Size(465, 45);
            this.lblTipsContent.TabIndex = 1;
            this.lblTipsContent.Text = "• Buat wallet sesuai tujuan, misalnya: \"Tabungan Liburan\", \"Dana Darurat\", atau \"" +
    "Dompet Harian\"\r\n• Anda dapat membuat banyak wallet untuk memisahkan keuangan\r\n• " +
    "Setelah wallet dibuat, Anda bisa langsung mencatat transaksi pertama";
            // 
            // lblTipsTitle
            // 
            this.lblTipsTitle.AutoSize = true;
            this.lblTipsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTipsTitle.Name = "lblTipsTitle";
            this.lblTipsTitle.Size = new System.Drawing.Size(125, 19);
            this.lblTipsTitle.TabIndex = 0;
            this.lblTipsTitle.Text = "Tips Membuat Wallet";
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.btnSimpanWallet);
            this.pnlCard.Controls.Add(this.btnBatal);
            this.pnlCard.Controls.Add(this.pnlAbout);
            this.pnlCard.Controls.Add(this.lblDescription);
            this.pnlCard.Controls.Add(this.txtNamaWallet);
            this.pnlCard.Controls.Add(this.lblNamaWallet);
            this.pnlCard.Controls.Add(this.pnlHeaderCard);
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(534, 380);
            this.pnlCard.TabIndex = 0;
            // 
            // btnSimpanWallet
            // 
            this.btnSimpanWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.btnSimpanWallet.FlatAppearance.BorderSize = 0;
            this.btnSimpanWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanWallet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpanWallet.ForeColor = System.Drawing.Color.White;
            this.btnSimpanWallet.Location = new System.Drawing.Point(400, 320);
            this.btnSimpanWallet.Name = "btnSimpanWallet";
            this.btnSimpanWallet.Size = new System.Drawing.Size(115, 40);
            this.btnSimpanWallet.TabIndex = 6;
            this.btnSimpanWallet.Text = "Simpan Wallet";
            this.btnSimpanWallet.UseVisualStyleBackColor = false;
            this.btnSimpanWallet.Click += new System.EventHandler(this.btnSimpanWallet_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnBatal.Location = new System.Drawing.Point(310, 320);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(80, 40);
            this.btnBatal.TabIndex = 5;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAbout.Controls.Add(this.lblAboutContent);
            this.pnlAbout.Controls.Add(this.lblAboutTitle);
            this.pnlAbout.Location = new System.Drawing.Point(20, 215);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(495, 80);
            this.pnlAbout.TabIndex = 4;
            // 
            // lblAboutContent
            // 
            this.lblAboutContent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAboutContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblAboutContent.Location = new System.Drawing.Point(35, 30);
            this.lblAboutContent.Name = "lblAboutContent";
            this.lblAboutContent.Size = new System.Drawing.Size(445, 40);
            this.lblAboutContent.TabIndex = 1;
            this.lblAboutContent.Text = "Wallet adalah tempat Anda menyimpan uang digital. Setelah dibuat, Anda dapat menc" +
    "atat pemasukan dan pengeluaran, serta melihat ringkasan keuangan di dashboard.";
            // 
            // lblAboutTitle
            // 
            this.lblAboutTitle.AutoSize = true;
            this.lblAboutTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblAboutTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.lblAboutTitle.Location = new System.Drawing.Point(10, 10);
            this.lblAboutTitle.Name = "lblAboutTitle";
            this.lblAboutTitle.Size = new System.Drawing.Size(83, 15);
            this.lblAboutTitle.TabIndex = 0;
            this.lblAboutTitle.Text = "Tentang Wallet";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDescription.Location = new System.Drawing.Point(20, 185);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(287, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Gunakan nama yang mudah diingat untuk membedakan wallet Anda";
            // 
            // txtNamaWallet
            // 
            this.txtNamaWallet.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNamaWallet.ForeColor = System.Drawing.Color.Gray;
            this.txtNamaWallet.Location = new System.Drawing.Point(20, 150);
            this.txtNamaWallet.Name = "txtNamaWallet";
            this.txtNamaWallet.Size = new System.Drawing.Size(495, 27);
            this.txtNamaWallet.TabIndex = 2;
            this.txtNamaWallet.Text = "Contoh: Dompet Utama, Tabungan, Dana Darurat";
            this.txtNamaWallet.Enter += new System.EventHandler(this.txtNamaWallet_Enter);
            this.txtNamaWallet.Leave += new System.EventHandler(this.txtNamaWallet_Leave);
            // 
            // lblNamaWallet
            // 
            this.lblNamaWallet.AutoSize = true;
            this.lblNamaWallet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNamaWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNamaWallet.Location = new System.Drawing.Point(20, 120);
            this.lblNamaWallet.Name = "lblNamaWallet";
            this.lblNamaWallet.Size = new System.Drawing.Size(91, 19);
            this.lblNamaWallet.TabIndex = 1;
            this.lblNamaWallet.Text = "Nama Wallet";
            // 
            // pnlHeaderCard
            // 
            this.pnlHeaderCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.pnlHeaderCard.Controls.Add(this.lblInformasiWalletSub);
            this.pnlHeaderCard.Controls.Add(this.lblInformasiWallet);
            this.pnlHeaderCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderCard.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderCard.Name = "pnlHeaderCard";
            this.pnlHeaderCard.Size = new System.Drawing.Size(532, 100);
            this.pnlHeaderCard.TabIndex = 0;
            // 
            // lblInformasiWalletSub
            // 
            this.lblInformasiWalletSub.AutoSize = true;
            this.lblInformasiWalletSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInformasiWalletSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblInformasiWalletSub.Location = new System.Drawing.Point(20, 55);
            this.lblInformasiWalletSub.Name = "lblInformasiWalletSub";
            this.lblInformasiWalletSub.Size = new System.Drawing.Size(183, 19);
            this.lblInformasiWalletSub.TabIndex = 1;
            this.lblInformasiWalletSub.Text = "Isi data wallet yang ingin Anda buat";
            // 
            // lblInformasiWallet
            // 
            this.lblInformasiWallet.AutoSize = true;
            this.lblInformasiWallet.Font = new System.Drawing.Font("Segoe UI Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lblInformasiWallet.ForeColor = System.Drawing.Color.White;
            this.lblInformasiWallet.Location = new System.Drawing.Point(20, 25);
            this.lblInformasiWallet.Name = "lblInformasiWallet";
            this.lblInformasiWallet.Size = new System.Drawing.Size(134, 21);
            this.lblInformasiWallet.TabIndex = 0;
            this.lblInformasiWallet.Text = "Informasi Wallet";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.btnBack);
            this.pnlTitle.Controls.Add(this.lblSubtitle);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(30, 30);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(881, 80);
            this.pnlTitle.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnBack.Location = new System.Drawing.Point(0, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitle.Location = new System.Drawing.Point(50, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(374, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Tambahkan dompet digital baru untuk mengelola keuangan Anda";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Bold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTitle.Location = new System.Drawing.Point(43, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Buat Wallet Baru";
            // 
            // CreateWalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 749);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateWalletForm";
            this.Text = "Buat Wallet Baru";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlTips.ResumeLayout(false);
            this.pnlTips.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.pnlHeaderCard.ResumeLayout(false);
            this.pnlHeaderCard.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        private SidebarControl sidebarControl1;
        private NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlHeaderCard;
        private System.Windows.Forms.Label lblInformasiWallet;
        private System.Windows.Forms.Label lblInformasiWalletSub;
        private System.Windows.Forms.Label lblNamaWallet;
        private System.Windows.Forms.TextBox txtNamaWallet;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Label lblAboutTitle;
        private System.Windows.Forms.Label lblAboutContent;
        private System.Windows.Forms.Button btnSimpanWallet;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Panel pnlTips;
        private System.Windows.Forms.Label lblTipsTitle;
        private System.Windows.Forms.Label lblTipsContent;
    }
}
