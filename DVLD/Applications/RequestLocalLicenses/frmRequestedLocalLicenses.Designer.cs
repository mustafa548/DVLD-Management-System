namespace DVLD
{
    partial class frmRequestedLocalLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestedLocalLicenses));
            this.dplStatus = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.mtxtInputFilter = new System.Windows.Forms.MaskedTextBox();
            this.lbRecordsValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbRecords = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dgvRequestedLocalLicenses = new SiticoneNetFrameworkUI.SiticoneDataGridView();
            this.dplFilterItems = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.lbFilterBy = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicensefirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLocal = new System.Windows.Forms.PictureBox();
            this.pbRequestedLocalLicenses = new System.Windows.Forms.PictureBox();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnAddNewAppliction = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedLocalLicenses)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequestedLocalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // dplStatus
            // 
            this.dplStatus.AllowMultipleSelection = false;
            this.dplStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dplStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.dplStatus.CanBeep = false;
            this.dplStatus.CanShake = true;
            this.dplStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dplStatus.DataSource = null;
            this.dplStatus.DisplayMember = null;
            this.dplStatus.DropdownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dplStatus.DropdownWidth = 0;
            this.dplStatus.DropShadowEnabled = false;
            this.dplStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplStatus.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dplStatus.HoveredItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplStatus.IsReadonly = false;
            this.dplStatus.ItemHeight = 30;
            this.dplStatus.Items.AddRange(new string[] {
            "All",
            "New",
            "Canceled",
            "Completed"});
            this.dplStatus.Location = new System.Drawing.Point(375, 238);
            this.dplStatus.Margin = new System.Windows.Forms.Padding(2);
            this.dplStatus.MaxDropDownItems = 8;
            this.dplStatus.Name = "dplStatus";
            this.dplStatus.NotFoundBackColor = System.Drawing.Color.Transparent;
            this.dplStatus.NotFoundFont = null;
            this.dplStatus.NotFoundTextColor = System.Drawing.Color.Gray;
            this.dplStatus.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.dplStatus.PlaceholderDisappearsOnFocus = true;
            this.dplStatus.PlaceholderText = "Select an option";
            this.dplStatus.SearchTextBoxHeight = 20;
            this.dplStatus.SearchTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplStatus.SearchTextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplStatus.SelectedIndex = 0;
            this.dplStatus.SelectedItem = "All";
            this.dplStatus.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.dplStatus.SelectedItemTextColor = System.Drawing.Color.White;
            this.dplStatus.SelectedValue = null;
            this.dplStatus.Size = new System.Drawing.Size(198, 24);
            this.dplStatus.TabIndex = 71;
            this.dplStatus.Text = "siticoneDropdown1";
            this.dplStatus.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplStatus.ValueMember = null;
            this.dplStatus.Visible = false;
            this.dplStatus.ItemSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs>(this.dplStatus_ItemSelected);
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(984, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(29, 29);
            this.btnClose1.TabIndex = 68;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // mtxtInputFilter
            // 
            this.mtxtInputFilter.AllowPromptAsInput = false;
            this.mtxtInputFilter.BackColor = System.Drawing.Color.LightGray;
            this.mtxtInputFilter.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtInputFilter.HidePromptOnLeave = true;
            this.mtxtInputFilter.Location = new System.Drawing.Point(375, 238);
            this.mtxtInputFilter.Name = "mtxtInputFilter";
            this.mtxtInputFilter.PromptChar = ' ';
            this.mtxtInputFilter.RejectInputOnFirstFailure = true;
            this.mtxtInputFilter.Size = new System.Drawing.Size(256, 25);
            this.mtxtInputFilter.TabIndex = 67;
            this.mtxtInputFilter.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtInputFilter.ValidatingType = typeof(int);
            this.mtxtInputFilter.Visible = false;
            this.mtxtInputFilter.TextChanged += new System.EventHandler(this.mtxtInputFilter_TextChanged);
            // 
            // lbRecordsValue
            // 
            this.lbRecordsValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsValue.Location = new System.Drawing.Point(85, 577);
            this.lbRecordsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecordsValue.Name = "lbRecordsValue";
            this.lbRecordsValue.Size = new System.Drawing.Size(58, 21);
            this.lbRecordsValue.TabIndex = 66;
            this.lbRecordsValue.Text = "4";
            // 
            // lbRecords
            // 
            this.lbRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(11, 577);
            this.lbRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(70, 21);
            this.lbRecords.TabIndex = 65;
            this.lbRecords.Text = "Records: ";
            // 
            // dgvRequestedLocalLicenses
            // 
            this.dgvRequestedLocalLicenses.AllowUserToReorderColumns = false;
            this.dgvRequestedLocalLicenses.AllowUserToReorderRows = false;
            this.dgvRequestedLocalLicenses.AllowUserToResizeColumns = false;
            this.dgvRequestedLocalLicenses.AutoSize = true;
            this.dgvRequestedLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvRequestedLocalLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvRequestedLocalLicenses.CellFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvRequestedLocalLicenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRequestedLocalLicenses.HeaderFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvRequestedLocalLicenses.Location = new System.Drawing.Point(1, 291);
            this.dgvRequestedLocalLicenses.Name = "dgvRequestedLocalLicenses";
            this.dgvRequestedLocalLicenses.ShowSampleData = true;
            this.dgvRequestedLocalLicenses.SiticoneAlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.dgvRequestedLocalLicenses.SiticoneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvRequestedLocalLicenses.SiticoneCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvRequestedLocalLicenses.SiticoneDragDropTargetFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvRequestedLocalLicenses.SiticoneDragGhostAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvRequestedLocalLicenses.SiticoneDragGhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvRequestedLocalLicenses.SiticoneDragGhostBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvRequestedLocalLicenses.SiticoneDragGhostForeColor = System.Drawing.Color.White;
            this.dgvRequestedLocalLicenses.SiticoneDragGhostSecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvRequestedLocalLicenses.SiticoneEmptyStateFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvRequestedLocalLicenses.SiticoneEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvRequestedLocalLicenses.SiticoneGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvRequestedLocalLicenses.SiticoneHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.dgvRequestedLocalLicenses.SiticoneHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvRequestedLocalLicenses.SiticoneHeaderBottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvRequestedLocalLicenses.SiticoneHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dgvRequestedLocalLicenses.SiticoneOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvRequestedLocalLicenses.SiticoneRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvRequestedLocalLicenses.SiticoneRowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvRequestedLocalLicenses.SiticoneRowHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvRequestedLocalLicenses.SiticoneRowHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.dgvRequestedLocalLicenses.SiticoneRowSeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvRequestedLocalLicenses.SiticoneSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvRequestedLocalLicenses.SiticoneSelectionForeColor = System.Drawing.Color.White;
            this.dgvRequestedLocalLicenses.SiticoneStatusBadgeActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(88)))));
            this.dgvRequestedLocalLicenses.SiticoneStatusBadgeErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.dgvRequestedLocalLicenses.SiticoneStatusBadgeFont = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvRequestedLocalLicenses.SiticoneStatusBadgeForeColor = System.Drawing.Color.White;
            this.dgvRequestedLocalLicenses.SiticoneStatusBadgeNeutralBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dgvRequestedLocalLicenses.SiticoneStatusBadgePendingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dgvRequestedLocalLicenses.SiticoneStatusBadgeWarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.dgvRequestedLocalLicenses.SiticoneSummaryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.dgvRequestedLocalLicenses.SiticoneSummaryFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvRequestedLocalLicenses.SiticoneSummaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.dgvRequestedLocalLicenses.SiticoneThemeEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvRequestedLocalLicenses.Size = new System.Drawing.Size(1025, 261);
            this.dgvRequestedLocalLicenses.TabIndex = 64;
            // 
            // dplFilterItems
            // 
            this.dplFilterItems.AllowMultipleSelection = false;
            this.dplFilterItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dplFilterItems.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.dplFilterItems.CanBeep = false;
            this.dplFilterItems.CanShake = true;
            this.dplFilterItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dplFilterItems.DataSource = null;
            this.dplFilterItems.DisplayMember = null;
            this.dplFilterItems.DropdownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dplFilterItems.DropdownWidth = 0;
            this.dplFilterItems.DropShadowEnabled = false;
            this.dplFilterItems.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplFilterItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplFilterItems.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dplFilterItems.HoveredItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplFilterItems.IsReadonly = false;
            this.dplFilterItems.ItemHeight = 30;
            this.dplFilterItems.Items.AddRange(new string[] {
            "None"});
            this.dplFilterItems.Location = new System.Drawing.Point(112, 238);
            this.dplFilterItems.Margin = new System.Windows.Forms.Padding(2);
            this.dplFilterItems.MaxDropDownItems = 8;
            this.dplFilterItems.Name = "dplFilterItems";
            this.dplFilterItems.NotFoundBackColor = System.Drawing.Color.Transparent;
            this.dplFilterItems.NotFoundFont = null;
            this.dplFilterItems.NotFoundTextColor = System.Drawing.Color.Gray;
            this.dplFilterItems.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.dplFilterItems.PlaceholderDisappearsOnFocus = true;
            this.dplFilterItems.PlaceholderText = "Select an option";
            this.dplFilterItems.SearchTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplFilterItems.SearchTextFont = null;
            this.dplFilterItems.SelectedIndex = 0;
            this.dplFilterItems.SelectedItem = "None";
            this.dplFilterItems.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.dplFilterItems.SelectedItemTextColor = System.Drawing.Color.White;
            this.dplFilterItems.SelectedValue = null;
            this.dplFilterItems.Size = new System.Drawing.Size(258, 24);
            this.dplFilterItems.TabIndex = 62;
            this.dplFilterItems.Text = "siticoneDropdown1";
            this.dplFilterItems.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplFilterItems.ValueMember = null;
            this.dplFilterItems.ItemSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs>(this.dplFilterItems_ItemSelected);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.Location = new System.Drawing.Point(11, 235);
            this.lbFilterBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(97, 31);
            this.lbFilterBy.TabIndex = 61;
            this.lbFilterBy.Text = "Filter By: ";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(223, 170);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(593, 39);
            this.lbTitle.TabIndex = 60;
            this.lbTitle.Text = "Requested Local Driving Licenses Applications";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cancelApplicationToolStripMenuItem,
            this.callPhoneToolStripMenuItem,
            this.scheduleTestsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.issueDrivingLicensefirstTimeToolStripMenuItem,
            this.toolStripMenuItem4,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showPersonToolStripMenuItem});
            this.guna2ContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(359, 344);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(358, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.showDetailsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(355, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(358, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32_2;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(358, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(355, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.cancelApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_321;
            this.cancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(358, 38);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // callPhoneToolStripMenuItem
            // 
            this.callPhoneToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            this.callPhoneToolStripMenuItem.Size = new System.Drawing.Size(355, 6);
            // 
            // scheduleTestsToolStripMenuItem
            // 
            this.scheduleTestsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.scheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.drivingTestToolStripMenuItem});
            this.scheduleTestsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.scheduleTestsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Schedule_Test_32;
            this.scheduleTestsToolStripMenuItem.Name = "scheduleTestsToolStripMenuItem";
            this.scheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(358, 38);
            this.scheduleTestsToolStripMenuItem.Text = "Schedule Tests";
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.visionTestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.visionTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Vision_Test_32;
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.visionTestToolStripMenuItem.Text = "Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // writtenTestToolStripMenuItem
            // 
            this.writtenTestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.writtenTestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.writtenTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Written_Test_32;
            this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            this.writtenTestToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.writtenTestToolStripMenuItem.Text = "Written  Test";
            this.writtenTestToolStripMenuItem.Click += new System.EventHandler(this.writtenTestToolStripMenuItem_Click);
            // 
            // drivingTestToolStripMenuItem
            // 
            this.drivingTestToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.drivingTestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.drivingTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Street_Test_32;
            this.drivingTestToolStripMenuItem.Name = "drivingTestToolStripMenuItem";
            this.drivingTestToolStripMenuItem.Size = new System.Drawing.Size(200, 38);
            this.drivingTestToolStripMenuItem.Text = "Driving Test";
            this.drivingTestToolStripMenuItem.Click += new System.EventHandler(this.drivingTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(355, 6);
            // 
            // issueDrivingLicensefirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicensefirstTimeToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.issueDrivingLicensefirstTimeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Name = "issueDrivingLicensefirstTimeToolStripMenuItem";
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Size = new System.Drawing.Size(358, 38);
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicensefirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicensefirstTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(355, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.showLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.LocalDriving_License;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(358, 38);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(355, 6);
            // 
            // showPersonToolStripMenuItem
            // 
            this.showPersonToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.showPersonToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showPersonToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            this.showPersonToolStripMenuItem.Size = new System.Drawing.Size(358, 38);
            this.showPersonToolStripMenuItem.Text = "Show Person License History";
            this.showPersonToolStripMenuItem.Click += new System.EventHandler(this.showPersonToolStripMenuItem_Click);
            // 
            // pbLocal
            // 
            this.pbLocal.Image = global::DVLD.Properties.Resources.Local_32;
            this.pbLocal.Location = new System.Drawing.Point(592, 64);
            this.pbLocal.Name = "pbLocal";
            this.pbLocal.Size = new System.Drawing.Size(50, 47);
            this.pbLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLocal.TabIndex = 75;
            this.pbLocal.TabStop = false;
            // 
            // pbRequestedLocalLicenses
            // 
            this.pbRequestedLocalLicenses.Image = global::DVLD.Properties.Resources.Manage_Applications_64;
            this.pbRequestedLocalLicenses.Location = new System.Drawing.Point(386, 7);
            this.pbRequestedLocalLicenses.Name = "pbRequestedLocalLicenses";
            this.pbRequestedLocalLicenses.Size = new System.Drawing.Size(200, 160);
            this.pbRequestedLocalLicenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRequestedLocalLicenses.TabIndex = 70;
            this.pbRequestedLocalLicenses.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BadgeBackColor = System.Drawing.Color.Red;
            this.btnClose.BadgeForeColor = System.Drawing.Color.White;
            this.btnClose.BadgeRadius = 8;
            this.btnClose.BadgeRightMargin = 10;
            this.btnClose.BadgeValue = 0;
            this.btnClose.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnClose.BorderColorStart = System.Drawing.Color.White;
            this.btnClose.BorderRadiusBottomLeft = 10;
            this.btnClose.BorderRadiusBottomRight = 10;
            this.btnClose.BorderRadiusTopLeft = 10;
            this.btnClose.BorderRadiusTopRight = 10;
            this.btnClose.BorderThickness = 1;
            this.btnClose.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnClose.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnClose.ButtonImage = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.CanBeep = false;
            this.btnClose.CanShake = false;
            this.btnClose.ClickSoundPath = null;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledOverlayOpacity = 0.5F;
            this.btnClose.EnableBorderGradient = false;
            this.btnClose.EnableClickSound = false;
            this.btnClose.EnableFocusBorder = false;
            this.btnClose.EnableHoverSound = false;
            this.btnClose.EnablePressScale = false;
            this.btnClose.EnableTextShadow = false;
            this.btnClose.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClose.FocusBorderThickness = 2;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnClose.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnClose.HoverSoundPath = null;
            this.btnClose.HoverTransitionSpeed = 0.08F;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageLeftMargin = 0;
            this.btnClose.ImageRightMargin = 3;
            this.btnClose.ImageSize = 25;
            this.btnClose.IsReadOnly = false;
            this.btnClose.Location = new System.Drawing.Point(895, 567);
            this.btnClose.MakeRadial = false;
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressAnimationSpeed = 0.2F;
            this.btnClose.PressDepth = 1;
            this.btnClose.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.RippleExpandSpeedFactor = 0.05F;
            this.btnClose.RippleFadeSpeedFactor = 0.03F;
            this.btnClose.ShadowBlurFactor = 0.85F;
            this.btnClose.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.ShadowOffsetX = 3;
            this.btnClose.ShadowOffsetY = 3;
            this.btnClose.Size = new System.Drawing.Size(118, 41);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextPaddingBottom = 0;
            this.btnClose.TextPaddingLeft = 15;
            this.btnClose.TextPaddingRight = 0;
            this.btnClose.TextPaddingTop = 0;
            this.btnClose.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.TextShadowOffsetX = 1;
            this.btnClose.TextShadowOffsetY = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewAppliction
            // 
            this.btnAddNewAppliction.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewAppliction.BadgeBackColor = System.Drawing.Color.Red;
            this.btnAddNewAppliction.BadgeForeColor = System.Drawing.Color.White;
            this.btnAddNewAppliction.BadgeRadius = 8;
            this.btnAddNewAppliction.BadgeRightMargin = 10;
            this.btnAddNewAppliction.BadgeValue = 0;
            this.btnAddNewAppliction.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddNewAppliction.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnAddNewAppliction.BorderColorStart = System.Drawing.Color.White;
            this.btnAddNewAppliction.BorderRadiusBottomLeft = 20;
            this.btnAddNewAppliction.BorderRadiusBottomRight = 20;
            this.btnAddNewAppliction.BorderRadiusTopLeft = 20;
            this.btnAddNewAppliction.BorderRadiusTopRight = 20;
            this.btnAddNewAppliction.BorderThickness = 1;
            this.btnAddNewAppliction.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewAppliction.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewAppliction.ButtonImage = global::DVLD.Properties.Resources.New_Application_64;
            this.btnAddNewAppliction.CanBeep = false;
            this.btnAddNewAppliction.CanShake = false;
            this.btnAddNewAppliction.ClickSoundPath = null;
            this.btnAddNewAppliction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewAppliction.DisabledOverlayOpacity = 0.5F;
            this.btnAddNewAppliction.EnableBorderGradient = false;
            this.btnAddNewAppliction.EnableClickSound = false;
            this.btnAddNewAppliction.EnableFocusBorder = false;
            this.btnAddNewAppliction.EnableHoverSound = false;
            this.btnAddNewAppliction.EnablePressScale = false;
            this.btnAddNewAppliction.EnableTextShadow = false;
            this.btnAddNewAppliction.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddNewAppliction.FocusBorderThickness = 2;
            this.btnAddNewAppliction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAppliction.ForeColor = System.Drawing.Color.White;
            this.btnAddNewAppliction.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewAppliction.HoverSoundPath = null;
            this.btnAddNewAppliction.HoverTransitionSpeed = 0.08F;
            this.btnAddNewAppliction.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewAppliction.ImageLeftMargin = 0;
            this.btnAddNewAppliction.ImageRightMargin = 0;
            this.btnAddNewAppliction.ImageSize = 50;
            this.btnAddNewAppliction.IsReadOnly = false;
            this.btnAddNewAppliction.Location = new System.Drawing.Point(945, 223);
            this.btnAddNewAppliction.MakeRadial = false;
            this.btnAddNewAppliction.Name = "btnAddNewAppliction";
            this.btnAddNewAppliction.PressAnimationSpeed = 0.2F;
            this.btnAddNewAppliction.PressDepth = 1;
            this.btnAddNewAppliction.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewAppliction.RippleExpandSpeedFactor = 0.05F;
            this.btnAddNewAppliction.RippleFadeSpeedFactor = 0.03F;
            this.btnAddNewAppliction.ShadowBlurFactor = 0.85F;
            this.btnAddNewAppliction.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewAppliction.ShadowOffsetX = 3;
            this.btnAddNewAppliction.ShadowOffsetY = 3;
            this.btnAddNewAppliction.Size = new System.Drawing.Size(68, 54);
            this.btnAddNewAppliction.TabIndex = 63;
            this.btnAddNewAppliction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewAppliction.TextPaddingBottom = 0;
            this.btnAddNewAppliction.TextPaddingLeft = 0;
            this.btnAddNewAppliction.TextPaddingRight = 0;
            this.btnAddNewAppliction.TextPaddingTop = 0;
            this.btnAddNewAppliction.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewAppliction.TextShadowOffsetX = 1;
            this.btnAddNewAppliction.TextShadowOffsetY = 1;
            this.btnAddNewAppliction.Click += new System.EventHandler(this.btnAddNewAppliction_Click);
            // 
            // frmRequestedLocalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 617);
            this.ControlBox = false;
            this.Controls.Add(this.pbLocal);
            this.Controls.Add(this.dplStatus);
            this.Controls.Add(this.pbRequestedLocalLicenses);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.mtxtInputFilter);
            this.Controls.Add(this.lbRecordsValue);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvRequestedLocalLicenses);
            this.Controls.Add(this.btnAddNewAppliction);
            this.Controls.Add(this.dplFilterItems);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRequestedLocalLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requested Local Licenses";
            this.Load += new System.EventHandler(this.frmRequestedLocalLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedLocalLicenses)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequestedLocalLicenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneDropdown dplStatus;
        private System.Windows.Forms.PictureBox pbRequestedLocalLicenses;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private System.Windows.Forms.MaskedTextBox mtxtInputFilter;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecordsValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecords;
        private SiticoneNetFrameworkUI.SiticoneDataGridView dgvRequestedLocalLicenses;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnAddNewAppliction;
        private SiticoneNetFrameworkUI.SiticoneDropdown dplFilterItems;
        private SiticoneNetFrameworkUI.SiticoneLabel lbFilterBy;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private System.Windows.Forms.PictureBox pbLocal;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator callPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicensefirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingTestToolStripMenuItem;
    }
}