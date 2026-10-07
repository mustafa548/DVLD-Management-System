namespace DVLD
{
    partial class frmChangePassword
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
            this.pbShowHideConfirmPass = new System.Windows.Forms.PictureBox();
            this.pbShowHideNewPass = new System.Windows.Forms.PictureBox();
            this.txtNewPassword = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtConfirmPassword = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.lbConfirmPassword = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbCurrentPassword = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.pbConfirmPassword = new System.Windows.Forms.PictureBox();
            this.pbNewPassword = new System.Windows.Forms.PictureBox();
            this.pbCurrentPassword = new System.Windows.Forms.PictureBox();
            this.pbShowHideCurrentPass = new System.Windows.Forms.PictureBox();
            this.txtCurrentPassword = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.lbNewPassword = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.btnSave = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.ctrlUserInfo1 = new DVLD.ctrlUserInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideCurrentPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(972, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(31, 31);
            this.btnClose1.TabIndex = 45;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // pbShowHideConfirmPass
            // 
            this.pbShowHideConfirmPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowHideConfirmPass.Image = global::DVLD.Properties.Resources.ShowPassword;
            this.pbShowHideConfirmPass.Location = new System.Drawing.Point(483, 633);
            this.pbShowHideConfirmPass.Name = "pbShowHideConfirmPass";
            this.pbShowHideConfirmPass.Size = new System.Drawing.Size(30, 30);
            this.pbShowHideConfirmPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowHideConfirmPass.TabIndex = 74;
            this.pbShowHideConfirmPass.TabStop = false;
            this.pbShowHideConfirmPass.Tag = "true";
            this.pbShowHideConfirmPass.Click += new System.EventHandler(this.pbShowHideConfirmPass_Click);
            // 
            // pbShowHideNewPass
            // 
            this.pbShowHideNewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowHideNewPass.Image = global::DVLD.Properties.Resources.ShowPassword;
            this.pbShowHideNewPass.Location = new System.Drawing.Point(483, 584);
            this.pbShowHideNewPass.Name = "pbShowHideNewPass";
            this.pbShowHideNewPass.Size = new System.Drawing.Size(30, 30);
            this.pbShowHideNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowHideNewPass.TabIndex = 73;
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
            this.txtNewPassword.Location = new System.Drawing.Point(199, 583);
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
            this.txtConfirmPassword.Location = new System.Drawing.Point(199, 639);
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
            // lbConfirmPassword
            // 
            this.lbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPassword.Location = new System.Drawing.Point(12, 639);
            this.lbConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbConfirmPassword.Name = "lbConfirmPassword";
            this.lbConfirmPassword.Size = new System.Drawing.Size(145, 21);
            this.lbConfirmPassword.TabIndex = 70;
            this.lbConfirmPassword.Text = "Confirm Password:";
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPassword.Location = new System.Drawing.Point(12, 535);
            this.lbCurrentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(145, 21);
            this.lbCurrentPassword.TabIndex = 69;
            this.lbCurrentPassword.Text = "Current Password:";
            // 
            // pbConfirmPassword
            // 
            this.pbConfirmPassword.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbConfirmPassword.Location = new System.Drawing.Point(162, 639);
            this.pbConfirmPassword.Name = "pbConfirmPassword";
            this.pbConfirmPassword.Size = new System.Drawing.Size(32, 23);
            this.pbConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConfirmPassword.TabIndex = 75;
            this.pbConfirmPassword.TabStop = false;
            // 
            // pbNewPassword
            // 
            this.pbNewPassword.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbNewPassword.Location = new System.Drawing.Point(162, 585);
            this.pbNewPassword.Name = "pbNewPassword";
            this.pbNewPassword.Size = new System.Drawing.Size(32, 23);
            this.pbNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewPassword.TabIndex = 76;
            this.pbNewPassword.TabStop = false;
            // 
            // pbCurrentPassword
            // 
            this.pbCurrentPassword.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbCurrentPassword.Location = new System.Drawing.Point(162, 535);
            this.pbCurrentPassword.Name = "pbCurrentPassword";
            this.pbCurrentPassword.Size = new System.Drawing.Size(32, 23);
            this.pbCurrentPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentPassword.TabIndex = 77;
            this.pbCurrentPassword.TabStop = false;
            // 
            // pbShowHideCurrentPass
            // 
            this.pbShowHideCurrentPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowHideCurrentPass.Image = global::DVLD.Properties.Resources.ShowPassword;
            this.pbShowHideCurrentPass.Location = new System.Drawing.Point(483, 535);
            this.pbShowHideCurrentPass.Name = "pbShowHideCurrentPass";
            this.pbShowHideCurrentPass.Size = new System.Drawing.Size(30, 30);
            this.pbShowHideCurrentPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowHideCurrentPass.TabIndex = 80;
            this.pbShowHideCurrentPass.TabStop = false;
            this.pbShowHideCurrentPass.Tag = "true";
            this.pbShowHideCurrentPass.Click += new System.EventHandler(this.pbShowHideCurrentPass_Click);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrentPassword.BackgroundColor = System.Drawing.Color.White;
            this.txtCurrentPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.txtCurrentPassword.BottomLeftCornerRadius = 12;
            this.txtCurrentPassword.BottomRightCornerRadius = 12;
            this.txtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPassword.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtCurrentPassword.FocusImage = null;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtCurrentPassword.HoverImage = null;
            this.txtCurrentPassword.IdleImage = null;
            this.txtCurrentPassword.InputType = SiticoneNetFrameworkUI.AdvancedTextBoxInputType.Password;
            this.txtCurrentPassword.Location = new System.Drawing.Point(199, 535);
            this.txtCurrentPassword.MakeRadial = true;
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCurrentPassword.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.PlaceholderText = "Current Password";
            this.txtCurrentPassword.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtCurrentPassword.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtCurrentPassword.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtCurrentPassword.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtCurrentPassword.Size = new System.Drawing.Size(279, 25);
            this.txtCurrentPassword.TabIndex = 79;
            this.txtCurrentPassword.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtCurrentPassword.TextContent = "";
            this.txtCurrentPassword.TopLeftCornerRadius = 12;
            this.txtCurrentPassword.TopRightCornerRadius = 12;
            this.txtCurrentPassword.ValidationEnabled = false;
            this.txtCurrentPassword.ValidationPattern = "";
            this.txtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtCurrentPassword_Validating);
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(12, 587);
            this.lbNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(145, 21);
            this.lbNewPassword.TabIndex = 78;
            this.lbNewPassword.Text = "New Password:";
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
            this.btnSave.Location = new System.Drawing.Point(853, 671);
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
            this.btnSave.TabIndex = 82;
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
            this.btnClose.Location = new System.Drawing.Point(722, 671);
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
            this.btnClose.TabIndex = 81;
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
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.Location = new System.Drawing.Point(60, 12);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(906, 492);
            this.ctrlUserInfo1.TabIndex = 46;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbShowHideCurrentPass);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.pbCurrentPassword);
            this.Controls.Add(this.pbNewPassword);
            this.Controls.Add(this.pbConfirmPassword);
            this.Controls.Add(this.pbShowHideConfirmPass);
            this.Controls.Add(this.pbShowHideNewPass);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lbConfirmPassword);
            this.Controls.Add(this.lbCurrentPassword);
            this.Controls.Add(this.ctrlUserInfo1);
            this.Controls.Add(this.btnClose1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHideCurrentPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private ctrlUserInfo ctrlUserInfo1;
        private System.Windows.Forms.PictureBox pbShowHideConfirmPass;
        private System.Windows.Forms.PictureBox pbShowHideNewPass;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtNewPassword;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtConfirmPassword;
        private SiticoneNetFrameworkUI.SiticoneLabel lbConfirmPassword;
        private SiticoneNetFrameworkUI.SiticoneLabel lbCurrentPassword;
        private System.Windows.Forms.PictureBox pbConfirmPassword;
        private System.Windows.Forms.PictureBox pbNewPassword;
        private System.Windows.Forms.PictureBox pbCurrentPassword;
        private System.Windows.Forms.PictureBox pbShowHideCurrentPass;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtCurrentPassword;
        private SiticoneNetFrameworkUI.SiticoneLabel lbNewPassword;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnSave;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}