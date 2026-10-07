using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmRealiseDetainedLicense : Form
    {
        private clsDetainedLicense DetainedLicense = null;

        private clsLocalLicense LocalLicense;

        public frmRealiseDetainedLicense()
        {
            InitializeComponent();
        }

        public frmRealiseDetainedLicense(int DetainedLicenseID)
        {
            InitializeComponent();

            DetainedLicense = clsDetainedLicense.Find(DetainedLicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillDataInLabels()
        {
            btnRealise.Enabled = true;
            llbShowLicenseHistory.Enabled = true;
            lbDetainIDValue.Text = DetainedLicense.DetainedLicenseID.ToString();
            lbDetainDateValue.Text = DetainedLicense.DetainedDate.ToString("dd/MM/yyyy");
            lbLicenseIDValue.Text = DetainedLicense.LicenseNumber.ToString();
            lbFineFeesValue.Text = DetainedLicense.Fine.ToString();
            lbTotalFeesValue.Text = (decimal.Parse(lbFineFeesValue.Text) + decimal.Parse(lbApplicationFeesValue.Text)).ToString();
        }

        private void frmRealiseDetainedLicense_Load(object sender, EventArgs e)
        {
            lbApplicationFeesValue.Text = clsApplicationType.Find((int)clsGlobal.enApplicationTypes.enRealiseDetainedLicense).ApplicationFees.ToString();
            lbCreatedByValue.Text = clsGlobal.CurrentUser.UserName;

            if (DetainedLicense != null)
            {
                ctrlLocalLicenseWithFilter1.AfterSelectLocalLicense(DetainedLicense.LocalLicense);
                FillDataInLabels();
                LocalLicense = DetainedLicense.LocalLicense;
            }
            else
                DetainedLicense = new clsDetainedLicense();

        }

        private void ctrlLocalLicenseWithFilter1_OnLocalLicenseSelected(int LicenseNumber)
        {
            LocalLicense = clsLocalLicense.Find(LicenseNumber);

            if (!LocalLicense.IsActive)
            {
                MessageBox.Show("This License Isn't Active, Choose Another One", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
                return;
            }

            if (!LocalLicense.IsDetained)
            {
                MessageBox.Show("This License Isn't Detained Can't Realise It, Choose Another One", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
                return;
            }

            DetainedLicense = clsDetainedLicense.FindByLicenseNumber(LicenseNumber);

            FillDataInLabels();

        }

        private void btnRealise_Click(object sender, EventArgs e)
        {
            clsApplication Application = new clsApplication();

            Application.ApplicationTypeID = (int)clsGlobal.enApplicationTypes.enRealiseDetainedLicense;
            Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            Application.Date = DateTime.Now;
            Application.PersonID = LocalLicense.Driver.PersonID;

            if (Application.Save())
            {
                DetainedLicense.IsRealised = true;
                DetainedLicense.RealiseDate = DateTime.Now;
                DetainedLicense.ApplicationNumber = Application.ApplicationNumber;

                if (DetainedLicense.Save())
                {
                    lbApplicationIDValue.Text = Application.ApplicationNumber.ToString();
                    llbShowLicenseInfo.Enabled = true;
                    btnRealise.Enabled = false;
                    LocalLicense.IsDetained = false;
                    LocalLicense.Save();
                    MessageBox.Show("Realised Completed Successfully", "Realised Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Can't Realise This License", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void llbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory PersonLicenseHistory = new frmPersonLicensesHistory(LocalLicense.Driver.PersonInfo);
            PersonLicenseHistory.ShowDialog();
        }

        private void llbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLocalLicenseDetails LocalLicenseDetails = new frmLocalLicenseDetails(LocalLicense.LicenseNumber);
            LocalLicenseDetails.ShowDialog();
        }

    }
}
