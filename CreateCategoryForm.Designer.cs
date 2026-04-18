namespace MangsIpulAsli
{
    partial class CreateCategoryForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblFooterHint = new System.Windows.Forms.Label();
            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.btnSimpanKategori = new System.Windows.Forms.Button();
            this.lblHelperText = new System.Windows.Forms.Label();
            this.pnlInputContainer = new System.Windows.Forms.Panel();
            this.lblTagIcon = new System.Windows.Forms.Label();
            this.txtNamaKategori = new System.Windows.Forms.TextBox();
            this.lblNamaKategoriTitle = new System.Windows.Forms.Label();
            this.pnlCardHeader = new System.Windows.Forms.Panel();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.navbarControl1 = new MangsIpulAsli.NavbarControl();
            this.sidebarControl1 = new MangsIpulAsli.SidebarControl();
            this.pnlContent.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            this.pnlInputContainer.SuspendLayout();
            this.pnlCardHeader.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlContent.Controls.Add(this.lblFooterHint);
            this.pnlContent.Controls.Add(this.pnlFormCard);
            this.pnlContent.Controls.Add(this.pnlHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(195, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.pnlContent.Size = new System.Drawing.Size(1245, 829);
            this.pnlContent.TabIndex = 2;
            // 
            // lblFooterHint
            // 
            this.lblFooterHint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFooterHint.AutoSize = true;
            this.lblFooterHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooterHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblFooterHint.Location = new System.Drawing.Point(415, 590);
            this.lblFooterHint.Name = "lblFooterHint";
            this.lblFooterHint.Size = new System.Drawing.Size(515, 15);
            this.lblFooterHint.TabIndex = 2;
            this.lblFooterHint.Text = "Setelah menambahkan kategori, Anda dapat menggunakannya untuk mengelompokkan prod" +
    "uk";
            this.lblFooterHint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlFormCard
            // 
            this.pnlFormCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFormCard.BackColor = System.Drawing.Color.White;
            this.pnlFormCard.Controls.Add(this.btnSimpanKategori);
            this.pnlFormCard.Controls.Add(this.lblHelperText);
            this.pnlFormCard.Controls.Add(this.pnlInputContainer);
            this.pnlFormCard.Controls.Add(this.lblNamaKategoriTitle);
            this.pnlFormCard.Controls.Add(this.pnlCardHeader);
            this.pnlFormCard.Location = new System.Drawing.Point(322, 193);
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.Size = new System.Drawing.Size(600, 380);
            this.pnlFormCard.TabIndex = 1;
            // 
            // btnSimpanKategori
            // 
            this.btnSimpanKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.btnSimpanKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpanKategori.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpanKategori.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSimpanKategori.Location = new System.Drawing.Point(395, 250);
            this.btnSimpanKategori.Name = "btnSimpanKategori";
            this.btnSimpanKategori.Size = new System.Drawing.Size(180, 45);
            this.btnSimpanKategori.TabIndex = 4;
            this.btnSimpanKategori.Text = "💾 Simpan Kategori";
            this.btnSimpanKategori.UseVisualStyleBackColor = false;
            this.btnSimpanKategori.Click += new System.EventHandler(this.btnSimpanKategori_Click);
            // 
            // lblHelperText
            // 
            this.lblHelperText.AutoSize = true;
            this.lblHelperText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelperText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblHelperText.Location = new System.Drawing.Point(22, 190);
            this.lblHelperText.Name = "lblHelperText";
            this.lblHelperText.Size = new System.Drawing.Size(241, 13);
            this.lblHelperText.TabIndex = 3;
            this.lblHelperText.Text = "Gunakan nama yang mudah diingat dan unik";
            // 
            // pnlInputContainer
            // 
            this.pnlInputContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInputContainer.Controls.Add(this.lblTagIcon);
            this.pnlInputContainer.Controls.Add(this.txtNamaKategori);
            this.pnlInputContainer.Location = new System.Drawing.Point(25, 135);
            this.pnlInputContainer.Name = "pnlInputContainer";
            this.pnlInputContainer.Size = new System.Drawing.Size(550, 50);
            this.pnlInputContainer.TabIndex = 2;
            // 
            // lblTagIcon
            // 
            this.lblTagIcon.AutoSize = true;
            this.lblTagIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTagIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblTagIcon.Location = new System.Drawing.Point(10, 14);
            this.lblTagIcon.Name = "lblTagIcon";
            this.lblTagIcon.Size = new System.Drawing.Size(32, 21);
            this.lblTagIcon.TabIndex = 1;
            this.lblTagIcon.Text = "🏷️";
            // 
            // txtNamaKategori
            // 
            this.txtNamaKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamaKategori.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNamaKategori.ForeColor = System.Drawing.Color.Gray;
            this.txtNamaKategori.Location = new System.Drawing.Point(42, 14);
            this.txtNamaKategori.Name = "txtNamaKategori";
            this.txtNamaKategori.Size = new System.Drawing.Size(490, 20);
            this.txtNamaKategori.TabIndex = 0;
            this.txtNamaKategori.Text = "Contoh: Makanan Ringan, Minuman, dll";
            this.txtNamaKategori.Enter += new System.EventHandler(this.txtNamaKategori_Enter);
            this.txtNamaKategori.Leave += new System.EventHandler(this.txtNamaKategori_Leave);
            // 
            // lblNamaKategoriTitle
            // 
            this.lblNamaKategoriTitle.AutoSize = true;
            this.lblNamaKategoriTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNamaKategoriTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNamaKategoriTitle.Location = new System.Drawing.Point(22, 105);
            this.lblNamaKategoriTitle.Name = "lblNamaKategoriTitle";
            this.lblNamaKategoriTitle.Size = new System.Drawing.Size(103, 19);
            this.lblNamaKategoriTitle.TabIndex = 1;
            this.lblNamaKategoriTitle.Text = "Nama Kategori";
            this.lblNamaKategoriTitle.Click += new System.EventHandler(this.lblNamaKategoriTitle_Click);
            // 
            // pnlCardHeader
            // 
            this.pnlCardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.pnlCardHeader.Controls.Add(this.lblCardTitle);
            this.pnlCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlCardHeader.Name = "pnlCardHeader";
            this.pnlCardHeader.Size = new System.Drawing.Size(600, 75);
            this.pnlCardHeader.TabIndex = 0;
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTitle.Location = new System.Drawing.Point(15, 25);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(241, 25);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "🏷️ Form Tambah Kategori";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(40, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1165, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnBack.Location = new System.Drawing.Point(0, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(50, 45);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(347, 20);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Buat kategori baru untuk mengelompokkan produk";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(42, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(276, 45);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Tambah Kategori";
            // 
            // navbarControl1
            // 
            this.navbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarControl1.Location = new System.Drawing.Point(195, 0);
            this.navbarControl1.Name = "navbarControl1";
            this.navbarControl1.Size = new System.Drawing.Size(1245, 49);
            this.navbarControl1.TabIndex = 1;
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(195, 878);
            this.sidebarControl1.TabIndex = 0;
            // 
            // CreateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateCategoryForm";
            this.Text = "Tambah Kategori";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlFormCard.ResumeLayout(false);
            this.pnlFormCard.PerformLayout();
            this.pnlInputContainer.ResumeLayout(false);
            this.pnlInputContainer.PerformLayout();
            this.pnlCardHeader.ResumeLayout(false);
            this.pnlCardHeader.PerformLayout();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Panel pnlCardHeader;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblNamaKategoriTitle;
        private System.Windows.Forms.Panel pnlInputContainer;
        private System.Windows.Forms.TextBox txtNamaKategori;
        private System.Windows.Forms.Label lblTagIcon;
        private System.Windows.Forms.Label lblHelperText;
        private System.Windows.Forms.Button btnSimpanKategori;
        private System.Windows.Forms.Label lblFooterHint;
    }
}
