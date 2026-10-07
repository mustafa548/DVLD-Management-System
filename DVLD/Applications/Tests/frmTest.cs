using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmTest : Form
    {
        private int _RequestID;

        private int _TestTypeID = -1;

        public frmTest(int RequestID, int TestTypeID)
        {
            InitializeComponent();

            _RequestID = RequestID;
            _TestTypeID = TestTypeID;
        }

        private void _RefreshTable()
        {
            dgvTestAppointments.GridView.DataSource = clsTestAppointment.GetAllTestAppointmentsByRequestAndTestType(_RequestID, _TestTypeID);

            if (dgvTestAppointments.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTestAppointments.GridView.Rows)
                    row.ContextMenuStrip = guna2ContextMenuStrip1;
            }
        }

        private void _RefreshNumOfRecords()
        {
            lbRecordsValue.Text = dgvTestAppointments.GridView.Rows.Count.ToString();
        }

        private void HandleTableWidth()
        {
            dgvTestAppointments.GridView.Columns["Appointment ID"].Width = 160;
            dgvTestAppointments.GridView.Columns["Appointment Date"].Width = 200;
            dgvTestAppointments.GridView.Columns["Paid Fees"].Width = 160;
            dgvTestAppointments.GridView.Columns["Is Locked"].Width = 160;
        }

        private void HandlePictureBoxAndTitle()
        {
            if (_TestTypeID == 1)
            {
                pbTest.Image = Resources.Vision_512;
                lbTitle.Text = "Vision Test Appointment";
                this.Text = "Vision Test";
            }
            else if (_TestTypeID == 2)
            {
                pbTest.Image = Resources.Written_Test_512;
                lbTitle.Text = "Written Test Appointment";
                this.Text = "Written Test";
            }
            else
            {
                pbTest.Image = Resources.driving_test_512;
                lbTitle.Text = "Driving Test Appointment";
                this.Text = "Driving Test";
            }
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            HandlePictureBoxAndTitle();

            ctrlRequestInfo1.SelectRequest(_RequestID);

            _RefreshTable();
            _RefreshNumOfRecords();

            if (dgvTestAppointments.GridView.Rows.Count > 0)
            {
                dgvTestAppointments.GridView.Columns["Appointment Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                HandleTableWidth();
            }

            guna2ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            guna2ContextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvTestAppointments.GridView.CurrentRow.Cells[0].Value;

            frmScheduleTest ScheduleVisionTestForm = new frmScheduleTest(_RequestID, TestAppointmentID, _TestTypeID);
            ScheduleVisionTestForm.ShowDialog();
        }

        private void HandleTableAfterAddNew()
        {
            _RefreshTable();
            _RefreshNumOfRecords();

            if (dgvTestAppointments.GridView.Rows.Count == 1)
                HandleTableWidth();
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment.DoesPassTestTypesByRequest(_RequestID, _TestTypeID))
            {
                MessageBox.Show("You Passed This Test Successfully", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsTestAppointment.IsTestAppointmentUnlocked(_RequestID))
            {
                MessageBox.Show("You Have Already an Active Appointment, You Can't Add Another Ones", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dgvTestAppointments.GridView.Rows.Count != 0)
            {
                frmScheduleTest ScheduleVisionTestFormByRetakeTest = new frmScheduleTest(_RequestID, _TestTypeID, true);
                ScheduleVisionTestFormByRetakeTest.ShowDialog();

                HandleTableAfterAddNew();

                return;
            }

            frmScheduleTest ScheduleVisionTestForm = new frmScheduleTest(_RequestID, _TestTypeID);
            ScheduleVisionTestForm.ShowDialog();

            HandleTableAfterAddNew();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvTestAppointments.GridView.CurrentRow.Cells[0].Value;

            frmTakeTest TakeTestForm = new frmTakeTest(_RequestID, TestAppointmentID, _TestTypeID);
            TakeTestForm.ShowDialog();

            _RefreshTable();
            ctrlRequestInfo1.SelectRequest(_RequestID);
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool isLocked = (bool)dgvTestAppointments.GridView.CurrentRow.Cells["Is Locked"].Value;

            if (isLocked)
            {
                editToolStripMenuItem.Enabled = false;
                takeTestToolStripMenuItem.Enabled = false;
            }
            else
            {
                editToolStripMenuItem.Enabled = true;
                takeTestToolStripMenuItem.Enabled = true;
            }

        }

    }
}
