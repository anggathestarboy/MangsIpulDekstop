namespace MangsIpulAsli
{
    partial class Form1
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
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLeftContent = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAdminBadge = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLoginContainer = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPasswordTag = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblIconPass = new System.Windows.Forms.Label();
            this.lblUsernameTag = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblIconUser = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlWindowControls = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftContent.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlLoginContainer.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlWindowControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 2;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.pnlMain.Controls.Add(this.pnlLeft, 0, 0);
            this.pnlMain.Controls.Add(this.pnlRight, 1, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 1;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Size = new System.Drawing.Size(1440, 878);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.pnlLeft.Controls.Add(this.pnlLeftContent);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(648, 878);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlLeftContent
            // 
            this.pnlLeftContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLeftContent.Controls.Add(this.lblDesc);
            this.pnlLeftContent.Controls.Add(this.lblTitle);
            this.pnlLeftContent.Controls.Add(this.lblAdminBadge);
            this.pnlLeftContent.Location = new System.Drawing.Point(60, 185);
            this.pnlLeftContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeftContent.Name = "pnlLeftContent";
            this.pnlLeftContent.Size = new System.Drawing.Size(569, 457);
            this.pnlLeftContent.TabIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.lblDesc.Location = new System.Drawing.Point(-5, 280);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(488, 98);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Akses penuh untuk mengelola produk, memantau pesanan, dan mengatur konten website" +
    " dengan sistem yang aman dan terpercaya.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(-15, 108);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(581, 172);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Admin Dashboard\r\nKelola Snack";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblAdminBadge
            // 
            this.lblAdminBadge.AutoSize = true;
            this.lblAdminBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblAdminBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblAdminBadge.ForeColor = System.Drawing.Color.White;
            this.lblAdminBadge.Location = new System.Drawing.Point(2, 79);
            this.lblAdminBadge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminBadge.Name = "lblAdminBadge";
            this.lblAdminBadge.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.lblAdminBadge.Size = new System.Drawing.Size(138, 29);
            this.lblAdminBadge.TabIndex = 0;
            this.lblAdminBadge.Text = "🛡️ Admin Panel";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.pnlLoginContainer);
            this.pnlRight.Controls.Add(this.pnlWindowControls);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(648, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(792, 878);
            this.pnlRight.TabIndex = 1;
            // 
            // pnlLoginContainer
            // 
            this.pnlLoginContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLoginContainer.Controls.Add(this.btnLogin);
            this.pnlLoginContainer.Controls.Add(this.lblPasswordTag);
            this.pnlLoginContainer.Controls.Add(this.pnlPassword);
            this.pnlLoginContainer.Controls.Add(this.lblUsernameTag);
            this.pnlLoginContainer.Controls.Add(this.pnlUsername);
            this.pnlLoginContainer.Controls.Add(this.lblSubHeader);
            this.pnlLoginContainer.Controls.Add(this.lblHeader);
            this.pnlLoginContainer.Controls.Add(this.pbLogo);
            this.pnlLoginContainer.Location = new System.Drawing.Point(208, 154);
            this.pnlLoginContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLoginContainer.Name = "pnlLoginContainer";
            this.pnlLoginContainer.Size = new System.Drawing.Size(375, 569);
            this.pnlLoginContainer.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(38, 488);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 41);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login ➜";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblPasswordTag
            // 
            this.lblPasswordTag.AutoSize = true;
            this.lblPasswordTag.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPasswordTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblPasswordTag.Location = new System.Drawing.Point(38, 390);
            this.lblPasswordTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordTag.Name = "lblPasswordTag";
            this.lblPasswordTag.Size = new System.Drawing.Size(89, 19);
            this.lblPasswordTag.TabIndex = 6;
            this.lblPasswordTag.Text = "🔒 Password";
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Controls.Add(this.lblIconPass);
            this.pnlPassword.Location = new System.Drawing.Point(38, 414);
            this.pnlPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(300, 45);
            this.pnlPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(38, 12);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Masukkan password";
            // 
            // lblIconPass
            // 
            this.lblIconPass.AutoSize = true;
            this.lblIconPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblIconPass.ForeColor = System.Drawing.Color.Gray;
            this.lblIconPass.Location = new System.Drawing.Point(9, 12);
            this.lblIconPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIconPass.Name = "lblIconPass";
            this.lblIconPass.Size = new System.Drawing.Size(32, 21);
            this.lblIconPass.TabIndex = 0;
            this.lblIconPass.Text = "🔑";
            // 
            // lblUsernameTag
            // 
            this.lblUsernameTag.AutoSize = true;
            this.lblUsernameTag.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsernameTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblUsernameTag.Location = new System.Drawing.Point(38, 292);
            this.lblUsernameTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameTag.Name = "lblUsernameTag";
            this.lblUsernameTag.Size = new System.Drawing.Size(92, 19);
            this.lblUsernameTag.TabIndex = 4;
            this.lblUsernameTag.Text = "👤 Username";
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsername.Controls.Add(this.txtUsername);
            this.pnlUsername.Controls.Add(this.lblIconUser);
            this.pnlUsername.Location = new System.Drawing.Point(38, 317);
            this.pnlUsername.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(300, 45);
            this.pnlUsername.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(38, 12);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(248, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Masukkan username";
            // 
            // lblIconUser
            // 
            this.lblIconUser.AutoSize = true;
            this.lblIconUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblIconUser.ForeColor = System.Drawing.Color.Gray;
            this.lblIconUser.Location = new System.Drawing.Point(9, 12);
            this.lblIconUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIconUser.Name = "lblIconUser";
            this.lblIconUser.Size = new System.Drawing.Size(32, 21);
            this.lblIconUser.TabIndex = 0;
            this.lblIconUser.Text = "✉️";
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSubHeader.Location = new System.Drawing.Point(60, 244);
            this.lblSubHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(260, 21);
            this.lblSubHeader.TabIndex = 2;
            this.lblSubHeader.Text = "Masuk untuk mengakses dashboard";
            this.lblSubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.lblHeader.Location = new System.Drawing.Point(68, 193);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(252, 51);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Admin Login";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(131, 41);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(112, 122);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlWindowControls
            // 
            this.pnlWindowControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWindowControls.Controls.Add(this.btnMinimize);
            this.pnlWindowControls.Controls.Add(this.btnClose);
            this.pnlWindowControls.Location = new System.Drawing.Point(717, 0);
            this.pnlWindowControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnlWindowControls.Name = "pnlWindowControls";
            this.pnlWindowControls.Size = new System.Drawing.Size(75, 32);
            this.pnlWindowControls.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Gray;
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 32);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.Gray;
            this.btnClose.Location = new System.Drawing.Point(38, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Mangs Ipul Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftContent.ResumeLayout(false);
            this.pnlLeftContent.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlLoginContainer.ResumeLayout(false);
            this.pnlLoginContainer.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlWindowControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlWindowControls;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlLoginContainer;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Label lblUsernameTag;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblIconUser;
        private System.Windows.Forms.Label lblPasswordTag;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblIconPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlLeftContent;
        private System.Windows.Forms.Label lblAdminBadge;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
    }
}

