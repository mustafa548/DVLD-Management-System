namespace DVLD
{
    partial class frmDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrivers));
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.mtxtInputFilter = new System.Windows.Forms.MaskedTextBox();
            this.lbRecordsValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbRecords = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dgvDrivers = new SiticoneNetFrameworkUI.SiticoneDataGridView();
            this.dplFilterItems = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.lbFilterBy = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pbDrivers = new System.Windows.Forms.PictureBox();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(1042, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(30, 30);
            this.btnClose1.TabIndex = 55;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // mtxtInputFilter
            // 
            this.mtxtInputFilter.AllowPromptAsInput = false;
            this.mtxtInputFilter.BackColor = System.Drawing.Color.LightGray;
            this.mtxtInputFilter.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtInputFilter.HidePromptOnLeave = true;
            this.mtxtInputFilter.Location = new System.Drawing.Point(369, 237);
            this.mtxtInputFilter.Name = "mtxtInputFilter";
            this.mtxtInputFilter.PromptChar = ' ';
            this.mtxtInputFilter.RejectInputOnFirstFailure = true;
            this.mtxtInputFilter.Size = new System.Drawing.Size(256, 25);
            this.mtxtInputFilter.TabIndex = 54;
            this.mtxtInputFilter.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtInputFilter.ValidatingType = typeof(int);
            this.mtxtInputFilter.Visible = false;
            this.mtxtInputFilter.TextChanged += new System.EventHandler(this.mtxtInputFilter_TextChanged);
            // 
            // lbRecordsValue
            // 
            this.lbRecordsValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsValue.Location = new System.Drawing.Point(81, 555);
            this.lbRecordsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecordsValue.Name = "lbRecordsValue";
            this.lbRecordsValue.Size = new System.Drawing.Size(58, 21);
            this.lbRecordsValue.TabIndex = 53;
            this.lbRecordsValue.Text = "4";
            // 
            // lbRecords
            // 
            this.lbRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(7, 555);
            this.lbRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(70, 21);
            this.lbRecords.TabIndex = 52;
            this.lbRecords.Text = "Records: ";
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToReorderColumns = false;
            this.dgvDrivers.AllowUserToReorderRows = false;
            this.dgvDrivers.AllowUserToResizeColumns = false;
            this.dgvDrivers.AutoSize = true;
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvDrivers.CellFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDrivers.HeaderFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvDrivers.Location = new System.Drawing.Point(5, 281);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ShowSampleData = true;
            this.dgvDrivers.SiticoneAlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.dgvDrivers.SiticoneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvDrivers.SiticoneCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvDrivers.SiticoneDragDropTargetFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDrivers.SiticoneDragGhostAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDrivers.SiticoneDragGhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvDrivers.SiticoneDragGhostBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDrivers.SiticoneDragGhostForeColor = System.Drawing.Color.White;
            this.dgvDrivers.SiticoneDragGhostSecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvDrivers.SiticoneEmptyStateFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDrivers.SiticoneEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvDrivers.SiticoneEnableColumnDropIndicator = false;
            this.dgvDrivers.SiticoneGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvDrivers.SiticoneHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.dgvDrivers.SiticoneHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDrivers.SiticoneHeaderBottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDrivers.SiticoneHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dgvDrivers.SiticoneOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvDrivers.SiticoneRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvDrivers.SiticoneRowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvDrivers.SiticoneRowHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvDrivers.SiticoneRowHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.dgvDrivers.SiticoneRowSeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvDrivers.SiticoneSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvDrivers.SiticoneSelectionForeColor = System.Drawing.Color.White;
            this.dgvDrivers.SiticoneStatusBadgeActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(88)))));
            this.dgvDrivers.SiticoneStatusBadgeErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.dgvDrivers.SiticoneStatusBadgeFont = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvDrivers.SiticoneStatusBadgeForeColor = System.Drawing.Color.White;
            this.dgvDrivers.SiticoneStatusBadgeNeutralBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dgvDrivers.SiticoneStatusBadgePendingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dgvDrivers.SiticoneStatusBadgeWarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.dgvDrivers.SiticoneSummaryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.dgvDrivers.SiticoneSummaryFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDrivers.SiticoneSummaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.dgvDrivers.SiticoneThemeEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvDrivers.Size = new System.Drawing.Size(1054, 261);
            this.dgvDrivers.TabIndex = 51;
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
            this.dplFilterItems.Location = new System.Drawing.Point(106, 237);
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
            this.dplFilterItems.TabIndex = 50;
            this.dplFilterItems.Text = "siticoneDropdown1";
            this.dplFilterItems.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplFilterItems.ValueMember = null;
            this.dplFilterItems.ItemSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs>(this.dplFilterItems_ItemSelected);
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.Location = new System.Drawing.Point(5, 237);
            this.lbFilterBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(97, 31);
            this.lbFilterBy.TabIndex = 49;
            this.lbFilterBy.Text = "Filter By: ";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(414, 175);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(219, 39);
            this.lbTitle.TabIndex = 48;
            this.lbTitle.Text = "Manage Drivers";
            // 
            // pbDrivers
            // 
            this.pbDrivers.Image = global::DVLD.Properties.Resources.Driver_Main;
            this.pbDrivers.Location = new System.Drawing.Point(414, 12);
            this.pbDrivers.Name = "pbDrivers";
            this.pbDrivers.Size = new System.Drawing.Size(200, 160);
            this.pbDrivers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDrivers.TabIndex = 57;
            this.pbDrivers.TabStop = false;
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
            this.btnClose.Location = new System.Drawing.Point(923, 545);
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
            this.btnClose.TabIndex = 56;
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
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 594);
            this.ControlBox = false;
            this.Controls.Add(this.pbDrivers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.mtxtInputFilter);
            this.Controls.Add(this.lbRecordsValue);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvDrivers);
            this.Controls.Add(this.dplFilterItems);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Drivers";
            this.Load += new System.EventHandler(this.frmDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDrivers;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private System.Windows.Forms.MaskedTextBox mtxtInputFilter;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecordsValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecords;
        private SiticoneNetFrameworkUI.SiticoneDataGridView dgvDrivers;
        private SiticoneNetFrameworkUI.SiticoneDropdown dplFilterItems;
        private SiticoneNetFrameworkUI.SiticoneLabel lbFilterBy;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
    }
}