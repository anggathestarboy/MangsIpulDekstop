namespace MangsIpulAsli
{
    partial class Dashboard
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
            this.sidebarControl1 = new MangsIpulAsli.SidebarControl();
            this.navbarControl1 = new MangsIpulAsli.NavbarControl();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.flowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.FlowLayoutPanel();
            this.cardStat1 = new System.Windows.Forms.Panel();
            this.cardStat2 = new System.Windows.Forms.Panel();
            this.cardStat3 = new System.Windows.Forms.Panel();
            this.cardStat4 = new System.Windows.Forms.Panel();
            this.pnlChartContainer = new System.Windows.Forms.Panel();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.pnlBottomRow = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlActivity = new System.Windows.Forms.Panel();
            this.pnlWallet = new System.Windows.Forms.Panel();
            this.pnlContent.SuspendLayout();
            this.flowMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlChartContainer.SuspendLayout();
            this.pnlBottomRow.SuspendLayout();
            this.SuspendLayout();
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
            // navbarControl1
            // 
            this.navbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarControl1.Location = new System.Drawing.Point(195, 0);
            this.navbarControl1.Margin = new System.Windows.Forms.Padding(0);
            this.navbarControl1.Name = "navbarControl1";
            this.navbarControl1.Size = new System.Drawing.Size(1245, 49);
            this.navbarControl1.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.pnlContent.Controls.Add(this.flowMain);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(195, 49);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1245, 829);
            this.pnlContent.TabIndex = 2;
            // 
            // flowMain
            // 
            this.flowMain.AutoScroll = true;
            this.flowMain.Controls.Add(this.pnlHeader);
            this.flowMain.Controls.Add(this.pnlStats);
            this.flowMain.Controls.Add(this.pnlChartContainer);
            this.flowMain.Controls.Add(this.pnlBottomRow);
            this.flowMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMain.Location = new System.Drawing.Point(0, 0);
            this.flowMain.Margin = new System.Windows.Forms.Padding(2);
            this.flowMain.Name = "flowMain";
            this.flowMain.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.flowMain.Size = new System.Drawing.Size(1245, 829);
            this.flowMain.TabIndex = 0;
            this.flowMain.WrapContents = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Location = new System.Drawing.Point(17, 18);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(4, 37);
            this.lblHeaderSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(290, 20);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Selamat datang di FoodAdmin Dashboard";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(184, 45);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Dashboard";
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.cardStat1);
            this.pnlStats.Controls.Add(this.cardStat2);
            this.pnlStats.Controls.Add(this.cardStat3);
            this.pnlStats.Controls.Add(this.cardStat4);
            this.pnlStats.Location = new System.Drawing.Point(17, 87);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1200, 122);
            this.pnlStats.TabIndex = 1;
            // 
            // cardStat1
            // 
            this.cardStat1.BackColor = System.Drawing.Color.White;
            this.cardStat1.Location = new System.Drawing.Point(0, 0);
            this.cardStat1.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.cardStat1.Name = "cardStat1";
            this.cardStat1.Size = new System.Drawing.Size(225, 106);
            this.cardStat1.TabIndex = 0;
            this.cardStat1.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // cardStat2
            // 
            this.cardStat2.BackColor = System.Drawing.Color.White;
            this.cardStat2.Location = new System.Drawing.Point(240, 0);
            this.cardStat2.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.cardStat2.Name = "cardStat2";
            this.cardStat2.Size = new System.Drawing.Size(225, 106);
            this.cardStat2.TabIndex = 1;
            this.cardStat2.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // cardStat3
            // 
            this.cardStat3.BackColor = System.Drawing.Color.White;
            this.cardStat3.Location = new System.Drawing.Point(480, 0);
            this.cardStat3.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.cardStat3.Name = "cardStat3";
            this.cardStat3.Size = new System.Drawing.Size(225, 106);
            this.cardStat3.TabIndex = 2;
            this.cardStat3.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // cardStat4
            // 
            this.cardStat4.BackColor = System.Drawing.Color.White;
            this.cardStat4.Location = new System.Drawing.Point(720, 0);
            this.cardStat4.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.cardStat4.Name = "cardStat4";
            this.cardStat4.Size = new System.Drawing.Size(225, 106);
            this.cardStat4.TabIndex = 3;
            this.cardStat4.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // pnlChartContainer
            // 
            this.pnlChartContainer.BackColor = System.Drawing.Color.White;
            this.pnlChartContainer.Controls.Add(this.lblChartTitle);
            this.pnlChartContainer.Location = new System.Drawing.Point(17, 213);
            this.pnlChartContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 16);
            this.pnlChartContainer.Name = "pnlChartContainer";
            this.pnlChartContainer.Size = new System.Drawing.Size(945, 325);
            this.pnlChartContainer.TabIndex = 2;
            this.pnlChartContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblChartTitle.Location = new System.Drawing.Point(15, 16);
            this.lblChartTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(151, 21);
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.Text = "📈 Grafik Penjualan";
            // 
            // pnlBottomRow
            // 
            this.pnlBottomRow.Controls.Add(this.pnlActivity);
            this.pnlBottomRow.Controls.Add(this.pnlWallet);
            this.pnlBottomRow.Location = new System.Drawing.Point(17, 556);
            this.pnlBottomRow.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottomRow.Name = "pnlBottomRow";
            this.pnlBottomRow.Size = new System.Drawing.Size(1200, 325);
            this.pnlBottomRow.TabIndex = 3;
            // 
            // pnlActivity
            // 
            this.pnlActivity.BackColor = System.Drawing.Color.White;
            this.pnlActivity.Location = new System.Drawing.Point(0, 0);
            this.pnlActivity.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pnlActivity.Name = "pnlActivity";
            this.pnlActivity.Size = new System.Drawing.Size(525, 284);
            this.pnlActivity.TabIndex = 0;
            this.pnlActivity.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // pnlWallet
            // 
            this.pnlWallet.BackColor = System.Drawing.Color.White;
            this.pnlWallet.Location = new System.Drawing.Point(542, 2);
            this.pnlWallet.Margin = new System.Windows.Forms.Padding(2);
            this.pnlWallet.Name = "pnlWallet";
            this.pnlWallet.Size = new System.Drawing.Size(405, 284);
            this.pnlWallet.TabIndex = 1;
            this.pnlWallet.Paint += new System.Windows.Forms.PaintEventHandler(this.card_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 878);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlContent.ResumeLayout(false);
            this.flowMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlChartContainer.ResumeLayout(false);
            this.pnlChartContainer.PerformLayout();
            this.pnlBottomRow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MangsIpulAsli.SidebarControl sidebarControl1;
        private MangsIpulAsli.NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flowMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.FlowLayoutPanel pnlStats;
        private System.Windows.Forms.Panel cardStat1;
        private System.Windows.Forms.Panel cardStat2;
        private System.Windows.Forms.Panel cardStat3;
        private System.Windows.Forms.Panel cardStat4;
        private System.Windows.Forms.Panel pnlChartContainer;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.FlowLayoutPanel pnlBottomRow;
        private System.Windows.Forms.Panel pnlActivity;
        private System.Windows.Forms.Panel pnlWallet;
    }
}
