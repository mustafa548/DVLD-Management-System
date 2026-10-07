using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private clsUser User;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill Input Fields To Login", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User = clsUser.Find(txtUserName.Text);

            if (User == null)
            {
                MessageBox.Show("This User Name Doesn't Exist Please Enter The Right UserName", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clsPasswordServices.VerifyPassword(txtPassword.Text, User.PasswordHash))
            {
                MessageBox.Show("Wrong Password Please Enter The Right Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!User.IsActive)
            {
                MessageBox.Show("This User Doesn't Active Please Contact The Admin", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsGlobal.CurrentUser = User;

            if (chbRememberMe.Checked)
                clsGlobal.SetValueOfUserNameInRegistry(txtUserName.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pbShowHidePass_Click(object sender, EventArgs e)
        {
            clsUiGlobal.TogglePassword(pbShowHidePass, txtPassword);
        }

        private void llbForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword ForgetPasswordForm = new frmForgetPassword();
            ForgetPasswordForm.ShowDialog();
        }
    }
}
