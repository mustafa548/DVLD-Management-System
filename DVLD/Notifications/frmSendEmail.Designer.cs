namespace DVLD
{
    partial class frmSendEmail
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
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.txtSubject = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.lbSubject = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.txtBody = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.lbBody = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbTo = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbToValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.btnSend = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.pbTo = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
            this.pbSubject = new System.Windows.Forms.PictureBox();
            this.lbWaiting = new SiticoneNetFrameworkUI.SiticoneLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(376, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 39);
            this.lbTitle.TabIndex = 46;
            this.lbTitle.Text = "Send Email";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.Transparent;
            this.txtSubject.BackgroundColor = System.Drawing.Color.White;
            this.txtSubject.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSubject.BottomLeftCornerRadius = 12;
            this.txtSubject.BottomRightCornerRadius = 12;
            this.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtSubject.FocusImage = null;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtSubject.HoverImage = null;
            this.txtSubject.IdleImage = null;
            this.txtSubject.Location = new System.Drawing.Point(154, 160);
            this.txtSubject.MakeRadial = true;
            this.txtSubject.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtSubject.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.PlaceholderText = "Subject";
            this.txtSubject.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtSubject.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSubject.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSubject.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtSubject.Size = new System.Drawing.Size(380, 25);
            this.txtSubject.TabIndex = 76;
            this.txtSubject.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtSubject.TextContent = "";
            this.txtSubject.TopLeftCornerRadius = 12;
            this.txtSubject.TopRightCornerRadius = 12;
            this.txtSubject.ValidationEnabled = false;
            this.txtSubject.ValidationPattern = "";
            // 
            // lbSubject
            // 
            this.lbSubject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.Location = new System.Drawing.Point(11, 160);
            this.lbSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(94, 21);
            this.lbSubject.TabIndex = 75;
            this.lbSubject.Text = "Subject:";
            // 
            // txtBody
            // 
            this.txtBody.BackColor = System.Drawing.Color.Transparent;
            this.txtBody.BackgroundColor = System.Drawing.Color.White;
            this.txtBody.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBody.BottomLeftCornerRadius = 8;
            this.txtBody.BottomRightCornerRadius = 8;
            this.txtBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBody.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.txtBody.FocusImage = null;
            this.txtBody.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.HoverBorderColor = System.Drawing.Color.Gray;
            this.txtBody.HoverImage = null;
            this.txtBody.IdleImage = null;
            this.txtBody.Location = new System.Drawing.Point(154, 214);
            this.txtBody.Margin = new System.Windows.Forms.Padding(2);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtBody.PlaceholderFont = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.PlaceholderText = "Body";
            this.txtBody.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtBody.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBody.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtBody.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtBody.Size = new System.Drawing.Size(543, 123);
            this.txtBody.TabIndex = 78;
            this.txtBody.TextColor = System.Drawing.SystemColors.WindowText;
            this.txtBody.TextContent = "";
            this.txtBody.TopLeftCornerRadius = 8;
            this.txtBody.TopRightCornerRadius = 8;
            this.txtBody.ValidationEnabled = false;
            this.txtBody.ValidationPattern = "";
            // 
            // lbBody
            // 
            this.lbBody.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBody.Location = new System.Drawing.Point(11, 214);
            this.lbBody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBody.Name = "lbBody";
            this.lbBody.Size = new System.Drawing.Size(94, 21);
            this.lbBody.TabIndex = 79;
            this.lbBody.Text = "Body:";
            // 
            // lbTo
            // 
            this.lbTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(11, 110);
            this.lbTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(94, 21);
            this.lbTo.TabIndex = 81;
            this.lbTo.Text = "To:";
            // 
            // lbToValue
            // 
            this.lbToValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToValue.Location = new System.Drawing.Point(154, 110);
            this.lbToValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbToValue.Name = "lbToValue";
            this.lbToValue.Size = new System.Drawing.Size(380, 21);
            this.lbToValue.TabIndex = 83;
            this.lbToValue.Text = "???";
            // 
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(844, 9);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(35, 35);
            this.btnClose1.TabIndex = 84;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BadgeBackColor = System.Drawing.Color.Red;
            this.btnSend.BadgeForeColor = System.Drawing.Color.White;
            this.btnSend.BadgeRadius = 8;
            this.btnSend.BadgeRightMargin = 10;
            this.btnSend.BadgeValue = 0;
            this.btnSend.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSend.BorderColorEnd = System.Drawing.Color.Gray;
            this.btnSend.BorderColorStart = System.Drawing.Color.White;
            this.btnSend.BorderRadiusBottomLeft = 10;
            this.btnSend.BorderRadiusBottomRight = 10;
            this.btnSend.BorderRadiusTopLeft = 10;
            this.btnSend.BorderRadiusTopRight = 10;
            this.btnSend.BorderThickness = 1;
            this.btnSend.ButtonColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSend.ButtonColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSend.ButtonImage = global::DVLD.Properties.Resources.Send;
            this.btnSend.CanBeep = false;
            this.btnSend.CanShake = false;
            this.btnSend.ClickSoundPath = null;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.DisabledOverlayOpacity = 0.5F;
            this.btnSend.EnableBorderGradient = false;
            this.btnSend.EnableClickSound = false;
            this.btnSend.EnableFocusBorder = false;
            this.btnSend.EnableHoverSound = false;
            this.btnSend.EnablePressScale = false;
            this.btnSend.EnableTextShadow = false;
            this.btnSend.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnSend.FocusBorderThickness = 2;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnSend.HoverSoundPath = null;
            this.btnSend.HoverTransitionSpeed = 0.08F;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.ImageLeftMargin = 0;
            this.btnSend.ImageRightMargin = 3;
            this.btnSend.ImageSize = 25;
            this.btnSend.IsReadOnly = false;
            this.btnSend.Location = new System.Drawing.Point(764, 400);
            this.btnSend.MakeRadial = false;
            this.btnSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnSend.Name = "btnSend";
            this.btnSend.PressAnimationSpeed = 0.2F;
            this.btnSend.PressDepth = 1;
            this.btnSend.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSend.RippleExpandSpeedFactor = 0.05F;
            this.btnSend.RippleFadeSpeedFactor = 0.03F;
            this.btnSend.ShadowBlurFactor = 0.85F;
            this.btnSend.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSend.ShadowOffsetX = 3;
            this.btnSend.ShadowOffsetY = 3;
            this.btnSend.Size = new System.Drawing.Size(118, 41);
            this.btnSend.TabIndex = 86;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.TextPaddingBottom = 0;
            this.btnSend.TextPaddingLeft = 15;
            this.btnSend.TextPaddingRight = 0;
            this.btnSend.TextPaddingTop = 0;
            this.btnSend.TextShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSend.TextShadowOffsetX = 1;
            this.btnSend.TextShadowOffsetY = 1;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
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
            this.btnClose.Location = new System.Drawing.Point(633, 400);
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
            this.btnClose.TabIndex = 85;
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
            // pbTo
            // 
            this.pbTo.Image = global::DVLD.Properties.Resources.Email_321;
            this.pbTo.Location = new System.Drawing.Point(110, 101);
            this.pbTo.Name = "pbTo";
            this.pbTo.Size = new System.Drawing.Size(30, 30);
            this.pbTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTo.TabIndex = 82;
            this.pbTo.TabStop = false;
            // 
            // pbBody
            // 
            this.pbBody.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbBody.Location = new System.Drawing.Point(110, 214);
            this.pbBody.Name = "pbBody";
            this.pbBody.Size = new System.Drawing.Size(30, 30);
            this.pbBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBody.TabIndex = 80;
            this.pbBody.TabStop = false;
            // 
            // pbSubject
            // 
            this.pbSubject.Image = global::DVLD.Properties.Resources.Number_32;
            this.pbSubject.Location = new System.Drawing.Point(110, 155);
            this.pbSubject.Name = "pbSubject";
            this.pbSubject.Size = new System.Drawing.Size(30, 30);
            this.pbSubject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSubject.TabIndex = 77;
            this.pbSubject.TabStop = false;
            // 
            // lbWaiting
            // 
            this.lbWaiting.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaiting.Location = new System.Drawing.Point(353, 420);
            this.lbWaiting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWaiting.Name = "lbWaiting";
            this.lbWaiting.Size = new System.Drawing.Size(114, 21);
            this.lbWaiting.TabIndex = 87;
            this.lbWaiting.Text = "Please Wait...";
            this.lbWaiting.Visible = false;
            // 
            // frmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbWaiting);
            this.Controls.Add(this.btnClose1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbToValue);
            this.Controls.Add(this.pbTo);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.pbBody);
            this.Controls.Add(this.lbBody);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.pbSubject);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lbTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Email";
            this.Load += new System.EventHandler(this.frmSendEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private System.Windows.Forms.PictureBox pbSubject;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtSubject;
        private SiticoneNetFrameworkUI.SiticoneLabel lbSubject;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced txtBody;
        private SiticoneNetFrameworkUI.SiticoneLabel lbBody;
        private System.Windows.Forms.PictureBox pbBody;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTo;
        private System.Windows.Forms.PictureBox pbTo;
        private SiticoneNetFrameworkUI.SiticoneLabel lbToValue;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnSend;
        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private SiticoneNetFrameworkUI.SiticoneLabel lbWaiting;
    }
}