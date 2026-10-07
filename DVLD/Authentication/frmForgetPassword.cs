using DVLD_Business;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmForgetPassword : Form
    {
        private bool allowTabCahnge = false;

        private clsUser User;

        private string OTP;

        private DateTime expiration = new DateTime();

        private int counter = 3;

        public frmForgetPassword()
        {
            InitializeComponent();
        }

        private void frmForgetPassword_Load(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabUserName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !allowTabCahnge;
        }

        private async void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please Enter Your User Name First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User = clsUser.Find(txtUserName.Text);

            if (User == null)
            {
                MessageBox.Show("This User Name Is Not Found, Please Enter The Right User Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!User.IsActive)
            {
                MessageBox.Show("This User Is Not Active, Please Contact The Admin", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsGlobal.HandlePasswordResetLimit(User))
            {
                MessageBox.Show("Your Account Can't Request OTP In That Time, Try Again Later", "OTP Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnClose.Enabled = false;
            btnSendOTP.Enabled = false;
            btnClose1.Enabled = false;
            lbWaiting.Visible = true;

            try
            {
                OTP = clsGlobal.GenerateOTP();

                string body = $"Hello, \nWe Received a Request To Reset Your DVLD Account Password\n\nYour OTP Is: {OTP}\nPlease Enter This Code In The App To Contine,\n\nBest Regrads\nDVLD Team";

                bool result = await Task.Run(() => clsGlobal.SendEmail(User.PersonInfo.Email, "DVLD - Password Reser Verification Code", body));

                if (result)
                {
                    allowTabCahnge = true;

                    tabControl.SelectedTab = tabVerification;

                    allowTabCahnge = false;

                    expiration = DateTime.Now.AddMinutes(10);

                    timer1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error: Email Sended Failed, Try Again Later", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    User.Attempts++;

                    if (User.PasswordBlockedUntil != null)
                        User.PasswordBlockedUntil = null;

                    User.LastAttemptAt = null;

                    User.Save();
                }
            }
            finally
            {
                btnClose.Enabled = true;
                btnSendOTP.Enabled = true;
                btnClose1.Enabled = true;
                lbWaiting.Visible = false;
            }

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == "")
            {
                MessageBox.Show("Please Enter The OTP First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (OTP != txtOTP.Text)
            {
                if (counter != 0)
                    counter--;
                else
                {
                    OTP = "";
                    MessageBox.Show("This OTP Became Invalid You Must Request To Resend OTP", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Wrong OTP, Please Write The Right OTP", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (expiration < DateTime.Now)
            {
                MessageBox.Show("The OTP Expiration Is Ended", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (counter == 0)
            {
                OTP = "";
                MessageBox.Show("This OTP Became Invalid You Must Request To Resend OTP", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            timer1.Enabled = false;

            allowTabCahnge = true;

            tabControl.SelectedTab = tabResetPassword;

            allowTabCahnge = false;
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text)
                clsUiGlobal.SetError(e, txtConfirmPassword, "Must Equal To New Password", errorProvider1);
            else
                clsUiGlobal.CancelError(e, txtConfirmPassword, errorProvider1);
        }

        private void pbShowHideNewPass_Click(object sender, EventArgs e)
        {
            clsUiGlobal.TogglePassword(pbShowHideNewPass, txtNewPassword);
        }

        private void pbShowHideConfirmPass_Click(object sender, EventArgs e)
        {
            clsUiGlobal.TogglePassword(pbShowHideConfirmPass, txtConfirmPassword);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please Enter Your Input Fiels First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("The Confirm Password Must Equal To The New Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (User.Save(txtNewPassword.Text))
            {
                MessageBox.Show("Saved Completed Successfully, You Can Log In By New Password", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsGlobal.DefaultPasswordResetLimit(User);
                this.Close();
            }
            else
                MessageBox.Show("Error: Can't Save The New Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(lbTimer.Text) > 0)
                lbTimer.Text = (int.Parse(lbTimer.Text) - 1).ToString();
            else
            {
                llbResendOTP.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private async void llbResendOTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!clsGlobal.HandlePasswordResetLimit(User))
            {
                MessageBox.Show("Your Account Can't Request OTP In That Time, Try Again Later", "OTP Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnClose.Enabled = false;
            btnSendOTP.Enabled = false;
            btnClose1.Enabled = false;
            llbResendOTP.Enabled = false;
            lbWaiting2.Visible = true;

            try
            {
                OTP = clsGlobal.GenerateOTP();

                string body = $"Hello, \nWe Received a Request To Reset Your DVLD Account Password\n\nYour OTP Is: {OTP}\nPlease Enter This Code In The App To Contine,\n\nBest Regrads\nDVLD Team";

                bool result = await Task.Run(() => clsGlobal.SendEmail(User.PersonInfo.Email, "DVLD - Password Reser Verification Code", body));

                if (result)
                {
                    counter = 3;

                    lbTimer.Text = "10";

                    expiration = DateTime.Now.AddMinutes(10);

                    timer1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error: Email Sended Failed, Try Again Later", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    User.Attempts++;

                    if (User.PasswordBlockedUntil != null)
                        User.PasswordBlockedUntil = null;

                    User.LastAttemptAt = null;

                    User.Save();
                }
            }
            finally
            {
                btnClose.Enabled = true;
                btnSendOTP.Enabled = true;
                btnClose1.Enabled = true;
                lbWaiting2.Visible = false;
            }
        }
    }
}
