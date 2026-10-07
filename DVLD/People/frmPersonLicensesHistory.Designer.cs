namespace DVLD
{
    partial class frmPersonLicensesHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonLicensesHistory));
            this.tabControl = new SiticoneNetFrameworkUI.SiticoneTabControl();
            this.tabLocal = new System.Windows.Forms.TabPage();
            this.lbLocalRecordsValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbLocalTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dgvLocalHistory = new SiticoneNetFrameworkUI.SiticoneDataGridView();
            this.lbLocalRecords = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.tabInternational = new System.Windows.Forms.TabPage();
            this.lbInternationalRecordsValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dgvInternationalHistory = new SiticoneNetFrameworkUI.SiticoneDataGridView();
            this.lbInternationalTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbInternationalRecords = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneButtonAdvanced1 = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.pbLicenseHistory = new System.Windows.Forms.PictureBox();
            this.showInternationalLicenseInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.localContextMenuStrip = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showLocalLicenseInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlPersonInfo1 = new DVLD.ctrlPersonInfo();
            this.tabControl.SuspendLayout();
            this.tabLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalHistory)).BeginInit();
            this.tabInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseHistory)).BeginInit();
            this.internationalContextMenuStrip.SuspendLayout();
            this.localContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AllowTabReorder = false;
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.BorderWidth = 0;
            this.tabControl.CloseButtonColor = System.Drawing.Color.Gray;
            this.tabControl.CloseButtonHoverColor = System.Drawing.Color.Red;
            this.tabControl.CloseButtonSymbolPadding = 0.25F;
            this.tabControl.CloseButtonThickness = 1.8F;
            this.tabControl.ContextMenuFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Controls.Add(this.tabLocal);
            this.tabControl.Controls.Add(this.tabInternational);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.DragIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tabControl.EnableMouseWheelTabSwitch = false;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.GhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.tabControl.GhostForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControl.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControl.Location = new System.Drawing.Point(12, 463);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.PinIconHoverColor = System.Drawing.Color.DarkGray;
            this.tabControl.PinnedIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.tabControl.PinThickness = 3F;
            this.tabControl.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedTabBackColor = System.Drawing.Color.Transparent;
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.SelectedTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.tabControl.SelectedTabIndicatorHeight = 3;
            this.tabControl.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.tabControl.SeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControl.SeparatorLineOpacity = 0.6F;
            this.tabControl.SeparatorLineThickness = 2;
            this.tabControl.ShowSeparatorLine = true;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1097, 314);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabCornerRadiusBottomLeft = 20;
            this.tabControl.TabCornerRadiusBottomRight = 20;
            this.tabControl.TabCornerRadiusTopLeft = 20;
            this.tabControl.TabCornerRadiusTopRight = 20;
            this.tabControl.TabImageSize = 35;
            this.tabControl.TabImageTextGap = 6;
            this.tabControl.TabIndex = 47;
            this.tabControl.TabWidth = 200;
            this.tabControl.UnpinnedIconColor = System.Drawing.Color.Gray;
            this.tabControl.UnselectedTabColor = System.Drawing.Color.Transparent;
            this.tabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabLocal
            // 
            this.tabLocal.BackColor = System.Drawing.Color.Transparent;
            this.tabLocal.Controls.Add(this.lbLocalRecordsValue);
            this.tabLocal.Controls.Add(this.lbLocalTitle);
            this.tabLocal.Controls.Add(this.dgvLocalHistory);
            this.tabLocal.Controls.Add(this.lbLocalRecords);
            this.tabLocal.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabLocal.Location = new System.Drawing.Point(4, 44);
            this.tabLocal.Name = "tabLocal";
            this.tabLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tabLocal.Size = new System.Drawing.Size(1089, 266);
            this.tabControl.SetTabImage(this.tabLocal, global::DVLD.Properties.Resources.Local_32);
            this.tabLocal.TabIndex = 0;
            this.tabLocal.Text = "Local";
            this.tabLocal.ToolTipText = "Connect User With Person";
            // 
            // lbLocalRecordsValue
            // 
            this.lbLocalRecordsValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalRecordsValue.Location = new System.Drawing.Point(80, 236);
            this.lbLocalRecordsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocalRecordsValue.Name = "lbLocalRecordsValue";
            this.lbLocalRecordsValue.Size = new System.Drawing.Size(58, 21);
            this.lbLocalRecordsValue.TabIndex = 51;
            this.lbLocalRecordsValue.Text = "4";
            // 
            // lbLocalTitle
            // 
            this.lbLocalTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalTitle.Location = new System.Drawing.Point(5, 3);
            this.lbLocalTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocalTitle.Name = "lbLocalTitle";
            this.lbLocalTitle.Size = new System.Drawing.Size(188, 21);
            this.lbLocalTitle.TabIndex = 51;
            this.lbLocalTitle.Text = "Local License History:";
            // 
            // dgvLocalHistory
            // 
            this.dgvLocalHistory.AllowUserToReorderColumns = false;
            this.dgvLocalHistory.AllowUserToResizeColumns = false;
            this.dgvLocalHistory.AutoSize = true;
            this.dgvLocalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvLocalHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvLocalHistory.CellFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvLocalHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLocalHistory.HeaderFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvLocalHistory.Location = new System.Drawing.Point(6, 27);
            this.dgvLocalHistory.Name = "dgvLocalHistory";
            this.dgvLocalHistory.ShowSampleData = true;
            this.dgvLocalHistory.SiticoneAlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.dgvLocalHistory.SiticoneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvLocalHistory.SiticoneCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvLocalHistory.SiticoneDragDropTargetFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvLocalHistory.SiticoneDragGhostAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvLocalHistory.SiticoneDragGhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvLocalHistory.SiticoneDragGhostBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvLocalHistory.SiticoneDragGhostForeColor = System.Drawing.Color.White;
            this.dgvLocalHistory.SiticoneDragGhostSecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvLocalHistory.SiticoneEmptyStateFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvLocalHistory.SiticoneEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvLocalHistory.SiticoneEnableColumnDropIndicator = false;
            this.dgvLocalHistory.SiticoneGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvLocalHistory.SiticoneHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.dgvLocalHistory.SiticoneHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvLocalHistory.SiticoneHeaderBottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvLocalHistory.SiticoneHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dgvLocalHistory.SiticoneOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvLocalHistory.SiticoneRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvLocalHistory.SiticoneRowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvLocalHistory.SiticoneRowHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvLocalHistory.SiticoneRowHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.dgvLocalHistory.SiticoneRowSeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvLocalHistory.SiticoneSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvLocalHistory.SiticoneSelectionForeColor = System.Drawing.Color.White;
            this.dgvLocalHistory.SiticoneStatusBadgeActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(88)))));
            this.dgvLocalHistory.SiticoneStatusBadgeErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.dgvLocalHistory.SiticoneStatusBadgeFont = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvLocalHistory.SiticoneStatusBadgeForeColor = System.Drawing.Color.White;
            this.dgvLocalHistory.SiticoneStatusBadgeNeutralBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dgvLocalHistory.SiticoneStatusBadgePendingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dgvLocalHistory.SiticoneStatusBadgeWarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.dgvLocalHistory.SiticoneSummaryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.dgvLocalHistory.SiticoneSummaryFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvLocalHistory.SiticoneSummaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.dgvLocalHistory.SiticoneThemeEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvLocalHistory.Size = new System.Drawing.Size(1054, 206);
            this.dgvLocalHistory.TabIndex = 51;
            // 
            // lbLocalRecords
            // 
            this.lbLocalRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalRecords.Location = new System.Drawing.Point(6, 236);
            this.lbLocalRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocalRecords.Name = "lbLocalRecords";
            this.lbLocalRecords.Size = new System.Drawing.Size(70, 21);
            this.lbLocalRecords.TabIndex = 53;
            this.lbLocalRecords.Text = "Records: ";
            // 
            // tabInternational
            // 
            this.tabInternational.BackColor = System.Drawing.Color.Transparent;
            this.tabInternational.Controls.Add(this.lbInternationalRecordsValue);
            this.tabInternational.Controls.Add(this.dgvInternationalHistory);
            this.tabInternational.Controls.Add(this.lbInternationalTitle);
            this.tabInternational.Controls.Add(this.lbInternationalRecords);
            this.tabInternational.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabInternational.Location = new System.Drawing.Point(4, 44);
            this.tabInternational.Name = "tabInternational";
            this.tabInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tabInternational.Size = new System.Drawing.Size(1089, 266);
            this.tabControl.SetTabImage(this.tabInternational, global::DVLD.Properties.Resources.International_32);
            this.tabInternational.TabIndex = 1;
            this.tabInternational.Text = "International";
            this.tabInternational.ToolTipText = "Write The User Info Login";
            // 
            // lbInternationalRecordsValue
            // 
            this.lbInternationalRecordsValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalRecordsValue.Location = new System.Drawing.Point(80, 239);
            this.lbInternationalRecordsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInternationalRecordsValue.Name = "lbInternationalRecordsValue";
            this.lbInternationalRecordsValue.Size = new System.Drawing.Size(58, 21);
            this.lbInternationalRecordsValue.TabIndex = 54;
            this.lbInternationalRecordsValue.Text = "4";
            // 
            // dgvInternationalHistory
            // 
            this.dgvInternationalHistory.AllowUserToReorderColumns = false;
            this.dgvInternationalHistory.AllowUserToResizeColumns = false;
            this.dgvInternationalHistory.AutoSize = true;
            this.dgvInternationalHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvInternationalHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvInternationalHistory.CellFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvInternationalHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvInternationalHistory.HeaderFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvInternationalHistory.Location = new System.Drawing.Point(6, 30);
            this.dgvInternationalHistory.Name = "dgvInternationalHistory";
            this.dgvInternationalHistory.ShowSampleData = true;
            this.dgvInternationalHistory.SiticoneAlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.dgvInternationalHistory.SiticoneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvInternationalHistory.SiticoneCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvInternationalHistory.SiticoneDragDropTargetFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvInternationalHistory.SiticoneDragGhostAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvInternationalHistory.SiticoneDragGhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvInternationalHistory.SiticoneDragGhostBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvInternationalHistory.SiticoneDragGhostForeColor = System.Drawing.Color.White;
            this.dgvInternationalHistory.SiticoneDragGhostSecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvInternationalHistory.SiticoneEmptyStateFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvInternationalHistory.SiticoneEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvInternationalHistory.SiticoneEnableColumnDropIndicator = false;
            this.dgvInternationalHistory.SiticoneGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvInternationalHistory.SiticoneHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.dgvInternationalHistory.SiticoneHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvInternationalHistory.SiticoneHeaderBottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvInternationalHistory.SiticoneHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dgvInternationalHistory.SiticoneOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvInternationalHistory.SiticoneRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvInternationalHistory.SiticoneRowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvInternationalHistory.SiticoneRowHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvInternationalHistory.SiticoneRowHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.dgvInternationalHistory.SiticoneRowSeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvInternationalHistory.SiticoneSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvInternationalHistory.SiticoneSelectionForeColor = System.Drawing.Color.White;
            this.dgvInternationalHistory.SiticoneStatusBadgeActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(88)))));
            this.dgvInternationalHistory.SiticoneStatusBadgeErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.dgvInternationalHistory.SiticoneStatusBadgeFont = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvInternationalHistory.SiticoneStatusBadgeForeColor = System.Drawing.Color.White;
            this.dgvInternationalHistory.SiticoneStatusBadgeNeutralBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dgvInternationalHistory.SiticoneStatusBadgePendingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dgvInternationalHistory.SiticoneStatusBadgeWarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.dgvInternationalHistory.SiticoneSummaryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.dgvInternationalHistory.SiticoneSummaryFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvInternationalHistory.SiticoneSummaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.dgvInternationalHistory.SiticoneThemeEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvInternationalHistory.Size = new System.Drawing.Size(1054, 206);
            this.dgvInternationalHistory.TabIndex = 56;
            // 
            // lbInternationalTitle
            // 
            this.lbInternationalTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalTitle.Location = new System.Drawing.Point(5, 6);
            this.lbInternationalTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInternationalTitle.Name = "lbInternationalTitle";
            this.lbInternationalTitle.Size = new System.Drawing.Size(225, 21);
            this.lbInternationalTitle.TabIndex = 55;
            this.lbInternationalTitle.Text = "International License History:";
            // 
            // lbInternationalRecords
            // 
            this.lbInternationalRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternationalRecords.Location = new System.Drawing.Point(6, 239);
            this.lbInternationalRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInternationalRecords.Name = "lbInternationalRecords";
            this.lbInternationalRecords.Size = new System.Drawing.Size(70, 21);
            this.lbInternationalRecords.TabIndex = 57;
            this.lbInternationalRecords.Text = "Records: ";
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(1092, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(30, 30);
            this.btnClose1.TabIndex = 49;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(444, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 39);
            this.lbTitle.TabIndex = 50;
            this.lbTitle.Text = "License History";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneButtonAdvanced1
            // 
            this.siticoneButtonAdvanced1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButtonAdvanced1.BadgeBackColor = System.Drawing.Color.Red;
            this.siticoneButtonAdvanced1.BadgeForeColor = System.Drawing.Color.White;
            this.siticoneButtonAdvanced1.BadgeRadius = 8;
            this.siticoneButtonAdvanced1.BadgeRightMargin = 10;
            this.siticoneButtonAdvanced1.BadgeValue = 0;
            this.siticoneButtonAdvanced1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticoneButtonAdvanced1.BorderColorEnd = System.Drawing.Color.Gray;
            this.siticoneButtonAdvanced1.BorderColorStart = System.Drawing.Color.White;
            this.siticoneButtonAdvanced1.BorderRadiusBottomLeft = 10;
            this.siticoneButtonAdvanced1.BorderRadiusBottomRight = 10;
            this.siticoneButtonAdvanced1.BorderRadiusTopLeft = 10;
            this.siticoneButtonAdvanced1.BorderRadiusTopRight = 10;
            this.siticoneButtonAdvanced1.BorderThickness = 1;
            this.siticoneButtonAdvanced1.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.siticoneButtonAdvanced1.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.siticoneButtonAdvanced1.ButtonImage = global::DVLD.Properties.Resources.Close_32;
            this.siticoneButtonAdvanced1.CanBeep = false;
            this.siticoneButtonAdvanced1.CanShake = false;
            this.siticoneButtonAdvanced1.ClickSoundPath = null;
            this.siticoneButtonAdvanced1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButtonAdvanced1.DisabledOverlayOpacity = 0.5F;
            this.siticoneButtonAdvanced1.EnableBorderGradient = false;
            this.siticoneButtonAdvanced1.EnableClickSound = false;
            this.siticoneButtonAdvanced1.EnableFocusBorder = false;
            this.siticoneButtonAdvanced1.EnableHoverSound = false;
            this.siticoneButtonAdvanced1.EnablePressScale = false;
            this.siticoneButtonAdvanced1.EnableTextShadow = false;
            this.siticoneButtonAdvanced1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.siticoneButtonAdvanced1.FocusBorderThickness = 2;
            this.siticoneButtonAdvanced1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButtonAdvanced1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.siticoneButtonAdvanced1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.siticoneButtonAdvanced1.HoverSoundPath = null;
            this.siticoneButtonAdvanced1.HoverTransitionSpeed = 0.08F;
            this.siticoneButtonAdvanced1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siticoneButtonAdvanced1.ImageLeftMargin = 0;
            this.siticoneButtonAdvanced1.ImageRightMargin = 3;
            this.siticoneButtonAdvanced1.ImageSize = 25;
            this.siticoneButtonAdvanced1.IsReadOnly = false;
            this.siticoneButtonAdvanced1.Location = new System.Drawing.Point(991, 780);
            this.siticoneButtonAdvanced1.MakeRadial = false;
            this.siticoneButtonAdvanced1.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneButtonAdvanced1.Name = "siticoneButtonAdvanced1";
            this.siticoneButtonAdvanced1.PressAnimationSpeed = 0.2F;
            this.siticoneButtonAdvanced1.PressDepth = 1;
            this.siticoneButtonAdvanced1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButtonAdvanced1.RippleExpandSpeedFactor = 0.05F;
            this.siticoneButtonAdvanced1.RippleFadeSpeedFactor = 0.03F;
            this.siticoneButtonAdvanced1.ShadowBlurFactor = 0.85F;
            this.siticoneButtonAdvanced1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButtonAdvanced1.ShadowOffsetX = 3;
            this.siticoneButtonAdvanced1.ShadowOffsetY = 3;
            this.siticoneButtonAdvanced1.Size = new System.Drawing.Size(118, 41);
            this.siticoneButtonAdvanced1.TabIndex = 48;
            this.siticoneButtonAdvanced1.Text = "Close";
            this.siticoneButtonAdvanced1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siticoneButtonAdvanced1.TextPaddingBottom = 0;
            this.siticoneButtonAdvanced1.TextPaddingLeft = 15;
            this.siticoneButtonAdvanced1.TextPaddingRight = 0;
            this.siticoneButtonAdvanced1.TextPaddingTop = 0;
            this.siticoneButtonAdvanced1.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButtonAdvanced1.TextShadowOffsetX = 1;
            this.siticoneButtonAdvanced1.TextShadowOffsetY = 1;
            this.siticoneButtonAdvanced1.Click += new System.EventHandler(this.siticoneButtonAdvanced1_Click);
            // 
            // pbLicenseHistory
            // 
            this.pbLicenseHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLicenseHistory.Image = global::DVLD.Properties.Resources.PersonLicenseHistory_512;
            this.pbLicenseHistory.Location = new System.Drawing.Point(12, 196);
            this.pbLicenseHistory.Name = "pbLicenseHistory";
            this.pbLicenseHistory.Size = new System.Drawing.Size(166, 185);
            this.pbLicenseHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLicenseHistory.TabIndex = 44;
            this.pbLicenseHistory.TabStop = false;
            // 
            // showInternationalLicenseInfoMenuItem
            // 
            this.showInternationalLicenseInfoMenuItem.ForeColor = System.Drawing.Color.White;
            this.showInternationalLicenseInfoMenuItem.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.showInternationalLicenseInfoMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showInternationalLicenseInfoMenuItem.Name = "showInternationalLicenseInfoMenuItem";
            this.showInternationalLicenseInfoMenuItem.Size = new System.Drawing.Size(238, 38);
            this.showInternationalLicenseInfoMenuItem.Text = "Show License Info";
            this.showInternationalLicenseInfoMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.showInternationalLicenseInfoMenuItem.Click += new System.EventHandler(this.showInternationalLicenseInfoMenuItem_Click);
            // 
            // internationalContextMenuStrip
            // 
            this.internationalContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.internationalContextMenuStrip.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internationalContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.internationalContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInternationalLicenseInfoMenuItem});
            this.internationalContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.internationalContextMenuStrip.Name = "guna2ContextMenuStrip1";
            this.internationalContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.internationalContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.internationalContextMenuStrip.RenderStyle.ColorTable = null;
            this.internationalContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.internationalContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.internationalContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.internationalContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.internationalContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.internationalContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.internationalContextMenuStrip.Size = new System.Drawing.Size(239, 42);
            // 
            // localContextMenuStrip
            // 
            this.localContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.localContextMenuStrip.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.localContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLocalLicenseInfoMenuItem});
            this.localContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.localContextMenuStrip.Name = "guna2ContextMenuStrip1";
            this.localContextMenuStrip.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.localContextMenuStrip.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.localContextMenuStrip.RenderStyle.ColorTable = null;
            this.localContextMenuStrip.RenderStyle.RoundedEdges = true;
            this.localContextMenuStrip.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.localContextMenuStrip.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.localContextMenuStrip.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.localContextMenuStrip.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(82)))));
            this.localContextMenuStrip.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.localContextMenuStrip.Size = new System.Drawing.Size(239, 42);
            // 
            // showLocalLicenseInfoMenuItem
            // 
            this.showLocalLicenseInfoMenuItem.ForeColor = System.Drawing.Color.White;
            this.showLocalLicenseInfoMenuItem.Image = global::DVLD.Properties.Resources.Renew_Driving_License_32;
            this.showLocalLicenseInfoMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLocalLicenseInfoMenuItem.Name = "showLocalLicenseInfoMenuItem";
            this.showLocalLicenseInfoMenuItem.Size = new System.Drawing.Size(238, 38);
            this.showLocalLicenseInfoMenuItem.Text = "Show License Info";
            this.showLocalLicenseInfoMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.showLocalLicenseInfoMenuItem.Click += new System.EventHandler(this.showLocalLicenseInfoMenuItem_Click);
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(184, 82);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(921, 375);
            this.ctrlPersonInfo1.TabIndex = 45;
            // 
            // frmPersonLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 823);
            this.ControlBox = false;
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.siticoneButtonAdvanced1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Controls.Add(this.pbLicenseHistory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Licenses History";
            this.Load += new System.EventHandler(this.frmPersonLicensesHistory_Load);
            this.tabControl.ResumeLayout(false);
            this.tabLocal.ResumeLayout(false);
            this.tabLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalHistory)).EndInit();
            this.tabInternational.ResumeLayout(false);
            this.tabInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseHistory)).EndInit();
            this.internationalContextMenuStrip.ResumeLayout(false);
            this.localContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLicenseHistory;
        private ctrlPersonInfo ctrlPersonInfo1;
        private SiticoneNetFrameworkUI.SiticoneTabControl tabControl;
        private System.Windows.Forms.TabPage tabLocal;
        private System.Windows.Forms.TabPage tabInternational;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced siticoneButtonAdvanced1;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private SiticoneNetFrameworkUI.SiticoneDataGridView dgvLocalHistory;
        private SiticoneNetFrameworkUI.SiticoneLabel lbLocalTitle;
        private SiticoneNetFrameworkUI.SiticoneLabel lbLocalRecords;
        private SiticoneNetFrameworkUI.SiticoneLabel lbLocalRecordsValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbInternationalRecordsValue;
        private SiticoneNetFrameworkUI.SiticoneDataGridView dgvInternationalHistory;
        private SiticoneNetFrameworkUI.SiticoneLabel lbInternationalTitle;
        private SiticoneNetFrameworkUI.SiticoneLabel lbInternationalRecords;
        private System.Windows.Forms.ToolStripMenuItem showInternationalLicenseInfoMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip internationalContextMenuStrip;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip localContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showLocalLicenseInfoMenuItem;
    }
}