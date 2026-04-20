using System.Drawing;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    partial class ResetPasswordForm
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.pnlConfirmField = new System.Windows.Forms.Panel();
            this.lblShowConfirm = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmLabel = new System.Windows.Forms.Label();
            this.pnlNewField = new System.Windows.Forms.Panel();
            this.lblShowNew = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewLabel = new System.Windows.Forms.Label();
            this.lblLupaPassword = new System.Windows.Forms.Label();
            this.pnlCurrentField = new System.Windows.Forms.Panel();
            this.lblShowCurrent = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentLabel = new System.Windows.Forms.Label();
            this.pnlCardHeader = new System.Windows.Forms.Panel();
            this.lblCardSubtitle = new System.Windows.Forms.Label();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlConfirmField.SuspendLayout();
            this.pnlNewField.SuspendLayout();
            this.pnlCurrentField.SuspendLayout();
            this.pnlCardHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(195, 878);
            this.sidebarControl1.TabIndex = 0;
            // 
            // navbarControl1
            // 
            this.navbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarControl1.Location = new System.Drawing.Point(195, 0);
            this.navbarControl1.Name = "navbarControl1";
            this.navbarControl1.Size = new System.Drawing.Size(1245, 49);
            this.navbarControl1.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlContent.Controls.Add(this.pnlCard);
            this.pnlContent.Controls.Add(this.lblSubtitle);
            this.pnlContent.Controls.Add(this.lblTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(195, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(1245, 829);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.btnResetPassword);
            this.pnlCard.Controls.Add(this.pnlConfirmField);
            this.pnlCard.Controls.Add(this.lblConfirmLabel);
            this.pnlCard.Controls.Add(this.pnlNewField);
            this.pnlCard.Controls.Add(this.lblNewLabel);
            this.pnlCard.Controls.Add(this.lblLupaPassword);
            this.pnlCard.Controls.Add(this.pnlCurrentField);
            this.pnlCard.Controls.Add(this.lblCurrentLabel);
            this.pnlCard.Controls.Add(this.pnlCardHeader);
            this.pnlCard.Location = new System.Drawing.Point(20, 120);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(600, 520);
            this.pnlCard.TabIndex = 2;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(25, 445);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(550, 45);
            this.btnResetPassword.TabIndex = 8;
            this.btnResetPassword.Text = "🔓 Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // pnlConfirmField
            // 
            this.pnlConfirmField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfirmField.Controls.Add(this.lblShowConfirm);
            this.pnlConfirmField.Controls.Add(this.txtConfirmPassword);
            this.pnlConfirmField.Location = new System.Drawing.Point(25, 375);
            this.pnlConfirmField.Name = "pnlConfirmField";
            this.pnlConfirmField.Size = new System.Drawing.Size(550, 40);
            this.pnlConfirmField.TabIndex = 7;
            // 
            // lblShowConfirm
            // 
            this.lblShowConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblShowConfirm.Location = new System.Drawing.Point(515, 0);
            this.lblShowConfirm.Name = "lblShowConfirm";
            this.lblShowConfirm.Size = new System.Drawing.Size(35, 40);
            this.lblShowConfirm.TabIndex = 1;
            this.lblShowConfirm.Text = "👁";
            this.lblShowConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowConfirm.Click += new System.EventHandler(this.btnShowConfirm_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(10, 10);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(495, 20);
            this.txtConfirmPassword.TabIndex = 0;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmLabel
            // 
            this.lblConfirmLabel.AutoSize = true;
            this.lblConfirmLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblConfirmLabel.Location = new System.Drawing.Point(25, 350);
            this.lblConfirmLabel.Name = "lblConfirmLabel";
            this.lblConfirmLabel.Size = new System.Drawing.Size(163, 19);
            this.lblConfirmLabel.TabIndex = 6;
            this.lblConfirmLabel.Text = "Konfirmasi Password Baru";
            // 
            // pnlNewField
            // 
            this.pnlNewField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewField.Controls.Add(this.lblShowNew);
            this.pnlNewField.Controls.Add(this.txtNewPassword);
            this.pnlNewField.Location = new System.Drawing.Point(25, 295);
            this.pnlNewField.Name = "pnlNewField";
            this.pnlNewField.Size = new System.Drawing.Size(550, 40);
            this.pnlNewField.TabIndex = 5;
            // 
            // lblShowNew
            // 
            this.lblShowNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblShowNew.Location = new System.Drawing.Point(515, 0);
            this.lblShowNew.Name = "lblShowNew";
            this.lblShowNew.Size = new System.Drawing.Size(35, 40);
            this.lblShowNew.TabIndex = 1;
            this.lblShowNew.Text = "👁";
            this.lblShowNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowNew.Click += new System.EventHandler(this.btnShowNew_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPassword.Location = new System.Drawing.Point(10, 10);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(495, 20);
            this.txtNewPassword.TabIndex = 0;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewLabel
            // 
            this.lblNewLabel.AutoSize = true;
            this.lblNewLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblNewLabel.Location = new System.Drawing.Point(25, 270);
            this.lblNewLabel.Name = "lblNewLabel";
            this.lblNewLabel.Size = new System.Drawing.Size(100, 19);
            this.lblNewLabel.TabIndex = 4;
            this.lblNewLabel.Text = "Password Baru";
            // 
            // lblLupaPassword
            // 
            this.lblLupaPassword.AutoSize = true;
            this.lblLupaPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLupaPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLupaPassword.ForeColor = System.Drawing.Color.Red;
            this.lblLupaPassword.Location = new System.Drawing.Point(480, 235);
            this.lblLupaPassword.Name = "lblLupaPassword";
            this.lblLupaPassword.Size = new System.Drawing.Size(95, 15);
            this.lblLupaPassword.TabIndex = 3;
            this.lblLupaPassword.Text = "🔒 Lupa Password?";
            this.lblLupaPassword.Click += new System.EventHandler(this.lblLupaPassword_Click);
            // 
            // pnlCurrentField
            // 
            this.pnlCurrentField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCurrentField.Controls.Add(this.lblShowCurrent);
            this.pnlCurrentField.Controls.Add(this.txtCurrentPassword);
            this.pnlCurrentField.Location = new System.Drawing.Point(25, 185);
            this.pnlCurrentField.Name = "pnlCurrentField";
            this.pnlCurrentField.Size = new System.Drawing.Size(550, 40);
            this.pnlCurrentField.TabIndex = 2;
            // 
            // lblShowCurrent
            // 
            this.lblShowCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowCurrent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblShowCurrent.Location = new System.Drawing.Point(515, 0);
            this.lblShowCurrent.Name = "lblShowCurrent";
            this.lblShowCurrent.Size = new System.Drawing.Size(35, 40);
            this.lblShowCurrent.TabIndex = 1;
            this.lblShowCurrent.Text = "👁";
            this.lblShowCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowCurrent.Click += new System.EventHandler(this.btnShowCurrent_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCurrentPassword.Location = new System.Drawing.Point(10, 10);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(495, 20);
            this.txtCurrentPassword.TabIndex = 0;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblCurrentLabel
            // 
            this.lblCurrentLabel.AutoSize = true;
            this.lblCurrentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblCurrentLabel.Location = new System.Drawing.Point(25, 160);
            this.lblCurrentLabel.Name = "lblCurrentLabel";
            this.lblCurrentLabel.Size = new System.Drawing.Size(117, 19);
            this.lblCurrentLabel.TabIndex = 1;
            this.lblCurrentLabel.Text = "Password Saat Ini";
            // 
            // pnlCardHeader
            // 
            this.pnlCardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.pnlCardHeader.Controls.Add(this.lblCardSubtitle);
            this.pnlCardHeader.Controls.Add(this.lblCardTitle);
            this.pnlCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlCardHeader.Name = "pnlCardHeader";
            this.pnlCardHeader.Size = new System.Drawing.Size(600, 80);
            this.pnlCardHeader.TabIndex = 0;
            // 
            // lblCardSubtitle
            // 
            this.lblCardSubtitle.AutoSize = true;
            this.lblCardSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCardSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblCardSubtitle.Location = new System.Drawing.Point(20, 45);
            this.lblCardSubtitle.Name = "lblCardSubtitle";
            this.lblCardSubtitle.Size = new System.Drawing.Size(262, 15);
            this.lblCardSubtitle.TabIndex = 1;
            this.lblCardSubtitle.Text = "Pastikan password baru Anda kuat dan mudah diingat";
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lblCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTitle.Location = new System.Drawing.Point(18, 15);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(176, 25);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Form Reset Password";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(20, 75);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(164, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Ubah password akun Anda";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(15, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reset Password";
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPasswordForm";
            this.Text = "Reset Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlConfirmField.ResumeLayout(false);
            this.pnlConfirmField.PerformLayout();
            this.pnlNewField.ResumeLayout(false);
            this.pnlNewField.PerformLayout();
            this.pnlCurrentField.ResumeLayout(false);
            this.pnlCurrentField.PerformLayout();
            this.pnlCardHeader.ResumeLayout(false);
            this.pnlCardHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private SidebarControl sidebarControl1;
        private NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlCardHeader;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Label lblCardSubtitle;
        private System.Windows.Forms.Label lblCurrentLabel;
        private System.Windows.Forms.Panel pnlCurrentField;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblShowCurrent;
        private System.Windows.Forms.Label lblLupaPassword;
        private System.Windows.Forms.Label lblNewLabel;
        private System.Windows.Forms.Panel pnlNewField;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblShowNew;
        private System.Windows.Forms.Label lblConfirmLabel;
        private System.Windows.Forms.Panel pnlConfirmField;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblShowConfirm;
        private System.Windows.Forms.Button btnResetPassword;
    }
}
