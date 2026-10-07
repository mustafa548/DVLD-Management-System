namespace DVLD
{
    partial class frmRequestDetails
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
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneButtonAdvanced();
            this.btnClose1 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.lbTitle = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.ctrlRequestInfo1 = new DVLD.ctrlRequestInfo();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(600, 574);
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
            this.btnClose.TabIndex = 43;
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
            // btnClose1
            // 
            this.btnClose1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose1.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose1.IconSize = 12;
            this.btnClose1.IconThickness = 3;
            this.btnClose1.Location = new System.Drawing.Point(678, 12);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(35, 35);
            this.btnClose1.TabIndex = 42;
            this.btnClose1.Text = "siticoneCloseButton1";
            this.btnClose1.TooltipText = "Close button";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(271, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 39);
            this.lbTitle.TabIndex = 44;
            this.lbTitle.Text = "Request Details";
            // 
            // ctrlRequestInfo1
            // 
            this.ctrlRequestInfo1.Location = new System.Drawing.Point(12, 66);
            this.ctrlRequestInfo1.Name = "ctrlRequestInfo1";
            this.ctrlRequestInfo1.Size = new System.Drawing.Size(706, 496);
            this.ctrlRequestInfo1.TabIndex = 45;
            // 
            // frmRequestDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 621);
            this.ControlBox = false;
            this.Controls.Add(this.ctrlRequestInfo1);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClose1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRequestDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Details";
            this.Load += new System.EventHandler(this.frmRequestDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneButtonAdvanced btnClose;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose1;
        private SiticoneNetFrameworkUI.SiticoneLabel lbTitle;
        private ctrlRequestInfo ctrlRequestInfo1;
    }
}