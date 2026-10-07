using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmIssueLocalLicense : Form
    {
        private int _RequestID;

        private clsRequestLocalLicense Request;

        public frmIssueLocalLicense(int RequestID)
        {
            InitializeComponent();

            _RequestID = RequestID;
        }

        private void frmIssueLocalLicense_Load(object sender, EventArgs e)
        {
            ctrlRequestInfo1.SelectRequest(_RequestID);
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are You Sure You Want Issue Local License For This Person", "Surely Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (message == DialogResult.Yes)
            {
                Request = clsRequestLocalLicense.FindRequestByID(_RequestID);

                clsLocalLicense LocalLicense = new clsLocalLicense();
                clsDriver Driver = clsDriver.FindByPerson(Request.PersonID);

                if (Driver == null)
                {
                    Driver = new clsDriver();

                    Driver.PersonID = Request.PersonID;
                    Driver.CreatedDate = DateTime.Now;
                    Driver.Save();
                }

                LocalLicense.IssueFirstTime();
                LocalLicense.IssueDate = DateTime.Now;
                LocalLicense.Remarks = txtNotes.Text;
                LocalLicense.LicenseClassID = Request.LicenseClassID;
                LocalLicense.ApplicationNumber = Request.ApplicationNumber;
                LocalLicense.IsActive = true;
                LocalLicense.DriverID = Driver.DriverID;

                if (LocalLicense.Save())
                {
                    Request.CompleteStatus();
                    MessageBox.Show("Local Driving License Is Saved Successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Can't Save This Local Driving License", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
