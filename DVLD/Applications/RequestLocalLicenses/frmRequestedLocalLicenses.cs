using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmRequestedLocalLicenses : Form
    {
        enum enTestType { enVisionTest = 1, enWrittenTest = 2, enStreetTest = 3 }

        private bool isTableEmpty = true;

        public frmRequestedLocalLicenses()
        {
            InitializeComponent();
        }

        private void _RefreshTable()
        {
            dgvRequestedLocalLicenses.GridView.DataSource = clsRequestLocalLicense.GetAllRequests();

            foreach (DataGridViewColumn Col in dgvRequestedLocalLicenses.GridView.Columns)
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;

            dplFilterItems.SelectedIndex = 0;
            dplStatus.SelectedIndex = 0;
            mtxtInputFilter.Clear();
            mtxtInputFilter.Visible = false;
            dplStatus.Visible = false;

            if (dgvRequestedLocalLicenses.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvRequestedLocalLicenses.GridView.Rows)
                    row.ContextMenuStrip = guna2ContextMenuStrip1;
            }
        }

        private void _RefreshNumOfRecords()
        {
            lbRecordsValue.Text = dgvRequestedLocalLicenses.GridView.Rows.Count.ToString();
        }

        private void _FillDropDownList()
        {
            foreach (DataGridViewColumn Col in dgvRequestedLocalLicenses.GridView.Columns)
                dplFilterItems.Items.Add(Col.HeaderText);
        }

        private void HandleTableWidth()
        {
            dgvRequestedLocalLicenses.GridView.Columns["Request ID"].Width = 120;
            dgvRequestedLocalLicenses.GridView.Columns["Driving Class"].Width = 300;
            dgvRequestedLocalLicenses.GridView.Columns["National No"].Width = 150;
            dgvRequestedLocalLicenses.GridView.Columns["Full Name"].Width = 350;
            dgvRequestedLocalLicenses.GridView.Columns["Date"].Width = 200;
            dgvRequestedLocalLicenses.GridView.Columns["Passed Tests"].Width = 150;
            dgvRequestedLocalLicenses.GridView.Columns["Status"].Width = 200;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRequestedLocalLicenses_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            _RefreshNumOfRecords();
            _FillDropDownList();

            if (dgvRequestedLocalLicenses.GridView.Rows.Count > 0)
            {
                dgvRequestedLocalLicenses.GridView.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                isTableEmpty = false;

                HandleTableWidth();
            }

            guna2ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            guna2ContextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void FindApplicationByStatus(string Status)
        {
            foreach (DataGridViewRow row in dgvRequestedLocalLicenses.GridView.Rows)
            {
                string value = row.Cells["Status"].Value.ToString().ToLower();

                if (value == Status.ToLower())
                    row.Visible = true;
                else
                {
                    if (dgvRequestedLocalLicenses.GridView.CurrentRow == row)
                        dgvRequestedLocalLicenses.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvRequestedLocalLicenses.GridView.Rows[0].Selected = true;
            }
        }

        private void VisibleAllTableRows()
        {
            foreach (DataGridViewRow row in dgvRequestedLocalLicenses.GridView.Rows)
                row.Visible = true;
        }

        private void dplFilterItems_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            VisibleAllTableRows();

            if (dplFilterItems.SelectedIndex != 0 && dplFilterItems.SelectedItem != "Status")
            {
                mtxtInputFilter.Visible = true;
                dplStatus.Visible = false;

                mtxtInputFilter.Clear();

                switch (dplFilterItems.SelectedItem.ToString())
                {
                    case "Request ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Passed Tests":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Date":
                        mtxtInputFilter.Mask = "00/00/0000";
                        break;
                    default:
                        mtxtInputFilter.Mask = "";
                        break;
                }
            }
            else if (dplFilterItems.SelectedItem == "Status")
            {
                dplStatus.SelectedIndex = 0;
                mtxtInputFilter.Visible = false;
                dplStatus.Visible = true;
            }
            else
            {
                dplStatus.Visible = false;
                mtxtInputFilter.Visible = false;
            }
        }

        private void dplStatus_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            if (dplStatus.SelectedItem == "All")
                VisibleAllTableRows();
            else
                FindApplicationByStatus(dplStatus.SelectedItem);
        }

        private void mtxtInputFilter_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRequestedLocalLicenses.GridView.Rows)
            {
                string value = row.Cells[dplFilterItems.SelectedItem].Value.ToString().ToLower();

                if (dplFilterItems.SelectedItem == "Date")
                    value = ((DateTime)row.Cells[dplFilterItems.SelectedItem].Value).ToString("ddMMyyyy");

                if (value.Contains(mtxtInputFilter.Text.ToLower()))
                    row.Visible = true;
                else
                {
                    if (dgvRequestedLocalLicenses.GridView.CurrentRow == row)
                        dgvRequestedLocalLicenses.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvRequestedLocalLicenses.GridView.Rows[0].Selected = true;
            }
        }

        private void btnAddNewAppliction_Click(object sender, EventArgs e)
        {
            frmAddAndEditRequestedLocalLicense AddAndEditRequestForm = new frmAddAndEditRequestedLocalLicense();
            AddAndEditRequestForm.ShowDialog();

            _RefreshTable();
            _RefreshNumOfRecords();

            if (dgvRequestedLocalLicenses.GridView.Rows.Count == 1 && isTableEmpty)
            {
                isTableEmpty = false;
                HandleTableWidth();
                _FillDropDownList();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAndEditRequestedLocalLicense AddAndEditRequestsForm = new frmAddAndEditRequestedLocalLicense((int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells["Request ID"].Value);
            AddAndEditRequestsForm.ShowDialog();

            _RefreshTable();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            clsRequestLocalLicense Request = clsRequestLocalLicense.FindRequestByID(RequestID);

            if (Request.IsCanceledStatus())
            {
                cancelApplicationToolStripMenuItem.Enabled = false;
                scheduleTestsToolStripMenuItem.Enabled = false;
                issueDrivingLicensefirstTimeToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
                cancelApplicationToolStripMenuItem.Enabled = true;
                scheduleTestsToolStripMenuItem.Enabled = true;
                issueDrivingLicensefirstTimeToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = true;
            }

            issueDrivingLicensefirstTimeToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;

            if (Request.PassedTests == 0)
            {
                visionTestToolStripMenuItem.Enabled = true;
                writtenTestToolStripMenuItem.Enabled = false;
                drivingTestToolStripMenuItem.Enabled = false;
            }
            else if (Request.PassedTests == 1)
            {
                visionTestToolStripMenuItem.Enabled = false;
                writtenTestToolStripMenuItem.Enabled = true;
                drivingTestToolStripMenuItem.Enabled = false;
            }
            else if (Request.PassedTests == 2)
            {
                visionTestToolStripMenuItem.Enabled = false;
                writtenTestToolStripMenuItem.Enabled = false;
                drivingTestToolStripMenuItem.Enabled = true;
            }
            else
            {
                scheduleTestsToolStripMenuItem.Enabled = false;
                issueDrivingLicensefirstTimeToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = false;
            }

            if (Request.IsCompletedStatus())
            {
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                scheduleTestsToolStripMenuItem.Enabled = false;
                issueDrivingLicensefirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            var message = MessageBox.Show($"Are You Sure You Want Delete This Request With ID = {RequestID}", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (message == DialogResult.Yes)
            {
                if (clsRequestLocalLicense.DeleteRequest(RequestID))
                    MessageBox.Show("Request Deleted Successfully", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error: Can't Delete This Request", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _RefreshTable();
                _RefreshNumOfRecords();

                if (dgvRequestedLocalLicenses.GridView.Rows.Count == 0)
                {
                    isTableEmpty = true;
                    dplFilterItems.Items.Clear();
                    dplFilterItems.Items.Add("None");
                }
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            clsRequestLocalLicense Request = clsRequestLocalLicense.FindRequestByID(RequestID);

            if (Request != null)
            {
                if (!Request.IsCanceledStatus())
                {
                    var message = MessageBox.Show($"Are You Sure You Want Cancel This Request With ID = {RequestID}", "Cancel Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (message == DialogResult.Yes)
                    {
                        if (Request.CancelStatus())
                            MessageBox.Show("Request Canceled Successfully", "Canceled Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Error: Can't Cancel This Request", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("This Request Is Already Canceled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _RefreshTable();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            frmRequestDetails RequestDetailsForm = new frmRequestDetails(RequestID);
            RequestDetailsForm.ShowDialog();
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            frmTest VisionTestForm = new frmTest(RequestID, (int)enTestType.enVisionTest);
            VisionTestForm.ShowDialog();

            _RefreshTable();
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            frmTest WrittenTestForm = new frmTest(RequestID, (int)enTestType.enWrittenTest);
            WrittenTestForm.ShowDialog();

            _RefreshTable();
        }

        private void drivingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            frmTest DrivingTestForm = new frmTest(RequestID, (int)enTestType.enStreetTest);
            DrivingTestForm.ShowDialog();

            _RefreshTable();
        }

        private void issueDrivingLicensefirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            frmIssueLocalLicense IssueLocalLicenseForm = new frmIssueLocalLicense(RequestID);
            IssueLocalLicenseForm.ShowDialog();

            _RefreshTable();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            clsRequestLocalLicense Request = clsRequestLocalLicense.FindRequestByID(RequestID);

            if (Request != null)
            {
                int LicenseID = clsLocalLicense.GetLicenseNumberByAppNumber(Request.ApplicationNumber);

                frmLocalLicenseDetails LocalLicenseDetailsForm = new frmLocalLicenseDetails(LicenseID);
                LocalLicenseDetailsForm.ShowDialog();
            }
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int RequestID = (int)dgvRequestedLocalLicenses.GridView.CurrentRow.Cells[0].Value;

            clsRequestLocalLicense Request = clsRequestLocalLicense.FindRequestByID(RequestID);

            if (Request != null)
            {
                frmPersonLicensesHistory LicensesHistoryOfPersonForm = new frmPersonLicensesHistory(Request.PersonInfo);
                LicensesHistoryOfPersonForm.ShowDialog();
            }
        }

    }
}
