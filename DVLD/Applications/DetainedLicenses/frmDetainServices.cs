using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmDetainServices : Form
    {
        public frmDetainServices()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageDetainedLicenses_Click(object sender, EventArgs e)
        {
            frmDetainedLicenses DetainedLicenseForm = new frmDetainedLicenses();
            DetainedLicenseForm.ShowDialog();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicenseForm = new frmDetainLicense();
            DetainLicenseForm.ShowDialog();
        }

        private void btnRealiseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmRealiseDetainedLicense RealiseDetainedLicenseForm = new frmRealiseDetainedLicense();
            RealiseDetainedLicenseForm.ShowDialog();
        }
    }
}
