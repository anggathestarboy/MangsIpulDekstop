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
            this.flpWallets = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTransferCard = new System.Windows.Forms.Panel();
            this.lblTransferHint = new System.Windows.Forms.Label();
            this.btnKirimTransfer = new System.Windows.Forms.Button();
            this.btnResetTransfer = new System.Windows.Forms.Button();
            this.txtJumlahTransfer = new System.Windows.Forms.TextBox();
            this.lblJumlahTransfer = new System.Windows.Forms.Label();
            this.cbWalletTujuan = new System.Windows.Forms.ComboBox();
            this.lblWalletTujuan = new System.Windows.Forms.Label();
            this.cbWalletAsal = new System.Windows.Forms.ComboBox();
            this.lblWalletAsal = new System.Windows.Forms.Label();
            this.pnlTransferHeader = new System.Windows.Forms.Panel();
            this.lblTransferSubtitle = new System.Windows.Forms.Label();
            this.lblTransferTitle = new System.Windows.Forms.Label();
            this.lblTransferIcon = new System.Windows.Forms.Label();
            this.lblTransferChevron = new System.Windows.Forms.Label();
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
            this.pnlTransferCard.SuspendLayout();
            this.pnlTransferHeader.SuspendLayout();
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
            this.pnlContent.Controls.Add(this.flpWallets);
            this.pnlContent.Controls.Add(this.pnlTransferCard);
            this.pnlContent.Controls.Add(this.pnlTransactionCard);
            this.pnlContent.Controls.Add(this.pnlChartCard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(30, 110);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(928, 2200);
            this.pnlContent.TabIndex = 1;
            // 
            // flpWallets
            // 
            this.flpWallets.AutoScroll = true;
            this.flpWallets.Location = new System.Drawing.Point(0, 1420);
            this.flpWallets.Name = "flpWallets";
            this.flpWallets.Size = new System.Drawing.Size(945, 700);
            this.flpWallets.TabIndex = 4;
            // 
            // pnlTransferCard
            // 
            this.pnlTransferCard.BackColor = System.Drawing.Color.White;
            this.pnlTransferCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTransferCard.Controls.Add(this.lblTransferHint);
            this.pnlTransferCard.Controls.Add(this.btnKirimTransfer);
            this.pnlTransferCard.Controls.Add(this.btnResetTransfer);
            this.pnlTransferCard.Controls.Add(this.txtJumlahTransfer);
            this.pnlTransferCard.Controls.Add(this.lblJumlahTransfer);
            this.pnlTransferCard.Controls.Add(this.cbWalletTujuan);
            this.pnlTransferCard.Controls.Add(this.lblWalletTujuan);
            this.pnlTransferCard.Controls.Add(this.cbWalletAsal);
            this.pnlTransferCard.Controls.Add(this.lblWalletAsal);
            this.pnlTransferCard.Controls.Add(this.pnlTransferHeader);
            this.pnlTransferCard.Location = new System.Drawing.Point(0, 1050);
            this.pnlTransferCard.Name = "pnlTransferCard";
            this.pnlTransferCard.Size = new System.Drawing.Size(945, 350);
            this.pnlTransferCard.TabIndex = 3;
            // 
            // lblTransferHint
            // 
            this.lblTransferHint.AutoSize = true;
            this.lblTransferHint.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTransferHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTransferHint.Location = new System.Drawing.Point(350, 315);
            this.lblTransferHint.Name = "lblTransferHint";
            this.lblTransferHint.Size = new System.Drawing.Size(426, 13);
            this.lblTransferHint.TabIndex = 9;
            this.lblTransferHint.Text = "* Semua field di atas wajib diisi untuk melakukan transfer antar wallet";
            // 
            // btnKirimTransfer
            // 
            this.btnKirimTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnKirimTransfer.FlatAppearance.BorderSize = 0;
            this.btnKirimTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKirimTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnKirimTransfer.ForeColor = System.Drawing.Color.White;
            this.btnKirimTransfer.Location = new System.Drawing.Point(780, 260);
            this.btnKirimTransfer.Name = "btnKirimTransfer";
            this.btnKirimTransfer.Size = new System.Drawing.Size(140, 40);
            this.btnKirimTransfer.TabIndex = 8;
            this.btnKirimTransfer.Text = "Kirim Transfer";
            this.btnKirimTransfer.UseVisualStyleBackColor = false;
            this.btnKirimTransfer.Click += new System.EventHandler(this.btnKirimTransfer_Click);
            // 
            // btnResetTransfer
            // 
            this.btnResetTransfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnResetTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnResetTransfer.Location = new System.Drawing.Point(690, 260);
            this.btnResetTransfer.Name = "btnResetTransfer";
            this.btnResetTransfer.Size = new System.Drawing.Size(80, 40);
            this.btnResetTransfer.TabIndex = 7;
            this.btnResetTransfer.Text = "Reset";
            this.btnResetTransfer.UseVisualStyleBackColor = true;
            this.btnResetTransfer.Click += new System.EventHandler(this.btnResetTransfer_Click);
            // 
            // txtJumlahTransfer
            // 
            this.txtJumlahTransfer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJumlahTransfer.Location = new System.Drawing.Point(500, 135);
            this.txtJumlahTransfer.Name = "txtJumlahTransfer";
            this.txtJumlahTransfer.Size = new System.Drawing.Size(420, 25);
            this.txtJumlahTransfer.TabIndex = 6;
            // 
            // lblJumlahTransfer
            // 
            this.lblJumlahTransfer.AutoSize = true;
            this.lblJumlahTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblJumlahTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblJumlahTransfer.Location = new System.Drawing.Point(500, 110);
            this.lblJumlahTransfer.Name = "lblJumlahTransfer";
            this.lblJumlahTransfer.Size = new System.Drawing.Size(115, 19);
            this.lblJumlahTransfer.TabIndex = 5;
            this.lblJumlahTransfer.Text = "$ Jumlah Transfer";
            // 
            // cbWalletTujuan
            // 
            this.cbWalletTujuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWalletTujuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbWalletTujuan.FormattingEnabled = true;
            this.cbWalletTujuan.Location = new System.Drawing.Point(25, 210);
            this.cbWalletTujuan.Name = "cbWalletTujuan";
            this.cbWalletTujuan.Size = new System.Drawing.Size(420, 25);
            this.cbWalletTujuan.TabIndex = 4;
            // 
            // lblWalletTujuan
            // 
            this.lblWalletTujuan.AutoSize = true;
            this.lblWalletTujuan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWalletTujuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblWalletTujuan.Location = new System.Drawing.Point(25, 185);
            this.lblWalletTujuan.Name = "lblWalletTujuan";
            this.lblWalletTujuan.Size = new System.Drawing.Size(164, 19);
            this.lblWalletTujuan.TabIndex = 3;
            this.lblWalletTujuan.Text = "Wallet Tujuan (Penerima)";
            // 
            // cbWalletAsal
            // 
            this.cbWalletAsal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWalletAsal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbWalletAsal.FormattingEnabled = true;
            this.cbWalletAsal.Location = new System.Drawing.Point(25, 135);
            this.cbWalletAsal.Name = "cbWalletAsal";
            this.cbWalletAsal.Size = new System.Drawing.Size(420, 25);
            this.cbWalletAsal.TabIndex = 2;
            // 
            // lblWalletAsal
            // 
            this.lblWalletAsal.AutoSize = true;
            this.lblWalletAsal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWalletAsal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblWalletAsal.Location = new System.Drawing.Point(25, 110);
            this.lblWalletAsal.Name = "lblWalletAsal";
            this.lblWalletAsal.Size = new System.Drawing.Size(148, 19);
            this.lblWalletAsal.TabIndex = 1;
            this.lblWalletAsal.Text = "Wallet Asal (Pengirim)";
            // 
            // pnlTransferHeader
            // 
            this.pnlTransferHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.pnlTransferHeader.Controls.Add(this.lblTransferChevron);
            this.pnlTransferHeader.Controls.Add(this.lblTransferIcon);
            this.pnlTransferHeader.Controls.Add(this.lblTransferSubtitle);
            this.pnlTransferHeader.Controls.Add(this.lblTransferTitle);
            this.pnlTransferHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTransferHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTransferHeader.Name = "pnlTransferHeader";
            this.pnlTransferHeader.Size = new System.Drawing.Size(943, 90);
            this.pnlTransferHeader.TabIndex = 0;
            // 
            // lblTransferChevron
            // 
            this.lblTransferChevron.AutoSize = true;
            this.lblTransferChevron.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTransferChevron.ForeColor = System.Drawing.Color.White;
            this.lblTransferChevron.Location = new System.Drawing.Point(900, 30);
            this.lblTransferChevron.Name = "lblTransferChevron";
            this.lblTransferChevron.Size = new System.Drawing.Size(25, 25);
            this.lblTransferChevron.TabIndex = 3;
            this.lblTransferChevron.Text = "˄";
            // 
            // lblTransferIcon
            // 
            this.lblTransferIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(180)))), ((int)(((byte)(252)))));
            this.lblTransferIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransferIcon.ForeColor = System.Drawing.Color.White;
            this.lblTransferIcon.Location = new System.Drawing.Point(25, 25);
            this.lblTransferIcon.Name = "lblTransferIcon";
            this.lblTransferIcon.Size = new System.Drawing.Size(40, 40);
            this.lblTransferIcon.TabIndex = 2;
            this.lblTransferIcon.Text = "⇄";
            this.lblTransferIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTransferSubtitle
            // 
            this.lblTransferSubtitle.AutoSize = true;
            this.lblTransferSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.lblTransferSubtitle.Location = new System.Drawing.Point(75, 50);
            this.lblTransferSubtitle.Name = "lblTransferSubtitle";
            this.lblTransferSubtitle.Size = new System.Drawing.Size(262, 17);
            this.lblTransferSubtitle.TabIndex = 1;
            this.lblTransferSubtitle.Text = "Kirim saldo dari satu wallet ke wallet lainnya";
            // 
            // lblTransferTitle
            // 
            this.lblTransferTitle.AutoSize = true;
            this.lblTransferTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransferTitle.ForeColor = System.Drawing.Color.White;
            this.lblTransferTitle.Location = new System.Drawing.Point(75, 20);
            this.lblTransferTitle.Name = "lblTransferTitle";
            this.lblTransferTitle.Size = new System.Drawing.Size(193, 20);
            this.lblTransferTitle.TabIndex = 0;
            this.lblTransferTitle.Text = "Transfer Antar Wallet";
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
            this.lblWajibHint.Size = new System.Drawing.Size(426, 13);
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
            this.lblJumlah.Size = new System.Drawing.Size(54, 19);
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
            this.lblTipeTransaksi.Size = new System.Drawing.Size(97, 19);
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
            this.lblPilihWallet.Size = new System.Drawing.Size(81, 19);
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
            this.lblTransSubtitle.Size = new System.Drawing.Size(248, 17);
            this.lblTransSubtitle.TabIndex = 1;
            this.lblTransSubtitle.Text = "Catat pemasukan atau pengeluaran Anda";
            // 
            // lblTransTitle
            // 
            this.lblTransTitle.AutoSize = true;
            this.lblTransTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTransTitle.ForeColor = System.Drawing.Color.White;
            this.lblTransTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTransTitle.Name = "lblTransTitle";
            this.lblTransTitle.Size = new System.Drawing.Size(198, 20);
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
            this.pnlChart.Location = new System.Drawing.Point(20, 56);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(905, 434);
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
            this.lblChartTitle.Size = new System.Drawing.Size(235, 36);
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
            this.pnlHeader.Size = new System.Drawing.Size(928, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubtitle.Location = new System.Drawing.Point(5, 45);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(305, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Ringkasan keuntungan dan dompet digital Anda";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 37);
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
        private System.Windows.Forms.Panel pnlTransferCard;
        private System.Windows.Forms.Panel pnlTransferHeader;
        private System.Windows.Forms.Label lblTransferTitle;
        private System.Windows.Forms.Label lblTransferSubtitle;
        private System.Windows.Forms.Label lblTransferIcon;
        private System.Windows.Forms.Label lblTransferChevron;
        private System.Windows.Forms.Label lblWalletAsal;
        private System.Windows.Forms.ComboBox cbWalletAsal;
        private System.Windows.Forms.Label lblWalletTujuan;
        private System.Windows.Forms.ComboBox cbWalletTujuan;
        private System.Windows.Forms.Label lblJumlahTransfer;
        private System.Windows.Forms.TextBox txtJumlahTransfer;
        private System.Windows.Forms.Button btnResetTransfer;
        private System.Windows.Forms.Button btnKirimTransfer;
        private System.Windows.Forms.Label lblTransferHint;
        private System.Windows.Forms.FlowLayoutPanel flpWallets;
    }
}
