namespace DVLD
{
    partial class frmDetainedLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainedLicenses));
            this.dplIsRealised = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.mtxtInputFilter = new System.Windows.Forms.MaskedTextBox();
            this.lbRecordsValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbRecords = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dgvDetainedLicenses = new SiticoneNetFrameworkUI.SiticoneDataGridView();
            this.dplFilterItems = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.lbFilterBy = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.btnRealiseDetainedLicense = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.pbDetainedLicenses = new System.Windows.Forms.PictureBox();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnDetainLicense = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.realiseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetainedLicenses)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dplIsRealised
            // 
            this.dplIsRealised.AllowMultipleSelection = false;
            this.dplIsRealised.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dplIsRealised.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.dplIsRealised.CanBeep = false;
            this.dplIsRealised.CanShake = true;
            this.dplIsRealised.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dplIsRealised.DataSource = null;
            this.dplIsRealised.DisplayMember = null;
            this.dplIsRealised.DropdownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dplIsRealised.DropdownWidth = 0;
            this.dplIsRealised.DropShadowEnabled = false;
            this.dplIsRealised.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplIsRealised.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplIsRealised.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dplIsRealised.HoveredItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplIsRealised.IsReadonly = false;
            this.dplIsRealised.ItemHeight = 30;
            this.dplIsRealised.Items.AddRange(new string[] {
            "All",
            "Yes",
            "No"});
            this.dplIsRealised.Location = new System.Drawing.Point(392, 236);
            this.dplIsRealised.Margin = new System.Windows.Forms.Padding(2);
            this.dplIsRealised.MaxDropDownItems = 8;
            this.dplIsRealised.Name = "dplIsRealised";
            this.dplIsRealised.NotFoundBackColor = System.Drawing.Color.Transparent;
            this.dplIsRealised.NotFoundFont = null;
            this.dplIsRealised.NotFoundTextColor = System.Drawing.Color.Gray;
            this.dplIsRealised.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.dplIsRealised.PlaceholderDisappearsOnFocus = true;
            this.dplIsRealised.PlaceholderText = "Select an option";
            this.dplIsRealised.SearchTextBoxHeight = 20;
            this.dplIsRealised.SearchTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplIsRealised.SearchTextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplIsRealised.SelectedIndex = 0;
            this.dplIsRealised.SelectedItem = "All";
            this.dplIsRealised.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.dplIsRealised.SelectedItemTextColor = System.Drawing.Color.White;
            this.dplIsRealised.SelectedValue = null;
            this.dplIsRealised.Size = new System.Drawing.Size(198, 24);
            this.dplIsRealised.TabIndex = 71;
            this.dplIsRealised.Text = "siticoneDropdown1";
            this.dplIsRealised.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplIsRealised.ValueMember = null;
            this.dplIsRealised.Visible = false;
            this.dplIsRealised.ItemSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs>(this.dplIsRealised_ItemSelected);
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(1038, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(35, 35);
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
            this.mtxtInputFilter.Location = new System.Drawing.Point(392, 235);
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
            this.lbRecordsValue.Location = new System.Drawing.Point(88, 554);
            this.lbRecordsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecordsValue.Name = "lbRecordsValue";
            this.lbRecordsValue.Size = new System.Drawing.Size(58, 21);
            this.lbRecordsValue.TabIndex = 66;
            this.lbRecordsValue.Text = "4";
            // 
            // lbRecords
            // 
            this.lbRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(14, 554);
            this.lbRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(70, 21);
            this.lbRecords.TabIndex = 65;
            this.lbRecords.Text = "Records: ";
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToReorderColumns = false;
            this.dgvDetainedLicenses.AllowUserToReorderRows = false;
            this.dgvDetainedLicenses.AllowUserToResizeColumns = false;
            this.dgvDetainedLicenses.AutoSize = true;
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvDetainedLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvDetainedLicenses.CellFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvDetainedLicenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDetainedLicenses.HeaderFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(12, 280);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ShowSampleData = true;
            this.dgvDetainedLicenses.SiticoneAlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.dgvDetainedLicenses.SiticoneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvDetainedLicenses.SiticoneCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvDetainedLicenses.SiticoneDragDropTargetFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDetainedLicenses.SiticoneDragGhostAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDetainedLicenses.SiticoneDragGhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvDetainedLicenses.SiticoneDragGhostBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDetainedLicenses.SiticoneDragGhostForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.SiticoneDragGhostSecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvDetainedLicenses.SiticoneEmptyStateFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDetainedLicenses.SiticoneEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvDetainedLicenses.SiticoneEnableColumnDropIndicator = false;
            this.dgvDetainedLicenses.SiticoneGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvDetainedLicenses.SiticoneHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.dgvDetainedLicenses.SiticoneHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDetainedLicenses.SiticoneHeaderBottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDetainedLicenses.SiticoneHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dgvDetainedLicenses.SiticoneOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDetainedLicenses.SiticoneRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvDetainedLicenses.SiticoneRowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvDetainedLicenses.SiticoneRowHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvDetainedLicenses.SiticoneRowHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.dgvDetainedLicenses.SiticoneRowSeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvDetainedLicenses.SiticoneSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvDetainedLicenses.SiticoneSelectionForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.SiticoneStatusBadgeActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(88)))));
            this.dgvDetainedLicenses.SiticoneStatusBadgeErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.dgvDetainedLicenses.SiticoneStatusBadgeFont = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvDetainedLicenses.SiticoneStatusBadgeForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.SiticoneStatusBadgeNeutralBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dgvDetainedLicenses.SiticoneStatusBadgePendingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dgvDetainedLicenses.SiticoneStatusBadgeWarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.dgvDetainedLicenses.SiticoneSummaryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.dgvDetainedLicenses.SiticoneSummaryFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDetainedLicenses.SiticoneSummaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.dgvDetainedLicenses.SiticoneThemeEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1054, 261);
            this.dgvDetainedLicenses.TabIndex = 64;
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
            this.dplFilterItems.Location = new System.Drawing.Point(113, 236);
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
            this.lbFilterBy.Location = new System.Drawing.Point(12, 236);
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
            this.lbTitle.Location = new System.Drawing.Point(434, 175);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(272, 39);
            this.lbTitle.TabIndex = 60;
            this.lbTitle.Text = "List Detained Licenses";
            // 
            // btnRealiseDetainedLicense
            // 
            this.btnRealiseDetainedLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnRealiseDetainedLicense.BadgeBackColor = System.Drawing.Color.Red;
            this.btnRealiseDetainedLicense.BadgeForeColor = System.Drawing.Color.White;
            this.btnRealiseDetainedLicense.BadgeRadius = 8;
            this.btnRealiseDetainedLicense.BadgeRightMargin = 10;
            this.btnRealiseDetainedLicense.BadgeValue = 0;
            this.btnRealiseDetainedLicense.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRealiseDetainedLicense.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnRealiseDetainedLicense.BorderColorStart = System.Drawing.Color.White;
            this.btnRealiseDetainedLicense.BorderRadiusBottomLeft = 20;
            this.btnRealiseDetainedLicense.BorderRadiusBottomRight = 20;
            this.btnRealiseDetainedLicense.BorderRadiusTopLeft = 20;
            this.btnRealiseDetainedLicense.BorderRadiusTopRight = 20;
            this.btnRealiseDetainedLicense.BorderThickness = 1;
            this.btnRealiseDetainedLicense.ButtonColorEnd = System.Drawing.Color.White;
            this.btnRealiseDetainedLicense.ButtonColorStart = System.Drawing.Color.White;
            this.btnRealiseDetainedLicense.ButtonImage = global::DVLD.Properties.Resources.Release_Detained_License_321;
            this.btnRealiseDetainedLicense.CanBeep = false;
            this.btnRealiseDetainedLicense.CanShake = false;
            this.btnRealiseDetainedLicense.ClickSoundPath = null;
            this.btnRealiseDetainedLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealiseDetainedLicense.DisabledOverlayOpacity = 0.5F;
            this.btnRealiseDetainedLicense.EnableBorderGradient = false;
            this.btnRealiseDetainedLicense.EnableClickSound = false;
            this.btnRealiseDetainedLicense.EnableFocusBorder = false;
            this.btnRealiseDetainedLicense.EnableHoverSound = false;
            this.btnRealiseDetainedLicense.EnablePressScale = false;
            this.btnRealiseDetainedLicense.EnableTextShadow = false;
            this.btnRealiseDetainedLicense.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnRealiseDetainedLicense.FocusBorderThickness = 2;
            this.btnRealiseDetainedLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealiseDetainedLicense.ForeColor = System.Drawing.Color.Black;
            this.btnRealiseDetainedLicense.HoverColor = System.Drawing.Color.LightGray;
            this.btnRealiseDetainedLicense.HoverSoundPath = null;
            this.btnRealiseDetainedLicense.HoverTransitionSpeed = 0.08F;
            this.btnRealiseDetainedLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRealiseDetainedLicense.ImageLeftMargin = 0;
            this.btnRealiseDetainedLicense.ImageRightMargin = 0;
            this.btnRealiseDetainedLicense.ImageSize = 50;
            this.btnRealiseDetainedLicense.IsReadOnly = false;
            this.btnRealiseDetainedLicense.Location = new System.Drawing.Point(921, 206);
            this.btnRealiseDetainedLicense.MakeRadial = false;
            this.btnRealiseDetainedLicense.Name = "btnRealiseDetainedLicense";
            this.btnRealiseDetainedLicense.PressAnimationSpeed = 0.2F;
            this.btnRealiseDetainedLicense.PressDepth = 1;
            this.btnRealiseDetainedLicense.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRealiseDetainedLicense.RippleExpandSpeedFactor = 0.05F;
            this.btnRealiseDetainedLicense.RippleFadeSpeedFactor = 0.03F;
            this.btnRealiseDetainedLicense.ShadowBlurFactor = 0.85F;
            this.btnRealiseDetainedLicense.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRealiseDetainedLicense.ShadowOffsetX = 3;
            this.btnRealiseDetainedLicense.ShadowOffsetY = 3;
            this.btnRealiseDetainedLicense.Size = new System.Drawing.Size(68, 54);
            this.btnRealiseDetainedLicense.TabIndex = 72;
            this.btnRealiseDetainedLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealiseDetainedLicense.TextPaddingBottom = 0;
            this.btnRealiseDetainedLicense.TextPaddingLeft = 0;
            this.btnRealiseDetainedLicense.TextPaddingRight = 0;
            this.btnRealiseDetainedLicense.TextPaddingTop = 0;
            this.btnRealiseDetainedLicense.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRealiseDetainedLicense.TextShadowOffsetX = 1;
            this.btnRealiseDetainedLicense.TextShadowOffsetY = 1;
            this.btnRealiseDetainedLicense.Click += new System.EventHandler(this.btnRealiseDetainedLicense_Click);
            // 
            // pbDetainedLicenses
            // 
            this.pbDetainedLicenses.Image = global::DVLD.Properties.Resources.Detain_512;
            this.pbDetainedLicenses.Location = new System.Drawing.Point(467, 12);
            this.pbDetainedLicenses.Name = "pbDetainedLicenses";
            this.pbDetainedLicenses.Size = new System.Drawing.Size(200, 160);
            this.pbDetainedLicenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDetainedLicenses.TabIndex = 70;
            this.pbDetainedLicenses.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(930, 544);
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
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnDetainLicense.BadgeBackColor = System.Drawing.Color.Red;
            this.btnDetainLicense.BadgeForeColor = System.Drawing.Color.White;
            this.btnDetainLicense.BadgeRadius = 8;
            this.btnDetainLicense.BadgeRightMargin = 10;
            this.btnDetainLicense.BadgeValue = 0;
            this.btnDetainLicense.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDetainLicense.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnDetainLicense.BorderColorStart = System.Drawing.Color.White;
            this.btnDetainLicense.BorderRadiusBottomLeft = 20;
            this.btnDetainLicense.BorderRadiusBottomRight = 20;
            this.btnDetainLicense.BorderRadiusTopLeft = 20;
            this.btnDetainLicense.BorderRadiusTopRight = 20;
            this.btnDetainLicense.BorderThickness = 1;
            this.btnDetainLicense.ButtonColorEnd = System.Drawing.Color.White;
            this.btnDetainLicense.ButtonColorStart = System.Drawing.Color.White;
            this.btnDetainLicense.ButtonImage = global::DVLD.Properties.Resources.Detain_321;
            this.btnDetainLicense.CanBeep = false;
            this.btnDetainLicense.CanShake = false;
            this.btnDetainLicense.ClickSoundPath = null;
            this.btnDetainLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetainLicense.DisabledOverlayOpacity = 0.5F;
            this.btnDetainLicense.EnableBorderGradient = false;
            this.btnDetainLicense.EnableClickSound = false;
            this.btnDetainLicense.EnableFocusBorder = false;
            this.btnDetainLicense.EnableHoverSound = false;
            this.btnDetainLicense.EnablePressScale = false;
            this.btnDetainLicense.EnableTextShadow = false;
            this.btnDetainLicense.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDetainLicense.FocusBorderThickness = 2;
            this.btnDetainLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetainLicense.ForeColor = System.Drawing.Color.Black;
            this.btnDetainLicense.HoverColor = System.Drawing.Color.LightGray;
            this.btnDetainLicense.HoverSoundPath = null;
            this.btnDetainLicense.HoverTransitionSpeed = 0.08F;
            this.btnDetainLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetainLicense.ImageLeftMargin = 0;
            this.btnDetainLicense.ImageRightMargin = 0;
            this.btnDetainLicense.ImageSize = 50;
            this.btnDetainLicense.IsReadOnly = false;
            this.btnDetainLicense.Location = new System.Drawing.Point(995, 206);
            this.btnDetainLicense.MakeRadial = false;
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.PressAnimationSpeed = 0.2F;
            this.btnDetainLicense.PressDepth = 1;
            this.btnDetainLicense.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDetainLicense.RippleExpandSpeedFactor = 0.05F;
            this.btnDetainLicense.RippleFadeSpeedFactor = 0.03F;
            this.btnDetainLicense.ShadowBlurFactor = 0.85F;
            this.btnDetainLicense.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetainLicense.ShadowOffsetX = 3;
            this.btnDetainLicense.ShadowOffsetY = 3;
            this.btnDetainLicense.Size = new System.Drawing.Size(68, 54);
            this.btnDetainLicense.TabIndex = 63;
            this.btnDetainLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetainLicense.TextPaddingBottom = 0;
            this.btnDetainLicense.TextPaddingLeft = 0;
            this.btnDetainLicense.TextPaddingRight = 0;
            this.btnDetainLicense.TextPaddingTop = 0;
            this.btnDetainLicense.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDetainLicense.TextShadowOffsetX = 1;
            this.btnDetainLicense.TextShadowOffsetY = 1;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem2,
            this.realiseDetainedLicenseToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(323, 162);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD.Properties.Resources.License_View_32;
            this.showLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(319, 6);
            // 
            // realiseDetainedLicenseToolStripMenuItem
            // 
            this.realiseDetainedLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.realiseDetainedLicenseToolStripMenuItem.Image = global::DVLD.Properties.Resources.Release_Detained_License_32;
            this.realiseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.realiseDetainedLicenseToolStripMenuItem.Name = "realiseDetainedLicenseToolStripMenuItem";
            this.realiseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(322, 38);
            this.realiseDetainedLicenseToolStripMenuItem.Text = "Realise Detained License";
            this.realiseDetainedLicenseToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.realiseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.realiseDetainedLicenseToolStripMenuItem_Click);
            // 
            // frmDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 597);
            this.ControlBox = false;
            this.Controls.Add(this.btnRealiseDetainedLicense);
            this.Controls.Add(this.dplIsRealised);
            this.Controls.Add(this.pbDetainedLicenses);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.mtxtInputFilter);
            this.Controls.Add(this.lbRecordsValue);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.dplFilterItems);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detained Licenses";
            this.Load += new System.EventHandler(this.frmDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetainedLicenses)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneDropdown dplIsRealised;
        private System.Windows.Forms.PictureBox pbDetainedLicenses;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private System.Windows.Forms.MaskedTextBox mtxtInputFilter;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecordsValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecords;
        private SiticoneNetFrameworkUI.SiticoneDataGridView dgvDetainedLicenses;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnDetainLicense;
        private SiticoneNetFrameworkUI.SiticoneDropdown dplFilterItems;
        private SiticoneNetFrameworkUI.SiticoneLabel lbFilterBy;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnRealiseDetainedLicense;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem realiseDetainedLicenseToolStripMenuItem;
    }
}