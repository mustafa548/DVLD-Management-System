using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLocalLicenseDetails : Form
    {
        private int _LicenseID;

        public frmLocalLicenseDetails(int LicenseID)
        {
            InitializeComponent();

            _LicenseID = LicenseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLocalLicenseDetails_Load(object sender, EventArgs e)
        {
            if (_LicenseID != -1)
                ctrlLocalLicense1.SelectLicense(_LicenseID);
            else
            {
                MessageBox.Show($"No License With ID = {_LicenseID}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
