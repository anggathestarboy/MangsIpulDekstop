namespace MangsIpulAsli
{
    partial class WalletListForm
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
            this.pnlTransactionCard = new System.Windows.Forms.Panel();
            this.lblWajibHint = new System.Windows.Forms.Label();
            this.btnSimpanTransaksi = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.cbTipeTransaksi = new System.Windows.Forms.ComboBox();
            this.lblTipeTransaksi = new System.Windows.Forms.Label();
            this.cbWallet = new System.Windows.Forms.ComboBox();
            this.lblPilihWallet = new System.Windows.Forms.Label();
            this.pnlTransHeader = new System.Windows.Forms.Panel();
            this.lblTransSubtitle = new System.Windows.Forms.Label();
            this.lblTransTitle = new System.Windows.Forms.Label();
            this.pnlChartCard = new System.Windows.Forms.Panel();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblChartHint = new System.Windows.Forms.Label();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlTransactionCard.SuspendLayout();
            this.pnlTransHeader.SuspendLayout();
            this.pnlChartCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(195, 800);
            this.sidebarControl1.TabIndex = 0;
            // 
            // navbarControl1
            // 
            this.navbarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.navbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarControl1.Location = new System.Drawing.Point(195, 0);
            this.navbarControl1.Name = "navbarControl1";
            this.navbarControl1.Size = new System.Drawing.Size(1005, 60);
            this.navbarControl1.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(195, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30);
            this.pnlMain.Size = new System.Drawing.Size(1005, 740);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlTransactionCard);
            this.pnlContent.Controls.Add(this.pnlChartCard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(30, 110);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(945, 1100);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlTransactionCard
            // 
            this.pnlTransactionCard.BackColor = System.Drawing.Color.White;
            this.pnlTransactionCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransactionCard.Controls.Add(this.lblWajibHint);
            this.pnlTransactionCard.Controls.Add(this.btnSimpanTransaksi);
            this.pnlTransactionCard.Controls.Add(this.btnReset);
            this.pnlTransactionCard.Controls.Add(this.txtDeskripsi);
            this.pnlTransactionCard.Controls.Add(this.lblDeskripsi);
            this.pnlTransactionCard.Controls.Add(this.dtpTanggal);
            this.pnlTransactionCard.Controls.Add(this.lblTanggal);
            this.pnlTransactionCard.Controls.Add(this.txtJumlah);
            this.pnlTransactionCard.Controls.Add(this.lblJumlah);
            this.pnlTransactionCard.Controls.Add(this.cbTipeTransaksi);
            this.pnlTransactionCard.Controls.Add(this.lblTipeTransaksi);
            this.pnlTransactionCard.Controls.Add(this.cbWallet);
            this.pnlTransactionCard.Controls.Add(this.lblPilihWallet);
            this.pnlTransactionCard.Controls.Add(this.pnlTransHeader);
            this.pnlTransactionCard.Location = new System.Drawing.Point(0, 580);
            this.pnlTransactionCard.Name = "pnlTransactionCard";
            this.pnlTransactionCard.Size = new System.Drawing.Size(945, 450);
            this.pnlTransactionCard.TabIndex = 2;
            // 
            // lblWajibHint
            // 
            this.lblWajibHint.AutoSize = true;
            this.lblWajibHint.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblWajibHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblWajibHint.Location = new System.Drawing.Point(300, 410);
            this.lblWajibHint.Name = "lblWajibHint";
            this.lblWajibHint.Size = new System.Drawing.Size(359, 13);
            this.lblWajibHint.TabIndex = 13;
            this.lblWajibHint.Text = "* Semua field wajib diisi kecuali tanggal (akan menggunakan hari ini jika kosong)" +
    "";
            // 
            // btnSimpanTransaksi
            // 
            this.btnSimpanTransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.btnSimpanTransaksi.FlatAppearance.BorderSize = 0;
            this.btnSimpanTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanTransaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpanTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnSimpanTransaksi.Location = new System.Drawing.Point(780, 350);
            this.btnSimpanTransaksi.Name = "btnSimpanTransaksi";
            this.btnSimpanTransaksi.Size = new System.Drawing.Size(140, 40);
            this.btnSimpanTransaksi.TabIndex = 12;
            this.btnSimpanTransaksi.Text = "Simpan Transaksi";
            this.btnSimpanTransaksi.UseVisualStyleBackColor = false;
            this.btnSimpanTransaksi.Click += new System.EventHandler(this.btnSimpanTransaksi_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnReset.Location = new System.Drawing.Point(690, 350);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 40);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeskripsi.Location = new System.Drawing.Point(500, 210);
            this.txtDeskripsi.Multiline = true;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(420, 100);
            this.txtDeskripsi.TabIndex = 10;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDeskripsi.Location = new System.Drawing.Point(500, 185);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(66, 19);
            this.lblDeskripsi.TabIndex = 9;
            this.lblDeskripsi.Text = "Deskripsi";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTanggal.Location = new System.Drawing.Point(500, 135);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(420, 25);
            this.dtpTanggal.TabIndex = 8;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTanggal.Location = new System.Drawing.Point(500, 110);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(58, 19);
            this.lblTanggal.TabIndex = 7;
            this.lblTanggal.Text = "Tanggal";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJumlah.Location = new System.Drawing.Point(25, 285);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(420, 25);
            this.txtJumlah.TabIndex = 6;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblJumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblJumlah.Location = new System.Drawing.Point(25, 260);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(53, 19);
            this.lblJumlah.TabIndex = 5;
            this.lblJumlah.Text = "Jumlah";
            // 
            // cbTipeTransaksi
            // 
            this.cbTipeTransaksi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipeTransaksi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTipeTransaksi.FormattingEnabled = true;
            this.cbTipeTransaksi.Location = new System.Drawing.Point(25, 210);
            this.cbTipeTransaksi.Name = "cbTipeTransaksi";
            this.cbTipeTransaksi.Size = new System.Drawing.Size(420, 25);
            this.cbTipeTransaksi.TabIndex = 4;
            // 
            // lblTipeTransaksi
            // 
            this.lblTipeTransaksi.AutoSize = true;
            this.lblTipeTransaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipeTransaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTipeTransaksi.Location = new System.Drawing.Point(25, 185);
            this.lblTipeTransaksi.Name = "lblTipeTransaksi";
            this.lblTipeTransaksi.Size = new System.Drawing.Size(95, 19);
            this.lblTipeTransaksi.TabIndex = 3;
            this.lblTipeTransaksi.Text = "Tipe Transaksi";
            // 
            // cbWallet
            // 
            this.cbWallet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWallet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbWallet.FormattingEnabled = true;
            this.cbWallet.Location = new System.Drawing.Point(25, 135);
            this.cbWallet.Name = "cbWallet";
            this.cbWallet.Size = new System.Drawing.Size(420, 25);
            this.cbWallet.TabIndex = 2;
            // 
            // lblPilihWallet
            // 
            this.lblPilihWallet.AutoSize = true;
            this.lblPilihWallet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPilihWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblPilihWallet.Location = new System.Drawing.Point(25, 110);
            this.lblPilihWallet.Name = "lblPilihWallet";
            this.lblPilihWallet.Size = new System.Drawing.Size(78, 19);
            this.lblPilihWallet.TabIndex = 1;
            this.lblPilihWallet.Text = "Pilih Wallet";
            // 
            // pnlTransHeader
            // 
            this.pnlTransHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.pnlTransHeader.Controls.Add(this.lblTransSubtitle);
            this.pnlTransHeader.Controls.Add(this.lblTransTitle);
            this.pnlTransHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTransHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTransHeader.Name = "pnlTransHeader";
            this.pnlTransHeader.Size = new System.Drawing.Size(943, 90);
            this.pnlTransHeader.TabIndex = 0;
            // 
            // lblTransSubtitle
            // 
            this.lblTransSubtitle.AutoSize = true;
            this.lblTransSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblTransSubtitle.Location = new System.Drawing.Point(25, 50);
            this.lblTransSubtitle.Name = "lblTransSubtitle";
            this.lblTransSubtitle.Size = new System.Drawing.Size(229, 17);
            this.lblTransSubtitle.TabIndex = 1;
            this.lblTransSubtitle.Text = "Catat pemasukan atau pengeluaran Anda";
            // 
            // lblTransTitle
            // 
            this.lblTransTitle.AutoSize = true;
            this.lblTransTitle.Font = new System.Drawing.Font("Segoe UI Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransTitle.ForeColor = System.Drawing.Color.White;
            this.lblTransTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTransTitle.Name = "lblTransTitle";
            this.lblTransTitle.Size = new System.Drawing.Size(175, 21);
            this.lblTransTitle.TabIndex = 0;
            this.lblTransTitle.Text = "Tambah Transaksi Baru";
            // 
            // pnlChartCard
            // 
            this.pnlChartCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.pnlChartCard.Controls.Add(this.pnlChart);
            this.pnlChartCard.Controls.Add(this.lblChartHint);
            this.pnlChartCard.Controls.Add(this.lblChartTitle);
            this.pnlChartCard.Location = new System.Drawing.Point(0, 0);
            this.pnlChartCard.Name = "pnlChartCard";
            this.pnlChartCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlChartCard.Size = new System.Drawing.Size(945, 550);
            this.pnlChartCard.TabIndex = 1;
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.Location = new System.Drawing.Point(20, 55);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(905, 435);
            this.pnlChart.TabIndex = 2;
            this.pnlChart.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChart_Paint);
            // 
            // lblChartHint
            // 
            this.lblChartHint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblChartHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChartHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblChartHint.Location = new System.Drawing.Point(20, 490);
            this.lblChartHint.Name = "lblChartHint";
            this.lblChartHint.Size = new System.Drawing.Size(905, 40);
            this.lblChartHint.TabIndex = 3;
            this.lblChartHint.Text = "Geser untuk melihat detail chart";
            this.lblChartHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.White;
            this.lblChartTitle.Location = new System.Drawing.Point(20, 20);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.lblChartTitle.Size = new System.Drawing.Size(232, 36);
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.Text = "Ringkasan pemasukan tahun ini";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(30, 30);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(945, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitle.Location = new System.Drawing.Point(5, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(287, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Ringkasan keuntungan dan dompet digital Anda";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Bold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dashboard Keuangan";
            // 
            // WalletListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WalletListForm";
            this.Text = "List Wallet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlTransactionCard.ResumeLayout(false);
            this.pnlTransactionCard.PerformLayout();
            this.pnlTransHeader.ResumeLayout(false);
            this.pnlTransHeader.PerformLayout();
            this.pnlChartCard.ResumeLayout(false);
            this.pnlChartCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private SidebarControl sidebarControl1;
        private NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlChartCard;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label lblChartHint;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTransactionCard;
        private System.Windows.Forms.Panel pnlTransHeader;
        private System.Windows.Forms.Label lblTransTitle;
        private System.Windows.Forms.Label lblTransSubtitle;
        private System.Windows.Forms.Label lblPilihWallet;
        private System.Windows.Forms.ComboBox cbWallet;
        private System.Windows.Forms.Label lblTipeTransaksi;
        private System.Windows.Forms.ComboBox cbTipeTransaksi;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSimpanTransaksi;
        private System.Windows.Forms.Label lblWajibHint;
    }
}
