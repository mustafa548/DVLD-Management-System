namespace DVLD
{
    partial class frmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbAppointments = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.dgvTestAppointments = new SiticoneNetFrameworkUI.SiticoneDataGridView();
            this.lbRecordsValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbRecords = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.btnAddNewAppointment = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.ctrlRequestInfo1 = new DVLD.ctrlRequestInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(726, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(29, 29);
            this.btnClose1.TabIndex = 76;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(174, 175);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(442, 39);
            this.lbTitle.TabIndex = 71;
            this.lbTitle.Text = "Vision Test Appointments";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAppointments
            // 
            this.lbAppointments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppointments.Location = new System.Drawing.Point(43, 735);
            this.lbAppointments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAppointments.Name = "lbAppointments";
            this.lbAppointments.Size = new System.Drawing.Size(125, 21);
            this.lbAppointments.TabIndex = 80;
            this.lbAppointments.Text = "Appointments:";
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.AllowUserToResizeColumns = false;
            this.dgvTestAppointments.AutoSize = true;
            this.dgvTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvTestAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvTestAppointments.CellFont = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvTestAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTestAppointments.HeaderFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvTestAppointments.Location = new System.Drawing.Point(40, 787);
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.ShowSampleData = true;
            this.dgvTestAppointments.SiticoneAlternatingRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(34)))), ((int)(((byte)(56)))));
            this.dgvTestAppointments.SiticoneBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvTestAppointments.SiticoneCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvTestAppointments.SiticoneDragDropTargetFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvTestAppointments.SiticoneDragGhostAccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvTestAppointments.SiticoneDragGhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvTestAppointments.SiticoneDragGhostBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvTestAppointments.SiticoneDragGhostForeColor = System.Drawing.Color.White;
            this.dgvTestAppointments.SiticoneDragGhostSecondaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvTestAppointments.SiticoneEmptyStateFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTestAppointments.SiticoneEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvTestAppointments.SiticoneEnableConditionalFormatting = true;
            this.dgvTestAppointments.SiticoneGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvTestAppointments.SiticoneHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(18)))), ((int)(((byte)(33)))));
            this.dgvTestAppointments.SiticoneHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvTestAppointments.SiticoneHeaderBottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvTestAppointments.SiticoneHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.dgvTestAppointments.SiticoneOuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(111)))), ((int)(((byte)(201)))));
            this.dgvTestAppointments.SiticoneRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.dgvTestAppointments.SiticoneRowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvTestAppointments.SiticoneRowHeaderBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvTestAppointments.SiticoneRowHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(73)))));
            this.dgvTestAppointments.SiticoneRowSeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(58)))), ((int)(((byte)(86)))));
            this.dgvTestAppointments.SiticoneSelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvTestAppointments.SiticoneSelectionForeColor = System.Drawing.Color.White;
            this.dgvTestAppointments.SiticoneStatusBadgeActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(88)))));
            this.dgvTestAppointments.SiticoneStatusBadgeErrorBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.dgvTestAppointments.SiticoneStatusBadgeFont = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvTestAppointments.SiticoneStatusBadgeForeColor = System.Drawing.Color.White;
            this.dgvTestAppointments.SiticoneStatusBadgeNeutralBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dgvTestAppointments.SiticoneStatusBadgePendingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dgvTestAppointments.SiticoneStatusBadgeWarningBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.dgvTestAppointments.SiticoneSummaryBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(21)))), ((int)(((byte)(39)))));
            this.dgvTestAppointments.SiticoneSummaryFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvTestAppointments.SiticoneSummaryForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.dgvTestAppointments.SiticoneThemeEmptyStateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(193)))), ((int)(((byte)(216)))));
            this.dgvTestAppointments.Size = new System.Drawing.Size(706, 168);
            this.dgvTestAppointments.TabIndex = 81;
            // 
            // lbRecordsValue
            // 
            this.lbRecordsValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordsValue.Location = new System.Drawing.Point(114, 968);
            this.lbRecordsValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecordsValue.Name = "lbRecordsValue";
            this.lbRecordsValue.Size = new System.Drawing.Size(58, 21);
            this.lbRecordsValue.TabIndex = 84;
            this.lbRecordsValue.Text = "4";
            // 
            // lbRecords
            // 
            this.lbRecords.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecords.Location = new System.Drawing.Point(40, 968);
            this.lbRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(70, 21);
            this.lbRecords.TabIndex = 83;
            this.lbRecords.Text = "Records: ";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(172, 80);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Image = global::DVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(171, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.takeTestToolStripMenuItem.Image = global::DVLD.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(171, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
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
            this.btnClose.Location = new System.Drawing.Point(617, 958);
            this.btnClose.MakeRadial = false;
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
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
            this.btnClose.TabIndex = 82;
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
            // pbTest
            // 
            this.pbTest.Image = global::DVLD.Properties.Resources.Written_Test_512;
            this.pbTest.Location = new System.Drawing.Point(290, 12);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(200, 160);
            this.pbTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTest.TabIndex = 78;
            this.pbTest.TabStop = false;
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewAppointment.BadgeBackColor = System.Drawing.Color.Red;
            this.btnAddNewAppointment.BadgeForeColor = System.Drawing.Color.White;
            this.btnAddNewAppointment.BadgeRadius = 8;
            this.btnAddNewAppointment.BadgeRightMargin = 10;
            this.btnAddNewAppointment.BadgeValue = 0;
            this.btnAddNewAppointment.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddNewAppointment.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnAddNewAppointment.BorderColorStart = System.Drawing.Color.White;
            this.btnAddNewAppointment.BorderRadiusBottomLeft = 20;
            this.btnAddNewAppointment.BorderRadiusBottomRight = 20;
            this.btnAddNewAppointment.BorderRadiusTopLeft = 20;
            this.btnAddNewAppointment.BorderRadiusTopRight = 20;
            this.btnAddNewAppointment.BorderThickness = 1;
            this.btnAddNewAppointment.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewAppointment.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewAppointment.ButtonImage = global::DVLD.Properties.Resources.AddAppointment_32;
            this.btnAddNewAppointment.CanBeep = false;
            this.btnAddNewAppointment.CanShake = false;
            this.btnAddNewAppointment.ClickSoundPath = null;
            this.btnAddNewAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewAppointment.DisabledOverlayOpacity = 0.5F;
            this.btnAddNewAppointment.EnableBorderGradient = false;
            this.btnAddNewAppointment.EnableClickSound = false;
            this.btnAddNewAppointment.EnableFocusBorder = false;
            this.btnAddNewAppointment.EnableHoverSound = false;
            this.btnAddNewAppointment.EnablePressScale = false;
            this.btnAddNewAppointment.EnableTextShadow = false;
            this.btnAddNewAppointment.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnAddNewAppointment.FocusBorderThickness = 2;
            this.btnAddNewAppointment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddNewAppointment.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnAddNewAppointment.HoverSoundPath = null;
            this.btnAddNewAppointment.HoverTransitionSpeed = 0.08F;
            this.btnAddNewAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNewAppointment.ImageLeftMargin = 0;
            this.btnAddNewAppointment.ImageRightMargin = 0;
            this.btnAddNewAppointment.ImageSize = 50;
            this.btnAddNewAppointment.IsReadOnly = false;
            this.btnAddNewAppointment.Location = new System.Drawing.Point(652, 718);
            this.btnAddNewAppointment.MakeRadial = false;
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.PressAnimationSpeed = 0.2F;
            this.btnAddNewAppointment.PressDepth = 1;
            this.btnAddNewAppointment.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddNewAppointment.RippleExpandSpeedFactor = 0.05F;
            this.btnAddNewAppointment.RippleFadeSpeedFactor = 0.03F;
            this.btnAddNewAppointment.ShadowBlurFactor = 0.85F;
            this.btnAddNewAppointment.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewAppointment.ShadowOffsetX = 3;
            this.btnAddNewAppointment.ShadowOffsetY = 3;
            this.btnAddNewAppointment.Size = new System.Drawing.Size(68, 54);
            this.btnAddNewAppointment.TabIndex = 72;
            this.btnAddNewAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewAppointment.TextPaddingBottom = 0;
            this.btnAddNewAppointment.TextPaddingLeft = 0;
            this.btnAddNewAppointment.TextPaddingRight = 0;
            this.btnAddNewAppointment.TextPaddingTop = 0;
            this.btnAddNewAppointment.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddNewAppointment.TextShadowOffsetX = 1;
            this.btnAddNewAppointment.TextShadowOffsetY = 1;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // ctrlRequestInfo1
            // 
            this.ctrlRequestInfo1.Location = new System.Drawing.Point(40, 217);
            this.ctrlRequestInfo1.Name = "ctrlRequestInfo1";
            this.ctrlRequestInfo1.Size = new System.Drawing.Size(706, 495);
            this.ctrlRequestInfo1.TabIndex = 79;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(769, 812);
            this.ControlBox = false;
            this.Controls.Add(this.lbRecordsValue);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvTestAppointments);
            this.Controls.Add(this.lbAppointments);
            this.Controls.Add(this.ctrlRequestInfo1);
            this.Controls.Add(this.pbTest);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision Test";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTest;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnAddNewAppointment;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private ctrlRequestInfo ctrlRequestInfo1;
        private SiticoneNetFrameworkUI.SiticoneLabel lbAppointments;
        private SiticoneNetFrameworkUI.SiticoneDataGridView dgvTestAppointments;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecordsValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRecords;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}