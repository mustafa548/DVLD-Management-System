namespace DVLD
{
    partial class ctrlUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPersonInfo1 = new DVLD.ctrlPersonInfo();
            this.gbLoginInfo = new SiticoneNetFrameworkUI.SiticoneAuraGroupBox();
            this.lbUserID = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbUserName = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbUserNameValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbIsActive = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel4 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbUserIDValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.lbIsActiveValue = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.gbLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(903, 375);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // gbLoginInfo
            // 
            this.gbLoginInfo.AccentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.gbLoginInfo.AccentLineThickness = 3;
            this.gbLoginInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbLoginInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(207)))), ((int)(((byte)(216)))));
            this.gbLoginInfo.Controls.Add(this.lbIsActiveValue);
            this.gbLoginInfo.Controls.Add(this.lbUserNameValue);
            this.gbLoginInfo.Controls.Add(this.lbUserName);
            this.gbLoginInfo.Controls.Add(this.lbUserIDValue);
            this.gbLoginInfo.Controls.Add(this.lbIsActive);
            this.gbLoginInfo.Controls.Add(this.lbUserID);
            this.gbLoginInfo.FillColor = System.Drawing.Color.White;
            this.gbLoginInfo.HeaderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.gbLoginInfo.HeaderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
            this.gbLoginInfo.HeaderHeight = 25;
            this.gbLoginInfo.Location = new System.Drawing.Point(3, 381);
            this.gbLoginInfo.Name = "gbLoginInfo";
            this.gbLoginInfo.Padding = new System.Windows.Forms.Padding(8, 33, 8, 8);
            this.gbLoginInfo.Size = new System.Drawing.Size(901, 109);
            this.gbLoginInfo.TabIndex = 2;
            this.gbLoginInfo.Text = "Login Information";
            this.gbLoginInfo.TitleFont = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.gbLoginInfo.TitleTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            // 
            // lbUserID
            // 
            this.lbUserID.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(95, 50);
            this.lbUserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(97, 31);
            this.lbUserID.TabIndex = 54;
            this.lbUserID.Text = "User ID:";
            this.lbUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            this.lbUserName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(363, 50);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(123, 31);
            this.lbUserName.TabIndex = 55;
            this.lbUserName.Text = "User Name:";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserNameValue
            // 
            this.lbUserNameValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNameValue.Location = new System.Drawing.Point(490, 50);
            this.lbUserNameValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserNameValue.Name = "lbUserNameValue";
            this.lbUserNameValue.Size = new System.Drawing.Size(97, 31);
            this.lbUserNameValue.TabIndex = 56;
            this.lbUserNameValue.Text = "User1";
            this.lbUserNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIsActive
            // 
            this.lbIsActive.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActive.Location = new System.Drawing.Point(657, 50);
            this.lbIsActive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIsActive.Name = "lbIsActive";
            this.lbIsActive.Size = new System.Drawing.Size(103, 31);
            this.lbIsActive.TabIndex = 57;
            this.lbIsActive.Text = "Is Active:";
            this.lbIsActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.Location = new System.Drawing.Point(418, 257);
            this.siticoneLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(97, 31);
            this.siticoneLabel4.TabIndex = 58;
            this.siticoneLabel4.Text = "Filter By: ";
            // 
            // lbUserIDValue
            // 
            this.lbUserIDValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserIDValue.Location = new System.Drawing.Point(196, 50);
            this.lbUserIDValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserIDValue.Name = "lbUserIDValue";
            this.lbUserIDValue.Size = new System.Drawing.Size(97, 31);
            this.lbUserIDValue.TabIndex = 59;
            this.lbUserIDValue.Text = "20";
            this.lbUserIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIsActiveValue
            // 
            this.lbIsActiveValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsActiveValue.Location = new System.Drawing.Point(764, 50);
            this.lbIsActiveValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIsActiveValue.Name = "lbIsActiveValue";
            this.lbIsActiveValue.Size = new System.Drawing.Size(97, 31);
            this.lbIsActiveValue.TabIndex = 60;
            this.lbIsActiveValue.Text = "Yes";
            this.lbIsActiveValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctrlUserInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gbLoginInfo);
            this.Controls.Add(this.ctrlPersonInfo1);
            this.Controls.Add(this.siticoneLabel4);
            this.Name = "ctrlUserInfo";
            this.Size = new System.Drawing.Size(906, 492);
            this.gbLoginInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private SiticoneNetFrameworkUI.SiticoneAuraGroupBox gbLoginInfo;
        private SiticoneNetFrameworkUI.SiticoneLabel lbUserID;
        private SiticoneNetFrameworkUI.SiticoneLabel lbIsActiveValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbUserNameValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbUserName;
        private SiticoneNetFrameworkUI.SiticoneLabel lbUserIDValue;
        private SiticoneNetFrameworkUI.SiticoneLabel lbIsActive;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel4;
    }
}
