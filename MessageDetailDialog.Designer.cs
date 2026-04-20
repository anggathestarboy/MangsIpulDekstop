using System.Drawing;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    partial class MessageDetailDialog
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.btnHeaderClose = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblFooterHint = new System.Windows.Forms.Label();
            this.btnTutup = new System.Windows.Forms.Button();
            this.btnBalas = new System.Windows.Forms.Button();
            this.pnlMessageCard = new System.Windows.Forms.Panel();
            this.lblMessageContent = new System.Windows.Forms.Label();
            this.lblTitlePesan = new System.Windows.Forms.Label();
            this.pnlSenderCard = new System.Windows.Forms.Panel();
            this.lblSenderEmail = new System.Windows.Forms.Label();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lblAvatarInitial = new System.Windows.Forms.Label();
            this.lblTitleSender = new System.Windows.Forms.Label();
            this.pnlInfoContainer = new System.Windows.Forms.Panel();
            this.pnlDateCard = new System.Windows.Forms.Panel();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.pnlIdCard = new System.Windows.Forms.Panel();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblIdLabel = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlMessageCard.SuspendLayout();
            this.pnlSenderCard.SuspendLayout();
            this.pnlAvatar.SuspendLayout();
            this.pnlInfoContainer.SuspendLayout();
            this.pnlDateCard.SuspendLayout();
            this.pnlIdCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.btnHeaderClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(600, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(15, 15);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(105, 21);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Detail Pesan";
            // 
            // btnHeaderClose
            // 
            this.btnHeaderClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeaderClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeaderClose.FlatAppearance.BorderSize = 0;
            this.btnHeaderClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeaderClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnHeaderClose.ForeColor = System.Drawing.Color.White;
            this.btnHeaderClose.Location = new System.Drawing.Point(555, 10);
            this.btnHeaderClose.Name = "btnHeaderClose";
            this.btnHeaderClose.Size = new System.Drawing.Size(30, 30);
            this.btnHeaderClose.TabIndex = 1;
            this.btnHeaderClose.Text = "✕";
            this.btnHeaderClose.UseVisualStyleBackColor = true;
            this.btnHeaderClose.Click += new System.EventHandler(this.btnHeaderClose_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblFooterHint);
            this.pnlMain.Controls.Add(this.btnTutup);
            this.pnlMain.Controls.Add(this.btnBalas);
            this.pnlMain.Controls.Add(this.pnlMessageCard);
            this.pnlMain.Controls.Add(this.lblTitlePesan);
            this.pnlMain.Controls.Add(this.pnlSenderCard);
            this.pnlMain.Controls.Add(this.lblTitleSender);
            this.pnlMain.Controls.Add(this.pnlInfoContainer);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 50);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(25);
            this.pnlMain.Size = new System.Drawing.Size(600, 530);
            this.pnlMain.TabIndex = 1;
            // 
            // lblFooterHint
            // 
            this.lblFooterHint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooterHint.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblFooterHint.ForeColor = System.Drawing.Color.Gray;
            this.lblFooterHint.Location = new System.Drawing.Point(25, 485);
            this.lblFooterHint.Name = "lblFooterHint";
            this.lblFooterHint.Size = new System.Drawing.Size(550, 20);
            this.lblFooterHint.TabIndex = 7;
            this.lblFooterHint.Text = "*Tombol balas akan membuka Gmail compose dengan email penerima terisi otomatis";
            this.lblFooterHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutup.FlatAppearance.BorderSize = 0;
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnTutup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnTutup.Location = new System.Drawing.Point(305, 435);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(270, 45);
            this.btnTutup.TabIndex = 6;
            this.btnTutup.Text = "✕  Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            this.btnTutup.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBalas
            // 
            this.btnBalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.btnBalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalas.FlatAppearance.BorderSize = 0;
            this.btnBalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnBalas.ForeColor = System.Drawing.Color.White;
            this.btnBalas.Location = new System.Drawing.Point(25, 435);
            this.btnBalas.Name = "btnBalas";
            this.btnBalas.Size = new System.Drawing.Size(270, 45);
            this.btnBalas.TabIndex = 5;
            this.btnBalas.Text = "✉  Balas via Gmail";
            this.btnBalas.UseVisualStyleBackColor = false;
            this.btnBalas.Click += new System.EventHandler(this.btnBalas_Click);
            // 
            // pnlMessageCard
            // 
            this.pnlMessageCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlMessageCard.Controls.Add(this.lblMessageContent);
            this.pnlMessageCard.Location = new System.Drawing.Point(25, 315);
            this.pnlMessageCard.Name = "pnlMessageCard";
            this.pnlMessageCard.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMessageCard.Size = new System.Drawing.Size(550, 100);
            this.pnlMessageCard.TabIndex = 4;
            // 
            // lblMessageContent
            // 
            this.lblMessageContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessageContent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMessageContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMessageContent.Location = new System.Drawing.Point(15, 15);
            this.lblMessageContent.Name = "lblMessageContent";
            this.lblMessageContent.Size = new System.Drawing.Size(520, 70);
            this.lblMessageContent.TabIndex = 0;
            this.lblMessageContent.Text = "Content goes here...";
            // 
            // lblTitlePesan
            // 
            this.lblTitlePesan.AutoSize = true;
            this.lblTitlePesan.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblTitlePesan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitlePesan.Location = new System.Drawing.Point(25, 285);
            this.lblTitlePesan.Name = "lblTitlePesan";
            this.lblTitlePesan.Size = new System.Drawing.Size(86, 19);
            this.lblTitlePesan.TabIndex = 3;
            this.lblTitlePesan.Text = "💬 Isi Pesan";
            // 
            // pnlSenderCard
            // 
            this.pnlSenderCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlSenderCard.Controls.Add(this.lblSenderEmail);
            this.pnlSenderCard.Controls.Add(this.lblSenderName);
            this.pnlSenderCard.Controls.Add(this.pnlAvatar);
            this.pnlSenderCard.Location = new System.Drawing.Point(25, 205);
            this.pnlSenderCard.Name = "pnlSenderCard";
            this.pnlSenderCard.Size = new System.Drawing.Size(550, 65);
            this.pnlSenderCard.TabIndex = 2;
            // 
            // lblSenderEmail
            // 
            this.lblSenderEmail.AutoSize = true;
            this.lblSenderEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSenderEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.lblSenderEmail.Location = new System.Drawing.Point(65, 35);
            this.lblSenderEmail.Name = "lblSenderEmail";
            this.lblSenderEmail.Size = new System.Drawing.Size(104, 15);
            this.lblSenderEmail.TabIndex = 2;
            this.lblSenderEmail.Text = "email@gmail.com";
            // 
            // lblSenderName
            // 
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblSenderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblSenderName.Location = new System.Drawing.Point(65, 15);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(73, 19);
            this.lblSenderName.TabIndex = 1;
            this.lblSenderName.Text = "Full Name";
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.pnlAvatar.Controls.Add(this.lblAvatarInitial);
            this.pnlAvatar.Location = new System.Drawing.Point(15, 12);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatar.TabIndex = 0;
            // 
            // lblAvatarInitial
            // 
            this.lblAvatarInitial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvatarInitial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvatarInitial.ForeColor = System.Drawing.Color.White;
            this.lblAvatarInitial.Location = new System.Drawing.Point(0, 0);
            this.lblAvatarInitial.Name = "lblAvatarInitial";
            this.lblAvatarInitial.Size = new System.Drawing.Size(40, 40);
            this.lblAvatarInitial.TabIndex = 0;
            this.lblAvatarInitial.Text = "A";
            this.lblAvatarInitial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleSender
            // 
            this.lblTitleSender.AutoSize = true;
            this.lblTitleSender.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblTitleSender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitleSender.Location = new System.Drawing.Point(25, 175);
            this.lblTitleSender.Name = "lblTitleSender";
            this.lblTitleSender.Size = new System.Drawing.Size(148, 19);
            this.lblTitleSender.TabIndex = 1;
            this.lblTitleSender.Text = "👤 Informasi Pengirim";
            // 
            // pnlInfoContainer
            // 
            this.pnlInfoContainer.Controls.Add(this.pnlDateCard);
            this.pnlInfoContainer.Controls.Add(this.pnlIdCard);
            this.pnlInfoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfoContainer.Location = new System.Drawing.Point(25, 25);
            this.pnlInfoContainer.Name = "pnlInfoContainer";
            this.pnlInfoContainer.Size = new System.Drawing.Size(550, 130);
            this.pnlInfoContainer.TabIndex = 0;
            // 
            // pnlDateCard
            // 
            this.pnlDateCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.pnlDateCard.Controls.Add(this.lblDateValue);
            this.pnlDateCard.Controls.Add(this.lblDateLabel);
            this.pnlDateCard.Location = new System.Drawing.Point(280, 0);
            this.pnlDateCard.Name = "pnlDateCard";
            this.pnlDateCard.Size = new System.Drawing.Size(270, 110);
            this.pnlDateCard.TabIndex = 1;
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblDateValue.Location = new System.Drawing.Point(20, 55);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(133, 20);
            this.lblDateValue.TabIndex = 1;
            this.lblDateValue.Text = "18 Mar 2026, 10.23";
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.lblDateLabel.Location = new System.Drawing.Point(20, 25);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(48, 15);
            this.lblDateLabel.TabIndex = 0;
            this.lblDateLabel.Text = "Tanggal";
            // 
            // pnlIdCard
            // 
            this.pnlIdCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
            this.pnlIdCard.Controls.Add(this.lblIdValue);
            this.pnlIdCard.Controls.Add(this.lblIdLabel);
            this.pnlIdCard.Location = new System.Drawing.Point(0, 0);
            this.pnlIdCard.Name = "pnlIdCard";
            this.pnlIdCard.Size = new System.Drawing.Size(270, 110);
            this.pnlIdCard.TabIndex = 0;
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblIdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblIdValue.Location = new System.Drawing.Point(20, 50);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(34, 25);
            this.lblIdValue.TabIndex = 1;
            this.lblIdValue.Text = "#1";
            // 
            // lblIdLabel
            // 
            this.lblIdLabel.AutoSize = true;
            this.lblIdLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.lblIdLabel.Location = new System.Drawing.Point(20, 25);
            this.lblIdLabel.Name = "lblIdLabel";
            this.lblIdLabel.Size = new System.Drawing.Size(52, 15);
            this.lblIdLabel.TabIndex = 0;
            this.lblIdLabel.Text = "ID Pesan";
            // 
            // MessageDetailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 580);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageDetailDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detail Pesan";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlMessageCard.ResumeLayout(false);
            this.pnlSenderCard.ResumeLayout(false);
            this.pnlSenderCard.PerformLayout();
            this.pnlAvatar.ResumeLayout(false);
            this.pnlInfoContainer.ResumeLayout(false);
            this.pnlDateCard.ResumeLayout(false);
            this.pnlDateCard.PerformLayout();
            this.pnlIdCard.ResumeLayout(false);
            this.pnlIdCard.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Button btnHeaderClose;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlInfoContainer;
        private System.Windows.Forms.Panel pnlIdCard;
        private System.Windows.Forms.Label lblIdLabel;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Panel pnlDateCard;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblTitleSender;
        private System.Windows.Forms.Panel pnlSenderCard;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lblAvatarInitial;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.Label lblSenderEmail;
        private System.Windows.Forms.Label lblTitlePesan;
        private System.Windows.Forms.Panel pnlMessageCard;
        private System.Windows.Forms.Label lblMessageContent;
        private System.Windows.Forms.Button btnBalas;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label lblFooterHint;
    }
}
