namespace MangsIpulAsli
{
    partial class WalletDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebarControl1 = new MangsIpulAsli.SidebarControl();
            this.navbarControl1 = new MangsIpulAsli.NavbarControl();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHistoryCard = new System.Windows.Forms.Panel();
            this.pnlTableFooter = new System.Windows.Forms.Panel();
            this.lblNetSummary = new System.Windows.Forms.Label();
            this.lblExpenseSummary = new System.Windows.Forms.Label();
            this.lblIncomeSummary = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHistoryHeader = new System.Windows.Forms.Panel();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.pnlFilterCard = new System.Windows.Forms.Panel();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblSampaiTanggal = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblDariTanggal = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.pnlTopCard = new System.Windows.Forms.Panel();
            this.pnlOutCard = new System.Windows.Forms.Panel();
            this.lblMoneyOut = new System.Windows.Forms.Label();
            this.lblOutLabel = new System.Windows.Forms.Label();
            this.pnlInCard = new System.Windows.Forms.Panel();
            this.lblMoneyIn = new System.Windows.Forms.Label();
            this.lblInLabel = new System.Windows.Forms.Label();
            this.lblDifference = new System.Windows.Forms.Label();
            this.lblDifferenceTitle = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceTitle = new System.Windows.Forms.Label();
            this.lblWalletName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlHistoryCard.SuspendLayout();
            this.pnlTableFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.pnlHistoryHeader.SuspendLayout();
            this.pnlFilterCard.SuspendLayout();
            this.pnlTopCard.SuspendLayout();
            this.pnlOutCard.SuspendLayout();
            this.pnlInCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarControl1
            // 
            this.sidebarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarControl1.Location = new System.Drawing.Point(0, 0);
            this.sidebarControl1.Name = "sidebarControl1";
            this.sidebarControl1.Size = new System.Drawing.Size(195, 1061);
            this.sidebarControl1.TabIndex = 0;
            // 
            // navbarControl1
            // 
            this.navbarControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.navbarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbarControl1.Location = new System.Drawing.Point(195, 0);
            this.navbarControl1.Name = "navbarControl1";
            this.navbarControl1.Size = new System.Drawing.Size(1155, 60);
            this.navbarControl1.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(195, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30);
            this.pnlMain.Size = new System.Drawing.Size(1155, 1001);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlHistoryCard);
            this.pnlContent.Controls.Add(this.pnlFilterCard);
            this.pnlContent.Controls.Add(this.pnlTopCard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(30, 110);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1078, 1200);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlHistoryCard
            // 
            this.pnlHistoryCard.BackColor = System.Drawing.Color.White;
            this.pnlHistoryCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistoryCard.Controls.Add(this.pnlTableFooter);
            this.pnlHistoryCard.Controls.Add(this.dgvTransactions);
            this.pnlHistoryCard.Controls.Add(this.pnlHistoryHeader);
            this.pnlHistoryCard.Location = new System.Drawing.Point(0, 350);
            this.pnlHistoryCard.Name = "pnlHistoryCard";
            this.pnlHistoryCard.Size = new System.Drawing.Size(1078, 600);
            this.pnlHistoryCard.TabIndex = 2;
            // 
            // pnlTableFooter
            // 
            this.pnlTableFooter.Controls.Add(this.lblNetSummary);
            this.pnlTableFooter.Controls.Add(this.lblExpenseSummary);
            this.pnlTableFooter.Controls.Add(this.lblIncomeSummary);
            this.pnlTableFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTableFooter.Location = new System.Drawing.Point(0, 548);
            this.pnlTableFooter.Name = "pnlTableFooter";
            this.pnlTableFooter.Size = new System.Drawing.Size(1076, 50);
            this.pnlTableFooter.TabIndex = 2;
            // 
            // lblNetSummary
            // 
            this.lblNetSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetSummary.AutoSize = true;
            this.lblNetSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNetSummary.Location = new System.Drawing.Point(900, 15);
            this.lblNetSummary.Name = "lblNetSummary";
            this.lblNetSummary.Size = new System.Drawing.Size(68, 19);
            this.lblNetSummary.TabIndex = 2;
            this.lblNetSummary.Text = "Net: Rp 0";
            // 
            // lblExpenseSummary
            // 
            this.lblExpenseSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpenseSummary.AutoSize = true;
            this.lblExpenseSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblExpenseSummary.ForeColor = System.Drawing.Color.Red;
            this.lblExpenseSummary.Location = new System.Drawing.Point(700, 15);
            this.lblExpenseSummary.Name = "lblExpenseSummary";
            this.lblExpenseSummary.Size = new System.Drawing.Size(130, 19);
            this.lblExpenseSummary.TabIndex = 1;
            this.lblExpenseSummary.Text = "Total Expense: Rp 0";
            // 
            // lblIncomeSummary
            // 
            this.lblIncomeSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncomeSummary.AutoSize = true;
            this.lblIncomeSummary.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblIncomeSummary.ForeColor = System.Drawing.Color.Green;
            this.lblIncomeSummary.Location = new System.Drawing.Point(520, 15);
            this.lblIncomeSummary.Name = "lblIncomeSummary";
            this.lblIncomeSummary.Size = new System.Drawing.Size(126, 19);
            this.lblIncomeSummary.TabIndex = 0;
            this.lblIncomeSummary.Text = "Total Income: Rp 0";
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactions.ColumnHeadersHeight = 40;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colType,
            this.colName,
            this.colAmount});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dgvTransactions.Location = new System.Drawing.Point(0, 60);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowTemplate.Height = 50;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(1076, 480);
            this.dgvTransactions.TabIndex = 1;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Tanggal";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Tipe";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Nama";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // pnlHistoryHeader
            // 
            this.pnlHistoryHeader.Controls.Add(this.lblHistoryTitle);
            this.pnlHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHistoryHeader.Name = "pnlHistoryHeader";
            this.pnlHistoryHeader.Size = new System.Drawing.Size(1076, 60);
            this.pnlHistoryHeader.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.Location = new System.Drawing.Point(20, 20);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(154, 20);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "Riwayat Transaksi";
            // 
            // pnlFilterCard
            // 
            this.pnlFilterCard.BackColor = System.Drawing.Color.White;
            this.pnlFilterCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterCard.Controls.Add(this.btnApplyFilter);
            this.pnlFilterCard.Controls.Add(this.dtpEnd);
            this.pnlFilterCard.Controls.Add(this.lblSampaiTanggal);
            this.pnlFilterCard.Controls.Add(this.dtpStart);
            this.pnlFilterCard.Controls.Add(this.lblDariTanggal);
            this.pnlFilterCard.Controls.Add(this.lblFilterTitle);
            this.pnlFilterCard.Location = new System.Drawing.Point(0, 210);
            this.pnlFilterCard.Name = "pnlFilterCard";
            this.pnlFilterCard.Size = new System.Drawing.Size(1078, 120);
            this.pnlFilterCard.TabIndex = 1;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(920, 60);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(130, 40);
            this.btnApplyFilter.TabIndex = 5;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(450, 65);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(420, 27);
            this.dtpEnd.TabIndex = 4;
            // 
            // lblSampaiTanggal
            // 
            this.lblSampaiTanggal.AutoSize = true;
            this.lblSampaiTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSampaiTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSampaiTanggal.Location = new System.Drawing.Point(450, 45);
            this.lblSampaiTanggal.Name = "lblSampaiTanggal";
            this.lblSampaiTanggal.Size = new System.Drawing.Size(90, 15);
            this.lblSampaiTanggal.TabIndex = 3;
            this.lblSampaiTanggal.Text = "Sampai Tanggal";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(20, 65);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(420, 27);
            this.dtpStart.TabIndex = 2;
            // 
            // lblDariTanggal
            // 
            this.lblDariTanggal.AutoSize = true;
            this.lblDariTanggal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDariTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDariTanggal.Location = new System.Drawing.Point(20, 45);
            this.lblDariTanggal.Name = "lblDariTanggal";
            this.lblDariTanggal.Size = new System.Drawing.Size(72, 15);
            this.lblDariTanggal.TabIndex = 1;
            this.lblDariTanggal.Text = "Dari Tanggal";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.Location = new System.Drawing.Point(15, 15);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(110, 18);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Filter Tanggal";
            // 
            // pnlTopCard
            // 
            this.pnlTopCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(86)))), ((int)(((byte)(219)))));
            this.pnlTopCard.Controls.Add(this.pnlOutCard);
            this.pnlTopCard.Controls.Add(this.pnlInCard);
            this.pnlTopCard.Controls.Add(this.lblDifference);
            this.pnlTopCard.Controls.Add(this.lblDifferenceTitle);
            this.pnlTopCard.Controls.Add(this.lblBalance);
            this.pnlTopCard.Controls.Add(this.lblBalanceTitle);
            this.pnlTopCard.Controls.Add(this.lblWalletName);
            this.pnlTopCard.Location = new System.Drawing.Point(0, 0);
            this.pnlTopCard.Name = "pnlTopCard";
            this.pnlTopCard.Size = new System.Drawing.Size(1078, 180);
            this.pnlTopCard.TabIndex = 0;
            // 
            // pnlOutCard
            // 
            this.pnlOutCard.BackColor = System.Drawing.Color.White;
            this.pnlOutCard.Controls.Add(this.lblMoneyOut);
            this.pnlOutCard.Controls.Add(this.lblOutLabel);
            this.pnlOutCard.Location = new System.Drawing.Point(525, 85);
            this.pnlOutCard.Name = "pnlOutCard";
            this.pnlOutCard.Size = new System.Drawing.Size(530, 80);
            this.pnlOutCard.TabIndex = 6;
            // 
            // lblMoneyOut
            // 
            this.lblMoneyOut.AutoSize = true;
            this.lblMoneyOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblMoneyOut.Location = new System.Drawing.Point(15, 35);
            this.lblMoneyOut.Name = "lblMoneyOut";
            this.lblMoneyOut.Size = new System.Drawing.Size(62, 26);
            this.lblMoneyOut.TabIndex = 1;
            this.lblMoneyOut.Text = "Rp 0";
            // 
            // lblOutLabel
            // 
            this.lblOutLabel.AutoSize = true;
            this.lblOutLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblOutLabel.Location = new System.Drawing.Point(15, 15);
            this.lblOutLabel.Name = "lblOutLabel";
            this.lblOutLabel.Size = new System.Drawing.Size(172, 15);
            this.lblOutLabel.TabIndex = 0;
            this.lblOutLabel.Text = "Uang Keluar(Berdasarkan Filter)";
            // 
            // pnlInCard
            // 
            this.pnlInCard.BackColor = System.Drawing.Color.White;
            this.pnlInCard.Controls.Add(this.lblMoneyIn);
            this.pnlInCard.Controls.Add(this.lblInLabel);
            this.pnlInCard.Location = new System.Drawing.Point(20, 85);
            this.pnlInCard.Name = "pnlInCard";
            this.pnlInCard.Size = new System.Drawing.Size(490, 80);
            this.pnlInCard.TabIndex = 5;
            // 
            // lblMoneyIn
            // 
            this.lblMoneyIn.AutoSize = true;
            this.lblMoneyIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblMoneyIn.Location = new System.Drawing.Point(15, 35);
            this.lblMoneyIn.Name = "lblMoneyIn";
            this.lblMoneyIn.Size = new System.Drawing.Size(62, 26);
            this.lblMoneyIn.TabIndex = 1;
            this.lblMoneyIn.Text = "Rp 0";
            // 
            // lblInLabel
            // 
            this.lblInLabel.AutoSize = true;
            this.lblInLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblInLabel.Location = new System.Drawing.Point(15, 15);
            this.lblInLabel.Name = "lblInLabel";
            this.lblInLabel.Size = new System.Drawing.Size(174, 15);
            this.lblInLabel.TabIndex = 0;
            this.lblInLabel.Text = "Uang Masuk(Berdasarkan Filter)";
            // 
            // lblDifference
            // 
            this.lblDifference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblDifference.ForeColor = System.Drawing.Color.White;
            this.lblDifference.Location = new System.Drawing.Point(850, 45);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(205, 25);
            this.lblDifference.TabIndex = 4;
            this.lblDifference.Text = "Rp 0";
            this.lblDifference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDifferenceTitle
            // 
            this.lblDifferenceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDifferenceTitle.AutoSize = true;
            this.lblDifferenceTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDifferenceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblDifferenceTitle.Location = new System.Drawing.Point(850, 25);
            this.lblDifferenceTitle.Name = "lblDifferenceTitle";
            this.lblDifferenceTitle.Size = new System.Drawing.Size(142, 15);
            this.lblDifferenceTitle.TabIndex = 3;
            this.lblDifferenceTitle.Text = "Selisih(Berdasarkan Filter)";
            this.lblDifferenceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(620, 45);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(205, 25);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Rp 0";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // lblBalanceTitle
            // 
            this.lblBalanceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalanceTitle.AutoSize = true;
            this.lblBalanceTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblBalanceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblBalanceTitle.Location = new System.Drawing.Point(620, 25);
            this.lblBalanceTitle.Name = "lblBalanceTitle";
            this.lblBalanceTitle.Size = new System.Drawing.Size(66, 15);
            this.lblBalanceTitle.TabIndex = 1;
            this.lblBalanceTitle.Text = "Total Saldo";
            this.lblBalanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWalletName
            // 
            this.lblWalletName.AutoSize = true;
            this.lblWalletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblWalletName.ForeColor = System.Drawing.Color.White;
            this.lblWalletName.Location = new System.Drawing.Point(20, 30);
            this.lblWalletName.Name = "lblWalletName";
            this.lblWalletName.Size = new System.Drawing.Size(167, 29);
            this.lblWalletName.TabIndex = 0;
            this.lblWalletName.Text = "Wallet Utama";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(30, 30);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1078, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(45, 45);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(249, 15);
            this.lblHeaderSubtitle.TabIndex = 2;
            this.lblHeaderSubtitle.Text = "Informasi lengkap dan riwayat transaksi wallet";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(0, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.Location = new System.Drawing.Point(40, 5);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(179, 31);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Detail Wallet";
            // 
            // WalletDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 1061);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WalletDetailForm";
            this.Text = "Detail Wallet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlHistoryCard.ResumeLayout(false);
            this.pnlTableFooter.ResumeLayout(false);
            this.pnlTableFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.pnlHistoryHeader.ResumeLayout(false);
            this.pnlHistoryHeader.PerformLayout();
            this.pnlFilterCard.ResumeLayout(false);
            this.pnlFilterCard.PerformLayout();
            this.pnlTopCard.ResumeLayout(false);
            this.pnlTopCard.PerformLayout();
            this.pnlOutCard.ResumeLayout(false);
            this.pnlOutCard.PerformLayout();
            this.pnlInCard.ResumeLayout(false);
            this.pnlInCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private SidebarControl sidebarControl1;
        private NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlTopCard;
        private System.Windows.Forms.Label lblWalletName;
        private System.Windows.Forms.Label lblBalanceTitle;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDifferenceTitle;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.Panel pnlInCard;
        private System.Windows.Forms.Label lblInLabel;
        private System.Windows.Forms.Label lblMoneyIn;
        private System.Windows.Forms.Panel pnlOutCard;
        private System.Windows.Forms.Label lblMoneyOut;
        private System.Windows.Forms.Label lblOutLabel;
        private System.Windows.Forms.Panel pnlFilterCard;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblDariTanggal;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblSampaiTanggal;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Panel pnlHistoryCard;
        private System.Windows.Forms.Panel pnlHistoryHeader;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Panel pnlTableFooter;
        private System.Windows.Forms.Label lblIncomeSummary;
        private System.Windows.Forms.Label lblExpenseSummary;
        private System.Windows.Forms.Label lblNetSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}
