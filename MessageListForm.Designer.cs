using System.Drawing;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    partial class MessageListForm
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
            this.lblFooterHint = new System.Windows.Forms.Label();
            this.flpMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeaderTable = new System.Windows.Forms.Panel();
            this.lblColTanggal = new System.Windows.Forms.Label();
            this.lblColPesan = new System.Windows.Forms.Label();
            this.lblColEmail = new System.Windows.Forms.Label();
            this.lblColNama = new System.Windows.Forms.Label();
            this.lblColNo = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.lblIconEmail = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            this.pnlHeaderTable.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlIcon.SuspendLayout();
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
            this.pnlContent.Controls.Add(this.lblFooterHint);
            this.pnlContent.Controls.Add(this.flpMessages);
            this.pnlContent.Controls.Add(this.pnlHeaderTable);
            this.pnlContent.Controls.Add(this.pnlTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(195, 49);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(1245, 829);
            this.pnlContent.TabIndex = 2;
            // 
            // lblFooterHint
            // 
            this.lblFooterHint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFooterHint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooterHint.ForeColor = System.Drawing.Color.Gray;
            this.lblFooterHint.Location = new System.Drawing.Point(20, 789);
            this.lblFooterHint.Name = "lblFooterHint";
            this.lblFooterHint.Size = new System.Drawing.Size(1205, 20);
            this.lblFooterHint.TabIndex = 3;
            this.lblFooterHint.Text = "Klik dua kali pada baris pesan untuk melihat detail";
            this.lblFooterHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpMessages
            // 
            this.flpMessages.AutoScroll = true;
            this.flpMessages.BackColor = System.Drawing.Color.White;
            this.flpMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMessages.Location = new System.Drawing.Point(20, 140);
            this.flpMessages.Name = "flpMessages";
            this.flpMessages.Size = new System.Drawing.Size(1205, 649);
            this.flpMessages.TabIndex = 2;
            // 
            // pnlHeaderTable
            // 
            this.pnlHeaderTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.pnlHeaderTable.Controls.Add(this.lblColTanggal);
            this.pnlHeaderTable.Controls.Add(this.lblColPesan);
            this.pnlHeaderTable.Controls.Add(this.lblColEmail);
            this.pnlHeaderTable.Controls.Add(this.lblColNama);
            this.pnlHeaderTable.Controls.Add(this.lblColNo);
            this.pnlHeaderTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderTable.Location = new System.Drawing.Point(20, 100);
            this.pnlHeaderTable.Name = "pnlHeaderTable";
            this.pnlHeaderTable.Size = new System.Drawing.Size(1205, 40);
            this.pnlHeaderTable.TabIndex = 1;
            // 
            // lblColTanggal
            // 
            this.lblColTanggal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblColTanggal.ForeColor = System.Drawing.Color.White;
            this.lblColTanggal.Location = new System.Drawing.Point(780, 0);
            this.lblColTanggal.Name = "lblColTanggal";
            this.lblColTanggal.Size = new System.Drawing.Size(120, 40);
            this.lblColTanggal.TabIndex = 4;
            this.lblColTanggal.Text = "Tanggal";
            this.lblColTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColPesan
            // 
            this.lblColPesan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblColPesan.ForeColor = System.Drawing.Color.White;
            this.lblColPesan.Location = new System.Drawing.Point(470, 0);
            this.lblColPesan.Name = "lblColPesan";
            this.lblColPesan.Size = new System.Drawing.Size(300, 40);
            this.lblColPesan.TabIndex = 3;
            this.lblColPesan.Text = "Pesan";
            this.lblColPesan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColEmail
            // 
            this.lblColEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblColEmail.ForeColor = System.Drawing.Color.White;
            this.lblColEmail.Location = new System.Drawing.Point(260, 0);
            this.lblColEmail.Name = "lblColEmail";
            this.lblColEmail.Size = new System.Drawing.Size(200, 40);
            this.lblColEmail.TabIndex = 2;
            this.lblColEmail.Text = "Email";
            this.lblColEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColNama
            // 
            this.lblColNama.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblColNama.ForeColor = System.Drawing.Color.White;
            this.lblColNama.Location = new System.Drawing.Point(60, 0);
            this.lblColNama.Name = "lblColNama";
            this.lblColNama.Size = new System.Drawing.Size(200, 40);
            this.lblColNama.TabIndex = 1;
            this.lblColNama.Text = "Nama";
            this.lblColNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColNo
            // 
            this.lblColNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblColNo.ForeColor = System.Drawing.Color.White;
            this.lblColNo.Location = new System.Drawing.Point(0, 0);
            this.lblColNo.Name = "lblColNo";
            this.lblColNo.Size = new System.Drawing.Size(50, 40);
            this.lblColNo.TabIndex = 0;
            this.lblColNo.Text = "No";
            this.lblColNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.lblSubtitle);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.pnlIcon);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(20, 20);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1205, 80);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(48, 47);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(262, 19);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Kelola dan lihat semua pesan dari pengguna";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(45, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Daftar Pesan Masuk";
            // 
            // pnlIcon
            // 
            this.pnlIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.pnlIcon.Controls.Add(this.lblIconEmail);
            this.pnlIcon.Location = new System.Drawing.Point(0, 10);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(40, 40);
            this.pnlIcon.TabIndex = 0;
            // 
            // lblIconEmail
            // 
            this.lblIconEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIconEmail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblIconEmail.ForeColor = System.Drawing.Color.White;
            this.lblIconEmail.Location = new System.Drawing.Point(0, 0);
            this.lblIconEmail.Name = "lblIconEmail";
            this.lblIconEmail.Size = new System.Drawing.Size(40, 40);
            this.lblIconEmail.TabIndex = 0;
            this.lblIconEmail.Text = "✉";
            this.lblIconEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MessageListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageListForm";
            this.Text = "Daftar Pesan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContent.ResumeLayout(false);
            this.pnlHeaderTable.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private SidebarControl sidebarControl1;
        private NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.Label lblIconEmail;
        private System.Windows.Forms.Panel pnlHeaderTable;
        private System.Windows.Forms.Label lblColNo;
        private System.Windows.Forms.Label lblColNama;
        private System.Windows.Forms.Label lblColEmail;
        private System.Windows.Forms.Label lblColPesan;
        private System.Windows.Forms.Label lblColTanggal;
        private System.Windows.Forms.FlowLayoutPanel flpMessages;
        private System.Windows.Forms.Label lblFooterHint;
    }
}
