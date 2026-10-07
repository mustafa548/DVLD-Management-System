namespace DVLD
{
    partial class frmForgetPassword
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
            this.tabControl = new SiticoneNetFrameworkUI.SiticoneTabControl();
            this.tabUserName = new System.Windows.Forms.TabPage();
            this.lbWaiting = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.txtUserName = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.lbUserName = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.btnSendOTP = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.tabVerification = new System.Windows.Forms.TabPage();
            this.btnVerify = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.lbNote = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pbOTP = new System.Windows.Forms.PictureBox();
            this.lbOTP = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.txtOTP = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.tabResetPassword = new System.Windows.Forms.TabPage();
            this.btnResetPassword = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.pbShowHideNewPass = new System.Windows.Forms.PictureBox();
            this.txtNewPassword = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.pbShowHideConfirmPass = new System.Windows.Forms.PictureBox();
            this.lbNewPassword = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pbNewPassword = new System.Windows.Forms.PictureBox();
            this.lbConfirmPassword = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pbConfirmPassword = new System.Windows.Forms.PictureBox();
            this.txtConfirmPassword = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.llbResendOTP = new SiticoneNetFrameworkUI.SiticoneLinkedLabel();
            this.lbTimer = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbWaiting2 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.tabControl.SuspendLayout();
            this.tabUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).BeginInit();
            this.tabVerification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOTP)).BeginInit();
            this.tabResetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(753, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(35, 35);
            this.btnClose1.TabIndex = 4;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
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
            this.tabControl.Controls.Add(this.tabUserName);
            this.tabControl.Controls.Add(this.tabVerification);
            this.tabControl.Controls.Add(this.tabResetPassword);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.DragIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.tabControl.EnableMouseWheelTabSwitch = false;
            this.tabControl.EnablePulseEffects = false;
            this.tabControl.EnableRippleEffects = false;
            this.tabControl.EnableScaleEffects = false;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.GhostBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.tabControl.GhostForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControl.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControl.Location = new System.Drawing.Point(67, 61);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.PinIconHoverColor = System.Drawing.Color.DarkGray;
            this.tabControl.PinnedIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.tabControl.PinThickness = 3F;
            this.tabControl.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedTabBackColor = System.Drawing.Color.Transparent;
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.SelectedTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(65)))));
            this.tabControl.SelectedTabIndicatorHeight = 3;
            this.tabControl.SelectedTextColor = System.Drawing.Color.Gray;
            this.tabControl.SeparatorLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tabControl.SeparatorLineOpacity = 0.6F;
            this.tabControl.SeparatorLineThickness = 2;
            this.tabControl.ShowSeparatorLine = true;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(637, 232);
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
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // tabUserName
            // 
            this.tabUserName.BackColor = System.Drawing.Color.Transparent;
            this.tabUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabUserName.Controls.Add(this.lbWaiting);
            this.tabUserName.Controls.Add(this.pbUserName);
            this.tabUserName.Controls.Add(this.txtUserName);
            this.tabUserName.Controls.Add(this.lbUserName);
            this.tabUserName.Controls.Add(this.btnSendOTP);
            this.tabUserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUserName.ForeColor = System.Drawing.Color.Black;
            this.tabUserName.Location = new System.Drawing.Point(4, 44);
            this.tabUserName.Name = "tabUserName";
            this.tabUserName.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserName.Size = new System.Drawing.Size(629, 184);
            this.tabControl.SetTabImage(this.tabUserName, global::DVLD.Properties.Resources.Person_32);
            this.tabUserName.TabIndex = 0;
            this.tabUserName.Text = "User Name";
            this.tabUserName.ToolTipText = "Enter Your User Name";
            // 
            // lbWaiting
            // 
            this.lbWaiting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.Location = new System.Drawing.Point(198, 158);
            this.lbWaiting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(94, 21);
            this.lbWaiting.TabIndex = 76;
            this.lbWaiting.Text = "Waiting...";
            this.lbWaiting.Visible = false;
            // 
            // pbUserName
            // 
            this.pbUserName.Image = global::DVLD.Properties.Resources.Person_32;
            this.pbUserName.Location = new System.Drawing.Point(108, 33);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(35, 35);
            this.pbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserName.TabIndex = 77;
            this.pbUserName.TabStop = false;
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
            this.txtUserName.Location = new System.Drawing.Point(148, 38);
            this.txtUserName.MakeRadial = true;
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtUserName.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.PlaceholderText = "Enter Your User Name";
            this.txtUserName.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtUserName.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtUserName.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtUserName.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtUserName.Size = new System.Drawing.Size(325, 25);
            this.txtUserName.TabIndex = 76;
            this.txtUserName.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtUserName.TextContent = "";
            this.txtUserName.TopLeftCornerRadius = 12;
            this.txtUserName.TopRightCornerRadius = 12;
            this.txtUserName.ValidationEnabled = false;
            this.txtUserName.ValidationPattern = "";
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(9, 42);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(94, 21);
            this.lbUserName.TabIndex = 75;
            this.lbUserName.Text = "User Name:";
            // 
            // btnSendOTP
            // 
            this.btnSendOTP.BackColor = System.Drawing.Color.Transparent;
            this.btnSendOTP.BadgeBackColor = System.Drawing.Color.Red;
            this.btnSendOTP.BadgeForeColor = System.Drawing.Color.White;
            this.btnSendOTP.BadgeRadius = 8;
            this.btnSendOTP.BadgeRightMargin = 10;
            this.btnSendOTP.BadgeValue = 0;
            this.btnSendOTP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSendOTP.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnSendOTP.BorderColorStart = System.Drawing.Color.White;
            this.btnSendOTP.BorderRadiusBottomLeft = 10;
            this.btnSendOTP.BorderRadiusBottomRight = 10;
            this.btnSendOTP.BorderRadiusTopLeft = 10;
            this.btnSendOTP.BorderRadiusTopRight = 10;
            this.btnSendOTP.BorderThickness = 1;
            this.btnSendOTP.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnSendOTP.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnSendOTP.ButtonImage = global::DVLD.Properties.Resources.PersonDetails_32;
            this.btnSendOTP.CanBeep = false;
            this.btnSendOTP.CanShake = false;
            this.btnSendOTP.ClickSoundPath = null;
            this.btnSendOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendOTP.DisabledOverlayOpacity = 0.5F;
            this.btnSendOTP.EnableBorderGradient = false;
            this.btnSendOTP.EnableClickSound = false;
            this.btnSendOTP.EnableFocusBorder = false;
            this.btnSendOTP.EnableHoverSound = false;
            this.btnSendOTP.EnablePressScale = false;
            this.btnSendOTP.EnableTextShadow = false;
            this.btnSendOTP.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSendOTP.FocusBorderThickness = 2;
            this.btnSendOTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnSendOTP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnSendOTP.HoverSoundPath = null;
            this.btnSendOTP.HoverTransitionSpeed = 0.08F;
            this.btnSendOTP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendOTP.ImageLeftMargin = 0;
            this.btnSendOTP.ImageRightMargin = 3;
            this.btnSendOTP.ImageSize = 25;
            this.btnSendOTP.IsReadOnly = false;
            this.btnSendOTP.Location = new System.Drawing.Point(480, 138);
            this.btnSendOTP.MakeRadial = false;
            this.btnSendOTP.Margin = new System.Windows.Forms.Padding(0);
            this.btnSendOTP.Name = "btnSendOTP";
            this.btnSendOTP.PressAnimationSpeed = 0.2F;
            this.btnSendOTP.PressDepth = 1;
            this.btnSendOTP.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSendOTP.RippleExpandSpeedFactor = 0.05F;
            this.btnSendOTP.RippleFadeSpeedFactor = 0.03F;
            this.btnSendOTP.ShadowBlurFactor = 0.85F;
            this.btnSendOTP.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSendOTP.ShadowOffsetX = 3;
            this.btnSendOTP.ShadowOffsetY = 3;
            this.btnSendOTP.Size = new System.Drawing.Size(146, 41);
            this.btnSendOTP.TabIndex = 42;
            this.btnSendOTP.Text = "Send OTP";
            this.btnSendOTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendOTP.TextPaddingBottom = 0;
            this.btnSendOTP.TextPaddingLeft = 15;
            this.btnSendOTP.TextPaddingRight = 0;
            this.btnSendOTP.TextPaddingTop = 0;
            this.btnSendOTP.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSendOTP.TextShadowOffsetX = 1;
            this.btnSendOTP.TextShadowOffsetY = 1;
            this.btnSendOTP.Click += new System.EventHandler(this.btnSendOTP_Click);
            // 
            // tabVerification
            // 
            this.tabVerification.BackColor = System.Drawing.Color.Transparent;
            this.tabVerification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabVerification.Controls.Add(this.lbWaiting2);
            this.tabVerification.Controls.Add(this.lbTimer);
            this.tabVerification.Controls.Add(this.llbResendOTP);
            this.tabVerification.Controls.Add(this.btnVerify);
            this.tabVerification.Controls.Add(this.lbNote);
            this.tabVerification.Controls.Add(this.pbOTP);
            this.tabVerification.Controls.Add(this.lbOTP);
            this.tabVerification.Controls.Add(this.txtOTP);
            this.tabVerification.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabVerification.Location = new System.Drawing.Point(4, 44);
            this.tabVerification.Name = "tabVerification";
            this.tabVerification.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerification.Size = new System.Drawing.Size(629, 184);
            this.tabControl.SetTabImage(this.tabVerification, global::DVLD.Properties.Resources.CheckLock);
            this.tabVerification.TabIndex = 1;
            this.tabVerification.Text = "Verification";
            this.tabVerification.ToolTipText = "Verify Your User Name";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Transparent;
            this.btnVerify.BadgeBackColor = System.Drawing.Color.Red;
            this.btnVerify.BadgeForeColor = System.Drawing.Color.White;
            this.btnVerify.BadgeRadius = 8;
            this.btnVerify.BadgeRightMargin = 10;
            this.btnVerify.BadgeValue = 0;
            this.btnVerify.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnVerify.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnVerify.BorderColorStart = System.Drawing.Color.White;
            this.btnVerify.BorderRadiusBottomLeft = 10;
            this.btnVerify.BorderRadiusBottomRight = 10;
            this.btnVerify.BorderRadiusTopLeft = 10;
            this.btnVerify.BorderRadiusTopRight = 10;
            this.btnVerify.BorderThickness = 1;
            this.btnVerify.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnVerify.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnVerify.ButtonImage = global::DVLD.Properties.Resources.Checked;
            this.btnVerify.CanBeep = false;
            this.btnVerify.CanShake = false;
            this.btnVerify.ClickSoundPath = null;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.DisabledOverlayOpacity = 0.5F;
            this.btnVerify.EnableBorderGradient = false;
            this.btnVerify.EnableClickSound = false;
            this.btnVerify.EnableFocusBorder = false;
            this.btnVerify.EnableHoverSound = false;
            this.btnVerify.EnablePressScale = false;
            this.btnVerify.EnableTextShadow = false;
            this.btnVerify.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnVerify.FocusBorderThickness = 2;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnVerify.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.btnVerify.HoverSoundPath = null;
            this.btnVerify.HoverTransitionSpeed = 0.08F;
            this.btnVerify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerify.ImageLeftMargin = 0;
            this.btnVerify.ImageRightMargin = 3;
            this.btnVerify.ImageSize = 25;
            this.btnVerify.IsReadOnly = false;
            this.btnVerify.Location = new System.Drawing.Point(508, 140);
            this.btnVerify.MakeRadial = false;
            this.btnVerify.Margin = new System.Windows.Forms.Padding(0);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.PressAnimationSpeed = 0.2F;
            this.btnVerify.PressDepth = 1;
            this.btnVerify.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVerify.RippleExpandSpeedFactor = 0.05F;
            this.btnVerify.RippleFadeSpeedFactor = 0.03F;
            this.btnVerify.ShadowBlurFactor = 0.85F;
            this.btnVerify.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVerify.ShadowOffsetX = 3;
            this.btnVerify.ShadowOffsetY = 3;
            this.btnVerify.Size = new System.Drawing.Size(118, 41);
            this.btnVerify.TabIndex = 49;
            this.btnVerify.Text = "Verify";
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerify.TextPaddingBottom = 0;
            this.btnVerify.TextPaddingLeft = 15;
            this.btnVerify.TextPaddingRight = 0;
            this.btnVerify.TextPaddingTop = 0;
            this.btnVerify.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVerify.TextShadowOffsetX = 1;
            this.btnVerify.TextShadowOffsetY = 1;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lbNote
            // 
            this.lbNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(118, 5);
            this.lbNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(395, 35);
            this.lbNote.TabIndex = 98;
            this.lbNote.Text = "We Send an OTP To Your Email That Logged In Your User Name: The Email May Be In S" +
    "pam Folder";
            // 
            // pbOTP
            // 
            this.pbOTP.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.pbOTP.Location = new System.Drawing.Point(67, 57);
            this.pbOTP.Name = "pbOTP";
            this.pbOTP.Size = new System.Drawing.Size(30, 30);
            this.pbOTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOTP.TabIndex = 80;
            this.pbOTP.TabStop = false;
            // 
            // lbOTP
            // 
            this.lbOTP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOTP.Location = new System.Drawing.Point(5, 61);
            this.lbOTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOTP.Name = "lbOTP";
            this.lbOTP.Size = new System.Drawing.Size(57, 21);
            this.lbOTP.TabIndex = 78;
            this.lbOTP.Text = "OTP:";
            // 
            // txtOTP
            // 
            this.txtOTP.BackColor = System.Drawing.Color.Transparent;
            this.txtOTP.BackgroundColor = System.Drawing.Color.White;
            this.txtOTP.BorderColor = System.Drawing.Color.DarkGray;
            this.txtOTP.BottomLeftCornerRadius = 12;
            this.txtOTP.BottomRightCornerRadius = 12;
            this.txtOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOTP.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtOTP.FocusImage = null;
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtOTP.HoverImage = null;
            this.txtOTP.IdleImage = null;
            this.txtOTP.InputType = SiticoneNetFrameworkUI.AdvancedTextBoxInputType.Digit;
            this.txtOTP.Location = new System.Drawing.Point(102, 57);
            this.txtOTP.MakeRadial = true;
            this.txtOTP.Margin = new System.Windows.Forms.Padding(2);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtOTP.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.PlaceholderText = "Enter The OTP";
            this.txtOTP.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtOTP.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtOTP.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtOTP.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtOTP.Size = new System.Drawing.Size(344, 25);
            this.txtOTP.TabIndex = 79;
            this.txtOTP.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtOTP.TextContent = "";
            this.txtOTP.TopLeftCornerRadius = 12;
            this.txtOTP.TopRightCornerRadius = 12;
            this.txtOTP.ValidationEnabled = false;
            this.txtOTP.ValidationPattern = "";
            // 
            // tabResetPassword
            // 
            this.tabResetPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabResetPassword.Controls.Add(this.btnResetPassword);
            this.tabResetPassword.Controls.Add(this.pbShowHideNewPass);
            this.tabResetPassword.Controls.Add(this.txtNewPassword);
            this.tabResetPassword.Controls.Add(this.pbShowHideConfirmPass);
            this.tabResetPassword.Controls.Add(this.lbNewPassword);
            this.tabResetPassword.Controls.Add(this.pbNewPassword);
            this.tabResetPassword.Controls.Add(this.lbConfirmPassword);
            this.tabResetPassword.Controls.Add(this.pbConfirmPassword);
            this.tabResetPassword.Controls.Add(this.txtConfirmPassword);
            this.tabResetPassword.Location = new System.Drawing.Point(4, 44);
            this.tabResetPassword.Name = "tabResetPassword";
            this.tabResetPassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabResetPassword.Size = new System.Drawing.Size(629, 184);
            this.tabControl.SetTabImage(this.tabResetPassword, global::DVLD.Properties.Resources.Key);
            this.tabResetPassword.TabIndex = 2;
            this.tabResetPassword.Text = "Reset Password";
            this.tabResetPassword.ToolTipText = "Enter New Password";
            this.tabResetPassword.UseVisualStyleBackColor = true;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPassword.BadgeBackColor = System.Drawing.Color.Red;
            this.btnResetPassword.BadgeForeColor = System.Drawing.Color.White;
            this.btnResetPassword.BadgeRadius = 8;
            this.btnResetPassword.BadgeRightMargin = 10;
            this.btnResetPassword.BadgeValue = 0;
            this.btnResetPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnResetPassword.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnResetPassword.BorderColorStart = System.Drawing.Color.White;
            this.btnResetPassword.BorderRadiusBottomLeft = 10;
            this.btnResetPassword.BorderRadiusBottomRight = 10;
            this.btnResetPassword.BorderRadiusTopLeft = 10;
            this.btnResetPassword.BorderRadiusTopRight = 10;
            this.btnResetPassword.BorderThickness = 1;
            this.btnResetPassword.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnResetPassword.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnResetPassword.ButtonImage = global::DVLD.Properties.Resources.Key;
            this.btnResetPassword.CanBeep = false;
            this.btnResetPassword.CanShake = false;
            this.btnResetPassword.ClickSoundPath = null;
            this.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.DisabledOverlayOpacity = 0.5F;
            this.btnResetPassword.EnableBorderGradient = false;
            this.btnResetPassword.EnableClickSound = false;
            this.btnResetPassword.EnableFocusBorder = false;
            this.btnResetPassword.EnableHoverSound = false;
            this.btnResetPassword.EnablePressScale = false;
            this.btnResetPassword.EnableTextShadow = false;
            this.btnResetPassword.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnResetPassword.FocusBorderThickness = 2;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnResetPassword.HoverSoundPath = null;
            this.btnResetPassword.HoverTransitionSpeed = 0.08F;
            this.btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.ImageLeftMargin = 0;
            this.btnResetPassword.ImageRightMargin = 3;
            this.btnResetPassword.ImageSize = 25;
            this.btnResetPassword.IsReadOnly = false;
            this.btnResetPassword.Location = new System.Drawing.Point(439, 140);
            this.btnResetPassword.MakeRadial = false;
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.PressAnimationSpeed = 0.2F;
            this.btnResetPassword.PressDepth = 1;
            this.btnResetPassword.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResetPassword.RippleExpandSpeedFactor = 0.05F;
            this.btnResetPassword.RippleFadeSpeedFactor = 0.03F;
            this.btnResetPassword.ShadowBlurFactor = 0.85F;
            this.btnResetPassword.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetPassword.ShadowOffsetX = 3;
            this.btnResetPassword.ShadowOffsetY = 3;
            this.btnResetPassword.Size = new System.Drawing.Size(187, 41);
            this.btnResetPassword.TabIndex = 49;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.TextPaddingBottom = 0;
            this.btnResetPassword.TextPaddingLeft = 15;
            this.btnResetPassword.TextPaddingRight = 0;
            this.btnResetPassword.TextPaddingTop = 0;
            this.btnResetPassword.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnResetPassword.TextShadowOffsetX = 1;
            this.btnResetPassword.TextShadowOffsetY = 1;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // pbShowHideNewPass
            // 
            this.pbShowHideNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowHideNewPass.Image = global::DVLD.Properties.Resources.ShowPassword;
            this.pbShowHideNewPass.Location = new System.Drawing.Point(483, 17);
            this.pbShowHideNewPass.Name = "pbShowHideNewPass";
            this.pbShowHideNewPass.Size = new System.Drawing.Size(40, 40);
            this.pbShowHideNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowHideNewPass.TabIndex = 76;
            this.pbShowHideNewPass.TabStop = false;
            this.pbShowHideNewPass.Tag = "true";
            this.pbShowHideNewPass.Click += new System.EventHandler(this.pbShowHideNewPass_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BackgroundColor = System.Drawing.Color.White;
            this.txtNewPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.BottomLeftCornerRadius = 12;
            this.txtNewPassword.BottomRightCornerRadius = 12;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtNewPassword.FocusImage = null;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtNewPassword.HoverImage = null;
            this.txtNewPassword.IdleImage = null;
            this.txtNewPassword.InputType = SiticoneNetFrameworkUI.AdvancedTextBoxInputType.Password;
            this.txtNewPassword.Location = new System.Drawing.Point(199, 26);
            this.txtNewPassword.MakeRadial = true;
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtNewPassword.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.PlaceholderText = "New Password";
            this.txtNewPassword.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtNewPassword.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtNewPassword.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtNewPassword.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtNewPassword.Size = new System.Drawing.Size(279, 25);
            this.txtNewPassword.TabIndex = 72;
            this.txtNewPassword.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtNewPassword.TextContent = "";
            this.txtNewPassword.TopLeftCornerRadius = 12;
            this.txtNewPassword.TopRightCornerRadius = 12;
            this.txtNewPassword.ValidationEnabled = false;
            this.txtNewPassword.ValidationPattern = "";
            // 
            // pbShowHideConfirmPass
            // 
            this.pbShowHideConfirmPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowHideConfirmPass.Image = global::DVLD.Properties.Resources.ShowPassword;
            this.pbShowHideConfirmPass.Location = new System.Drawing.Point(483, 74);
            this.pbShowHideConfirmPass.Name = "pbShowHideConfirmPass";
            this.pbShowHideConfirmPass.Size = new System.Drawing.Size(40, 40);
            this.pbShowHideConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowHideConfirmPass.TabIndex = 75;
            this.pbShowHideConfirmPass.TabStop = false;
            this.pbShowHideConfirmPass.Tag = "true";
            this.pbShowHideConfirmPass.Click += new System.EventHandler(this.pbShowHideConfirmPass_Click);
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(5, 30);
            this.lbNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(122, 21);
            this.lbNewPassword.TabIndex = 69;
            this.lbNewPassword.Text = "New Password:";
            // 
            // pbNewPassword
            // 
            this.pbNewPassword.Image = global::DVLD.Properties.Resources.Password_32;
            this.pbNewPassword.Location = new System.Drawing.Point(154, 17);
            this.pbNewPassword.Name = "pbNewPassword";
            this.pbNewPassword.Size = new System.Drawing.Size(40, 40);
            this.pbNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewPassword.TabIndex = 74;
            this.pbNewPassword.TabStop = false;
            // 
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.Location = new System.Drawing.Point(4, 89);
            this.lbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(145, 21);
            this.lbConfirmPassword.TabIndex = 70;
            this.lbConfirmPassword.Text = "Confirm Password:";
            // 
            // pbConfirmPassword
            // 
            this.pbConfirmPassword.Image = global::DVLD.Properties.Resources.Password_32;
            this.pbConfirmPassword.Location = new System.Drawing.Point(154, 74);
            this.pbConfirmPassword.Name = "pbConfirmPassword";
            this.pbConfirmPassword.Size = new System.Drawing.Size(40, 40);
            this.pbConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConfirmPassword.TabIndex = 73;
            this.pbConfirmPassword.TabStop = false;
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
            this.txtConfirmPassword.Location = new System.Drawing.Point(199, 82);
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
            this.txtConfirmPassword.TabIndex = 71;
            this.txtConfirmPassword.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtConfirmPassword.TextContent = "";
            this.txtConfirmPassword.TopLeftCornerRadius = 12;
            this.txtConfirmPassword.TopRightCornerRadius = 12;
            this.txtConfirmPassword.ValidationEnabled = false;
            this.txtConfirmPassword.ValidationPattern = "";
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(270, 8);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 39);
            this.lbTitle.TabIndex = 48;
            this.lbTitle.Text = "Forget Password";
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
            this.btnClose.Location = new System.Drawing.Point(665, 305);
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
            this.btnClose.TabIndex = 49;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // llbResendOTP
            // 
            this.llbResendOTP.BackColor = System.Drawing.Color.Transparent;
            this.llbResendOTP.Enabled = false;
            this.llbResendOTP.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.llbResendOTP.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbResendOTP.Location = new System.Drawing.Point(5, 109);
            this.llbResendOTP.Name = "llbResendOTP";
            this.llbResendOTP.Size = new System.Drawing.Size(100, 27);
            this.llbResendOTP.TabIndex = 79;
            this.llbResendOTP.TabStop = true;
            this.llbResendOTP.Text = "Resend OTP";
            this.llbResendOTP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbResendOTP_LinkClicked);
            // 
            // lbTimer
            // 
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(110, 109);
            this.lbTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(35, 21);
            this.lbTimer.TabIndex = 99;
            this.lbTimer.Text = "10";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbWaiting2
            // 
            this.lbWaiting2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting2.Location = new System.Drawing.Point(219, 158);
            this.lbWaiting2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWaiting2.Name = "lbWaiting2";
            this.lbWaiting2.Size = new System.Drawing.Size(94, 21);
            this.lbWaiting2.TabIndex = 77;
            this.lbWaiting2.Text = "Waiting...";
            this.lbWaiting2.Visible = false;
            // 
            // frmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 355);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnClose1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget Password";
            this.Load += new System.EventHandler(this.frmForgetPassword_Load);
            this.tabControl.ResumeLayout(false);
            this.tabUserName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).EndInit();
            this.tabVerification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOTP)).EndInit();
            this.tabResetPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneTabControl tabControl;
        private System.Windows.Forms.TabPage tabUserName;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnSendOTP;
        private System.Windows.Forms.TabPage tabVerification;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private System.Windows.Forms.PictureBox pbUserName;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtUserName;
        private SiticoneNetFrameworkUI.SiticoneLabel lbUserName;
        private System.Windows.Forms.PictureBox pbOTP;
        private SiticoneNetFrameworkUI.SiticoneLabel lbOTP;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtOTP;
        private SiticoneNetFrameworkUI.SiticoneLabel lbNote;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnVerify;
        private System.Windows.Forms.TabPage tabResetPassword;
        private System.Windows.Forms.PictureBox pbShowHideNewPass;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtNewPassword;
        private System.Windows.Forms.PictureBox pbShowHideConfirmPass;
        private SiticoneNetFrameworkUI.SiticoneLabel lbNewPassword;
        private System.Windows.Forms.PictureBox pbNewPassword;
        private SiticoneNetFrameworkUI.SiticoneLabel lbConfirmPassword;
        private System.Windows.Forms.PictureBox pbConfirmPassword;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtConfirmPassword;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnResetPassword;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private SiticoneNetFrameworkUI.SiticoneLabel lbWaiting;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private SiticoneNetFrameworkUI.SiticoneLinkedLabel llbResendOTP;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTimer;
        private System.Windows.Forms.Timer timer1;
        private SiticoneNetFrameworkUI.SiticoneLabel lbWaiting2;
    }
}