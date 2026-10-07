namespace DVLD
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.dgvUsers = new SiticoneNetFrameworkUI.SiticoneDataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsAppMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtxtInputFilter = new System.Windows.Forms.MaskedTextBox();
            this.lbRecordsValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbRecords = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dplFilterItems = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.lbFilterBy = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dplIsActive = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnAddNewUser = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(985, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(68, 68);
            this.btnClose1.TabIndex = 44;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToReorderColumns = false;
            this.dgvUsers.AllowUserToReorderRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AutoSize = true;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvUsers.CellFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUsers.HeaderFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.Location = new System.Drawing.Point(12, 280);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ShowSampleData = true;
            this.dgvUsers.SiticoneAlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.dgvUsers.SiticoneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvUsers.SiticoneCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvUsers.SiticoneDragDropTargetFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvUsers.SiticoneDragGhostAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvUsers.SiticoneDragGhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvUsers.SiticoneDragGhostBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvUsers.SiticoneDragGhostForeColor = System.Drawing.Color.White;
            this.dgvUsers.SiticoneDragGhostSecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvUsers.SiticoneEmptyStateFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvUsers.SiticoneEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvUsers.SiticoneEnableConditionalFormatting = true;
            this.dgvUsers.SiticoneGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvUsers.SiticoneHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.dgvUsers.SiticoneHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvUsers.SiticoneHeaderBottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvUsers.SiticoneHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dgvUsers.SiticoneOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvUsers.SiticoneRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvUsers.SiticoneRowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvUsers.SiticoneRowHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvUsers.SiticoneRowHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.dgvUsers.SiticoneRowSeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvUsers.SiticoneSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvUsers.SiticoneSelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.SiticoneStatusBadgeActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(88)))));
            this.dgvUsers.SiticoneStatusBadgeErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.dgvUsers.SiticoneStatusBadgeFont = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvUsers.SiticoneStatusBadgeForeColor = System.Drawing.Color.White;
            this.dgvUsers.SiticoneStatusBadgeNeutralBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dgvUsers.SiticoneStatusBadgePendingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dgvUsers.SiticoneStatusBadgeWarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.dgvUsers.SiticoneSummaryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.dgvUsers.SiticoneSummaryFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvUsers.SiticoneSummaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.dgvUsers.SiticoneThemeEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvUsers.Size = new System.Drawing.Size(1022, 261);
            this.dgvUsers.TabIndex = 45;
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
            this.sendEmailToolStripMenuItem,
            this.whatsAppMessageToolStripMenuItem});
            this.guna2ContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(253, 206);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(249, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.deleteToolStripMenuItem.Image = global::DVLD.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(249, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sendEmailToolStripMenuItem.Image = global::DVLD.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // whatsAppMessageToolStripMenuItem
            // 
            this.whatsAppMessageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.whatsAppMessageToolStripMenuItem.Image = global::DVLD.Properties.Resources.call_32;
            this.whatsAppMessageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.whatsAppMessageToolStripMenuItem.Name = "whatsAppMessageToolStripMenuItem";
            this.whatsAppMessageToolStripMenuItem.Size = new System.Drawing.Size(252, 38);
            this.whatsAppMessageToolStripMenuItem.Text = "WhatsApp Message";
            this.whatsAppMessageToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.whatsAppMessageToolStripMenuItem.Click += new System.EventHandler(this.whatsAppMessageToolStripMenuItem_Click);
            // 
            // mtxtInputFilter
            // 
            this.mtxtInputFilter.AllowPromptAsInput = false;
            this.mtxtInputFilter.BackColor = System.Drawing.Color.LightGray;
            this.mtxtInputFilter.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtInputFilter.HidePromptOnLeave = true;
            this.mtxtInputFilter.Location = new System.Drawing.Point(386, 225);
            this.mtxtInputFilter.Name = "mtxtInputFilter";
            this.mtxtInputFilter.PromptChar = ' ';
            this.mtxtInputFilter.RejectInputOnFirstFailure = true;
            this.mtxtInputFilter.Size = new System.Drawing.Size(256, 25);
            this.mtxtInputFilter.TabIndex = 53;
            this.mtxtInputFilter.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtInputFilter.ValidatingType = typeof(int);
            this.mtxtInputFilter.Visible = false;
            this.mtxtInputFilter.TextChanged += new System.EventHandler(this.mtxtInputFilter_TextChanged);
            // 
            // lbRecordsValue
            // 
            this.lbRecordsValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsValue.Location = new System.Drawing.Point(76, 554);
            this.lbRecordsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecordsValue.Name = "lbRecordsValue";
            this.lbRecordsValue.Size = new System.Drawing.Size(58, 21);
            this.lbRecordsValue.TabIndex = 52;
            this.lbRecordsValue.Text = "4";
            // 
            // lbRecords
            // 
            this.lbRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(11, 554);
            this.lbRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(70, 21);
            this.lbRecords.TabIndex = 51;
            this.lbRecords.Text = "Records: ";
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
            this.dplFilterItems.Location = new System.Drawing.Point(113, 225);
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
            this.dplFilterItems.TabIndex = 49;
            this.dplFilterItems.Text = "siticoneDropdown1";
            this.dplFilterItems.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplFilterItems.ValueMember = null;
            this.dplFilterItems.ItemSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs>(this.dplFilterItems_ItemSelected);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.Location = new System.Drawing.Point(11, 222);
            this.lbFilterBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(97, 31);
            this.lbFilterBy.TabIndex = 48;
            this.lbFilterBy.Text = "Filter By: ";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(425, 167);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(197, 39);
            this.lbTitle.TabIndex = 47;
            this.lbTitle.Text = "Manage Users";
            // 
            // dplIsActive
            // 
            this.dplIsActive.AllowMultipleSelection = false;
            this.dplIsActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dplIsActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.dplIsActive.CanBeep = false;
            this.dplIsActive.CanShake = true;
            this.dplIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dplIsActive.DataSource = null;
            this.dplIsActive.DisplayMember = null;
            this.dplIsActive.DropdownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dplIsActive.DropdownWidth = 0;
            this.dplIsActive.DropShadowEnabled = false;
            this.dplIsActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplIsActive.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dplIsActive.HoveredItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplIsActive.IsReadonly = false;
            this.dplIsActive.ItemHeight = 30;
            this.dplIsActive.Items.AddRange(new string[] {
            "All",
            "Yes",
            "No"});
            this.dplIsActive.Location = new System.Drawing.Point(386, 225);
            this.dplIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.dplIsActive.MaxDropDownItems = 8;
            this.dplIsActive.Name = "dplIsActive";
            this.dplIsActive.NotFoundBackColor = System.Drawing.Color.Transparent;
            this.dplIsActive.NotFoundFont = null;
            this.dplIsActive.NotFoundTextColor = System.Drawing.Color.Gray;
            this.dplIsActive.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.dplIsActive.PlaceholderDisappearsOnFocus = true;
            this.dplIsActive.PlaceholderText = "Select an option";
            this.dplIsActive.SearchTextBoxHeight = 20;
            this.dplIsActive.SearchTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplIsActive.SearchTextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplIsActive.SelectedIndex = 0;
            this.dplIsActive.SelectedItem = "All";
            this.dplIsActive.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.dplIsActive.SelectedItemTextColor = System.Drawing.Color.White;
            this.dplIsActive.SelectedValue = null;
            this.dplIsActive.Size = new System.Drawing.Size(198, 24);
            this.dplIsActive.TabIndex = 58;
            this.dplIsActive.Text = "siticoneDropdown1";
            this.dplIsActive.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplIsActive.ValueMember = null;
            this.dplIsActive.Visible = false;
            this.dplIsActive.ItemSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs>(this.dplIsActive_ItemSelected);
            // 
            // pbUsers
            // 
            this.pbUsers.Image = global::DVLD.Properties.Resources.Users_2_400;
            this.pbUsers.Location = new System.Drawing.Point(422, 12);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(200, 160);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsers.TabIndex = 56;
            this.pbUsers.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(916, 544);
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
            this.btnClose.TabIndex = 54;
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
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.BadgeBackColor = System.Drawing.Color.Red;
            this.btnAddNewUser.BadgeForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.BadgeRadius = 8;
            this.btnAddNewUser.BadgeRightMargin = 10;
            this.btnAddNewUser.BadgeValue = 0;
            this.btnAddNewUser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddNewUser.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnAddNewUser.BorderColorStart = System.Drawing.Color.White;
            this.btnAddNewUser.BorderRadiusBottomLeft = 20;
            this.btnAddNewUser.BorderRadiusBottomRight = 20;
            this.btnAddNewUser.BorderRadiusTopLeft = 20;
            this.btnAddNewUser.BorderRadiusTopRight = 20;
            this.btnAddNewUser.BorderThickness = 1;
            this.btnAddNewUser.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewUser.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewUser.ButtonImage = global::DVLD.Properties.Resources.Add_New_User_32;
            this.btnAddNewUser.CanBeep = false;
            this.btnAddNewUser.CanShake = false;
            this.btnAddNewUser.ClickSoundPath = null;
            this.btnAddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewUser.DisabledOverlayOpacity = 0.5F;
            this.btnAddNewUser.EnableBorderGradient = false;
            this.btnAddNewUser.EnableClickSound = false;
            this.btnAddNewUser.EnableFocusBorder = false;
            this.btnAddNewUser.EnableHoverSound = false;
            this.btnAddNewUser.EnablePressScale = false;
            this.btnAddNewUser.EnableTextShadow = false;
            this.btnAddNewUser.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddNewUser.FocusBorderThickness = 2;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewUser.HoverSoundPath = null;
            this.btnAddNewUser.HoverTransitionSpeed = 0.08F;
            this.btnAddNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewUser.ImageLeftMargin = 0;
            this.btnAddNewUser.ImageRightMargin = 0;
            this.btnAddNewUser.ImageSize = 50;
            this.btnAddNewUser.IsReadOnly = false;
            this.btnAddNewUser.Location = new System.Drawing.Point(939, 206);
            this.btnAddNewUser.MakeRadial = false;
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.PressAnimationSpeed = 0.2F;
            this.btnAddNewUser.PressDepth = 1;
            this.btnAddNewUser.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewUser.RippleExpandSpeedFactor = 0.05F;
            this.btnAddNewUser.RippleFadeSpeedFactor = 0.03F;
            this.btnAddNewUser.ShadowBlurFactor = 0.85F;
            this.btnAddNewUser.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewUser.ShadowOffsetX = 3;
            this.btnAddNewUser.ShadowOffsetY = 3;
            this.btnAddNewUser.Size = new System.Drawing.Size(78, 63);
            this.btnAddNewUser.TabIndex = 50;
            this.btnAddNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewUser.TextPaddingBottom = 0;
            this.btnAddNewUser.TextPaddingLeft = 0;
            this.btnAddNewUser.TextPaddingRight = 0;
            this.btnAddNewUser.TextPaddingTop = 0;
            this.btnAddNewUser.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewUser.TextShadowOffsetX = 1;
            this.btnAddNewUser.TextShadowOffsetY = 1;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 596);
            this.ControlBox = false;
            this.Controls.Add(this.dplIsActive);
            this.Controls.Add(this.pbUsers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.mtxtInputFilter);
            this.Controls.Add(this.lbRecordsValue);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.dplFilterItems);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnClose1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneDataGridView dgvUsers;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private System.Windows.Forms.MaskedTextBox mtxtInputFilter;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecordsValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecords;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnAddNewUser;
        private SiticoneNetFrameworkUI.SiticoneDropdown dplFilterItems;
        private SiticoneNetFrameworkUI.SiticoneLabel lbFilterBy;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsAppMessageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbUsers;
        private SiticoneNetFrameworkUI.SiticoneDropdown dplIsActive;
    }
}