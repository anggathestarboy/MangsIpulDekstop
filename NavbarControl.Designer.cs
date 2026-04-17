namespace MangsIpulAsli
{
    partial class NavbarControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.pnlWindowControls = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUserAvatar = new System.Windows.Forms.Label();
            this.btnNavMail = new System.Windows.Forms.Label();
            this.lblNavTitle = new System.Windows.Forms.Label();
            this.pnlNavbar.SuspendLayout();
            this.pnlWindowControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.pnlNavbar.Controls.Add(this.pnlWindowControls);
            this.pnlNavbar.Controls.Add(this.lblUserName);
            this.pnlNavbar.Controls.Add(this.pbUserAvatar);
            this.pnlNavbar.Controls.Add(this.btnNavMail);
            this.pnlNavbar.Controls.Add(this.lblNavTitle);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(1245, 49);
            this.pnlNavbar.TabIndex = 1;
            this.pnlNavbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNavbar_Paint);
            // 
            // pnlWindowControls
            // 
            this.pnlWindowControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWindowControls.Controls.Add(this.btnMinimize);
            this.pnlWindowControls.Controls.Add(this.btnClose);
            this.pnlWindowControls.Location = new System.Drawing.Point(1170, 0);
            this.pnlWindowControls.Margin = new System.Windows.Forms.Padding(2);
            this.pnlWindowControls.Name = "pnlWindowControls";
            this.pnlWindowControls.Size = new System.Drawing.Size(75, 32);
            this.pnlWindowControls.TabIndex = 4;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
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
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(38, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(968, 13);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(35, 19);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "user";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // pbUserAvatar
            // 
            this.pbUserAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUserAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.pbUserAvatar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.pbUserAvatar.ForeColor = System.Drawing.Color.White;
            this.pbUserAvatar.Location = new System.Drawing.Point(1107, 7);
            this.pbUserAvatar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pbUserAvatar.Name = "pbUserAvatar";
            this.pbUserAvatar.Size = new System.Drawing.Size(26, 28);
            this.pbUserAvatar.TabIndex = 2;
            this.pbUserAvatar.Text = "AD";
            this.pbUserAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pbUserAvatar.Click += new System.EventHandler(this.pbUserAvatar_Click);
            // 
            // btnNavMail
            // 
            this.btnNavMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavMail.AutoSize = true;
            this.btnNavMail.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnNavMail.ForeColor = System.Drawing.Color.White;
            this.btnNavMail.Location = new System.Drawing.Point(931, 9);
            this.btnNavMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnNavMail.Name = "btnNavMail";
            this.btnNavMail.Size = new System.Drawing.Size(33, 25);
            this.btnNavMail.TabIndex = 1;
            this.btnNavMail.Text = "✉";
            // 
            // lblNavTitle
            // 
            this.lblNavTitle.AutoSize = true;
            this.lblNavTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.White;
            this.lblNavTitle.Location = new System.Drawing.Point(15, 16);
            this.lblNavTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(89, 21);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "Dashboard";
            // 
            // NavbarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNavbar);
            this.Name = "NavbarControl";
            this.Size = new System.Drawing.Size(1245, 49);
            this.pnlNavbar.ResumeLayout(false);
            this.pnlNavbar.PerformLayout();
            this.pnlWindowControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Panel pnlWindowControls;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label pbUserAvatar;
        private System.Windows.Forms.Label btnNavMail;
        private System.Windows.Forms.Label lblNavTitle;
    }
}
