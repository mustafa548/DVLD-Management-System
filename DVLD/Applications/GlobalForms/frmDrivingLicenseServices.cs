using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmDrivingLicenseServices : Form
    {
        public frmDrivingLicenseServices()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalLicenses_Click(object sender, EventArgs e)
        {
            frmAddAndEditRequestedLocalLicense AddLocalLicenseRequestForm = new frmAddAndEditRequestedLocalLicense();
            AddLocalLicenseRequestForm.ShowDialog();
        }

        private void btnInternationalLicenses_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenses AddInternationalLicenseForm = new frmAddInternationalLicenses();
            AddInternationalLicenseForm.ShowDialog();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            frmRenewLocalLicense RenewLocalLicenseForm = new frmRenewLocalLicense();
            RenewLocalLicenseForm.ShowDialog();
        }

        private void btnReplacement_Click(object sender, EventArgs e)
        {
            frmReplacementLicense ReplacementLicenseForm = new frmReplacementLicense();
            ReplacementLicenseForm.ShowDialog();
        }

        private void btnRealiseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmRealiseDetainedLicense RealiseDetainedLicenseForm = new frmRealiseDetainedLicense();
            RealiseDetainedLicenseForm.ShowDialog();
        }

        private void btnRetakeTest_Click(object sender, EventArgs e)
        {
            frmRequestedLocalLicenses RequestedLocalLicensesForm = new frmRequestedLocalLicenses();
            RequestedLocalLicensesForm.ShowDialog();
        }
    }
}
