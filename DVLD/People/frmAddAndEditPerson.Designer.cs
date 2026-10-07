namespace DVLD
{
    partial class frmAddAndEditPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAndEditPerson));
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbPersonID = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.gbContainer = new SiticoneNetFrameworkUI.SiticonePanel();
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.pbCountry = new System.Windows.Forms.PictureBox();
            this.pbNationalIDNumber = new System.Windows.Forms.PictureBox();
            this.pbMale = new System.Windows.Forms.PictureBox();
            this.pbFemale = new System.Windows.Forms.PictureBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.pbAddress = new System.Windows.Forms.PictureBox();
            this.pbDateOfBirth = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.llbSetImage = new SiticoneNetFrameworkUI.SiticoneLinkedLabel();
            this.dplCountries = new SiticoneNetFrameworkUI.SiticoneDropdown();
            this.dtpDateOfBirth = new SiticoneNetFrameworkUI.SiticoneDateTimePicker();
            this.txtPhone = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.lbCountry = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbPhone = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbDateOfBirth = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.txtAddress = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtEmail = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtNationalIDNumber = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtLastName = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtThirdName = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtSecondName = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.txtFirstName = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.rdFemale = new SiticoneNetFrameworkUI.SiticoneRadioButton();
            this.rdMale = new SiticoneNetFrameworkUI.SiticoneRadioButton();
            this.lbAddress = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbEmail = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbGender = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbNationalIDNumber = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbName = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbPersonIDValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.ofdSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbPersonID = new System.Windows.Forms.PictureBox();
            this.lbWaiting = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.gbContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalIDNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(879, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(35, 35);
            this.btnClose1.TabIndex = 3;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(347, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 39);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Add New Person";
            // 
            // lbPersonID
            // 
            this.lbPersonID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonID.Location = new System.Drawing.Point(11, 61);
            this.lbPersonID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(95, 21);
            this.lbPersonID.TabIndex = 10;
            this.lbPersonID.Text = "Person ID:";
            // 
            // gbContainer
            // 
            this.gbContainer.AcrylicTintColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbContainer.BackColor = System.Drawing.Color.Transparent;
            this.gbContainer.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            this.gbContainer.BorderColor = System.Drawing.Color.Gray;
            this.gbContainer.BorderDashPattern = null;
            this.gbContainer.BorderGradientEndColor = System.Drawing.Color.Purple;
            this.gbContainer.BorderGradientStartColor = System.Drawing.Color.Blue;
            this.gbContainer.BorderThickness = 2F;
            this.gbContainer.Controls.Add(this.lbWaiting);
            this.gbContainer.Controls.Add(this.pbPhone);
            this.gbContainer.Controls.Add(this.pbCountry);
            this.gbContainer.Controls.Add(this.pbNationalIDNumber);
            this.gbContainer.Controls.Add(this.pbMale);
            this.gbContainer.Controls.Add(this.pbFemale);
            this.gbContainer.Controls.Add(this.pbEmail);
            this.gbContainer.Controls.Add(this.pbAddress);
            this.gbContainer.Controls.Add(this.pbDateOfBirth);
            this.gbContainer.Controls.Add(this.pbName);
            this.gbContainer.Controls.Add(this.pbPersonImage);
            this.gbContainer.Controls.Add(this.btnSave);
            this.gbContainer.Controls.Add(this.btnClose);
            this.gbContainer.Controls.Add(this.llbSetImage);
            this.gbContainer.Controls.Add(this.dplCountries);
            this.gbContainer.Controls.Add(this.dtpDateOfBirth);
            this.gbContainer.Controls.Add(this.txtPhone);
            this.gbContainer.Controls.Add(this.lbCountry);
            this.gbContainer.Controls.Add(this.lbPhone);
            this.gbContainer.Controls.Add(this.lbDateOfBirth);
            this.gbContainer.Controls.Add(this.txtAddress);
            this.gbContainer.Controls.Add(this.txtEmail);
            this.gbContainer.Controls.Add(this.txtNationalIDNumber);
            this.gbContainer.Controls.Add(this.txtLastName);
            this.gbContainer.Controls.Add(this.txtThirdName);
            this.gbContainer.Controls.Add(this.txtSecondName);
            this.gbContainer.Controls.Add(this.txtFirstName);
            this.gbContainer.Controls.Add(this.rdFemale);
            this.gbContainer.Controls.Add(this.rdMale);
            this.gbContainer.Controls.Add(this.lbAddress);
            this.gbContainer.Controls.Add(this.lbEmail);
            this.gbContainer.Controls.Add(this.lbGender);
            this.gbContainer.Controls.Add(this.lbNationalIDNumber);
            this.gbContainer.Controls.Add(this.lbName);
            this.gbContainer.CornerRadiusBottomLeft = 12F;
            this.gbContainer.CornerRadiusBottomRight = 12F;
            this.gbContainer.CornerRadiusTopLeft = 12F;
            this.gbContainer.CornerRadiusTopRight = 12F;
            this.gbContainer.EnableAcrylicEffect = false;
            this.gbContainer.EnableMicaEffect = false;
            this.gbContainer.EnableRippleEffect = true;
            this.gbContainer.FillColor = System.Drawing.Color.White;
            this.gbContainer.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray};
            this.gbContainer.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.gbContainer.Location = new System.Drawing.Point(11, 90);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.PatternColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbContainer.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.gbContainer.RippleAlpha = 50;
            this.gbContainer.RippleAlphaDecrement = 3;
            this.gbContainer.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbContainer.RippleMaxSize = 600F;
            this.gbContainer.RippleSpeed = 15F;
            this.gbContainer.ShowBorder = true;
            this.gbContainer.Size = new System.Drawing.Size(896, 348);
            this.gbContainer.TabIndex = 11;
            this.gbContainer.TabStop = true;
            this.gbContainer.UseBorderGradient = false;
            this.gbContainer.UseMultiGradient = false;
            this.gbContainer.UsePatternTexture = false;
            this.gbContainer.UseRadialGradient = false;
            // 
            // pbPhone
            // 
            this.pbPhone.Image = global::DVLD.Properties.Resources.Phone_32;
            this.pbPhone.Location = new System.Drawing.Point(450, 114);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(32, 23);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhone.TabIndex = 52;
            this.pbPhone.TabStop = false;
            // 
            // pbCountry
            // 
            this.pbCountry.Image = global::DVLD.Properties.Resources.Country_32;
            this.pbCountry.Location = new System.Drawing.Point(461, 159);
            this.pbCountry.Name = "pbCountry";
            this.pbCountry.Size = new System.Drawing.Size(32, 23);
            this.pbCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCountry.TabIndex = 51;
            this.pbCountry.TabStop = false;
            // 
            // pbNationalIDNumber
            // 
            this.pbNationalIDNumber.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbNationalIDNumber.Location = new System.Drawing.Point(100, 73);
            this.pbNationalIDNumber.Name = "pbNationalIDNumber";
            this.pbNationalIDNumber.Size = new System.Drawing.Size(32, 23);
            this.pbNationalIDNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNationalIDNumber.TabIndex = 50;
            this.pbNationalIDNumber.TabStop = false;
            // 
            // pbMale
            // 
            this.pbMale.Image = global::DVLD.Properties.Resources.Man_32;
            this.pbMale.Location = new System.Drawing.Point(100, 114);
            this.pbMale.Name = "pbMale";
            this.pbMale.Size = new System.Drawing.Size(32, 23);
            this.pbMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMale.TabIndex = 49;
            this.pbMale.TabStop = false;
            // 
            // pbFemale
            // 
            this.pbFemale.Image = global::DVLD.Properties.Resources.Woman_32;
            this.pbFemale.Location = new System.Drawing.Point(232, 114);
            this.pbFemale.Name = "pbFemale";
            this.pbFemale.Size = new System.Drawing.Size(32, 23);
            this.pbFemale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFemale.TabIndex = 48;
            this.pbFemale.TabStop = false;
            // 
            // pbEmail
            // 
            this.pbEmail.Image = global::DVLD.Properties.Resources.Email_32;
            this.pbEmail.Location = new System.Drawing.Point(100, 158);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(32, 23);
            this.pbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmail.TabIndex = 47;
            this.pbEmail.TabStop = false;
            // 
            // pbAddress
            // 
            this.pbAddress.Image = global::DVLD.Properties.Resources.Address_32;
            this.pbAddress.Location = new System.Drawing.Point(100, 202);
            this.pbAddress.Name = "pbAddress";
            this.pbAddress.Size = new System.Drawing.Size(32, 23);
            this.pbAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAddress.TabIndex = 46;
            this.pbAddress.TabStop = false;
            // 
            // pbDateOfBirth
            // 
            this.pbDateOfBirth.Image = global::DVLD.Properties.Resources.Calendar_32;
            this.pbDateOfBirth.Location = new System.Drawing.Point(492, 70);
            this.pbDateOfBirth.Name = "pbDateOfBirth";
            this.pbDateOfBirth.Size = new System.Drawing.Size(32, 23);
            this.pbDateOfBirth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDateOfBirth.TabIndex = 45;
            this.pbDateOfBirth.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.Image = global::DVLD.Properties.Resources.Person_32;
            this.pbName.Location = new System.Drawing.Point(100, 28);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(32, 23);
            this.pbName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbName.TabIndex = 44;
            this.pbName.TabStop = false;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.Male_512;
            this.pbPersonImage.Location = new System.Drawing.Point(718, 73);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(166, 185);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonImage.TabIndex = 43;
            this.pbPersonImage.TabStop = false;
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
            this.btnSave.Location = new System.Drawing.Point(718, 290);
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
            this.btnSave.TabIndex = 42;
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
            this.btnClose.Location = new System.Drawing.Point(587, 290);
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
            this.btnClose.TabIndex = 41;
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
            // llbSetImage
            // 
            this.llbSetImage.BackColor = System.Drawing.Color.Transparent;
            this.llbSetImage.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold);
            this.llbSetImage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llbSetImage.Location = new System.Drawing.Point(759, 261);
            this.llbSetImage.Name = "llbSetImage";
            this.llbSetImage.Size = new System.Drawing.Size(85, 27);
            this.llbSetImage.TabIndex = 40;
            this.llbSetImage.TabStop = true;
            this.llbSetImage.Text = "Set Image";
            this.llbSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSetImage_LinkClicked);
            // 
            // dplCountries
            // 
            this.dplCountries.AllowMultipleSelection = false;
            this.dplCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.dplCountries.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(220)))));
            this.dplCountries.CanBeep = false;
            this.dplCountries.CanShake = true;
            this.dplCountries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dplCountries.DataSource = null;
            this.dplCountries.DisplayMember = null;
            this.dplCountries.DropdownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.dplCountries.DropdownWidth = 0;
            this.dplCountries.DropShadowEnabled = false;
            this.dplCountries.EnableSearch = true;
            this.dplCountries.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplCountries.HoveredItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.dplCountries.HoveredItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplCountries.IsReadonly = false;
            this.dplCountries.ItemHeight = 30;
            this.dplCountries.Location = new System.Drawing.Point(498, 158);
            this.dplCountries.Margin = new System.Windows.Forms.Padding(2);
            this.dplCountries.MaxDropDownItems = 8;
            this.dplCountries.Name = "dplCountries";
            this.dplCountries.NotFoundBackColor = System.Drawing.Color.Transparent;
            this.dplCountries.NotFoundFont = null;
            this.dplCountries.NotFoundTextColor = System.Drawing.Color.Gray;
            this.dplCountries.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.dplCountries.PlaceholderDisappearsOnFocus = true;
            this.dplCountries.PlaceholderText = "Select an option";
            this.dplCountries.SearchTextBoxHeight = 20;
            this.dplCountries.SearchTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplCountries.SearchTextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dplCountries.SelectedIndex = -1;
            this.dplCountries.SelectedItem = null;
            this.dplCountries.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.dplCountries.SelectedItemTextColor = System.Drawing.Color.White;
            this.dplCountries.SelectedValue = null;
            this.dplCountries.Size = new System.Drawing.Size(198, 24);
            this.dplCountries.TabIndex = 38;
            this.dplCountries.Text = "siticoneDropdown1";
            this.dplCountries.UnselectedItemTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.dplCountries.ValueMember = null;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.AutoScaleFonts = true;
            this.dtpDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.dtpDateOfBirth.BaseCalendarFormSize = new System.Drawing.Size(535, 460);
            this.dtpDateOfBirth.BorderColor = System.Drawing.Color.Gray;
            this.dtpDateOfBirth.BorderWidth = 2;
            this.dtpDateOfBirth.BottomLeftBorderRadius = 13;
            this.dtpDateOfBirth.BottomRightBorderRadius = 13;
            this.dtpDateOfBirth.CalendarBackgroundColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.CalendarChevronColor = System.Drawing.Color.Gray;
            this.dtpDateOfBirth.CalendarChevronHoverColor = System.Drawing.Color.Blue;
            this.dtpDateOfBirth.CalendarDayButtonBackColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.CalendarDayButtonForeColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.CalendarDayHeaderBackColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.CalendarDayHeaderForeColor = System.Drawing.Color.Gray;
            this.dtpDateOfBirth.CalendarDayLabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.CalendarDisabledDateBackColor = System.Drawing.Color.DimGray;
            this.dtpDateOfBirth.CalendarDisabledDateForeColor = System.Drawing.Color.LightGray;
            this.dtpDateOfBirth.CalendarFormAnimationSpeed = 15;
            this.dtpDateOfBirth.CalendarFormAnimationStep = 0.08D;
            this.dtpDateOfBirth.CalendarFormBackColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.CalendarFormBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dtpDateOfBirth.CalendarFormBorderWidth = 2;
            this.dtpDateOfBirth.CalendarFormCornerRadius = 2;
            this.dtpDateOfBirth.CalendarFormFadeOutStep = 0.1D;
            this.dtpDateOfBirth.CalendarFormHeight = 360;
            this.dtpDateOfBirth.CalendarFormShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpDateOfBirth.CalendarFormShadowDepth = 5;
            this.dtpDateOfBirth.CalendarFormWidth = 380;
            this.dtpDateOfBirth.CalendarGridMargin = new System.Windows.Forms.Padding(8);
            this.dtpDateOfBirth.CalendarGridPadding = new System.Windows.Forms.Padding(5);
            this.dtpDateOfBirth.CalendarLockedDateBackColor = System.Drawing.Color.LightGray;
            this.dtpDateOfBirth.CalendarLockedDateForeColor = System.Drawing.Color.DarkGray;
            this.dtpDateOfBirth.CalendarLockedDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("dtpDateOfBirth.CalendarLockedDates")));
            this.dtpDateOfBirth.CalendarMargin = 5;
            this.dtpDateOfBirth.CalendarMaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.CalendarMaxYear = 2126;
            this.dtpDateOfBirth.CalendarMinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.CalendarMinYear = 1926;
            this.dtpDateOfBirth.CalendarRangeDateBackColor = System.Drawing.Color.LightBlue;
            this.dtpDateOfBirth.CalendarRangeEndDateBackColor = System.Drawing.Color.DodgerBlue;
            this.dtpDateOfBirth.CalendarRangeSelectedForeColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.CalendarRangeStartDateBackColor = System.Drawing.Color.DodgerBlue;
            this.dtpDateOfBirth.CalendarSelectedDateBackColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.CalendarSelectedDateForeColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.CalendarSelectionMode = SiticoneNetFrameworkUI.SelectionMode.Single;
            this.dtpDateOfBirth.CalendarTodayBackColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.CalendarYearPickerHeight = 10;
            this.dtpDateOfBirth.CanBeep = true;
            this.dtpDateOfBirth.CanShake = true;
            this.dtpDateOfBirth.ChevronColor = System.Drawing.Color.Gray;
            this.dtpDateOfBirth.ChevronHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            this.dtpDateOfBirth.ChevronHoverColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.ChevronPanelBorderRadius = 0;
            this.dtpDateOfBirth.ChevronPanelHeight = 32;
            this.dtpDateOfBirth.ChevronPenThickness = 1.8F;
            this.dtpDateOfBirth.ChevronRightMargin = 18;
            this.dtpDateOfBirth.ChevronSize = new System.Drawing.Size(9, 14);
            this.dtpDateOfBirth.ChevronStep = 15F;
            this.dtpDateOfBirth.ChevronTimerInterval = 15;
            this.dtpDateOfBirth.ClearIconColor = System.Drawing.Color.Gray;
            this.dtpDateOfBirth.ClearIconHoverColor = System.Drawing.Color.Red;
            this.dtpDateOfBirth.ClearIconRightMargin = 48;
            this.dtpDateOfBirth.ClearIconSize = 11;
            this.dtpDateOfBirth.ContainerPanelMargin = new System.Windows.Forms.Padding(5);
            this.dtpDateOfBirth.ContainerPanelPadding = new System.Windows.Forms.Padding(0);
            this.dtpDateOfBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDateOfBirth.CustomDateFormat = "dd/MM/yyyy";
            this.dtpDateOfBirth.CustomDateFormatter = null;
            this.dtpDateOfBirth.DateFormat = SiticoneNetFrameworkUI.DateFormat.Custom;
            this.dtpDateOfBirth.DayButtonBorderRadius = 0;
            this.dtpDateOfBirth.DayButtonClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.dtpDateOfBirth.DayButtonFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpDateOfBirth.DayButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.dtpDateOfBirth.DayButtonHoverForeColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.DayButtonMargin = new System.Windows.Forms.Padding(3);
            this.dtpDateOfBirth.DayButtonRowHeight = 16.66F;
            this.dtpDateOfBirth.DayHeaderFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dtpDateOfBirth.DayHeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dtpDateOfBirth.DayHeaderMargin = new System.Windows.Forms.Padding(1, 1, 1, 8);
            this.dtpDateOfBirth.DayHeaderRowHeight = 30F;
            this.dtpDateOfBirth.DisabledDayFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.dtpDateOfBirth.DropdownBackColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.DropdownFont = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpDateOfBirth.DropdownHeight = 250;
            this.dtpDateOfBirth.FillColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.FirstDayOfWeek = System.DayOfWeek.Saturday;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.ForeColor = System.Drawing.Color.DimGray;
            this.dtpDateOfBirth.GradientEndColor = System.Drawing.Color.Gray;
            this.dtpDateOfBirth.GradientStartColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.HighlightWeekends = true;
            this.dtpDateOfBirth.IconSize = 16;
            this.dtpDateOfBirth.IsReadonly = false;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(530, 70);
            this.dtpDateOfBirth.LockedDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("dtpDateOfBirth.LockedDates")));
            this.dtpDateOfBirth.MakeRadial = true;
            this.dtpDateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MaxFontScale = 1.8F;
            this.dtpDateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinFontScale = 0.4F;
            this.dtpDateOfBirth.MinimumFormSize = new System.Drawing.Size(150, 150);
            this.dtpDateOfBirth.MonthChevronPanelMargin = new System.Windows.Forms.Padding(4, 17, 4, 0);
            this.dtpDateOfBirth.MonthChevronSpacing = 5;
            this.dtpDateOfBirth.MonthComboBoxMargin = new System.Windows.Forms.Padding(0, 17, 5, 0);
            this.dtpDateOfBirth.MonthComboBoxSize = new System.Drawing.Size(130, 30);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.NavigationFlowPadding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.dtpDateOfBirth.NavigationPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtpDateOfBirth.NavigationPanelHeight = 65;
            this.dtpDateOfBirth.NextMonthPanelWidth = 34;
            this.dtpDateOfBirth.NextYearPanelWidth = 40;
            this.dtpDateOfBirth.PlaceholderText = "Select a date";
            this.dtpDateOfBirth.PrevMonthPanelWidth = 34;
            this.dtpDateOfBirth.PrevYearPanelWidth = 40;
            this.dtpDateOfBirth.RangeStartEndCornerRadius = 0;
            this.dtpDateOfBirth.ReadonlyBorderColor = System.Drawing.Color.Gray;
            this.dtpDateOfBirth.ReadonlyFillColor = System.Drawing.Color.DarkGray;
            this.dtpDateOfBirth.ReadOnlyForeColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.ReadonlyPlaceHolderColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.SelectedDate = null;
            this.dtpDateOfBirth.SelectedDateBorderColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.SelectedDateBorderThickness = 1F;
            this.dtpDateOfBirth.SelectedDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("dtpDateOfBirth.SelectedDates")));
            this.dtpDateOfBirth.SelectionMode = SiticoneNetFrameworkUI.SelectionMode.Single;
            this.dtpDateOfBirth.ShakeAmplitude = 4;
            this.dtpDateOfBirth.ShakeTimerInterval = 30;
            this.dtpDateOfBirth.ShakeTotalShakes = 8;
            this.dtpDateOfBirth.ShowClearButton = true;
            this.dtpDateOfBirth.ShowMonthYearNavigation = true;
            this.dtpDateOfBirth.ShowTodayButton = false;
            this.dtpDateOfBirth.Size = new System.Drawing.Size(166, 26);
            this.dtpDateOfBirth.TabIndex = 37;
            this.dtpDateOfBirth.Text = "siticoneDateTimePicker1";
            this.dtpDateOfBirth.TodayBorderColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.TodayBorderThickness = 2F;
            this.dtpDateOfBirth.TodayButtonBackColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.TodayButtonBorderRadius = 0;
            this.dtpDateOfBirth.TodayButtonClickBackColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.TodayButtonFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dtpDateOfBirth.TodayButtonForeColor = System.Drawing.Color.White;
            this.dtpDateOfBirth.TodayButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDateOfBirth.TodayButtonMargin = new System.Windows.Forms.Padding(0, 17, 15, 0);
            this.dtpDateOfBirth.TodayButtonSize = new System.Drawing.Size(70, 35);
            this.dtpDateOfBirth.TodayButtonText = "Today";
            this.dtpDateOfBirth.TodayTextColor = System.Drawing.Color.Black;
            this.dtpDateOfBirth.TodayTextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDateOfBirth.TopLeftBorderRadius = 13;
            this.dtpDateOfBirth.TopRightBorderRadius = 13;
            this.dtpDateOfBirth.UseCalendarFormAnimation = true;
            this.dtpDateOfBirth.UseCalendarFormShadow = true;
            this.dtpDateOfBirth.UseChevronAnimation = true;
            this.dtpDateOfBirth.UseGradientFill = false;
            this.dtpDateOfBirth.Value = null;
            this.dtpDateOfBirth.WeekendDayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dtpDateOfBirth.WeekendDayForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpDateOfBirth.YearChevronPanelMargin = new System.Windows.Forms.Padding(4, 17, 4, 0);
            this.dtpDateOfBirth.YearChevronSpacing = 1;
            this.dtpDateOfBirth.YearComboBoxMargin = new System.Windows.Forms.Padding(5, 17, 0, 0);
            this.dtpDateOfBirth.YearComboBoxSize = new System.Drawing.Size(90, 30);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BackgroundColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.BottomLeftCornerRadius = 12;
            this.txtPhone.BottomRightCornerRadius = 12;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtPhone.FocusImage = null;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtPhone.HoverImage = null;
            this.txtPhone.IdleImage = null;
            this.txtPhone.InputType = SiticoneNetFrameworkUI.AdvancedTextBoxInputType.Digit;
            this.txtPhone.Location = new System.Drawing.Point(488, 114);
            this.txtPhone.MakeRadial = true;
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtPhone.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtPhone.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPhone.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPhone.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtPhone.Size = new System.Drawing.Size(208, 25);
            this.txtPhone.TabIndex = 36;
            this.txtPhone.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtPhone.TextContent = "";
            this.txtPhone.TopLeftCornerRadius = 12;
            this.txtPhone.TopRightCornerRadius = 12;
            this.txtPhone.ValidationPattern = "";
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // lbCountry
            // 
            this.lbCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(390, 159);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(66, 21);
            this.lbCountry.TabIndex = 32;
            this.lbCountry.Text = "Country:";
            // 
            // lbPhone
            // 
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(390, 116);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(55, 21);
            this.lbPhone.TabIndex = 31;
            this.lbPhone.Text = "Phone:";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(390, 73);
            this.lbDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(110, 21);
            this.lbDateOfBirth.TabIndex = 30;
            this.lbDateOfBirth.Text = "Date Of Birth: ";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BackgroundColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.BottomLeftCornerRadius = 8;
            this.txtAddress.BottomRightCornerRadius = 8;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtAddress.FocusImage = null;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtAddress.HoverImage = null;
            this.txtAddress.IdleImage = null;
            this.txtAddress.Location = new System.Drawing.Point(154, 199);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtAddress.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtAddress.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtAddress.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtAddress.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtAddress.Size = new System.Drawing.Size(542, 89);
            this.txtAddress.TabIndex = 29;
            this.txtAddress.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.TextContent = "";
            this.txtAddress.TopLeftCornerRadius = 8;
            this.txtAddress.TopRightCornerRadius = 8;
            this.txtAddress.ValidationEnabled = false;
            this.txtAddress.ValidationPattern = "";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.BottomLeftCornerRadius = 12;
            this.txtEmail.BottomRightCornerRadius = 12;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtEmail.FocusImage = null;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtEmail.HoverImage = null;
            this.txtEmail.IdleImage = null;
            this.txtEmail.Location = new System.Drawing.Point(153, 156);
            this.txtEmail.MakeRadial = true;
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtEmail.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtEmail.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtEmail.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtEmail.Size = new System.Drawing.Size(233, 25);
            this.txtEmail.TabIndex = 28;
            this.txtEmail.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.TextContent = "";
            this.txtEmail.TopLeftCornerRadius = 12;
            this.txtEmail.TopRightCornerRadius = 12;
            this.txtEmail.ValidationPattern = "";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtNationalIDNumber
            // 
            this.txtNationalIDNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalIDNumber.BackgroundColor = System.Drawing.Color.White;
            this.txtNationalIDNumber.BorderColor = System.Drawing.Color.DarkGray;
            this.txtNationalIDNumber.BottomLeftCornerRadius = 12;
            this.txtNationalIDNumber.BottomRightCornerRadius = 12;
            this.txtNationalIDNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalIDNumber.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtNationalIDNumber.FocusImage = null;
            this.txtNationalIDNumber.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalIDNumber.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtNationalIDNumber.HoverImage = null;
            this.txtNationalIDNumber.IdleImage = null;
            this.txtNationalIDNumber.Location = new System.Drawing.Point(153, 70);
            this.txtNationalIDNumber.MakeRadial = true;
            this.txtNationalIDNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNationalIDNumber.Name = "txtNationalIDNumber";
            this.txtNationalIDNumber.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtNationalIDNumber.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalIDNumber.PlaceholderText = "National No.";
            this.txtNationalIDNumber.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtNationalIDNumber.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtNationalIDNumber.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtNationalIDNumber.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtNationalIDNumber.Size = new System.Drawing.Size(233, 25);
            this.txtNationalIDNumber.TabIndex = 27;
            this.txtNationalIDNumber.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtNationalIDNumber.TextContent = "";
            this.txtNationalIDNumber.TopLeftCornerRadius = 12;
            this.txtNationalIDNumber.TopRightCornerRadius = 12;
            this.txtNationalIDNumber.ValidationEnabled = false;
            this.txtNationalIDNumber.ValidationPattern = "";
            this.txtNationalIDNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalIDNumber_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.BackgroundColor = System.Drawing.Color.White;
            this.txtLastName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.BottomLeftCornerRadius = 12;
            this.txtLastName.BottomRightCornerRadius = 12;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtLastName.FocusImage = null;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtLastName.HoverImage = null;
            this.txtLastName.IdleImage = null;
            this.txtLastName.Location = new System.Drawing.Point(718, 27);
            this.txtLastName.MakeRadial = true;
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtLastName.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.PlaceholderText = "Last";
            this.txtLastName.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtLastName.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtLastName.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtLastName.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtLastName.Size = new System.Drawing.Size(166, 25);
            this.txtLastName.TabIndex = 26;
            this.txtLastName.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtLastName.TextContent = "";
            this.txtLastName.TopLeftCornerRadius = 12;
            this.txtLastName.TopRightCornerRadius = 12;
            this.txtLastName.ValidationEnabled = false;
            this.txtLastName.ValidationPattern = "";
            // 
            // txtThirdName
            // 
            this.txtThirdName.BackColor = System.Drawing.Color.Transparent;
            this.txtThirdName.BackgroundColor = System.Drawing.Color.White;
            this.txtThirdName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtThirdName.BottomLeftCornerRadius = 12;
            this.txtThirdName.BottomRightCornerRadius = 12;
            this.txtThirdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThirdName.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtThirdName.FocusImage = null;
            this.txtThirdName.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdName.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtThirdName.HoverImage = null;
            this.txtThirdName.IdleImage = null;
            this.txtThirdName.Location = new System.Drawing.Point(530, 27);
            this.txtThirdName.MakeRadial = true;
            this.txtThirdName.Margin = new System.Windows.Forms.Padding(2);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtThirdName.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdName.PlaceholderText = "Third";
            this.txtThirdName.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtThirdName.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtThirdName.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtThirdName.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtThirdName.Size = new System.Drawing.Size(166, 25);
            this.txtThirdName.TabIndex = 25;
            this.txtThirdName.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtThirdName.TextContent = "";
            this.txtThirdName.TopLeftCornerRadius = 12;
            this.txtThirdName.TopRightCornerRadius = 12;
            this.txtThirdName.ValidationEnabled = false;
            this.txtThirdName.ValidationPattern = "";
            // 
            // txtSecondName
            // 
            this.txtSecondName.BackColor = System.Drawing.Color.Transparent;
            this.txtSecondName.BackgroundColor = System.Drawing.Color.White;
            this.txtSecondName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSecondName.BottomLeftCornerRadius = 12;
            this.txtSecondName.BottomRightCornerRadius = 12;
            this.txtSecondName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecondName.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtSecondName.FocusImage = null;
            this.txtSecondName.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtSecondName.HoverImage = null;
            this.txtSecondName.IdleImage = null;
            this.txtSecondName.Location = new System.Drawing.Point(341, 27);
            this.txtSecondName.MakeRadial = true;
            this.txtSecondName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtSecondName.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.PlaceholderText = "Second";
            this.txtSecondName.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSecondName.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSecondName.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSecondName.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtSecondName.Size = new System.Drawing.Size(166, 25);
            this.txtSecondName.TabIndex = 24;
            this.txtSecondName.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtSecondName.TextContent = "";
            this.txtSecondName.TopLeftCornerRadius = 12;
            this.txtSecondName.TopRightCornerRadius = 12;
            this.txtSecondName.ValidationEnabled = false;
            this.txtSecondName.ValidationPattern = "";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BackgroundColor = System.Drawing.Color.White;
            this.txtFirstName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtFirstName.BottomLeftCornerRadius = 12;
            this.txtFirstName.BottomRightCornerRadius = 12;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtFirstName.FocusImage = null;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtFirstName.HoverImage = null;
            this.txtFirstName.IdleImage = null;
            this.txtFirstName.Location = new System.Drawing.Point(153, 28);
            this.txtFirstName.MakeRadial = true;
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtFirstName.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.PlaceholderText = "First";
            this.txtFirstName.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtFirstName.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtFirstName.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtFirstName.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtFirstName.Size = new System.Drawing.Size(166, 25);
            this.txtFirstName.TabIndex = 23;
            this.txtFirstName.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.TextContent = "";
            this.txtFirstName.TopLeftCornerRadius = 12;
            this.txtFirstName.TopRightCornerRadius = 12;
            this.txtFirstName.ValidationEnabled = false;
            this.txtFirstName.ValidationPattern = "";
            // 
            // rdFemale
            // 
            this.rdFemale.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rdFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdFemale.CanBeep = false;
            this.rdFemale.CanShake = false;
            this.rdFemale.Checked = false;
            this.rdFemale.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdFemale.ContainerBackColor = System.Drawing.Color.Transparent;
            this.rdFemale.ContainerBorderColor = System.Drawing.Color.Transparent;
            this.rdFemale.ContainerBorderWidth = 1;
            this.rdFemale.ContainerBottomLeftRadius = 8;
            this.rdFemale.ContainerBottomRightRadius = 8;
            this.rdFemale.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdFemale.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdFemale.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdFemale.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdFemale.ContainerHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdFemale.ContainerPadding = 8;
            this.rdFemale.ContainerPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdFemale.ContainerTopLeftRadius = 8;
            this.rdFemale.ContainerTopRightRadius = 8;
            this.rdFemale.EnableRipple = false;
            this.rdFemale.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemale.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.rdFemale.IsContained = false;
            this.rdFemale.IsReadOnly = false;
            this.rdFemale.Location = new System.Drawing.Point(269, 112);
            this.rdFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdFemale.MinimumSize = new System.Drawing.Size(178, 26);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdFemale.RippleDuration = 0.5F;
            this.rdFemale.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard;
            this.rdFemale.ShakeDuration = 0.5F;
            this.rdFemale.Size = new System.Drawing.Size(178, 31);
            this.rdFemale.TabIndex = 22;
            this.rdFemale.Text = "Female";
            this.rdFemale.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rdFemale.ToolTipText = "";
            this.rdFemale.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdFemale.Click += new System.EventHandler(this.rdFemale_Click);
            // 
            // rdMale
            // 
            this.rdMale.AccessibleName = "";
            this.rdMale.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rdMale.BackColor = System.Drawing.Color.Transparent;
            this.rdMale.CanBeep = false;
            this.rdMale.CanShake = false;
            this.rdMale.Checked = true;
            this.rdMale.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdMale.ContainerBackColor = System.Drawing.Color.Transparent;
            this.rdMale.ContainerBorderColor = System.Drawing.Color.Transparent;
            this.rdMale.ContainerBorderWidth = 1;
            this.rdMale.ContainerBottomLeftRadius = 8;
            this.rdMale.ContainerBottomRightRadius = 8;
            this.rdMale.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdMale.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdMale.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdMale.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdMale.ContainerHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdMale.ContainerPadding = 8;
            this.rdMale.ContainerPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdMale.ContainerTopLeftRadius = 8;
            this.rdMale.ContainerTopRightRadius = 8;
            this.rdMale.EnableRipple = false;
            this.rdMale.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMale.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.rdMale.IsContained = false;
            this.rdMale.IsReadOnly = false;
            this.rdMale.Location = new System.Drawing.Point(154, 112);
            this.rdMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdMale.MinimumSize = new System.Drawing.Size(178, 26);
            this.rdMale.Name = "rdMale";
            this.rdMale.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdMale.RippleDuration = 0.5F;
            this.rdMale.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard;
            this.rdMale.ShakeDuration = 0.5F;
            this.rdMale.Size = new System.Drawing.Size(178, 31);
            this.rdMale.TabIndex = 20;
            this.rdMale.Text = "Male";
            this.rdMale.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rdMale.ToolTipText = "";
            this.rdMale.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.rdMale.Click += new System.EventHandler(this.rdMale_Click);
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(4, 202);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(95, 21);
            this.lbAddress.TabIndex = 18;
            this.lbAddress.Text = "Address:";
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(4, 159);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(95, 21);
            this.lbEmail.TabIndex = 17;
            this.lbEmail.Text = "Email:";
            // 
            // lbGender
            // 
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(4, 116);
            this.lbGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(95, 21);
            this.lbGender.TabIndex = 16;
            this.lbGender.Text = "Gender:";
            // 
            // lbNationalIDNumber
            // 
            this.lbNationalIDNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNationalIDNumber.Location = new System.Drawing.Point(4, 73);
            this.lbNationalIDNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNationalIDNumber.Name = "lbNationalIDNumber";
            this.lbNationalIDNumber.Size = new System.Drawing.Size(107, 21);
            this.lbNationalIDNumber.TabIndex = 15;
            this.lbNationalIDNumber.Text = "National No:";
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(4, 30);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(91, 21);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Name:";
            // 
            // lbPersonIDValue
            // 
            this.lbPersonIDValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersonIDValue.Location = new System.Drawing.Point(164, 59);
            this.lbPersonIDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPersonIDValue.Name = "lbPersonIDValue";
            this.lbPersonIDValue.Size = new System.Drawing.Size(95, 21);
            this.lbPersonIDValue.TabIndex = 13;
            this.lbPersonIDValue.Text = "N/A";
            // 
            // ofdSelectImage
            // 
            this.ofdSelectImage.FileName = "ofdSelectImage";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pbPersonID
            // 
            this.pbPersonID.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbPersonID.Location = new System.Drawing.Point(111, 59);
            this.pbPersonID.Name = "pbPersonID";
            this.pbPersonID.Size = new System.Drawing.Size(32, 23);
            this.pbPersonID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonID.TabIndex = 14;
            this.pbPersonID.TabStop = false;
            // 
            // lbWaiting
            // 
            this.lbWaiting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.Location = new System.Drawing.Point(300, 310);
            this.lbWaiting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(114, 21);
            this.lbWaiting.TabIndex = 88;
            this.lbWaiting.Text = "Please Wait...";
            this.lbWaiting.Visible = false;
            // 
            // frmAddAndEditPerson
            // 
            this.AcceptButton = this.llbSetImage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pbPersonID);
            this.Controls.Add(this.lbPersonIDValue);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAndEditPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person";
            this.Load += new System.EventHandler(this.frmAddAndEditPerson_Load);
            this.gbContainer.ResumeLayout(false);
            this.gbContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNationalIDNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateOfBirth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private SiticoneNetFrameworkUI.SiticoneLabel lbPersonID;
        private SiticoneNetFrameworkUI.SiticonePanel gbContainer;
        private SiticoneNetFrameworkUI.SiticoneLabel lbPersonIDValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbEmail;
        private SiticoneNetFrameworkUI.SiticoneLabel lbGender;
        private SiticoneNetFrameworkUI.SiticoneLabel lbNationalIDNumber;
        private SiticoneNetFrameworkUI.SiticoneLabel lbName;
        private SiticoneNetFrameworkUI.SiticoneLabel lbAddress;
        private SiticoneNetFrameworkUI.SiticoneRadioButton rdMale;
        private SiticoneNetFrameworkUI.SiticoneRadioButton rdFemale;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtFirstName;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtSecondName;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtThirdName;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtLastName;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtNationalIDNumber;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtEmail;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtAddress;
        private SiticoneNetFrameworkUI.SiticoneLabel lbDateOfBirth;
        private SiticoneNetFrameworkUI.SiticoneLabel lbPhone;
        private SiticoneNetFrameworkUI.SiticoneLabel lbCountry;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtPhone;
        private SiticoneNetFrameworkUI.SiticoneDateTimePicker dtpDateOfBirth;
        private SiticoneNetFrameworkUI.SiticoneDropdown dplCountries;
        private SiticoneNetFrameworkUI.SiticoneLinkedLabel llbSetImage;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnSave;
        private System.Windows.Forms.OpenFileDialog ofdSelectImage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.PictureBox pbPersonID;
        private System.Windows.Forms.PictureBox pbName;
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.PictureBox pbCountry;
        private System.Windows.Forms.PictureBox pbNationalIDNumber;
        private System.Windows.Forms.PictureBox pbMale;
        private System.Windows.Forms.PictureBox pbFemale;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.PictureBox pbAddress;
        private System.Windows.Forms.PictureBox pbDateOfBirth;
        private SiticoneNetFrameworkUI.SiticoneLabel lbWaiting;
    }
}