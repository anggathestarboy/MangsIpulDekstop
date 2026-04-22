using System.Drawing;
using System.Windows.Forms;

namespace MangsIpulAsli
{
    partial class WalletHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sidebarControl1 = new MangsIpulAsli.SidebarControl();
            this.navbarControl1 = new MangsIpulAsli.NavbarControl();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHistoryCard = new System.Windows.Forms.Panel();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.pnlHistoryHeader = new System.Windows.Forms.Panel();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.lblHistorySubtitle = new System.Windows.Forms.Label();
            this.pnlSummaryCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTotalCard = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.pbTotalIcon = new System.Windows.Forms.PictureBox();
            this.pnlIncomeCard = new System.Windows.Forms.Panel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblIncomeLabel = new System.Windows.Forms.Label();
            this.pbIncomeIcon = new System.Windows.Forms.PictureBox();
            this.pnlExpenseCard = new System.Windows.Forms.Panel();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblExpenseLabel = new System.Windows.Forms.Label();
            this.pbExpenseIcon = new System.Windows.Forms.PictureBox();
            this.pnlFilterCard = new System.Windows.Forms.Panel();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblSampai = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblDari = new System.Windows.Forms.Label();
            this.cmbTypeFilter = new System.Windows.Forms.ComboBox();
            this.lblTipeFilter = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlHistoryCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.pnlHistoryHeader.SuspendLayout();
            this.pnlSummaryCards.SuspendLayout();
            this.pnlTotalCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalIcon)).BeginInit();
            this.pnlIncomeCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncomeIcon)).BeginInit();
            this.pnlExpenseCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpenseIcon)).BeginInit();
            this.pnlFilterCard.SuspendLayout();
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
            this.pnlContent.Controls.Add(this.pnlSummaryCards);
            this.pnlContent.Controls.Add(this.pnlFilterCard);
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
            this.pnlHistoryCard.Controls.Add(this.dgvHistory);
            this.pnlHistoryCard.Controls.Add(this.pnlHistoryHeader);
            this.pnlHistoryCard.Location = new System.Drawing.Point(0, 380);
            this.pnlHistoryCard.Name = "pnlHistoryCard";
            this.pnlHistoryCard.Size = new System.Drawing.Size(1078, 600);
            this.pnlHistoryCard.TabIndex = 2;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistory.ColumnHeadersHeight = 50;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colWallet,
            this.colCategory,
            this.colDescription,
            this.colAmount,
            this.colType,
            this.colAction});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.EnableHeadersVisualStyles = false;
            this.dgvHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dgvHistory.Location = new System.Drawing.Point(0, 80);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowTemplate.Height = 50;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(1076, 518);
            this.dgvHistory.TabIndex = 1;
            // 
            // pnlHistoryHeader
            // 
            this.pnlHistoryHeader.Controls.Add(this.lblHistorySubtitle);
            this.pnlHistoryHeader.Controls.Add(this.lblHistoryTitle);
            this.pnlHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHistoryHeader.Name = "pnlHistoryHeader";
            this.pnlHistoryHeader.Size = new System.Drawing.Size(1076, 80);
            this.pnlHistoryHeader.TabIndex = 0;
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lblHistoryTitle.Location = new System.Drawing.Point(20, 20);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(147, 21);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "Riwayat Transaksi";
            // 
            // lblHistorySubtitle
            // 
            this.lblHistorySubtitle.AutoSize = true;
            this.lblHistorySubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHistorySubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblHistorySubtitle.Location = new System.Drawing.Point(20, 45);
            this.lblHistorySubtitle.Name = "lblHistorySubtitle";
            this.lblHistorySubtitle.Size = new System.Drawing.Size(161, 15);
            this.lblHistorySubtitle.TabIndex = 1;
            this.lblHistorySubtitle.Text = "Klik transaksi untuk lihat detail";
            // 
            // pnlSummaryCards
            // 
            this.pnlSummaryCards.Controls.Add(this.pnlTotalCard);
            this.pnlSummaryCards.Controls.Add(this.pnlIncomeCard);
            this.pnlSummaryCards.Controls.Add(this.pnlExpenseCard);
            this.pnlSummaryCards.Location = new System.Drawing.Point(0, 250);
            this.pnlSummaryCards.Name = "pnlSummaryCards";
            this.pnlSummaryCards.Size = new System.Drawing.Size(1078, 110);
            this.pnlSummaryCards.TabIndex = 1;
            // 
            // pnlTotalCard
            // 
            this.pnlTotalCard.BackColor = System.Drawing.Color.White;
            this.pnlTotalCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalCard.Controls.Add(this.lblTotalCount);
            this.pnlTotalCard.Controls.Add(this.lblTotalLabel);
            this.pnlTotalCard.Controls.Add(this.pbTotalIcon);
            this.pnlTotalCard.Location = new System.Drawing.Point(3, 3);
            this.pnlTotalCard.Name = "pnlTotalCard";
            this.pnlTotalCard.Size = new System.Drawing.Size(350, 100);
            this.pnlTotalCard.TabIndex = 0;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI Bold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.Location = new System.Drawing.Point(85, 45);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(26, 30);
            this.lblTotalCount.TabIndex = 2;
            this.lblTotalCount.Text = "0";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTotalLabel.Location = new System.Drawing.Point(85, 25);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(32, 15);
            this.lblTotalLabel.TabIndex = 1;
            this.lblTotalLabel.Text = "Total";
            // 
            // pbTotalIcon
            // 
            this.pbTotalIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pbTotalIcon.ImageLocation = "https://img.icons8.com/ios-filled/50/2563eb/wallet.png";
            this.pbTotalIcon.Location = new System.Drawing.Point(20, 25);
            this.pbTotalIcon.Name = "pbTotalIcon";
            this.pbTotalIcon.Size = new System.Drawing.Size(50, 50);
            this.pbTotalIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTotalIcon.TabIndex = 0;
            this.pbTotalIcon.TabStop = false;
            // 
            // pnlIncomeCard
            // 
            this.pnlIncomeCard.BackColor = System.Drawing.Color.White;
            this.pnlIncomeCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIncomeCard.Controls.Add(this.lblTotalIncome);
            this.pnlIncomeCard.Controls.Add(this.lblIncomeLabel);
            this.pnlIncomeCard.Controls.Add(this.pbIncomeIcon);
            this.pnlIncomeCard.Location = new System.Drawing.Point(359, 3);
            this.pnlIncomeCard.Name = "pnlIncomeCard";
            this.pnlIncomeCard.Size = new System.Drawing.Size(350, 100);
            this.pnlIncomeCard.TabIndex = 1;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI Bold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblTotalIncome.Location = new System.Drawing.Point(85, 45);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(62, 30);
            this.lblTotalIncome.TabIndex = 2;
            this.lblTotalIncome.Text = "Rp 0";
            // 
            // lblIncomeLabel
            // 
            this.lblIncomeLabel.AutoSize = true;
            this.lblIncomeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIncomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblIncomeLabel.Location = new System.Drawing.Point(85, 25);
            this.lblIncomeLabel.Name = "lblIncomeLabel";
            this.lblIncomeLabel.Size = new System.Drawing.Size(46, 15);
            this.lblIncomeLabel.TabIndex = 1;
            this.lblIncomeLabel.Text = "Income";
            // 
            // pbIncomeIcon
            // 
            this.pbIncomeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.pbIncomeIcon.ImageLocation = "https://img.icons8.com/ios-filled/50/16a34a/long-arrow-up.png";
            this.pbIncomeIcon.Location = new System.Drawing.Point(20, 25);
            this.pbIncomeIcon.Name = "pbIncomeIcon";
            this.pbIncomeIcon.Size = new System.Drawing.Size(50, 50);
            this.pbIncomeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIncomeIcon.TabIndex = 0;
            this.pbIncomeIcon.TabStop = false;
            // 
            // pnlExpenseCard
            // 
            this.pnlExpenseCard.BackColor = System.Drawing.Color.White;
            this.pnlExpenseCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExpenseCard.Controls.Add(this.lblTotalExpense);
            this.pnlExpenseCard.Controls.Add(this.lblExpenseLabel);
            this.pnlExpenseCard.Controls.Add(this.pbExpenseIcon);
            this.pnlExpenseCard.Location = new System.Drawing.Point(715, 3);
            this.pnlExpenseCard.Name = "pnlExpenseCard";
            this.pnlExpenseCard.Size = new System.Drawing.Size(350, 100);
            this.pnlExpenseCard.TabIndex = 2;
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Segoe UI Bold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblTotalExpense.Location = new System.Drawing.Point(85, 45);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(62, 30);
            this.lblTotalExpense.TabIndex = 2;
            this.lblTotalExpense.Text = "Rp 0";
            // 
            // lblExpenseLabel
            // 
            this.lblExpenseLabel.AutoSize = true;
            this.lblExpenseLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExpenseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblExpenseLabel.Location = new System.Drawing.Point(85, 25);
            this.lblExpenseLabel.Name = "lblExpenseLabel";
            this.lblExpenseLabel.Size = new System.Drawing.Size(50, 15);
            this.lblExpenseLabel.TabIndex = 1;
            this.lblExpenseLabel.Text = "Expense";
            // 
            // pbExpenseIcon
            // 
            this.pbExpenseIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pbExpenseIcon.ImageLocation = "https://img.icons8.com/ios-filled/50/dc2626/long-arrow-down.png";
            this.pbExpenseIcon.Location = new System.Drawing.Point(20, 25);
            this.pbExpenseIcon.Name = "pbExpenseIcon";
            this.pbExpenseIcon.Size = new System.Drawing.Size(50, 50);
            this.pbExpenseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbExpenseIcon.TabIndex = 0;
            this.pbExpenseIcon.TabStop = false;
            // 
            // pnlFilterCard
            // 
            this.pnlFilterCard.BackColor = System.Drawing.Color.White;
            this.pnlFilterCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterCard.Controls.Add(this.btnApplyFilter);
            this.pnlFilterCard.Controls.Add(this.dtpEnd);
            this.pnlFilterCard.Controls.Add(this.lblSampai);
            this.pnlFilterCard.Controls.Add(this.dtpStart);
            this.pnlFilterCard.Controls.Add(this.lblDari);
            this.pnlFilterCard.Controls.Add(this.cmbTypeFilter);
            this.pnlFilterCard.Controls.Add(this.lblTipeFilter);
            this.pnlFilterCard.Controls.Add(this.lblFilterTitle);
            this.pnlFilterCard.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterCard.Name = "pnlFilterCard";
            this.pnlFilterCard.Size = new System.Drawing.Size(1078, 230);
            this.pnlFilterCard.TabIndex = 0;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI Bold", 10F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Location = new System.Drawing.Point(20, 165);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(1035, 45);
            this.btnApplyFilter.TabIndex = 7;
            this.btnApplyFilter.Text = "🔄 Terapkan Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(545, 125);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(510, 27);
            this.dtpEnd.TabIndex = 6;
            // 
            // lblSampai
            // 
            this.lblSampai.AutoSize = true;
            this.lblSampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSampai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblSampai.Location = new System.Drawing.Point(545, 105);
            this.lblSampai.Name = "lblSampai";
            this.lblSampai.Size = new System.Drawing.Size(46, 15);
            this.lblSampai.TabIndex = 5;
            this.lblSampai.Text = "Sampai";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(20, 125);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(510, 27);
            this.dtpStart.TabIndex = 4;
            // 
            // lblDari
            // 
            this.lblDari.AutoSize = true;
            this.lblDari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblDari.Location = new System.Drawing.Point(20, 105);
            this.lblDari.Name = "lblDari";
            this.lblDari.Size = new System.Drawing.Size(28, 15);
            this.lblDari.TabIndex = 3;
            this.lblDari.Text = "Dari";
            // 
            // cmbTypeFilter
            // 
            this.cmbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeFilter.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbTypeFilter.FormattingEnabled = true;
            this.cmbTypeFilter.Items.AddRange(new object[] {
            "Semua",
            "income",
            "expense"});
            this.cmbTypeFilter.Location = new System.Drawing.Point(20, 65);
            this.cmbTypeFilter.Name = "cmbTypeFilter";
            this.cmbTypeFilter.Size = new System.Drawing.Size(1035, 28);
            this.cmbTypeFilter.TabIndex = 2;
            // 
            // lblTipeFilter
            // 
            this.lblTipeFilter.AutoSize = true;
            this.lblTipeFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTipeFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTipeFilter.Location = new System.Drawing.Point(20, 45);
            this.lblTipeFilter.Name = "lblTipeFilter";
            this.lblTipeFilter.Size = new System.Drawing.Size(29, 15);
            this.lblTipeFilter.TabIndex = 1;
            this.lblTipeFilter.Text = "Tipe";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI Bold", 11F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblFilterTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(130, 20);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "📅 Filter Transaksi";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
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
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(5, 40);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(258, 19);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Kelola dan lihat semua transaksi keuangan Anda";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Bold", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(217, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Daftar Transaksi";
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Tanggal";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colWallet
            // 
            this.colWallet.HeaderText = "Dompet";
            this.colWallet.Name = "colWallet";
            this.colWallet.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Kategori";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Deskripsi";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Jumlah";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.HeaderText = "Tipe";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Text = "Hapus";
            this.colAction.UseColumnTextForButtonValue = true;
            // 
            // WalletHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 1061);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.navbarControl1);
            this.Controls.Add(this.sidebarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WalletHistoryForm";
            this.Text = "Riwayat Wallet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlHistoryCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.pnlHistoryHeader.ResumeLayout(false);
            this.pnlHistoryHeader.PerformLayout();
            this.pnlSummaryCards.ResumeLayout(false);
            this.pnlTotalCard.ResumeLayout(false);
            this.pnlTotalCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTotalIcon)).EndInit();
            this.pnlIncomeCard.ResumeLayout(false);
            this.pnlIncomeCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncomeIcon)).EndInit();
            this.pnlExpenseCard.ResumeLayout(false);
            this.pnlExpenseCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpenseIcon)).EndInit();
            this.pnlFilterCard.ResumeLayout(false);
            this.pnlFilterCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        private SidebarControl sidebarControl1;
        private NavbarControl navbarControl1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlFilterCard;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblTipeFilter;
        private System.Windows.Forms.ComboBox cmbTypeFilter;
        private System.Windows.Forms.Label lblDari;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblSampai;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.FlowLayoutPanel pnlSummaryCards;
        private System.Windows.Forms.Panel pnlTotalCard;
        private System.Windows.Forms.PictureBox pbTotalIcon;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Panel pnlIncomeCard;
        private System.Windows.Forms.PictureBox pbIncomeIcon;
        private System.Windows.Forms.Label lblIncomeLabel;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Panel pnlExpenseCard;
        private System.Windows.Forms.PictureBox pbExpenseIcon;
        private System.Windows.Forms.Label lblExpenseLabel;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Panel pnlHistoryCard;
        private System.Windows.Forms.Panel pnlHistoryHeader;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Label lblHistorySubtitle;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}
