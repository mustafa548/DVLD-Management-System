using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddInternationalLicenses : Form
    {
        private clsLocalLicense _LocalLicense = null;

        clsApplication Application = new clsApplication();
        clsInternationalLicense InternationalLicense = new clsInternationalLicense();

        public frmAddInternationalLicenses()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlLocalLicenseWithFilter1_OnLocalLicenseSelected(int LicenseID)
        {
            _LocalLicense = clsLocalLicense.Find(LicenseID);

            if (!_LocalLicense.IsActive)
            {
                MessageBox.Show("This License Isn't Active, Choose Another One", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
                _LocalLicense = null;
                return;
            }

            if (_LocalLicense.IsDetained)
            {
                MessageBox.Show("This License Is Detained You Must Realise It First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
                _LocalLicense = null;
                return;
            }

            if (_LocalLicense.LicenseClass.LicenseClassID != 3)
            {
                MessageBox.Show("You Must Choose a Class 3 Local License To Issue International License", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
                _LocalLicense = null;
                return;
            }

            if (clsInternationalLicense.IsInternationalLicenseExistsByDriverID(_LocalLicense.DriverID))
            {
                MessageBox.Show("This Driver Already Has An Active International License", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlLocalLicenseWithFilter1.DeleteDataFromCard();
                _LocalLicense = null;
                return;
            }

            lbLocalLicenseIDValue.Text = LicenseID.ToString();
            llbShowLicenseHistory.Enabled = true;
        }

        private void frmAddInternationalLicenses_Load(object sender, EventArgs e)
        {
            lbApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbIssueDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbExpirationDateValue.Text = clsInternationalLicense.GetExpirationDate(DateTime.Now).ToString("dd/MM/yyyy");
            lbFeesValue.Text = clsApplicationType.Find((int)clsGlobal.enApplicationTypes.enIssueInternationalLicense).ApplicationFees.ToString();
            lbCreatedByValue.Text = clsGlobal.CurrentUser.UserName;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_LocalLicense == null)
            {
                MessageBox.Show("You Must Select Class 3 Local License First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Date = DateTime.Now;
            Application.ApplicationTypeID = (int)clsGlobal.enApplicationTypes.enIssueInternationalLicense;
            Application.PersonID = _LocalLicense.Driver.PersonID;
            Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (Application.Save())
            {
                InternationalLicense.IssueDate = DateTime.Now;
                InternationalLicense.ApplicationNumber = Application.ApplicationNumber;
                InternationalLicense.LicenseNumber = _LocalLicense.LicenseNumber;

                if (InternationalLicense.AddNewInternationalLicense())
                {
                    MessageBox.Show("Issued Completed Successfully", "Issued Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbIApplicationIDValue.Text = Application.ApplicationNumber.ToString();
                    lbILicenseIDValue.Text = InternationalLicense.InternationalLicenseID.ToString();
                    llbShowLicenseInfo.Enabled = true;
                    btnIssue.Enabled = false;
                }
                else
                    MessageBox.Show("Can't Save This International License", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llbShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonLicensesHistory PersonLicenseHistoryForm = new frmPersonLicensesHistory(clsDriver.Find(_LocalLicense.DriverID).PersonInfo);
            PersonLicenseHistoryForm.ShowDialog();
        }

        private void llbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo InternationalLicenseInfoForm = new frmInternationalLicenseInfo(InternationalLicense.InternationalLicenseID);
            InternationalLicenseInfoForm.ShowDialog();
        }
    }
}
