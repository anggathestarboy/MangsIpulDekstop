using System.Drawing;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    partial class ProfileForm
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
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblFooterNote = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.pnlWarning = new System.Windows.Forms.Panel();
            this.lblWarningText = new System.Windows.Forms.Label();
            this.lblWarningIcon = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsernameLabel = new System.Windows.Forms.Label();
            this.pnlUserHeader = new System.Windows.Forms.Panel();
            this.lblDisplayEmail = new System.Windows.Forms.Label();
            this.lblDisplayUsername = new System.Windows.Forms.Label();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblAvatarInitial = new System.Windows.Forms.Label();
            this.pnlCardHeader = new System.Windows.Forms.Panel();
            this.lblIconInfo = new System.Windows.Forms.Label();
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblIconMail = new System.Windows.Forms.Label();
            this.lblIconUserField = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlWarning.SuspendLayout();
            this.pnlUserHeader.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
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
            this.pnlContent.Controls.Add(this.lblLastUpdate);
            this.pnlContent.Controls.Add(this.pnlCard);
            this.pnlContent.Controls.Add(this.lblSubtitle);
            this.pnlContent.Controls.Add(this.lblTitle);
            this.pnlContent.Controls.Add(this.btnBack);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(195, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1245, 829);
            this.pnlContent.TabIndex = 2;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastUpdate.ForeColor = System.Drawing.Color.Gray;
            this.lblLastUpdate.Location = new System.Drawing.Point(340, 630);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(600, 20);
            this.lblLastUpdate.TabIndex = 4;
            this.lblLastUpdate.Text = "Terakhir diperbarui: 4/20/2026";
            this.lblLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblFooterNote);
            this.pnlCard.Controls.Add(this.btnSimpan);
            this.pnlCard.Controls.Add(this.pnlWarning);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblEmailLabel);
            this.pnlCard.Controls.Add(this.txtUsername);
            this.pnlCard.Controls.Add(this.lblUsernameLabel);
            this.pnlCard.Controls.Add(this.pnlUserHeader);
            this.pnlCard.Controls.Add(this.pnlCardHeader);
            this.pnlCard.Location = new System.Drawing.Point(340, 120);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(600, 500);
            this.pnlCard.TabIndex = 3;
            // 
            // lblFooterNote
            // 
            this.lblFooterNote.AutoSize = true;
            this.lblFooterNote.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooterNote.ForeColor = System.Drawing.Color.Red;
            this.lblFooterNote.Location = new System.Drawing.Point(25, 470);
            this.lblFooterNote.Name = "lblFooterNote";
            this.lblFooterNote.Size = new System.Drawing.Size(95, 13);
            this.lblFooterNote.TabIndex = 8;
            this.lblFooterNote.Text = "* Field wajib diisi";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(425, 410);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(150, 30);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "💾 Simpan Perubahan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // pnlWarning
            // 
            this.pnlWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlWarning.Controls.Add(this.lblWarningText);
            this.pnlWarning.Controls.Add(this.lblWarningIcon);
            this.pnlWarning.Location = new System.Drawing.Point(25, 340);
            this.pnlWarning.Name = "pnlWarning";
            this.pnlWarning.Size = new System.Drawing.Size(550, 45);
            this.pnlWarning.TabIndex = 6;
            // 
            // lblWarningText
            // 
            this.lblWarningText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWarningText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblWarningText.Location = new System.Drawing.Point(40, 12);
            this.lblWarningText.Name = "lblWarningText";
            this.lblWarningText.Size = new System.Drawing.Size(500, 20);
            this.lblWarningText.TabIndex = 1;
            this.lblWarningText.Text = "Pastikan email yang Anda gunakan aktif untuk keperluan verifikasi";
            // 
            // lblWarningIcon
            // 
            this.lblWarningIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWarningIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblWarningIcon.Location = new System.Drawing.Point(10, 10);
            this.lblWarningIcon.Name = "lblWarningIcon";
            this.lblWarningIcon.Size = new System.Drawing.Size(25, 25);
            this.lblWarningIcon.TabIndex = 0;
            this.lblWarningIcon.Text = "ℹ";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(25, 285);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(550, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblEmailLabel.Location = new System.Drawing.Point(25, 260);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(53, 19);
            this.lblEmailLabel.TabIndex = 4;
            this.lblEmailLabel.Text = "Email *";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(25, 210);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(550, 27);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUsernameLabel
            // 
            this.lblUsernameLabel.AutoSize = true;
            this.lblUsernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblUsernameLabel.Location = new System.Drawing.Point(25, 185);
            this.lblUsernameLabel.Name = "lblUsernameLabel";
            this.lblUsernameLabel.Size = new System.Drawing.Size(81, 19);
            this.lblUsernameLabel.TabIndex = 2;
            this.lblUsernameLabel.Text = "Username *";
            // 
            // pnlUserHeader
            // 
            this.pnlUserHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.pnlUserHeader.Controls.Add(this.lblDisplayEmail);
            this.pnlUserHeader.Controls.Add(this.lblDisplayUsername);
            this.pnlUserHeader.Controls.Add(this.pnlAvatar);
            this.pnlUserHeader.Location = new System.Drawing.Point(25, 85);
            this.pnlUserHeader.Name = "pnlUserHeader";
            this.pnlUserHeader.Size = new System.Drawing.Size(550, 80);
            this.pnlUserHeader.TabIndex = 1;
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDisplayEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblDisplayEmail.Location = new System.Drawing.Point(75, 42);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(147, 19);
            this.lblDisplayEmail.TabIndex = 2;
            this.lblDisplayEmail.Text = "mangsipul@gmail.com";
            // 
            // lblDisplayUsername
            // 
            this.lblDisplayUsername.AutoSize = true;
            this.lblDisplayUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblDisplayUsername.Location = new System.Drawing.Point(75, 18);
            this.lblDisplayUsername.Name = "lblDisplayUsername";
            this.lblDisplayUsername.Size = new System.Drawing.Size(130, 21);
            this.lblDisplayUsername.TabIndex = 1;
            this.lblDisplayUsername.Text = "adminmangsipul";
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.pnlAvatar.Controls.Add(this.lblAvatarInitial);
            this.pnlAvatar.Location = new System.Drawing.Point(15, 15);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(50, 50);
            this.pnlAvatar.TabIndex = 0;
            // 
            // lblAvatarInitial
            // 
            this.lblAvatarInitial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitial.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitial.ForeColor = System.Drawing.Color.White;
            this.lblAvatarInitial.Location = new System.Drawing.Point(0, 0);
            this.lblAvatarInitial.Name = "lblAvatarInitial";
            this.lblAvatarInitial.Size = new System.Drawing.Size(50, 50);
            this.lblAvatarInitial.TabIndex = 0;
            this.lblAvatarInitial.Text = "A";
            this.lblAvatarInitial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCardHeader
            // 
            this.pnlCardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.pnlCardHeader.Controls.Add(this.lblIconInfo);
            this.pnlCardHeader.Controls.Add(this.lblCardTitle);
            this.pnlCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlCardHeader.Name = "pnlCardHeader";
            this.pnlCardHeader.Size = new System.Drawing.Size(600, 60);
            this.pnlCardHeader.TabIndex = 0;
            // 
            // lblIconInfo
            // 
            this.lblIconInfo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblIconInfo.ForeColor = System.Drawing.Color.White;
            this.lblIconInfo.Location = new System.Drawing.Point(15, 15);
            this.lblIconInfo.Name = "lblIconInfo";
            this.lblIconInfo.Size = new System.Drawing.Size(30, 30);
            this.lblIconInfo.TabIndex = 0;
            this.lblIconInfo.Text = "👤";
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.AutoSize = true;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lblCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblCardTitle.Location = new System.Drawing.Point(50, 17);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(145, 25);
            this.lblCardTitle.TabIndex = 1;
            this.lblCardTitle.Text = "Informasi Profil";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(390, 80);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(196, 20);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Kelola informasi profil Anda";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(385, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Profil Saya";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnBack.Location = new System.Drawing.Point(340, 40);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblIconMail
            // 
            this.lblIconMail.Location = new System.Drawing.Point(0, 0);
            this.lblIconMail.Name = "lblIconMail";
            this.lblIconMail.Size = new System.Drawing.Size(100, 23);
            this.lblIconMail.TabIndex = 0;
            // 
            // lblIconUserField
            // 
            this.lblIconUserField.Location = new System.Drawing.Point(0, 0);
            this.lblIconUserField.Name = "lblIconUserField";
            this.lblIconUserField.Size = new System.Drawing.Size(100, 23);
            this.lblIconUserField.TabIndex = 0;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "Profil Akun";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlWarning.ResumeLayout(false);
            this.pnlUserHeader.ResumeLayout(false);
            this.pnlUserHeader.PerformLayout();
            this.pnlAvatar.ResumeLayout(false);
            this.pnlCardHeader.ResumeLayout(false);
            this.pnlCardHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private SidebarControl sidebarControl1;
        private NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlCardHeader;
        private System.Windows.Forms.Label lblIconInfo;
        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.Panel pnlUserHeader;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblAvatarInitial;
        private System.Windows.Forms.Label lblDisplayUsername;
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.Label lblIconUserField;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblIconMail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlWarning;
        private System.Windows.Forms.Label lblWarningIcon;
        private System.Windows.Forms.Label lblWarningText;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label lblFooterNote;
        private System.Windows.Forms.Label lblLastUpdate;
    }
}
