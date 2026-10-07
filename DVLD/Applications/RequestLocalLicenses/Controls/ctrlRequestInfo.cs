using DVLD_Business;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlRequestInfo : UserControl
    {
        clsRequestLocalLicense Request;

        public ctrlRequestInfo()
        {
            InitializeComponent();
        }

        public void SelectRequest(int RequestID)
        {
            Request = clsRequestLocalLicense.FindRequestByID(RequestID);

            if (Request != null)
            {
                llbShowLicenseInfo.Visible = true;

                lbRequestIDValue.Text = Request.RequestID.ToString();
                lbAppliedForLicenseValue.Text = Request.LicenseClassInfo.Name;
                lbPassedTestsValue.Text = Request.PassedTests.ToString();

                ctrlApplicationInfo1.SelectApplication(Request);
            }

            if (Request != null && Request.IsCompletedStatus())
                llbShowLicenseInfo.Enabled = true;
        }

        private void llbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int LicenseID = clsLocalLicense.GetLicenseNumberByAppNumber(Request.ApplicationNumber);
            frmLocalLicenseDetails LocalLicenseDetailsForm = new frmLocalLicenseDetails(LicenseID);
            LocalLicenseDetailsForm.ShowDialog();
        }
    }
}
