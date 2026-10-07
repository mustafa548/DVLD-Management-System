using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmPersonLicensesHistory : Form
    {
        private clsPerson _Person;


        public frmPersonLicensesHistory(clsPerson Person)
        {
            InitializeComponent();

            _Person = Person;
        }

        public frmPersonLicensesHistory(int PersonID)
        {
            InitializeComponent();

            _Person = clsPerson.Find(PersonID);
        }

        private void siticoneButtonAdvanced1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _RefreshLocalTable()
        {
            dgvLocalHistory.DataSource = clsLocalLicense.GetAllLocalLicensesByPerson(_Person.PersonID);

            if (dgvLocalHistory.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvLocalHistory.GridView.Rows)
                    row.ContextMenuStrip = localContextMenuStrip;
            }
        }

        private void _RefreshLocalNumberOfRecords()
        {
            lbLocalRecordsValue.Text = dgvLocalHistory.GridView.Rows.Count.ToString();
        }

        private void HandleLocalTableWidth()
        {
            dgvLocalHistory.GridView.Columns["License ID"].Width = 150; 
            dgvLocalHistory.GridView.Columns["App ID"].Width = 120;
            dgvLocalHistory.GridView.Columns["Class Name"].Width = 300;
            dgvLocalHistory.GridView.Columns["Issue Date"].Width = 160;
            dgvLocalHistory.GridView.Columns["Expiration Date"].Width = 160;
            dgvLocalHistory.GridView.Columns["Is Active"].Width = 120;
        }

        private void _RefreshInternationalTable()
        {
            dgvInternationalHistory.DataSource = clsInternationalLicense.GetAllInternationalLicensesByPerson(_Person.PersonID);

            if (dgvInternationalHistory.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvInternationalHistory.GridView.Rows)
                    row.ContextMenuStrip = internationalContextMenuStrip;
            }
        }

        private void _RefreshInternationalNumberOfRecords()
        {
            lbInternationalRecordsValue.Text = dgvInternationalHistory.GridView.Rows.Count.ToString();
        }

        private void HandleInternationalTableWidth()
        {
            dgvInternationalHistory.GridView.Columns["Int.License ID"].Width = 180;
            dgvInternationalHistory.GridView.Columns["Application ID"].Width = 160;
            dgvInternationalHistory.GridView.Columns["L.License ID"].Width = 180;
            dgvInternationalHistory.GridView.Columns["Issue Date"].Width = 160;
            dgvInternationalHistory.GridView.Columns["Expiration Date"].Width = 160;
            dgvInternationalHistory.GridView.Columns["Is Active"].Width = 120;
        }

        private void frmPersonLicensesHistory_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.SelectPerson(_Person);

            _RefreshLocalTable();
            _RefreshLocalNumberOfRecords();

            if (dgvLocalHistory.GridView.Rows.Count > 0)
            {
                dgvLocalHistory.GridView.Columns["Issue Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvLocalHistory.GridView.Columns["Expiration Date"].DefaultCellStyle.Format = "dd/MM/yyyy";

                HandleLocalTableWidth();
            }

            _RefreshInternationalTable();
            _RefreshInternationalNumberOfRecords();

            if (dgvInternationalHistory.GridView.Rows.Count > 0)
            {
                dgvInternationalHistory.GridView.Columns["Issue Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvInternationalHistory.GridView.Columns["Expiration Date"].DefaultCellStyle.Format = "dd/MM/yyyy";

                HandleInternationalTableWidth();
            }

            localContextMenuStrip.RenderMode = ToolStripRenderMode.Professional;
            localContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());

            internationalContextMenuStrip.RenderMode = ToolStripRenderMode.Professional;
            internationalContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());

        }

        private void showLocalLicenseInfoMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocalHistory.GridView.CurrentRow.Cells[0].Value;

            frmLocalLicenseDetails LocalLicenseDetails = new frmLocalLicenseDetails(LicenseID);
            LocalLicenseDetails.ShowDialog();
        }

        private void showInternationalLicenseInfoMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = (int)dgvInternationalHistory.GridView.CurrentRow.Cells[0].Value;

            frmInternationalLicenseInfo InternationalLicenseInfoForm = new frmInternationalLicenseInfo(InternationalLicenseID);
            InternationalLicenseInfoForm.ShowDialog();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 1)
            {
                _RefreshInternationalTable();
            }
        }

    }
}
