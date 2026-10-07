using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmRenewLocalLicense : Form
    {
        private clsLocalLicense LocalLicense;

        private clsLocalLicense NewLocalLicense;

        public frmRenewLocalLicense()
        {
            InitializeComponent();
        }

        private void frmRenewLocalLicense_Load(object sender, EventArgs e)
        {
            lbApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbIssueDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbApplicationFeesValue.Text = clsApplicationType.Find((int)clsGlobal.enApplicationTypes.enRenewDrivingLicense).ApplicationFees.ToString();
            lbCreatedByValue.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlLocalLicenseWithFilter1_OnLocalLicenseSelected(int LicenseNumber)
        {
            LocalLicense = clsLocalLicense.Find(LicenseNumber);

            if (LocalLicense.IsDetained)
            {
                MessageBox.Show("This License Is Detained You Must Realise It First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
                return;
            }

            if (DateTime.Now < LocalLicense.ExpirationDate)
            {
                MessageBox.Show($"This Local License Is Active Now It Will Expire At {LocalLicense.ExpirationDate.ToString("dd/MM/yyyy")}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
            }
            else if (!LocalLicense.IsActive)
            {
                MessageBox.Show("This License ISn't Active, Choose Another One.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
            }
            else
            {
                llbShowLicenseHistory.Enabled = true;
                btnRenew.Enabled = true;
                LocalLicense.IsActive = false;
                LocalLicense.Save();
                lbLicenseFeesValue.Text = LocalLicense.LicenseClass.Fees.ToString();
                lbOldLicenseIDValue.Text = LicenseNumber.ToString();
                lbExpirationDateValue.Text = DateTime.Now.AddYears(LocalLicense.LicenseClass.ValidtyLength).ToString("dd/MM/yyyy");
                lbTotalFeesValue.Text = (decimal.Parse(lbApplicationFeesValue.Text) + decimal.Parse(lbLicenseFeesValue.Text)).ToString();
            }
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            clsApplication Application = new clsApplication();

            NewLocalLicense = new clsLocalLicense();

            Application.ApplicationTypeID = (int)clsGlobal.enApplicationTypes.enRenewDrivingLicense;
            Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            Application.Date = DateTime.Now;
            Application.PersonID = LocalLicense.Driver.PersonID;

            if (Application.Save())
            {
                NewLocalLicense.RenewIssue();
                NewLocalLicense.IssueDate = DateTime.Now;
                NewLocalLicense.ExpirationDate = DateTime.Now.AddYears(LocalLicense.LicenseClass.ValidtyLength);
                NewLocalLicense.Remarks = txtNotes.Text;
                NewLocalLicense.LicenseClassID = LocalLicense.LicenseClassID;
                NewLocalLicense.ApplicationNumber = Application.ApplicationNumber;
                NewLocalLicense.DriverID = LocalLicense.DriverID;
                NewLocalLicense.IsActive = true;

                if (NewLocalLicense.Save())
                {
                    lbRLApplicationIDValue.Text = Application.ApplicationNumber.ToString();
                    lbRenewedLicenseIDValue.Text = NewLocalLicense.LicenseNumber.ToString();
                    llbShowNewLicenseInfo.Enabled = true;
                    btnRenew.Enabled = false;
                    ctrlLocalLicenseWithFilter1.DisableFilter();
                    MessageBox.Show("Saved Completed Successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Can't Save This License", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void llbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory PersonLicensesHistoryForm = new frmPersonLicensesHistory(LocalLicense.Driver.PersonInfo);
            PersonLicensesHistoryForm.ShowDialog();
        }

        private void llbShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLocalLicenseDetails LocalLicenseDetailsForm = new frmLocalLicenseDetails(NewLocalLicense.LicenseNumber);
            LocalLicenseDetailsForm.ShowDialog();
        }
    }
}
