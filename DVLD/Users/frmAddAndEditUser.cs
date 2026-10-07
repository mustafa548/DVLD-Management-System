using DVLD_Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddAndEditUser : Form
    {
        private int _UserID;

        private clsUser _User;

        enum enMode {enAddNew, enEdit};

        private enMode _Mode;

        private int _PersonID = -1;

        public frmAddAndEditUser()
        {
            InitializeComponent();
            _Mode = enMode.enAddNew;
        }

        public frmAddAndEditUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.enEdit;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HidePasswordComponentsInEdit()
        {
            lbPassword.Visible            = false;
            lbConfirmPassword.Visible     = false;

            pbPassword.Visible            = false;
            pbConfirmPassword.Visible     = false;

            txtPassword.Visible           = false;
            txtConfirmPassword.Visible    = false;

            pbShowHidePass.Visible        = false;
            pbShowHideConfirmPass.Visible = false;
        }

        private void frmAddAndEditUser_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.enAddNew)
            {
                lbTitle.Text = "Add New User";
                _User = new clsUser();
                return;
            }

            _User = clsUser.Find(_UserID);

            if (_User != null)
            {
                _PersonID = _User.PersonID;

                lbTitle.Text = "Edit User";
                ctrlPersonInfoWithFilter1.AfterPersonSelected(_User.PersonInfo);

                lbUserIDValue.Text = _User.UserID.ToString();
                txtUserName.Text = _User.UserName;

                HidePasswordComponentsInEdit();
                chbIsActive.Location = new Point(chbIsActive.Location.X, chbIsActive.Location.Y - 130);

                chbIsActive.Checked = _User.IsActive;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || (txtPassword.Text == "" && _Mode == enMode.enAddNew) || (txtConfirmPassword.Text == "" && _Mode == enMode.enAddNew))
            {
                MessageBox.Show("You Should Fill The Input Field First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ( !(txtUserName.Text == _User.UserName || clsValidation.IsValidUserName(txtUserName.Text)) )
            {
                MessageBox.Show("The User Name Is Exists, Enter Another One", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("The Input Field Of Confirm Password Must Equal The Input Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_PersonID == -1)
            {
                MessageBox.Show("You Must Select Person First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.UserName = txtUserName.Text.Trim();
            _User.IsActive = chbIsActive.Checked;
            _User.PersonID = _PersonID;

            bool IsSaved = _Mode == enMode.enAddNew ? _User.Save(txtPassword.Text) : _User.Save();

            if (IsSaved)
            {
                _Mode = enMode.enEdit;
                lbUserIDValue.Text = _User.UserID.ToString();

                var message = MessageBox.Show("User Saved Successfully.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (message == DialogResult.OK)
                    this.Close();
            }
            else
                MessageBox.Show("Can't Save This User Info.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }   

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
                clsUiGlobal.SetError(e, txtConfirmPassword, "Must Equal To Password", errorProvider1);
            else
                clsUiGlobal.CancelError(e, txtConfirmPassword, errorProvider1);
        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtUserName.Text != _User.UserName && !clsValidation.IsValidUserName(txtUserName.Text))
                clsUiGlobal.SetError(e, txtUserName, "Must Unique", errorProvider1);
            else
                clsUiGlobal.CancelError(e, txtUserName, errorProvider1);
        }

        private void ctrlPersonInfoWithFilter1_OnPersonSelected(int PersonID)
        {
            if (clsUser.IsUserExistsByPersonID(PersonID))
            {
                _PersonID = -1;
                MessageBox.Show("This Person Is Already User Choose Another One.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonInfoWithFilter1.ClearSelectedPerson();
            }
            else
            {
                _PersonID = PersonID;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PersonID == -1)
                MessageBox.Show("You Must Select Person First.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                tabControl.SelectedTab = tabLoginInfo;
        }

        private void pbShowHidePass_Click(object sender, EventArgs e)
        {
            clsUiGlobal.TogglePassword(pbShowHidePass, txtPassword);
        }

        private void pbShowHideConfirmPass_Click(object sender, EventArgs e)
        {
            clsUiGlobal.TogglePassword(pbShowHideConfirmPass, txtConfirmPassword);
        }
    }
}
