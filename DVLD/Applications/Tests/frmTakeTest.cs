using DVLD.Properties;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmTakeTest : Form
    {
        private int _RequestID;

        private int _TestAppointmentID;

        private int _TestTypeID = -1;

        private clsRequestLocalLicense Request = new clsRequestLocalLicense();

        private clsTestAppointment TestAppointment = new clsTestAppointment();

        private clsTest Test = new clsTest();

        public frmTakeTest(int RequestID, int TestAppointmentID, int TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
            _RequestID = RequestID;
            _TestAppointmentID = TestAppointmentID;
        }

        private void HandlePictureBoxAndTitle()
        {
            if (_TestTypeID == 1)
            {
                pbTakeTest.Image = Resources.Vision_512;
                gbTakeTest.Text = "Vision Test";
            }
            else if (_TestTypeID == 2)
            {
                pbTakeTest.Image = Resources.Written_Test_512;
                gbTakeTest.Text = "Written Test";
            }
            else
            {
                pbTakeTest.Image = Resources.driving_test_512;
                gbTakeTest.Text = "Driving Test";
            }
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            HandlePictureBoxAndTitle();

            Request = clsRequestLocalLicense.FindRequestByID(_RequestID);
            TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            if (Request != null)
            {
                lbRequestIDValue.Text = Request.RequestID.ToString();
                lbDrivingClassValue.Text = Request.LicenseClassInfo.Name;
                lbNameValue.Text = Request.PersonInfo.GetFullName();
            }

            lbTrialValue.Text = clsTestAppointment.GetNumOfTestTrialByRequest(_TestAppointmentID, _RequestID, _TestTypeID).ToString();

            if (TestAppointment != null)
            {
                lbDateValue.Text = TestAppointment.AppointmentDate.ToString("dd/MM/yyyy");
                lbFeesValue.Text = TestAppointment.TestType.Fees.ToString();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are You Sure You Want Take Test For This Request??", "Ask Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (message == DialogResult.Yes)
            {
                TestAppointment.IsLocked = true;

                Test.Result = rdPass.Checked;
                Test.Notes = txtNotes.Text;
                Test.TestAppointmentID = _TestAppointmentID;

                if (rdPass.Checked)
                    Request.PassedTests++;

                if (TestAppointment.Save() && Test.AddNewTest() && Request.Save())
                {
                    lbTestIDValue.Text = Test.TestID.ToString();
                    MessageBox.Show("Taking Test For This Request Is Completed Successfully", "Taking Test Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error Can't Take This Test", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
