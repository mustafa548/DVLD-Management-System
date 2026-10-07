using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddAndEditRequestedLocalLicense : Form
    {
        private int _PersonID = -1;

        private int _RequestID;

        private DateTime ApplicationDate;

        private clsRequestLocalLicense Request;

        enum enMode {enAddNewMode, enEditMode}

        enMode _Mode;

        private void _FillDropDownList()
        {
            DataTable dt = clsLicenseClass.GetAllLicenseClasses();

            foreach(DataRow row in dt.Rows)
            {
                dplLicenseClasses.Items.Add(row["Name"].ToString());
            }
        }

        public frmAddAndEditRequestedLocalLicense()
        {
            InitializeComponent();

            _Mode = enMode.enAddNewMode;
        }

        public frmAddAndEditRequestedLocalLicense(int RequestID)
        {
            InitializeComponent();

            _Mode = enMode.enEditMode;
            _RequestID = RequestID;
        }

        private void frmAddAndEditRequestedLocalLicense_Load(object sender, EventArgs e)
        {
            _FillDropDownList();

            if (_Mode == enMode.enAddNewMode)
            {
                lbTitle.Text = "New Local Driving License Application";
                lbApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
                ApplicationDate = DateTime.Now;
                lbCreatedByValue.Text = clsGlobal.CurrentUser.UserName;
                lbApplicationFeesValue.Text = clsApplicationType.Find((int)clsGlobal.enApplicationTypes.enNewDrivingLicense).ApplicationFees.ToString();
                Request = new clsRequestLocalLicense();
                return;
            }

            lbTitle.Text = "Edit Local Driving License Application";

            Request = clsRequestLocalLicense.FindRequestByID(_RequestID);

            if (Request != null)
            {
                _PersonID = Request.PersonID;

                ctrlPersonInfoWithFilter1.AfterPersonSelected(Request.PersonInfo);
                lbRequestIDValue.Text = Request.RequestID.ToString();
                lbApplicationDateValue.Text = Request.Date.ToString("dd/MM/yyyy");
                ApplicationDate = Request.Date;
                dplLicenseClasses.SelectedItem = Request.LicenseClassInfo.Name;
                lbApplicationFeesValue.Text = Request.ApplicationType.ApplicationFees.ToString();
                lbCreatedByValue.Text = Request.CreatedByUser.UserName;
            }
            else
            {
                this.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_PersonID != -1)
                tabControl.SelectedTab = tabApplicationInfo;
            else
                MessageBox.Show("Please Choose Person First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctrlPersonInfoWithFilter1_OnPersonSelected(int PersonID)
        {
            _PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_PersonID == -1)
            {
                MessageBox.Show("You Must Select Person First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dplLicenseClasses.SelectedItem == null)
            {
                MessageBox.Show("You Must Select a License Class First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLicenseClass LicenseClass = clsLicenseClass.Find(dplLicenseClasses.SelectedItem);

            if (_Mode == enMode.enAddNewMode && clsRequestLocalLicense.DoesPersonHaveActiveOrCompletedRequest(_PersonID, LicenseClass.LicenseClassID))
            {
                MessageBox.Show("This Person Has This Class Request", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((Request.LicenseClassInfo != null && dplLicenseClasses.SelectedItem != Request.LicenseClassInfo.Name) && clsRequestLocalLicense.DoesPersonHaveActiveOrCompletedRequest(_PersonID, LicenseClass.LicenseClassID))
            {
                MessageBox.Show("This Person Has This Class Request", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Request.PersonID = _PersonID;
            Request.Date = ApplicationDate;
            Request.ApplicationTypeID = (int)clsGlobal.enApplicationTypes.enNewDrivingLicense;
            Request.LicenseClassID = LicenseClass.LicenseClassID;
            Request.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (Request.Save())
            {
                _Mode = enMode.enEditMode;
                MessageBox.Show("Saved Completed Successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Can't Save This Request", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
