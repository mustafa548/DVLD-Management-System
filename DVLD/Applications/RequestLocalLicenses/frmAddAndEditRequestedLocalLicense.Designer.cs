namespace DVLD
{
    partial class frmAddAndEditRequestedLocalLicense
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
            this.tabControl = new SiticoneNetFrameworkUI.SiticoneTabControl();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.ctrlPersonInfoWithFilter1 = new DVLD.ctrlPersonInfoWithFilter();
            this.tabApplicationInfo = new System.Windows.Forms.TabPage();
            this.dplLicenseClasses = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.lbApplicationDateValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbApplicationFeesValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbCreatedByValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pbCreatedBy = new System.Windows.Forms.PictureBox();
            this.lbCreatedBy = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pbRequestID = new System.Windows.Forms.PictureBox();
            this.pbApplicationFees = new System.Windows.Forms.PictureBox();
            this.pbApplicationDate = new System.Windows.Forms.PictureBox();
            this.pbLicenseClass = new System.Windows.Forms.PictureBox();
            this.btnSave = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.lbRequestIDValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbApplicationFees = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbLicenseClass = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbApplicationDate = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbRequestID = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.tabControl.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequestID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).BeginInit();
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
            this.tabControl.Controls.Add(this.tabPersonInfo);
            this.tabControl.Controls.Add(this.tabApplicationInfo);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.DragIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tabControl.EnableMouseWheelTabSwitch = false;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.GhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.tabControl.GhostForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControl.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControl.Location = new System.Drawing.Point(60, 79);
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
            this.tabControl.Size = new System.Drawing.Size(923, 602);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabCornerRadiusBottomLeft = 20;
            this.tabControl.TabCornerRadiusBottomRight = 20;
            this.tabControl.TabCornerRadiusTopLeft = 20;
            this.tabControl.TabCornerRadiusTopRight = 20;
            this.tabControl.TabImageSize = 35;
            this.tabControl.TabImageTextGap = 6;
            this.tabControl.TabIndex = 49;
            this.tabControl.TabWidth = 200;
            this.tabControl.UnpinnedIconColor = System.Drawing.Color.Gray;
            this.tabControl.UnselectedTabColor = System.Drawing.Color.Transparent;
            this.tabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(282, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(492, 39);
            this.lbTitle.TabIndex = 48;
            this.lbTitle.Text = "New Local Driving License Application";
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(1008, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(27, 27);
            this.btnClose1.TabIndex = 47;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.BackColor = System.Drawing.Color.Transparent;
            this.tabPersonInfo.Controls.Add(this.btnNext);
            this.tabPersonInfo.Controls.Add(this.ctrlPersonInfoWithFilter1);
            this.tabPersonInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(915, 554);
            this.tabControl.SetTabImage(this.tabPersonInfo, global::DVLD.Properties.Resources.People_64);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            this.tabPersonInfo.ToolTipText = "Connect User With Person";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BadgeBackColor = System.Drawing.Color.Red;
            this.btnNext.BadgeForeColor = System.Drawing.Color.White;
            this.btnNext.BadgeRadius = 8;
            this.btnNext.BadgeRightMargin = 10;
            this.btnNext.BadgeValue = 0;
            this.btnNext.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNext.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnNext.BorderColorStart = System.Drawing.Color.White;
            this.btnNext.BorderRadiusBottomLeft = 10;
            this.btnNext.BorderRadiusBottomRight = 10;
            this.btnNext.BorderRadiusTopLeft = 10;
            this.btnNext.BorderRadiusTopRight = 10;
            this.btnNext.BorderThickness = 1;
            this.btnNext.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnNext.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnNext.ButtonImage = global::DVLD.Properties.Resources.Next_32;
            this.btnNext.CanBeep = false;
            this.btnNext.CanShake = false;
            this.btnNext.ClickSoundPath = null;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledOverlayOpacity = 0.5F;
            this.btnNext.EnableBorderGradient = false;
            this.btnNext.EnableClickSound = false;
            this.btnNext.EnableFocusBorder = false;
            this.btnNext.EnableHoverSound = false;
            this.btnNext.EnablePressScale = false;
            this.btnNext.EnableTextShadow = false;
            this.btnNext.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnNext.FocusBorderThickness = 2;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnNext.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnNext.HoverSoundPath = null;
            this.btnNext.HoverTransitionSpeed = 0.08F;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.ImageLeftMargin = 0;
            this.btnNext.ImageRightMargin = 3;
            this.btnNext.ImageSize = 25;
            this.btnNext.IsReadOnly = false;
            this.btnNext.Location = new System.Drawing.Point(794, 507);
            this.btnNext.MakeRadial = false;
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressAnimationSpeed = 0.2F;
            this.btnNext.PressDepth = 1;
            this.btnNext.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNext.RippleExpandSpeedFactor = 0.05F;
            this.btnNext.RippleFadeSpeedFactor = 0.03F;
            this.btnNext.ShadowBlurFactor = 0.85F;
            this.btnNext.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.ShadowOffsetX = 3;
            this.btnNext.ShadowOffsetY = 3;
            this.btnNext.Size = new System.Drawing.Size(118, 41);
            this.btnNext.TabIndex = 42;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.TextPaddingBottom = 0;
            this.btnNext.TextPaddingLeft = 15;
            this.btnNext.TextPaddingRight = 0;
            this.btnNext.TextPaddingTop = 0;
            this.btnNext.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.TextShadowOffsetX = 1;
            this.btnNext.TextShadowOffsetY = 1;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrlPersonInfoWithFilter1
            // 
            this.ctrlPersonInfoWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPersonInfoWithFilter1.Name = "ctrlPersonInfoWithFilter1";
            this.ctrlPersonInfoWithFilter1.Size = new System.Drawing.Size(907, 498);
            this.ctrlPersonInfoWithFilter1.TabIndex = 0;
            this.ctrlPersonInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrlPersonInfoWithFilter1_OnPersonSelected);
            // 
            // tabApplicationInfo
            // 
            this.tabApplicationInfo.BackColor = System.Drawing.Color.Transparent;
            this.tabApplicationInfo.Controls.Add(this.dplLicenseClasses);
            this.tabApplicationInfo.Controls.Add(this.lbApplicationDateValue);
            this.tabApplicationInfo.Controls.Add(this.lbApplicationFeesValue);
            this.tabApplicationInfo.Controls.Add(this.lbCreatedByValue);
            this.tabApplicationInfo.Controls.Add(this.pbCreatedBy);
            this.tabApplicationInfo.Controls.Add(this.lbCreatedBy);
            this.tabApplicationInfo.Controls.Add(this.pbRequestID);
            this.tabApplicationInfo.Controls.Add(this.pbApplicationFees);
            this.tabApplicationInfo.Controls.Add(this.pbApplicationDate);
            this.tabApplicationInfo.Controls.Add(this.pbLicenseClass);
            this.tabApplicationInfo.Controls.Add(this.btnSave);
            this.tabApplicationInfo.Controls.Add(this.btnClose);
            this.tabApplicationInfo.Controls.Add(this.lbRequestIDValue);
            this.tabApplicationInfo.Controls.Add(this.lbApplicationFees);
            this.tabApplicationInfo.Controls.Add(this.lbLicenseClass);
            this.tabApplicationInfo.Controls.Add(this.lbApplicationDate);
            this.tabApplicationInfo.Controls.Add(this.lbRequestID);
            this.tabApplicationInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabApplicationInfo.Location = new System.Drawing.Point(4, 44);
            this.tabApplicationInfo.Name = "tabApplicationInfo";
            this.tabApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplicationInfo.Size = new System.Drawing.Size(915, 554);
            this.tabControl.SetTabImage(this.tabApplicationInfo, global::DVLD.Properties.Resources.Manage_Applications_32);
            this.tabApplicationInfo.TabIndex = 1;
            this.tabApplicationInfo.Text = "Application Info";
            this.tabApplicationInfo.ToolTipText = "Write The User Info Login";
            // 
            // dplLicenseClasses
            // 
            this.dplLicenseClasses.AllowMultipleSelection = false;
            this.dplLicenseClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dplLicenseClasses.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.dplLicenseClasses.CanBeep = false;
            this.dplLicenseClasses.CanShake = true;
            this.dplLicenseClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dplLicenseClasses.DataSource = null;
            this.dplLicenseClasses.DisplayMember = null;
            this.dplLicenseClasses.DropdownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dplLicenseClasses.DropdownWidth = 0;
            this.dplLicenseClasses.DropShadowEnabled = false;
            this.dplLicenseClasses.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplLicenseClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplLicenseClasses.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dplLicenseClasses.HoveredItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplLicenseClasses.IsReadonly = false;
            this.dplLicenseClasses.ItemHeight = 30;
            this.dplLicenseClasses.Location = new System.Drawing.Point(316, 172);
            this.dplLicenseClasses.Margin = new System.Windows.Forms.Padding(2);
            this.dplLicenseClasses.MaxDropDownItems = 8;
            this.dplLicenseClasses.Name = "dplLicenseClasses";
            this.dplLicenseClasses.NotFoundBackColor = System.Drawing.Color.Transparent;
            this.dplLicenseClasses.NotFoundFont = null;
            this.dplLicenseClasses.NotFoundTextColor = System.Drawing.Color.Gray;
            this.dplLicenseClasses.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.dplLicenseClasses.PlaceholderDisappearsOnFocus = true;
            this.dplLicenseClasses.PlaceholderText = "Select an option";
            this.dplLicenseClasses.SearchTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplLicenseClasses.SearchTextFont = null;
            this.dplLicenseClasses.SelectedIndex = -1;
            this.dplLicenseClasses.SelectedItem = null;
            this.dplLicenseClasses.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.dplLicenseClasses.SelectedItemTextColor = System.Drawing.Color.White;
            this.dplLicenseClasses.SelectedValue = null;
            this.dplLicenseClasses.Size = new System.Drawing.Size(343, 24);
            this.dplLicenseClasses.TabIndex = 74;
            this.dplLicenseClasses.Text = "siticoneDropdown1";
            this.dplLicenseClasses.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplLicenseClasses.ValueMember = null;
            // 
            // lbApplicationDateValue
            // 
            this.lbApplicationDateValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDateValue.Location = new System.Drawing.Point(316, 118);
            this.lbApplicationDateValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApplicationDateValue.Name = "lbApplicationDateValue";
            this.lbApplicationDateValue.Size = new System.Drawing.Size(144, 21);
            this.lbApplicationDateValue.TabIndex = 73;
            this.lbApplicationDateValue.Text = "1/9/2020";
            // 
            // lbApplicationFeesValue
            // 
            this.lbApplicationFeesValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFeesValue.Location = new System.Drawing.Point(316, 232);
            this.lbApplicationFeesValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApplicationFeesValue.Name = "lbApplicationFeesValue";
            this.lbApplicationFeesValue.Size = new System.Drawing.Size(73, 21);
            this.lbApplicationFeesValue.TabIndex = 72;
            this.lbApplicationFeesValue.Text = "15";
            // 
            // lbCreatedByValue
            // 
            this.lbCreatedByValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedByValue.Location = new System.Drawing.Point(316, 289);
            this.lbCreatedByValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreatedByValue.Name = "lbCreatedByValue";
            this.lbCreatedByValue.Size = new System.Drawing.Size(144, 21);
            this.lbCreatedByValue.TabIndex = 71;
            this.lbCreatedByValue.Text = "User1";
            // 
            // pbCreatedBy
            // 
            this.pbCreatedBy.Image = global::DVLD.Properties.Resources.User_32__2;
            this.pbCreatedBy.Location = new System.Drawing.Point(271, 279);
            this.pbCreatedBy.Name = "pbCreatedBy";
            this.pbCreatedBy.Size = new System.Drawing.Size(40, 40);
            this.pbCreatedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCreatedBy.TabIndex = 70;
            this.pbCreatedBy.TabStop = false;
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(170, 289);
            this.lbCreatedBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(96, 21);
            this.lbCreatedBy.TabIndex = 69;
            this.lbCreatedBy.Text = "Created By:";
            // 
            // pbRequestID
            // 
            this.pbRequestID.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbRequestID.Location = new System.Drawing.Point(271, 52);
            this.pbRequestID.Name = "pbRequestID";
            this.pbRequestID.Size = new System.Drawing.Size(40, 40);
            this.pbRequestID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRequestID.TabIndex = 66;
            this.pbRequestID.TabStop = false;
            // 
            // pbApplicationFees
            // 
            this.pbApplicationFees.Image = global::DVLD.Properties.Resources.money_32;
            this.pbApplicationFees.Location = new System.Drawing.Point(271, 222);
            this.pbApplicationFees.Name = "pbApplicationFees";
            this.pbApplicationFees.Size = new System.Drawing.Size(40, 40);
            this.pbApplicationFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbApplicationFees.TabIndex = 65;
            this.pbApplicationFees.TabStop = false;
            // 
            // pbApplicationDate
            // 
            this.pbApplicationDate.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pbApplicationDate.Location = new System.Drawing.Point(271, 108);
            this.pbApplicationDate.Name = "pbApplicationDate";
            this.pbApplicationDate.Size = new System.Drawing.Size(40, 40);
            this.pbApplicationDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbApplicationDate.TabIndex = 64;
            this.pbApplicationDate.TabStop = false;
            // 
            // pbLicenseClass
            // 
            this.pbLicenseClass.Image = global::DVLD.Properties.Resources.LocalDriving_License1;
            this.pbLicenseClass.Location = new System.Drawing.Point(271, 165);
            this.pbLicenseClass.Name = "pbLicenseClass";
            this.pbLicenseClass.Size = new System.Drawing.Size(40, 40);
            this.pbLicenseClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLicenseClass.TabIndex = 63;
            this.pbLicenseClass.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BadgeBackColor = System.Drawing.Color.Red;
            this.btnSave.BadgeForeColor = System.Drawing.Color.White;
            this.btnSave.BadgeRadius = 8;
            this.btnSave.BadgeRightMargin = 10;
            this.btnSave.BadgeValue = 0;
            this.btnSave.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnSave.BorderColorStart = System.Drawing.Color.White;
            this.btnSave.BorderRadiusBottomLeft = 10;
            this.btnSave.BorderRadiusBottomRight = 10;
            this.btnSave.BorderRadiusTopLeft = 10;
            this.btnSave.BorderRadiusTopRight = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSave.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSave.ButtonImage = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.CanBeep = false;
            this.btnSave.CanShake = false;
            this.btnSave.ClickSoundPath = null;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledOverlayOpacity = 0.5F;
            this.btnSave.EnableBorderGradient = false;
            this.btnSave.EnableClickSound = false;
            this.btnSave.EnableFocusBorder = false;
            this.btnSave.EnableHoverSound = false;
            this.btnSave.EnablePressScale = false;
            this.btnSave.EnableTextShadow = false;
            this.btnSave.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSave.FocusBorderThickness = 2;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnSave.HoverSoundPath = null;
            this.btnSave.HoverTransitionSpeed = 0.08F;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageLeftMargin = 0;
            this.btnSave.ImageRightMargin = 3;
            this.btnSave.ImageSize = 25;
            this.btnSave.IsReadOnly = false;
            this.btnSave.Location = new System.Drawing.Point(783, 497);
            this.btnSave.MakeRadial = false;
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressAnimationSpeed = 0.2F;
            this.btnSave.PressDepth = 1;
            this.btnSave.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.RippleExpandSpeedFactor = 0.05F;
            this.btnSave.RippleFadeSpeedFactor = 0.03F;
            this.btnSave.ShadowBlurFactor = 0.85F;
            this.btnSave.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.ShadowOffsetX = 3;
            this.btnSave.ShadowOffsetY = 3;
            this.btnSave.Size = new System.Drawing.Size(118, 41);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextPaddingBottom = 0;
            this.btnSave.TextPaddingLeft = 15;
            this.btnSave.TextPaddingRight = 0;
            this.btnSave.TextPaddingTop = 0;
            this.btnSave.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.TextShadowOffsetX = 1;
            this.btnSave.TextShadowOffsetY = 1;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(652, 497);
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
            this.btnClose.TabIndex = 47;
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
            // lbRequestIDValue
            // 
            this.lbRequestIDValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequestIDValue.Location = new System.Drawing.Point(316, 61);
            this.lbRequestIDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRequestIDValue.Name = "lbRequestIDValue";
            this.lbRequestIDValue.Size = new System.Drawing.Size(66, 21);
            this.lbRequestIDValue.TabIndex = 55;
            this.lbRequestIDValue.Text = "???";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationFees.Location = new System.Drawing.Point(134, 232);
            this.lbApplicationFees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(132, 21);
            this.lbApplicationFees.TabIndex = 50;
            this.lbApplicationFees.Text = "Application Fees:";
            // 
            // lbLicenseClass
            // 
            this.lbLicenseClass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseClass.Location = new System.Drawing.Point(153, 175);
            this.lbLicenseClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLicenseClass.Name = "lbLicenseClass";
            this.lbLicenseClass.Size = new System.Drawing.Size(113, 21);
            this.lbLicenseClass.TabIndex = 49;
            this.lbLicenseClass.Text = "License Class:";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApplicationDate.Location = new System.Drawing.Point(126, 118);
            this.lbApplicationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(140, 21);
            this.lbApplicationDate.TabIndex = 48;
            this.lbApplicationDate.Text = "Application Date:";
            // 
            // lbRequestID
            // 
            this.lbRequestID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequestID.Location = new System.Drawing.Point(165, 61);
            this.lbRequestID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRequestID.Name = "lbRequestID";
            this.lbRequestID.Size = new System.Drawing.Size(101, 21);
            this.lbRequestID.TabIndex = 47;
            this.lbRequestID.Text = "Request ID:";
            // 
            // frmAddAndEditRequestedLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 685);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndEditRequestedLocalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Requested Local Licenses";
            this.Load += new System.EventHandler(this.frmAddAndEditRequestedLocalLicense_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabApplicationInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCreatedBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRequestID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApplicationDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLicenseClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneTabControl tabControl;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnNext;
        private ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private System.Windows.Forms.TabPage tabApplicationInfo;
        private System.Windows.Forms.PictureBox pbRequestID;
        private System.Windows.Forms.PictureBox pbApplicationFees;
        private System.Windows.Forms.PictureBox pbApplicationDate;
        private System.Windows.Forms.PictureBox pbLicenseClass;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnSave;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRequestIDValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbApplicationFees;
        private SiticoneNetFrameworkUI.SiticoneLabel lbLicenseClass;
        private SiticoneNetFrameworkUI.SiticoneLabel lbApplicationDate;
        private SiticoneNetFrameworkUI.SiticoneLabel lbRequestID;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneLabel lbCreatedBy;
        private System.Windows.Forms.PictureBox pbCreatedBy;
        private SiticoneNetFrameworkUI.SiticoneLabel lbApplicationDateValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbApplicationFeesValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbCreatedByValue;
        private SiticoneNetFrameworkUI.SiticoneDropdown dplLicenseClasses;
    }
}