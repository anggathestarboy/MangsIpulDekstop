namespace MangsIpulAsli
{
    partial class CreateProductForm
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.lblStockReq = new System.Windows.Forms.Label();
            this.lblPriceReq = new System.Windows.Forms.Label();
            this.lblCategoryReq = new System.Windows.Forms.Label();
            this.lblNameReq = new System.Windows.Forms.Label();
            this.lblDescReq = new System.Windows.Forms.Label();
            this.lblImageInfo = new System.Windows.Forms.Label();
            this.pnlImagePlaceholder = new System.Windows.Forms.Panel();
            this.lblImageClickInfo = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblImageTitle = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormHeaderTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.navbarControl1 = new MangsIpulAsli.NavbarControl();
            this.sidebarControl1 = new MangsIpulAsli.SidebarControl();
            this.pnlContent.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            this.pnlImagePlaceholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            this.pnlFormHeader.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlContent.Controls.Add(this.pnlFormCard);
            this.pnlContent.Controls.Add(this.btnBack);
            this.pnlContent.Controls.Add(this.pnlHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(260, 60);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlContent.Size = new System.Drawing.Size(1660, 1021);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlFormCard
            // 
            this.pnlFormCard.BackColor = System.Drawing.Color.White;
            this.pnlFormCard.Controls.Add(this.btnSave);
            this.pnlFormCard.Controls.Add(this.btnBatal);
            this.pnlFormCard.Controls.Add(this.lblStockReq);
            this.pnlFormCard.Controls.Add(this.lblPriceReq);
            this.pnlFormCard.Controls.Add(this.lblCategoryReq);
            this.pnlFormCard.Controls.Add(this.lblNameReq);
            this.pnlFormCard.Controls.Add(this.lblDescReq);
            this.pnlFormCard.Controls.Add(this.lblImageInfo);
            this.pnlFormCard.Controls.Add(this.pnlImagePlaceholder);
            this.pnlFormCard.Controls.Add(this.lblImageTitle);
            this.pnlFormCard.Controls.Add(this.txtDescription);
            this.pnlFormCard.Controls.Add(this.lblDescription);
            this.pnlFormCard.Controls.Add(this.txtStock);
            this.pnlFormCard.Controls.Add(this.lblStock);
            this.pnlFormCard.Controls.Add(this.txtPrice);
            this.pnlFormCard.Controls.Add(this.lblPrice);
            this.pnlFormCard.Controls.Add(this.cmbCategory);
            this.pnlFormCard.Controls.Add(this.lblCategory);
            this.pnlFormCard.Controls.Add(this.txtName);
            this.pnlFormCard.Controls.Add(this.lblName);
            this.pnlFormCard.Controls.Add(this.pnlFormHeader);
            this.pnlFormCard.Location = new System.Drawing.Point(27, 160);
            this.pnlFormCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.Size = new System.Drawing.Size(933, 837);
            this.pnlFormCard.TabIndex = 2;
            this.pnlFormCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFormCard_Paint);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(720, 763);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(187, 49);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "💾 Simpan Produk";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.White;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnBatal.Location = new System.Drawing.Point(573, 763);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(133, 49);
            this.btnBatal.TabIndex = 19;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // lblStockReq
            // 
            this.lblStockReq.AutoSize = true;
            this.lblStockReq.ForeColor = System.Drawing.Color.Red;
            this.lblStockReq.Location = new System.Drawing.Point(73, 622);
            this.lblStockReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockReq.Name = "lblStockReq";
            this.lblStockReq.Size = new System.Drawing.Size(12, 16);
            this.lblStockReq.TabIndex = 18;
            this.lblStockReq.Text = "*";
            // 
            // lblPriceReq
            // 
            this.lblPriceReq.AutoSize = true;
            this.lblPriceReq.ForeColor = System.Drawing.Color.Red;
            this.lblPriceReq.Location = new System.Drawing.Point(77, 511);
            this.lblPriceReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceReq.Name = "lblPriceReq";
            this.lblPriceReq.Size = new System.Drawing.Size(12, 16);
            this.lblPriceReq.TabIndex = 17;
            this.lblPriceReq.Text = "*";
            // 
            // lblCategoryReq
            // 
            this.lblCategoryReq.AutoSize = true;
            this.lblCategoryReq.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryReq.Location = new System.Drawing.Point(93, 400);
            this.lblCategoryReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryReq.Name = "lblCategoryReq";
            this.lblCategoryReq.Size = new System.Drawing.Size(12, 16);
            this.lblCategoryReq.TabIndex = 16;
            this.lblCategoryReq.Text = "*";
            // 
            // lblNameReq
            // 
            this.lblNameReq.AutoSize = true;
            this.lblNameReq.ForeColor = System.Drawing.Color.Red;
            this.lblNameReq.Location = new System.Drawing.Point(120, 289);
            this.lblNameReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameReq.Name = "lblNameReq";
            this.lblNameReq.Size = new System.Drawing.Size(12, 16);
            this.lblNameReq.TabIndex = 15;
            this.lblNameReq.Text = "*";
            // 
            // lblDescReq
            // 
            this.lblDescReq.AutoSize = true;
            this.lblDescReq.ForeColor = System.Drawing.Color.Red;
            this.lblDescReq.Location = new System.Drawing.Point(597, 289);
            this.lblDescReq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescReq.Name = "lblDescReq";
            this.lblDescReq.Size = new System.Drawing.Size(12, 16);
            this.lblDescReq.TabIndex = 14;
            this.lblDescReq.Text = "*";
            // 
            // lblImageInfo
            // 
            this.lblImageInfo.AutoSize = true;
            this.lblImageInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblImageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblImageInfo.Location = new System.Drawing.Point(513, 714);
            this.lblImageInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageInfo.Name = "lblImageInfo";
            this.lblImageInfo.Size = new System.Drawing.Size(128, 19);
            this.lblImageInfo.TabIndex = 13;
            this.lblImageInfo.Text = "*Wajib pilih gambar";
            // 
            // pnlImagePlaceholder
            // 
            this.pnlImagePlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImagePlaceholder.Controls.Add(this.lblImageClickInfo);
            this.pnlImagePlaceholder.Controls.Add(this.pbProductImage);
            this.pnlImagePlaceholder.Location = new System.Drawing.Point(513, 425);
            this.pnlImagePlaceholder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlImagePlaceholder.Name = "pnlImagePlaceholder";
            this.pnlImagePlaceholder.Size = new System.Drawing.Size(399, 283);
            this.pnlImagePlaceholder.TabIndex = 12;
            // 
            // lblImageClickInfo
            // 
            this.lblImageClickInfo.AutoSize = true;
            this.lblImageClickInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblImageClickInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblImageClickInfo.Location = new System.Drawing.Point(133, 252);
            this.lblImageClickInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageClickInfo.Name = "lblImageClickInfo";
            this.lblImageClickInfo.Size = new System.Drawing.Size(150, 19);
            this.lblImageClickInfo.TabIndex = 1;
            this.lblImageClickInfo.Text = "Klik untuk pilih gambar";
            // 
            // pbProductImage
            // 
            this.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductImage.Location = new System.Drawing.Point(67, 25);
            this.pbProductImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(267, 222);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Click += new System.EventHandler(this.pbProductImage_Click);
            // 
            // lblImageTitle
            // 
            this.lblImageTitle.AutoSize = true;
            this.lblImageTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblImageTitle.Location = new System.Drawing.Point(513, 400);
            this.lblImageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageTitle.Name = "lblImageTitle";
            this.lblImageTitle.Size = new System.Drawing.Size(109, 20);
            this.lblImageTitle.TabIndex = 11;
            this.lblImageTitle.Text = "Gambar Menu";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(513, 314);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(399, 73);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(513, 289);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 20);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Deskripsi ";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStock.Location = new System.Drawing.Point(27, 646);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(452, 30);
            this.txtStock.TabIndex = 8;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(27, 622);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(44, 20);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stok ";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(27, 535);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(452, 30);
            this.txtPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(27, 511);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 20);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Harga ";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(27, 425);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(452, 31);
            this.cmbCategory.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(27, 400);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 20);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(27, 314);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(452, 30);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(27, 289);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nama Menu ";
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.pnlFormHeader.Controls.Add(this.lblFormHeaderTitle);
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(933, 62);
            this.pnlFormHeader.TabIndex = 0;
            // 
            // lblFormHeaderTitle
            // 
            this.lblFormHeaderTitle.AutoSize = true;
            this.lblFormHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormHeaderTitle.Location = new System.Drawing.Point(27, 18);
            this.lblFormHeaderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormHeaderTitle.Name = "lblFormHeaderTitle";
            this.lblFormHeaderTitle.Size = new System.Drawing.Size(200, 28);
            this.lblFormHeaderTitle.TabIndex = 0;
            this.lblFormHeaderTitle.Text = "Form Tambah Menu";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.btnBack.Location = new System.Drawing.Point(27, 123);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Kembali";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(27, 25);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1606, 98);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(0, 55);
            this.lblHeaderSub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(341, 25);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Tambah informasi menu makanan baru";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(-11, 0);
            this.lblHeaderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(292, 54);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Tambah Menu";
            // 
            // navbarControl1
            // 
            this.navbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarControl1.Location = new System.Drawing.Point(260, 0);
            this.navbarControl1.Margin = new System.Windows.Forms.Padding(0);
            this.navbarControl1.Name = "navbarControl1";
            this.navbarControl1.Size = new System.Drawing.Size(1660, 60);
            this.navbarControl1.TabIndex = 1;
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Margin = new System.Windows.Forms.Padding(0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(260, 1081);
            this.sidebarControl1.TabIndex = 0;
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1081);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateProductForm";
            this.Text = "Tambah Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlFormCard.ResumeLayout(false);
            this.pnlFormCard.PerformLayout();
            this.pnlImagePlaceholder.ResumeLayout(false);
            this.pnlImagePlaceholder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
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
        private System.Windows.Forms.Label btnBack;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormHeaderTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblImageTitle;
        private System.Windows.Forms.Panel pnlImagePlaceholder;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lblImageClickInfo;
        private System.Windows.Forms.Label lblImageInfo;
        private System.Windows.Forms.Label lblDescReq;
        private System.Windows.Forms.Label lblNameReq;
        private System.Windows.Forms.Label lblCategoryReq;
        private System.Windows.Forms.Label lblPriceReq;
        private System.Windows.Forms.Label lblStockReq;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSave;
    }
}
