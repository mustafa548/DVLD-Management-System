namespace DVLD
{
    partial class frmAddAndEditUser
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
            this.components = new System.ComponentModel.Container();
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.tabControl = new SiticoneNetFrameworkUI.SiticoneTabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.ctrlPersonInfoWithFilter1 = new DVLD.ctrlPersonInfoWithFilter();
            this.tabLoginInfo = new System.Windows.Forms.TabPage();
            this.pbShowHidePass = new System.Windows.Forms.PictureBox();
            this.pbShowHideConfirmPass = new System.Windows.Forms.PictureBox();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbConfirmPassword = new System.Windows.Forms.PictureBox();
            this.pbUserID = new System.Windows.Forms.PictureBox();
            this.btnSave = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.chbIsActive = new SiticoneNetFrameworkUI.SiticoneCheckBoxAdvanced();
            this.txtPassword = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtConfirmPassword = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtUserName = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.lbUserIDValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbConfirmPassword = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbPassword = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbUserName = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbUserID = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(886, 9);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(53, 53);
            this.btnClose1.TabIndex = 44;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(337, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 39);
            this.lbTitle.TabIndex = 45;
            this.lbTitle.Text = "Add New User";
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
            this.tabControl.Controls.Add(this.tabLoginInfo);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.DragIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tabControl.EnableMouseWheelTabSwitch = false;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.GhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.tabControl.GhostForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControl.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControl.Location = new System.Drawing.Point(12, 85);
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
            this.tabControl.TabIndex = 46;
            this.tabControl.TabWidth = 200;
            this.tabControl.UnpinnedIconColor = System.Drawing.Color.Gray;
            this.tabControl.UnselectedTabColor = System.Drawing.Color.Transparent;
            this.tabControl.UnselectedTextColor = System.Drawing.Color.Gray;
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
            // tabLoginInfo
            // 
            this.tabLoginInfo.BackColor = System.Drawing.Color.Transparent;
            this.tabLoginInfo.Controls.Add(this.pbShowHidePass);
            this.tabLoginInfo.Controls.Add(this.pbShowHideConfirmPass);
            this.tabLoginInfo.Controls.Add(this.pbUserName);
            this.tabLoginInfo.Controls.Add(this.pbPassword);
            this.tabLoginInfo.Controls.Add(this.pbConfirmPassword);
            this.tabLoginInfo.Controls.Add(this.pbUserID);
            this.tabLoginInfo.Controls.Add(this.btnSave);
            this.tabLoginInfo.Controls.Add(this.btnClose);
            this.tabLoginInfo.Controls.Add(this.chbIsActive);
            this.tabLoginInfo.Controls.Add(this.txtPassword);
            this.tabLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tabLoginInfo.Controls.Add(this.txtUserName);
            this.tabLoginInfo.Controls.Add(this.lbUserIDValue);
            this.tabLoginInfo.Controls.Add(this.lbConfirmPassword);
            this.tabLoginInfo.Controls.Add(this.lbPassword);
            this.tabLoginInfo.Controls.Add(this.lbUserName);
            this.tabLoginInfo.Controls.Add(this.lbUserID);
            this.tabLoginInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabLoginInfo.Location = new System.Drawing.Point(4, 44);
            this.tabLoginInfo.Name = "tabLoginInfo";
            this.tabLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfo.Size = new System.Drawing.Size(915, 554);
            this.tabControl.SetTabImage(this.tabLoginInfo, global::DVLD.Properties.Resources.Person_32);
            this.tabLoginInfo.TabIndex = 1;
            this.tabLoginInfo.Text = "Login Info";
            this.tabLoginInfo.ToolTipText = "Write The User Info Login";
            // 
            // pbShowHidePass
            // 
            this.pbShowHidePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowHidePass.Image = global::DVLD.Properties.Resources.ShowPassword;
            this.pbShowHidePass.Location = new System.Drawing.Point(554, 184);
            this.pbShowHidePass.Name = "pbShowHidePass";
            this.pbShowHidePass.Size = new System.Drawing.Size(40, 40);
            this.pbShowHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowHidePass.TabIndex = 68;
            this.pbShowHidePass.TabStop = false;
            this.pbShowHidePass.Tag = "true";
            this.pbShowHidePass.Click += new System.EventHandler(this.pbShowHidePass_Click);
            // 
            // pbShowHideConfirmPass
            // 
            this.pbShowHideConfirmPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowHideConfirmPass.Image = global::DVLD.Properties.Resources.ShowPassword;
            this.pbShowHideConfirmPass.Location = new System.Drawing.Point(554, 241);
            this.pbShowHideConfirmPass.Name = "pbShowHideConfirmPass";
            this.pbShowHideConfirmPass.Size = new System.Drawing.Size(40, 40);
            this.pbShowHideConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowHideConfirmPass.TabIndex = 67;
            this.pbShowHideConfirmPass.TabStop = false;
            this.pbShowHideConfirmPass.Tag = "true";
            this.pbShowHideConfirmPass.Click += new System.EventHandler(this.pbShowHideConfirmPass_Click);
            // 
            // pbUserName
            // 
            this.pbUserName.Image = global::DVLD.Properties.Resources.Person_32;
            this.pbUserName.Location = new System.Drawing.Point(225, 127);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(40, 40);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserName.TabIndex = 66;
            this.pbUserName.TabStop = false;
            // 
            // pbPassword
            // 
            this.pbPassword.Image = global::DVLD.Properties.Resources.Password_32;
            this.pbPassword.Location = new System.Drawing.Point(225, 184);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(40, 40);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPassword.TabIndex = 65;
            this.pbPassword.TabStop = false;
            // 
            // pbConfirmPassword
            // 
            this.pbConfirmPassword.Image = global::DVLD.Properties.Resources.Password_32;
            this.pbConfirmPassword.Location = new System.Drawing.Point(225, 241);
            this.pbConfirmPassword.Name = "pbConfirmPassword";
            this.pbConfirmPassword.Size = new System.Drawing.Size(40, 40);
            this.pbConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConfirmPassword.TabIndex = 64;
            this.pbConfirmPassword.TabStop = false;
            // 
            // pbUserID
            // 
            this.pbUserID.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbUserID.Location = new System.Drawing.Point(225, 70);
            this.pbUserID.Name = "pbUserID";
            this.pbUserID.Size = new System.Drawing.Size(40, 40);
            this.pbUserID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserID.TabIndex = 63;
            this.pbUserID.TabStop = false;
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
            // chbIsActive
            // 
            this.chbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.chbIsActive.Checked = true;
            this.chbIsActive.CheckedBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(21)))), ((int)(((byte)(243)))));
            this.chbIsActive.CheckState = SiticoneNetFrameworkUI.CheckState.Checked;
            this.chbIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbIsActive.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chbIsActive.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.chbIsActive.Location = new System.Drawing.Point(225, 312);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(101, 22);
            this.chbIsActive.Style = SiticoneNetFrameworkUI.CheckBoxStyleAdvanced.Glow;
            this.chbIsActive.TabIndex = 60;
            this.chbIsActive.Text = "Is Active";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.BottomLeftCornerRadius = 12;
            this.txtPassword.BottomRightCornerRadius = 12;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtPassword.FocusImage = null;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtPassword.HoverImage = null;
            this.txtPassword.IdleImage = null;
            this.txtPassword.InputType = SiticoneNetFrameworkUI.AdvancedTextBoxInputType.Password;
            this.txtPassword.Location = new System.Drawing.Point(270, 193);
            this.txtPassword.MakeRadial = true;
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtPassword.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPassword.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPassword.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPassword.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtPassword.Size = new System.Drawing.Size(279, 25);
            this.txtPassword.TabIndex = 58;
            this.txtPassword.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtPassword.TextContent = "";
            this.txtPassword.TopLeftCornerRadius = 12;
            this.txtPassword.TopRightCornerRadius = 12;
            this.txtPassword.ValidationEnabled = false;
            this.txtPassword.ValidationPattern = "";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BackgroundColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.BottomLeftCornerRadius = 12;
            this.txtConfirmPassword.BottomRightCornerRadius = 12;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtConfirmPassword.FocusImage = null;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.HoverImage = null;
            this.txtConfirmPassword.IdleImage = null;
            this.txtConfirmPassword.InputType = SiticoneNetFrameworkUI.AdvancedTextBoxInputType.Password;
            this.txtConfirmPassword.Location = new System.Drawing.Point(270, 249);
            this.txtConfirmPassword.MakeRadial = true;
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtConfirmPassword.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtConfirmPassword.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtConfirmPassword.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtConfirmPassword.Size = new System.Drawing.Size(279, 25);
            this.txtConfirmPassword.TabIndex = 57;
            this.txtConfirmPassword.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtConfirmPassword.TextContent = "";
            this.txtConfirmPassword.TopLeftCornerRadius = 12;
            this.txtConfirmPassword.TopRightCornerRadius = 12;
            this.txtConfirmPassword.ValidationEnabled = false;
            this.txtConfirmPassword.ValidationPattern = "";
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.BackgroundColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtUserName.BottomLeftCornerRadius = 12;
            this.txtUserName.BottomRightCornerRadius = 12;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtUserName.FocusImage = null;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtUserName.HoverImage = null;
            this.txtUserName.IdleImage = null;
            this.txtUserName.Location = new System.Drawing.Point(270, 134);
            this.txtUserName.MakeRadial = true;
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtUserName.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.PlaceholderText = "User Name";
            this.txtUserName.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserName.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtUserName.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtUserName.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtUserName.Size = new System.Drawing.Size(279, 25);
            this.txtUserName.TabIndex = 56;
            this.txtUserName.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.TextContent = "";
            this.txtUserName.TopLeftCornerRadius = 12;
            this.txtUserName.TopRightCornerRadius = 12;
            this.txtUserName.ValidationEnabled = false;
            this.txtUserName.ValidationPattern = "";
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lbUserIDValue
            // 
            this.lbUserIDValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIDValue.Location = new System.Drawing.Point(270, 79);
            this.lbUserIDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserIDValue.Name = "lbUserIDValue";
            this.lbUserIDValue.Size = new System.Drawing.Size(66, 21);
            this.lbUserIDValue.TabIndex = 55;
            this.lbUserIDValue.Text = "???";
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.Location = new System.Drawing.Point(75, 256);
            this.lbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(145, 21);
            this.lbConfirmPassword.TabIndex = 50;
            this.lbConfirmPassword.Text = "Confirm Password:";
            // 
            // lbPassword
            // 
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(141, 197);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(79, 21);
            this.lbPassword.TabIndex = 49;
            this.lbPassword.Text = "Password:";
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(126, 138);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(94, 21);
            this.lbUserName.TabIndex = 48;
            this.lbUserName.Text = "User Name:";
            // 
            // lbUserID
            // 
            this.lbUserID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(154, 79);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(66, 21);
            this.lbUserID.TabIndex = 47;
            this.lbUserID.Text = "User ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddAndEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 686);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Users";
            this.Load += new System.EventHandler(this.frmAddAndEditUser_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabLoginInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private SiticoneNetFrameworkUI.SiticoneTabControl tabControl;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private System.Windows.Forms.TabPage tabLoginInfo;
        private ctrlPersonInfoWithFilter ctrlPersonInfoWithFilter1;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnNext;
        private SiticoneNetFrameworkUI.SiticoneLabel lbUserID;
        private SiticoneNetFrameworkUI.SiticoneLabel lbConfirmPassword;
        private SiticoneNetFrameworkUI.SiticoneLabel lbPassword;
        private SiticoneNetFrameworkUI.SiticoneLabel lbUserName;
        private SiticoneNetFrameworkUI.SiticoneLabel lbUserIDValue;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtPassword;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtConfirmPassword;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtUserName;
        private SiticoneNetFrameworkUI.SiticoneCheckBoxAdvanced chbIsActive;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnSave;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbUserID;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbConfirmPassword;
        private System.Windows.Forms.PictureBox pbShowHidePass;
        private System.Windows.Forms.PictureBox pbShowHideConfirmPass;
    }
}