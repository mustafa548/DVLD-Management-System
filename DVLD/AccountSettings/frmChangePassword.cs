using System;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlUserInfo1.SelectUser(clsGlobal.CurrentUser.UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbShowHideCurrentPass_Click(object sender, EventArgs e)
        {
            clsUiGlobal.TogglePassword(pbShowHideCurrentPass, txtCurrentPassword);
        }

        private void pbShowHideNewPass_Click(object sender, EventArgs e)
        {
            clsUiGlobal.TogglePassword(pbShowHideNewPass, txtNewPassword);
        }

        private void pbShowHideConfirmPass_Click(object sender, EventArgs e)
        {
            clsUiGlobal.TogglePassword(pbShowHideConfirmPass, txtConfirmPassword);
        }

        private void txtCurrentPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!clsPasswordServices.VerifyPassword(txtCurrentPassword.Text, clsGlobal.CurrentUser.PasswordHash))
                clsUiGlobal.SetError(e, txtCurrentPassword, "Must Equal To Your Current Password", errorProvider1);
            else
                clsUiGlobal.CancelError(e, txtCurrentPassword, errorProvider1);
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtNewPassword.Text)
                clsUiGlobal.SetError(e, txtConfirmPassword, "Must Equal To The New Password", errorProvider1);
            else
                clsUiGlobal.CancelError(e, txtConfirmPassword, errorProvider1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == "" || txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please Fill The Input Fields First.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsPasswordServices.VerifyPassword(txtCurrentPassword.Text, clsGlobal.CurrentUser.PasswordHash))
            {
                MessageBox.Show("Error: Please Right Your Current Password Correctly.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Error: The Confirmed Password Field Must Equal To The New Password Field.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGlobal.CurrentUser.Save(txtNewPassword.Text))
            {
                clsGlobal.DefaultPasswordResetLimit(clsGlobal.CurrentUser);
                MessageBox.Show("Password Saved Successfully.", "Password Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Can't Save This User's Password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }
    }
}
