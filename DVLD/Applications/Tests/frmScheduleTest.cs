using DVLD.Properties;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmScheduleTest : Form
    {
        enum enMode { enAddNewMode, enEditMode };

        private enMode _Mode;

        private int _RequestID;

        private bool _IsRetakeTest = false;

        private int _TestTypeID = -1;

        private clsRequestLocalLicense Request = new clsRequestLocalLicense();

        private int _TestAppointmentID = -1;

        private clsTestAppointment TestAppointment = new clsTestAppointment();

        public frmScheduleTest(int RequestID, int TestTypeID, bool IsRetakeTest = false)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
            _IsRetakeTest = IsRetakeTest;
            _RequestID = RequestID;
            _Mode = enMode.enAddNewMode;
        }

        public frmScheduleTest(int RequestID, int TestAppointmentID, int TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
            _RequestID = RequestID;
            _TestAppointmentID = TestAppointmentID;
            _Mode = enMode.enEditMode;
        }

        private void HandlePictureBoxAndTitle()
        {
            if (_TestTypeID == 1)
            {
                pbScheduleTest.Image = Resources.Vision_512;
                lbTitle.Text = "Schedule Vision Test";
                this.Text = "Schedule Vision Test";
                gbTest.Text = "Vision Test";
            }
            else if (_TestTypeID == 2)
            {
                pbScheduleTest.Image = Resources.Written_Test_512;
                lbTitle.Text = "Schedule Written Test";
                this.Text = "Schedule Written Test";
                gbTest.Text = "Written Test";
            }
            else
            {
                pbScheduleTest.Image = Resources.driving_test_512;
                lbTitle.Text = "Schedule Driving Test";
                this.Text = "Schedule Driving Test";
                gbTest.Text = "Driving Test";
            }
        }

        private void HandleRetakeTestElements()
        {
            gbRetakeTestInfo.Enabled = true;
            lbRAppFeesValue.Text = clsApplicationType.Find((int)clsGlobal.enApplicationTypes.enRetakeTest).ApplicationFees.ToString();
            lbTotalFeesValue.Text = (decimal.Parse(lbRAppFeesValue.Text) + decimal.Parse(lbFeesValue.Text)).ToString();
            lbTitle.Text = "Schedule Retake Test";
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            HandlePictureBoxAndTitle();

            Request = clsRequestLocalLicense.FindRequestByID(_RequestID);

            if (Request != null)
            {
                lbRequestIDValue.Text = Request.RequestID.ToString();
                lbDrivingClassValue.Text = Request.LicenseClassInfo.Name;
                lbNameValue.Text = Request.PersonInfo.GetFullName();
            }

            dtpDate.MinDate = DateTime.Now;
            dtpDate.CalendarMinYear = dtpDate.MinDate.Year;
            lbTrialValue.Text = clsTestAppointment.GetNumOfTestTrialByRequest(_TestAppointmentID, _RequestID, _TestTypeID).ToString();

            if (_Mode == enMode.enAddNewMode)
            {
                lbFeesValue.Text = clsTestType.Find(_TestTypeID).Fees.ToString();

                if (_IsRetakeTest)
                    HandleRetakeTestElements();

                return;
            }

            TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            lbFeesValue.Text = TestAppointment.TestType.Fees.ToString();
            dtpDate.SelectedDate = TestAppointment.AppointmentDate;

            if (TestAppointment.RetakeTestAppNumber != -1)
                HandleRetakeTestElements();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpDate.SelectedDate == null)
            {
                MessageBox.Show("You Must Select An Appointment Date First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TestAppointment.PaidFees = decimal.Parse(lbFeesValue.Text);
            TestAppointment.RequestID = _RequestID;
            TestAppointment.AppointmentDate = (DateTime)dtpDate.SelectedDate;
            TestAppointment.TestTypeID = _TestTypeID;

            if (_IsRetakeTest)
            {
                clsApplication Application = new clsApplication();
                Application.Date = DateTime.Now;
                Application.PersonID = Request.PersonID;
                Application.ApplicationTypeID = (int)clsGlobal.enApplicationTypes.enRetakeTest;
                Application.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                Application.Save();

                TestAppointment.RetakeTestAppNumber = Application.ApplicationNumber;

                lbRTestAppIDValue.Text = Application.ApplicationNumber.ToString();
            }

            if (TestAppointment.Save())
            {
                MessageBox.Show("Saved Completed Successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Can't Save This Appointment", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
