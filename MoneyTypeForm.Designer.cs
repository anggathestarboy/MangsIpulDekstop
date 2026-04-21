namespace MangsIpulAsli
{
    partial class MoneyTypeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebarControl1 = new MangsIpulAsli.SidebarControl();
            this.navbarControl1 = new MangsIpulAsli.NavbarControl();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlListCard = new System.Windows.Forms.Panel();
            this.dgvMoneyTypes = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colHapus = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlListHeader = new System.Windows.Forms.Panel();
            this.lblTotalTipe = new System.Windows.Forms.Label();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlAddCard = new System.Windows.Forms.Panel();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.txtNamaTipe = new System.Windows.Forms.TextBox();
            this.lblNamaTipe = new System.Windows.Forms.Label();
            this.pnlAddHeader = new System.Windows.Forms.Panel();
            this.lblTambahSubtitle = new System.Windows.Forms.Label();
            this.lblTambahTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyTypes)).BeginInit();
            this.pnlListHeader.SuspendLayout();
            this.pnlAddCard.SuspendLayout();
            this.pnlAddHeader.SuspendLayout();
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
            this.navbarControl1.Size = new System.Drawing.Size(1105, 60);
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
            this.pnlMain.Size = new System.Drawing.Size(1105, 740);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlListCard);
            this.pnlContent.Controls.Add(this.pnlAddCard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(30, 110);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1045, 1000);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlListCard
            // 
            this.pnlListCard.BackColor = System.Drawing.Color.White;
            this.pnlListCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlListCard.Controls.Add(this.dgvMoneyTypes);
            this.pnlListCard.Controls.Add(this.pnlListHeader);
            this.pnlListCard.Location = new System.Drawing.Point(0, 360);
            this.pnlListCard.Name = "pnlListCard";
            this.pnlListCard.Size = new System.Drawing.Size(1045, 500);
            this.pnlListCard.TabIndex = 1;
            // 
            // dgvMoneyTypes
            // 
            this.dgvMoneyTypes.AllowUserToAddRows = false;
            this.dgvMoneyTypes.AllowUserToDeleteRows = false;
            this.dgvMoneyTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMoneyTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvMoneyTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMoneyTypes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMoneyTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMoneyTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMoneyTypes.ColumnHeadersHeight = 45;
            this.dgvMoneyTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colNama,
            this.colKategori,
            this.colEdit,
            this.colHapus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMoneyTypes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMoneyTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMoneyTypes.EnableHeadersVisualStyles = false;
            this.dgvMoneyTypes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dgvMoneyTypes.Location = new System.Drawing.Point(0, 70);
            this.dgvMoneyTypes.Name = "dgvMoneyTypes";
            this.dgvMoneyTypes.ReadOnly = true;
            this.dgvMoneyTypes.RowHeadersVisible = false;
            this.dgvMoneyTypes.RowTemplate.Height = 50;
            this.dgvMoneyTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMoneyTypes.Size = new System.Drawing.Size(1043, 428);
            this.dgvMoneyTypes.TabIndex = 1;
            this.dgvMoneyTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMoneyTypes_CellContentClick);
            // 
            // colNo
            // 
            this.colNo.FillWeight = 30F;
            this.colNo.HeaderText = "NO";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            // 
            // colNama
            // 
            this.colNama.FillWeight = 150F;
            this.colNama.HeaderText = "NAMA TIPE";
            this.colNama.Name = "colNama";
            this.colNama.ReadOnly = true;
            // 
            // colKategori
            // 
            this.colKategori.HeaderText = "KATEGORI";
            this.colKategori.Name = "colKategori";
            this.colKategori.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "AKSI";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            // 
            // colHapus
            // 
            this.colHapus.HeaderText = "";
            this.colHapus.Name = "colHapus";
            this.colHapus.ReadOnly = true;
            this.colHapus.Text = "Hapus";
            // 
            // pnlListHeader
            // 
            this.pnlListHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.pnlListHeader.Controls.Add(this.lblTotalTipe);
            this.pnlListHeader.Controls.Add(this.lblListTitle);
            this.pnlListHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlListHeader.Name = "pnlListHeader";
            this.pnlListHeader.Size = new System.Drawing.Size(1043, 70);
            this.pnlListHeader.TabIndex = 0;
            // 
            // lblTotalTipe
            // 
            this.lblTotalTipe.AutoSize = true;
            this.lblTotalTipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalTipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblTotalTipe.Location = new System.Drawing.Point(20, 40);
            this.lblTotalTipe.Name = "lblTotalTipe";
            this.lblTotalTipe.Size = new System.Drawing.Size(111, 15);
            this.lblTotalTipe.TabIndex = 1;
            this.lblTotalTipe.Text = "Total 0 tipe terdaftar";
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.White;
            this.lblListTitle.Location = new System.Drawing.Point(20, 15);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(155, 21);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Daftar Tipe Transaksi";
            // 
            // pnlAddCard
            // 
            this.pnlAddCard.BackColor = System.Drawing.Color.White;
            this.pnlAddCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddCard.Controls.Add(this.btnSimpan);
            this.pnlAddCard.Controls.Add(this.cbKategori);
            this.pnlAddCard.Controls.Add(this.lblKategori);
            this.pnlAddCard.Controls.Add(this.txtNamaTipe);
            this.pnlAddCard.Controls.Add(this.lblNamaTipe);
            this.pnlAddCard.Controls.Add(this.pnlAddHeader);
            this.pnlAddCard.Location = new System.Drawing.Point(0, 0);
            this.pnlAddCard.Name = "pnlAddCard";
            this.pnlAddCard.Size = new System.Drawing.Size(1045, 330);
            this.pnlAddCard.TabIndex = 0;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(885, 250);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(130, 40);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Tambah Tipe";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Pengeluaran (Expense)",
            "Pemasukan (Income)"});
            this.cbKategori.Location = new System.Drawing.Point(580, 160);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(435, 28);
            this.cbKategori.TabIndex = 4;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblKategori.Location = new System.Drawing.Point(580, 130);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(61, 19);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori";
            // 
            // txtNamaTipe
            // 
            this.txtNamaTipe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNamaTipe.ForeColor = System.Drawing.Color.Gray;
            this.txtNamaTipe.Location = new System.Drawing.Point(30, 160);
            this.txtNamaTipe.Name = "txtNamaTipe";
            this.txtNamaTipe.Size = new System.Drawing.Size(510, 27);
            this.txtNamaTipe.TabIndex = 2;
            this.txtNamaTipe.Text = "Contoh: Makanan, Gaji, Transportasi";
            this.txtNamaTipe.Enter += new System.EventHandler(this.txtNamaTipe_Enter);
            this.txtNamaTipe.Leave += new System.EventHandler(this.txtNamaTipe_Leave);
            // 
            // lblNamaTipe
            // 
            this.lblNamaTipe.AutoSize = true;
            this.lblNamaTipe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNamaTipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNamaTipe.Location = new System.Drawing.Point(30, 130);
            this.lblNamaTipe.Name = "lblNamaTipe";
            this.lblNamaTipe.Size = new System.Drawing.Size(79, 19);
            this.lblNamaTipe.TabIndex = 1;
            this.lblNamaTipe.Text = "Nama Tipe";
            // 
            // pnlAddHeader
            // 
            this.pnlAddHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.pnlAddHeader.Controls.Add(this.lblTambahSubtitle);
            this.pnlAddHeader.Controls.Add(this.lblTambahTitle);
            this.pnlAddHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlAddHeader.Name = "pnlAddHeader";
            this.pnlAddHeader.Size = new System.Drawing.Size(1043, 100);
            this.pnlAddHeader.TabIndex = 0;
            // 
            // lblTambahSubtitle
            // 
            this.lblTambahSubtitle.AutoSize = true;
            this.lblTambahSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTambahSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(179)))));
            this.lblTambahSubtitle.Location = new System.Drawing.Point(30, 55);
            this.lblTambahSubtitle.Name = "lblTambahSubtitle";
            this.lblTambahSubtitle.Size = new System.Drawing.Size(262, 17);
            this.lblTambahSubtitle.TabIndex = 1;
            this.lblTambahSubtitle.Text = "Buat kategori baru untuk pemasukan atau pengeluaran";
            // 
            // lblTambahTitle
            // 
            this.lblTambahTitle.AutoSize = true;
            this.lblTambahTitle.Font = new System.Drawing.Font("Segoe UI Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTambahTitle.ForeColor = System.Drawing.Color.White;
            this.lblTambahTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTambahTitle.Name = "lblTambahTitle";
            this.lblTambahTitle.Size = new System.Drawing.Size(221, 21);
            this.lblTambahTitle.TabIndex = 0;
            this.lblTambahTitle.Text = "Tambah Tipe Transaksi Baru";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(30, 30);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1045, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(0, 45);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(248, 19);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Kelola kategori pemasukan dan pengeluaran";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Bold", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(-5, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(233, 45);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Tipe Transaksi";
            // 
            // MoneyTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoneyTypeForm";
            this.Text = "Tipe Transaksi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoneyTypes)).EndInit();
            this.pnlListHeader.ResumeLayout(false);
            this.pnlListHeader.PerformLayout();
            this.pnlAddCard.ResumeLayout(false);
            this.pnlAddCard.PerformLayout();
            this.pnlAddHeader.ResumeLayout(false);
            this.pnlAddHeader.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private SidebarControl sidebarControl1;
        private NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlAddCard;
        private System.Windows.Forms.Panel pnlAddHeader;
        private System.Windows.Forms.Label lblTambahTitle;
        private System.Windows.Forms.Label lblTambahSubtitle;
        private System.Windows.Forms.Label lblNamaTipe;
        private System.Windows.Forms.TextBox txtNamaTipe;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Panel pnlListCard;
        private System.Windows.Forms.Panel pnlListHeader;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblTotalTipe;
        private System.Windows.Forms.DataGridView dgvMoneyTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategori;
        private System.Windows.Forms.DataGridViewLinkColumn colEdit;
        private System.Windows.Forms.DataGridViewLinkColumn colHapus;
    }
}
