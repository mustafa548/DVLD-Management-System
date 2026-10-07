namespace DVLD
{
    partial class frmPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeople));
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbFilterBy = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dplFilterItems = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.dgvPeople = new SiticoneNetFrameworkUI.SiticoneDataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsAppMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecords = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbRecordsValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.mtxtInputFilter = new System.Windows.Forms.MaskedTextBox();
            this.btnAddNewPerson = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.pbPeople = new System.Windows.Forms.PictureBox();
            this.dplGender = new SiticoneNetFrameworkUI.SiticoneDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(423, 180);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(197, 39);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "Manage People";
            // 
            // lbFilterBy
            // 
            this.lbFilterBy.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterBy.Location = new System.Drawing.Point(9, 249);
            this.lbFilterBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFilterBy.Name = "lbFilterBy";
            this.lbFilterBy.Size = new System.Drawing.Size(97, 31);
            this.lbFilterBy.TabIndex = 5;
            this.lbFilterBy.Text = "Filter By: ";
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
            this.dplFilterItems.Location = new System.Drawing.Point(110, 249);
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
            this.dplFilterItems.TabIndex = 6;
            this.dplFilterItems.Text = "siticoneDropdown1";
            this.dplFilterItems.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplFilterItems.ValueMember = null;
            this.dplFilterItems.ItemSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs>(this.dplFilterItems_ItemSelected);
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToReorderColumns = false;
            this.dgvPeople.AllowUserToReorderRows = false;
            this.dgvPeople.AllowUserToResizeColumns = false;
            this.dgvPeople.AutoSize = true;
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvPeople.CellFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPeople.HeaderFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvPeople.Location = new System.Drawing.Point(9, 293);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ShowSampleData = true;
            this.dgvPeople.SiticoneAlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.dgvPeople.SiticoneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvPeople.SiticoneCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvPeople.SiticoneDragDropTargetFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvPeople.SiticoneDragGhostAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvPeople.SiticoneDragGhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvPeople.SiticoneDragGhostBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvPeople.SiticoneDragGhostForeColor = System.Drawing.Color.White;
            this.dgvPeople.SiticoneDragGhostSecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvPeople.SiticoneEmptyStateFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvPeople.SiticoneEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvPeople.SiticoneEnableColumnDropIndicator = false;
            this.dgvPeople.SiticoneGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvPeople.SiticoneHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.dgvPeople.SiticoneHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvPeople.SiticoneHeaderBottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvPeople.SiticoneHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dgvPeople.SiticoneOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvPeople.SiticoneRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvPeople.SiticoneRowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvPeople.SiticoneRowHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvPeople.SiticoneRowHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.dgvPeople.SiticoneRowSeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvPeople.SiticoneSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvPeople.SiticoneSelectionForeColor = System.Drawing.Color.White;
            this.dgvPeople.SiticoneStatusBadgeActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(88)))));
            this.dgvPeople.SiticoneStatusBadgeErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.dgvPeople.SiticoneStatusBadgeFont = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvPeople.SiticoneStatusBadgeForeColor = System.Drawing.Color.White;
            this.dgvPeople.SiticoneStatusBadgeNeutralBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dgvPeople.SiticoneStatusBadgePendingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dgvPeople.SiticoneStatusBadgeWarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.dgvPeople.SiticoneSummaryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.dgvPeople.SiticoneSummaryFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPeople.SiticoneSummaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.dgvPeople.SiticoneThemeEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvPeople.Size = new System.Drawing.Size(1054, 261);
            this.dgvPeople.TabIndex = 8;
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
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
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
            // lbRecords
            // 
            this.lbRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(11, 567);
            this.lbRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(70, 21);
            this.lbRecords.TabIndex = 9;
            this.lbRecords.Text = "Records: ";
            // 
            // lbRecordsValue
            // 
            this.lbRecordsValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsValue.Location = new System.Drawing.Point(85, 567);
            this.lbRecordsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecordsValue.Name = "lbRecordsValue";
            this.lbRecordsValue.Size = new System.Drawing.Size(58, 21);
            this.lbRecordsValue.TabIndex = 10;
            this.lbRecordsValue.Text = "4";
            // 
            // mtxtInputFilter
            // 
            this.mtxtInputFilter.AllowPromptAsInput = false;
            this.mtxtInputFilter.BackColor = System.Drawing.Color.LightGray;
            this.mtxtInputFilter.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtInputFilter.HidePromptOnLeave = true;
            this.mtxtInputFilter.Location = new System.Drawing.Point(389, 248);
            this.mtxtInputFilter.Name = "mtxtInputFilter";
            this.mtxtInputFilter.PromptChar = ' ';
            this.mtxtInputFilter.RejectInputOnFirstFailure = true;
            this.mtxtInputFilter.Size = new System.Drawing.Size(256, 25);
            this.mtxtInputFilter.TabIndex = 11;
            this.mtxtInputFilter.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtInputFilter.ValidatingType = typeof(int);
            this.mtxtInputFilter.Visible = false;
            this.mtxtInputFilter.TextChanged += new System.EventHandler(this.mtxtInputFilter_TextChanged);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewPerson.BadgeBackColor = System.Drawing.Color.Red;
            this.btnAddNewPerson.BadgeForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.BadgeRadius = 8;
            this.btnAddNewPerson.BadgeRightMargin = 10;
            this.btnAddNewPerson.BadgeValue = 0;
            this.btnAddNewPerson.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddNewPerson.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnAddNewPerson.BorderColorStart = System.Drawing.Color.White;
            this.btnAddNewPerson.BorderRadiusBottomLeft = 20;
            this.btnAddNewPerson.BorderRadiusBottomRight = 20;
            this.btnAddNewPerson.BorderRadiusTopLeft = 20;
            this.btnAddNewPerson.BorderRadiusTopRight = 20;
            this.btnAddNewPerson.BorderThickness = 1;
            this.btnAddNewPerson.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewPerson.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewPerson.ButtonImage = global::DVLD.Properties.Resources.AddPerson_32;
            this.btnAddNewPerson.CanBeep = false;
            this.btnAddNewPerson.CanShake = false;
            this.btnAddNewPerson.ClickSoundPath = null;
            this.btnAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewPerson.DisabledOverlayOpacity = 0.5F;
            this.btnAddNewPerson.EnableBorderGradient = false;
            this.btnAddNewPerson.EnableClickSound = false;
            this.btnAddNewPerson.EnableFocusBorder = false;
            this.btnAddNewPerson.EnableHoverSound = false;
            this.btnAddNewPerson.EnablePressScale = false;
            this.btnAddNewPerson.EnableTextShadow = false;
            this.btnAddNewPerson.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddNewPerson.FocusBorderThickness = 2;
            this.btnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewPerson.HoverSoundPath = null;
            this.btnAddNewPerson.HoverTransitionSpeed = 0.08F;
            this.btnAddNewPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewPerson.ImageLeftMargin = 0;
            this.btnAddNewPerson.ImageRightMargin = 0;
            this.btnAddNewPerson.ImageSize = 50;
            this.btnAddNewPerson.IsReadOnly = false;
            this.btnAddNewPerson.Location = new System.Drawing.Point(992, 219);
            this.btnAddNewPerson.MakeRadial = false;
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.PressAnimationSpeed = 0.2F;
            this.btnAddNewPerson.PressDepth = 1;
            this.btnAddNewPerson.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewPerson.RippleExpandSpeedFactor = 0.05F;
            this.btnAddNewPerson.RippleFadeSpeedFactor = 0.03F;
            this.btnAddNewPerson.ShadowBlurFactor = 0.85F;
            this.btnAddNewPerson.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewPerson.ShadowOffsetX = 3;
            this.btnAddNewPerson.ShadowOffsetY = 3;
            this.btnAddNewPerson.Size = new System.Drawing.Size(68, 54);
            this.btnAddNewPerson.TabIndex = 7;
            this.btnAddNewPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewPerson.TextPaddingBottom = 0;
            this.btnAddNewPerson.TextPaddingLeft = 0;
            this.btnAddNewPerson.TextPaddingRight = 0;
            this.btnAddNewPerson.TextPaddingTop = 0;
            this.btnAddNewPerson.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewPerson.TextShadowOffsetX = 1;
            this.btnAddNewPerson.TextShadowOffsetY = 1;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(1021, 0);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(63, 63);
            this.btnClose1.TabIndex = 43;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
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
            this.btnClose.Location = new System.Drawing.Point(927, 557);
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
            this.btnClose.TabIndex = 45;
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
            // pbPeople
            // 
            this.pbPeople.Image = global::DVLD.Properties.Resources.People_400;
            this.pbPeople.Location = new System.Drawing.Point(420, 12);
            this.pbPeople.Name = "pbPeople";
            this.pbPeople.Size = new System.Drawing.Size(200, 160);
            this.pbPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPeople.TabIndex = 47;
            this.pbPeople.TabStop = false;
            // 
            // dplGender
            // 
            this.dplGender.AllowMultipleSelection = false;
            this.dplGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dplGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.dplGender.CanBeep = false;
            this.dplGender.CanShake = true;
            this.dplGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dplGender.DataSource = null;
            this.dplGender.DisplayMember = null;
            this.dplGender.DropdownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dplGender.DropdownWidth = 0;
            this.dplGender.DropShadowEnabled = false;
            this.dplGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplGender.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dplGender.HoveredItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplGender.IsReadonly = false;
            this.dplGender.ItemHeight = 30;
            this.dplGender.Items.AddRange(new string[] {
            "All",
            "Male",
            "Female"});
            this.dplGender.Location = new System.Drawing.Point(389, 249);
            this.dplGender.Margin = new System.Windows.Forms.Padding(2);
            this.dplGender.MaxDropDownItems = 8;
            this.dplGender.Name = "dplGender";
            this.dplGender.NotFoundBackColor = System.Drawing.Color.Transparent;
            this.dplGender.NotFoundFont = null;
            this.dplGender.NotFoundTextColor = System.Drawing.Color.Gray;
            this.dplGender.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.dplGender.PlaceholderDisappearsOnFocus = true;
            this.dplGender.PlaceholderText = "Select an option";
            this.dplGender.SearchTextBoxHeight = 20;
            this.dplGender.SearchTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplGender.SearchTextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplGender.SelectedIndex = 0;
            this.dplGender.SelectedItem = "All";
            this.dplGender.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.dplGender.SelectedItemTextColor = System.Drawing.Color.White;
            this.dplGender.SelectedValue = null;
            this.dplGender.Size = new System.Drawing.Size(198, 24);
            this.dplGender.TabIndex = 59;
            this.dplGender.Text = "siticoneDropdown1";
            this.dplGender.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplGender.ValueMember = null;
            this.dplGender.Visible = false;
            this.dplGender.ItemSelected += new System.EventHandler<SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs>(this.dplGender_ItemSelected);
            // 
            // frmPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 615);
            this.ControlBox = false;
            this.Controls.Add(this.dplGender);
            this.Controls.Add(this.pbPeople);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.mtxtInputFilter);
            this.Controls.Add(this.lbRecordsValue);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.dplFilterItems);
            this.Controls.Add(this.lbFilterBy);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People";
            this.Load += new System.EventHandler(this.frmPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private SiticoneNetFrameworkUI.SiticoneLabel lbFilterBy;
        private SiticoneNetFrameworkUI.SiticoneDropdown dplFilterItems;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnAddNewPerson;
        private SiticoneNetFrameworkUI.SiticoneDataGridView dgvPeople;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecords;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecordsValue;
        private System.Windows.Forms.MaskedTextBox mtxtInputFilter;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsAppMessageToolStripMenuItem;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private System.Windows.Forms.PictureBox pbPeople;
        private SiticoneNetFrameworkUI.SiticoneDropdown dplGender;
    }
}