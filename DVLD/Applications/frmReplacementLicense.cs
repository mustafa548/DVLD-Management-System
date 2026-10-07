using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmReplacementLicense : Form
    {
        private clsLocalLicense LocalLicense;

        private clsLocalLicense NewLocalLicense;

        public frmReplacementLicense()
        {
            InitializeComponent();
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

            if (!LocalLicense.IsActive)
            {
                MessageBox.Show("This License Isn't Active, Choose Another One", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
            }
            else
            {
                llbShowLicenseHistory.Enabled = true;
                btnIssueReplacement.Enabled = true;
                lbOldLicenseIDValue.Text = LicenseNumber.ToString();
            }
        }

        private void frmReplacementLicense_Load(object sender, EventArgs e)
        {
            lbApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbApplicationFeesValue.Text = clsApplicationType.Find((int)clsGlobal.enApplicationTypes.enReplacementForDamaged).ApplicationFees.ToString();
            lbCreatedByValue.Text = clsGlobal.CurrentUser.UserName;
        }

        private void rdDamagedLicense_Click(object sender, EventArgs e)
        {
            lbApplicationFeesValue.Text = clsApplicationType.Find((int)clsGlobal.enApplicationTypes.enReplacementForDamaged).ApplicationFees.ToString();
        }

        private void rdLostLicense_Click(object sender, EventArgs e)
        {
            lbApplicationFeesValue.Text = clsApplicationType.Find((int)clsGlobal.enApplicationTypes.enReplacementForLost).ApplicationFees.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            clsApplication Application = new clsApplication();

            NewLocalLicense = new clsLocalLicense();

            if (rdDamagedLicense.Checked)
                Application.ApplicationTypeID = (int)clsGlobal.enApplicationTypes.enReplacementForDamaged;
            else
                Application.ApplicationTypeID = (int)clsGlobal.enApplicationTypes.enReplacementForLost;

            Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            Application.Date = DateTime.Now;
            Application.PersonID = LocalLicense.Driver.PersonID;

            if (Application.Save())
            {
                if (rdDamagedLicense.Checked)
                    NewLocalLicense.IssueReplacementForDamaged();
                else
                    NewLocalLicense.IssueReplacementForLost();

                NewLocalLicense.IssueDate = DateTime.Now;
                NewLocalLicense.ExpirationDate = DateTime.Now.AddYears(LocalLicense.LicenseClass.ValidtyLength);
                NewLocalLicense.Remarks = LocalLicense.Remarks;
                NewLocalLicense.LicenseClassID = LocalLicense.LicenseClassID;
                NewLocalLicense.ApplicationNumber = Application.ApplicationNumber;
                NewLocalLicense.DriverID = LocalLicense.DriverID;
                NewLocalLicense.IsActive = true;

                if (NewLocalLicense.Save())
                {
                    lbLRApplicationIDValue.Text = Application.ApplicationNumber.ToString();
                    lbReplacedLicenseIDValue.Text = NewLocalLicense.LicenseNumber.ToString();
                    llbShowNewLicenseInfo.Enabled = true;
                    btnIssueReplacement.Enabled = false;
                    ctrlLocalLicenseWithFilter1.DisableFilter();
                    gbReplacementFor.Enabled = false;
                    LocalLicense.IsActive = false;
                    LocalLicense.Save();
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
