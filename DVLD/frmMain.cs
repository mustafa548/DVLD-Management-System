using System;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            gbAccountSettings.Visible = false;
            gbApplication.Visible = false;

            frmPeople peopleForm = new frmPeople();
            peopleForm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            gbAccountSettings.Visible = false;
            gbApplication.Visible = false;

            frmUsers UsersForm = new frmUsers();
            UsersForm.ShowDialog();
        }

        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            gbAccountSettings.Visible = true;
            gbApplication.Visible = false;
        }

        private void btnCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo UserInfoForm = new frmUserInfo(clsGlobal.CurrentUser.UserID);
            UserInfoForm.ShowDialog();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = new clsUser();

            clsGlobal.SetValueOfUserNameInRegistry("");

            this.DialogResult = DialogResult.Retry;

            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangePasswordForm = new frmChangePassword();
            ChangePasswordForm.ShowDialog();
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            gbAccountSettings.Visible = false;
            gbApplication.Visible = true;
        }

        private void btnManageApplicationTypes_Click(object sender, EventArgs e)
        {
            frmApplicationTypes ApplicationTypesForm = new frmApplicationTypes();
            ApplicationTypesForm.ShowDialog();
        }

        private void btnManageTestTypes_Click(object sender, EventArgs e)
        {
            frmTestTypes TestTypesForm = new frmTestTypes();
            TestTypesForm.ShowDialog();
        }

        private void btnManageApplication_Click(object sender, EventArgs e)
        {
            frmManageApllications ManageApplicationsForm = new frmManageApllications();
            ManageApplicationsForm.ShowDialog();
        }

        private void btnDrivingLicenseService_Click(object sender, EventArgs e)
        {
            frmDrivingLicenseServices DrivingLicenseServicesForm = new frmDrivingLicenseServices();
            DrivingLicenseServicesForm.ShowDialog();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            gbAccountSettings.Visible = false;
            gbApplication.Visible = false;

            frmDrivers DriversForm = new frmDrivers();
            DriversForm.ShowDialog();
        }

        private void btnDetainLicenses_Click(object sender, EventArgs e)
        {
            frmDetainServices DetainServicesForm = new frmDetainServices();
            DetainServicesForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
