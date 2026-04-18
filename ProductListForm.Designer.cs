using System.Windows.Forms;

namespace MangsIpulAsli
{
    partial class ProductListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlTableContainer = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGambar = new System.Windows.Forms.DataGridViewImageColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.lblPaginationInfo = new System.Windows.Forms.Label();
            this.flpPaginationButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnTambahProduk = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.navbarControl1 = new MangsIpulAsli.NavbarControl();
            this.sidebarControl1 = new MangsIpulAsli.SidebarControl();
            this.pnlContent.SuspendLayout();
            this.pnlTableContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnlPagination.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlContent.Controls.Add(this.pnlTableContainer);
            this.pnlContent.Controls.Add(this.pnlControls);
            this.pnlContent.Controls.Add(this.pnlHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(195, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(1245, 829);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlTableContainer
            // 
            this.pnlTableContainer.BackColor = System.Drawing.Color.White;
            this.pnlTableContainer.Controls.Add(this.dgvProducts);
            this.pnlTableContainer.Controls.Add(this.pnlPagination);
            this.pnlTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTableContainer.Location = new System.Drawing.Point(20, 160);
            this.pnlTableContainer.Name = "pnlTableContainer";
            this.pnlTableContainer.Size = new System.Drawing.Size(1205, 649);
            this.pnlTableContainer.TabIndex = 2;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeight = 45;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colMenu,
            this.colKategori,
            this.colHarga,
            this.colStok,
            this.colGambar,
            this.colUpdate,
            this.colDelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 80;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1205, 599);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 50;
            // 
            // colMenu
            // 
            this.colMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMenu.HeaderText = "Menu";
            this.colMenu.Name = "colMenu";
            this.colMenu.ReadOnly = true;
            // 
            // colKategori
            // 
            this.colKategori.HeaderText = "Kategori";
            this.colKategori.Name = "colKategori";
            this.colKategori.ReadOnly = true;
            this.colKategori.Width = 150;
            // 
            // colHarga
            // 
            this.colHarga.HeaderText = "Harga";
            this.colHarga.Name = "colHarga";
            this.colHarga.ReadOnly = true;
            this.colHarga.Width = 120;
            // 
            // colStok
            // 
            this.colStok.HeaderText = "Stok";
            this.colStok.Name = "colStok";
            this.colStok.ReadOnly = true;
            this.colStok.Width = 100;
            // 
            // colGambar
            // 
            this.colGambar.HeaderText = "Gambar";
            this.colGambar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colGambar.Name = "colGambar";
            this.colGambar.ReadOnly = true;
            this.colGambar.Width = 100;
            // 
            // colUpdate
            // 
            this.colUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colUpdate.HeaderText = "Edit";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            this.colUpdate.Text = "Edit";
            this.colUpdate.UseColumnTextForButtonValue = true;
            this.colUpdate.Width = 100;
            this.colUpdate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.colUpdate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.colUpdate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 58, 138);
            this.colUpdate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.colUpdate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // colDelete
            // 
            this.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDelete.HeaderText = "Hapus";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Text = "Hapus";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 100;
            this.colDelete.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.colDelete.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.colDelete.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.colDelete.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.colDelete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            // pnlPagination
            // 
            this.pnlPagination.Controls.Add(this.lblPaginationInfo);
            this.pnlPagination.Controls.Add(this.flpPaginationButtons);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPagination.Location = new System.Drawing.Point(0, 599);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(1205, 50);
            this.pnlPagination.TabIndex = 1;
            // 
            // lblPaginationInfo
            // 
            this.lblPaginationInfo.AutoSize = true;
            this.lblPaginationInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaginationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblPaginationInfo.Location = new System.Drawing.Point(15, 18);
            this.lblPaginationInfo.Name = "lblPaginationInfo";
            this.lblPaginationInfo.Size = new System.Drawing.Size(135, 15);
            this.lblPaginationInfo.TabIndex = 1;
            this.lblPaginationInfo.Text = "Menampilkan 1-6 dari 10";
            // 
            // flpPaginationButtons
            // 
            this.flpPaginationButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPaginationButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPaginationButtons.Location = new System.Drawing.Point(892, 7);
            this.flpPaginationButtons.Name = "flpPaginationButtons";
            this.flpPaginationButtons.Size = new System.Drawing.Size(300, 35);
            this.flpPaginationButtons.TabIndex = 0;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnTambahProduk);
            this.pnlControls.Controls.Add(this.cmbKategori);
            this.pnlControls.Controls.Add(this.txtSearch);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(20, 100);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1205, 60);
            this.pnlControls.TabIndex = 1;
            // 
            // btnTambahProduk
            // 
            this.btnTambahProduk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambahProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.btnTambahProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahProduk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTambahProduk.ForeColor = System.Drawing.Color.White;
            this.btnTambahProduk.Location = new System.Drawing.Point(1055, 10);
            this.btnTambahProduk.Name = "btnTambahProduk";
            this.btnTambahProduk.Size = new System.Drawing.Size(150, 40);
            this.btnTambahProduk.TabIndex = 2;
            this.btnTambahProduk.Text = "+ Tambah Produk";
            this.btnTambahProduk.UseVisualStyleBackColor = false;
            this.btnTambahProduk.Click += new System.EventHandler(this.btnTambahProduk_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(260, 15);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(180, 29);
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(0, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Cari menu...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1205, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(0, 45);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(286, 20);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Kelola semua menu makanan di restoran Anda";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(-8, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(351, 45);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Daftar Menu Makanan";
            // 
            // navbarControl1
            // 
            this.navbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarControl1.Location = new System.Drawing.Point(195, 0);
            this.navbarControl1.Margin = new System.Windows.Forms.Padding(0);
            this.navbarControl1.Name = "navbarControl1";
            this.navbarControl1.Size = new System.Drawing.Size(1245, 49);
            this.navbarControl1.TabIndex = 1;
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Margin = new System.Windows.Forms.Padding(0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(195, 878);
            this.sidebarControl1.TabIndex = 0;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductListForm";
            this.Text = "Daftar Menu Makanan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContent.ResumeLayout(false);
            this.pnlTableContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnlPagination.ResumeLayout(false);
            this.pnlPagination.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SidebarControl sidebarControl1;
        private NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Button btnTambahProduk;
        private System.Windows.Forms.Panel pnlTableContainer;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.Label lblPaginationInfo;
        private System.Windows.Forms.FlowLayoutPanel flpPaginationButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStok;
        private System.Windows.Forms.DataGridViewImageColumn colGambar;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}
