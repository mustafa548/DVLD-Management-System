using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmDetainLicense : Form
    {
        private clsLocalLicense LocalLicense;

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lbDetainDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbCreatedByValue.Text = clsGlobal.CurrentUser.UserName;
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

            if (LocalLicense.IsDetained)
            {
                MessageBox.Show("This License Is Already Detained, Choose Another One", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
                return;
            }

            llbShowLicenseHistory.Enabled = true;
            btnDetain.Enabled = true;
            lbLicenseIDValue.Text = LicenseNumber.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (txtFineFees.Text == "")
            {
                MessageBox.Show("You Must Fill The Fine Fees Input First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var message = MessageBox.Show("Are You Sure You Want Detain This Local License??", "Detain License", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (message != DialogResult.Yes)
                return;

            clsDetainedLicense DetainedLicense = new clsDetainedLicense();

            DetainedLicense.DetainedDate = DateTime.Now;
            DetainedLicense.Fine = decimal.Parse(txtFineFees.Text);
            DetainedLicense.LicenseNumber = LocalLicense.LicenseNumber;

            if (DetainedLicense.Save())
            {
                LocalLicense.IsDetained = true;
                LocalLicense.Save();
                btnDetain.Enabled = false;
                llbShowLicenseInfo.Enabled = true;
                lbDetainID.Text = DetainedLicense.DetainedLicenseID.ToString();
                ctrlLocalLicenseWithFilter1.DisableFilter();
                MessageBox.Show("Detained Completed Successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Can't Detain This License", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void llbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory PersonLicenseHistoryForm = new frmPersonLicensesHistory(LocalLicense.Driver.PersonInfo);
            PersonLicenseHistoryForm.ShowDialog();
        }

        private void llbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLocalLicenseDetails LocalLicenseDetailsForm = new frmLocalLicenseDetails(LocalLicense.LicenseNumber);
            LocalLicenseDetailsForm.ShowDialog();
        }

    }
}
