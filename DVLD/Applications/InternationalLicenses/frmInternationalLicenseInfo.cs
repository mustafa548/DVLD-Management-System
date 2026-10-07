using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmInternationalLicenseInfo : Form
    {
        private int _InternationalLicenseID;

        public frmInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();

            _InternationalLicenseID = InternationalLicenseID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicense1.SelectInternationalLicense(_InternationalLicenseID);
        }
    }
}
