namespace MangsIpulAsli
{
    partial class EditProductForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
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
            this.pnlContent.Location = new System.Drawing.Point(195, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(1245, 829);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlFormCard
            // 
            this.pnlFormCard.BackColor = System.Drawing.Color.White;
            this.pnlFormCard.Controls.Add(this.btnUpdate);
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
            this.pnlFormCard.Location = new System.Drawing.Point(20, 130);
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.Size = new System.Drawing.Size(700, 680);
            this.pnlFormCard.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(540, 620);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 40);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "💾 Update Produk";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.White;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnBatal.Location = new System.Drawing.Point(430, 620);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(100, 40);
            this.btnBatal.TabIndex = 19;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // lblStockReq
            // 
            this.lblStockReq.AutoSize = true;
            this.lblStockReq.ForeColor = System.Drawing.Color.Red;
            this.lblStockReq.Location = new System.Drawing.Point(55, 505);
            this.lblStockReq.Name = "lblStockReq";
            this.lblStockReq.Size = new System.Drawing.Size(11, 13);
            this.lblStockReq.TabIndex = 18;
            this.lblStockReq.Text = "*";
            // 
            // lblPriceReq
            // 
            this.lblPriceReq.AutoSize = true;
            this.lblPriceReq.ForeColor = System.Drawing.Color.Red;
            this.lblPriceReq.Location = new System.Drawing.Point(58, 415);
            this.lblPriceReq.Name = "lblPriceReq";
            this.lblPriceReq.Size = new System.Drawing.Size(11, 13);
            this.lblPriceReq.TabIndex = 17;
            this.lblPriceReq.Text = "*";
            // 
            // lblCategoryReq
            // 
            this.lblCategoryReq.AutoSize = true;
            this.lblCategoryReq.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryReq.Location = new System.Drawing.Point(70, 325);
            this.lblCategoryReq.Name = "lblCategoryReq";
            this.lblCategoryReq.Size = new System.Drawing.Size(11, 13);
            this.lblCategoryReq.TabIndex = 16;
            this.lblCategoryReq.Text = "*";
            // 
            // lblNameReq
            // 
            this.lblNameReq.AutoSize = true;
            this.lblNameReq.ForeColor = System.Drawing.Color.Red;
            this.lblNameReq.Location = new System.Drawing.Point(90, 235);
            this.lblNameReq.Name = "lblNameReq";
            this.lblNameReq.Size = new System.Drawing.Size(11, 13);
            this.lblNameReq.TabIndex = 15;
            this.lblNameReq.Text = "*";
            // 
            // lblDescReq
            // 
            this.lblDescReq.AutoSize = true;
            this.lblDescReq.ForeColor = System.Drawing.Color.Red;
            this.lblDescReq.Location = new System.Drawing.Point(448, 235);
            this.lblDescReq.Name = "lblDescReq";
            this.lblDescReq.Size = new System.Drawing.Size(11, 13);
            this.lblDescReq.TabIndex = 14;
            this.lblDescReq.Text = "*";
            // 
            // lblImageInfo
            // 
            this.lblImageInfo.AutoSize = true;
            this.lblImageInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblImageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblImageInfo.Location = new System.Drawing.Point(385, 580);
            this.lblImageInfo.Name = "lblImageInfo";
            this.lblImageInfo.Size = new System.Drawing.Size(183, 13);
            this.lblImageInfo.TabIndex = 13;
            this.lblImageInfo.Text = "*Kosongkan jika tidak ingin mengubah gambar";
            // 
            // pnlImagePlaceholder
            // 
            this.pnlImagePlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImagePlaceholder.Controls.Add(this.lblImageClickInfo);
            this.pnlImagePlaceholder.Controls.Add(this.pbProductImage);
            this.pnlImagePlaceholder.Location = new System.Drawing.Point(385, 345);
            this.pnlImagePlaceholder.Name = "pnlImagePlaceholder";
            this.pnlImagePlaceholder.Size = new System.Drawing.Size(300, 230);
            this.pnlImagePlaceholder.TabIndex = 12;
            // 
            // lblImageClickInfo
            // 
            this.lblImageClickInfo.AutoSize = true;
            this.lblImageClickInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblImageClickInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblImageClickInfo.Location = new System.Drawing.Point(100, 205);
            this.lblImageClickInfo.Name = "lblImageClickInfo";
            this.lblImageClickInfo.Size = new System.Drawing.Size(115, 13);
            this.lblImageClickInfo.TabIndex = 1;
            this.lblImageClickInfo.Text = "Klik untuk ganti gambar";
            // 
            // pbProductImage
            // 
            this.pbProductImage.Location = new System.Drawing.Point(50, 20);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(200, 180);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 0;
            this.pbProductImage.TabStop = false;
            this.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbProductImage.Click += new System.EventHandler(this.pbProductImage_Click);
            // 
            // lblImageTitle
            // 
            this.lblImageTitle.AutoSize = true;
            this.lblImageTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblImageTitle.Location = new System.Drawing.Point(385, 325);
            this.lblImageTitle.Name = "lblImageTitle";
            this.lblImageTitle.Size = new System.Drawing.Size(85, 15);
            this.lblImageTitle.TabIndex = 11;
            this.lblImageTitle.Text = "Gambar Menu";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(385, 255);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 60);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(385, 235);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(65, 15);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Deskripsi ";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStock.Location = new System.Drawing.Point(20, 525);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(340, 25);
            this.txtStock.TabIndex = 8;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location = new System.Drawing.Point(20, 505);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 15);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stok ";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(20, 435);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(340, 25);
            this.txtPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(20, 415);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Harga ";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(20, 345);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(340, 25);
            this.cmbCategory.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(20, 325);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(61, 15);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Kategori ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(20, 255);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 25);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(20, 235);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nama Menu ";
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.pnlFormHeader.Controls.Add(this.lblFormHeaderTitle);
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormCard.Controls.Add(this.pnlFormHeader);
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(700, 50);
            this.pnlFormHeader.TabIndex = 0;
            // 
            // lblFormHeaderTitle
            // 
            this.lblFormHeaderTitle.AutoSize = true;
            this.lblFormHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormHeaderTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormHeaderTitle.Name = "lblFormHeaderTitle";
            this.lblFormHeaderTitle.Size = new System.Drawing.Size(135, 21);
            this.lblFormHeaderTitle.TabIndex = 0;
            this.lblFormHeaderTitle.Text = "Form Edit Menu";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.btnBack.Location = new System.Drawing.Point(20, 100);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 19);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Kembali";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.lblHeaderSub.Size = new System.Drawing.Size(277, 20);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Edit informasi menu makanan di restoran Anda";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(-8, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(168, 45);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Edit Menu";
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
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProductForm";
            this.Text = "Edit Menu";
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
        private System.Windows.Forms.Button btnUpdate;
    }
}
