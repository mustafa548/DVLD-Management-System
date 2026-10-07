using DVLD_Business;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmDetainedLicenses : Form
    {
        public frmDetainedLicenses()
        {
            InitializeComponent();
        }

        private bool isTableEmpty = true;

        private void _RefreshTable()
        {
            dgvDetainedLicenses.GridView.DataSource = clsDetainedLicense.GetAllDetainedLicenses();

            foreach (DataGridViewColumn Col in dgvDetainedLicenses.GridView.Columns)
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;

            dplFilterItems.SelectedIndex = 0;
            dplIsRealised.SelectedIndex = 0;
            mtxtInputFilter.Clear();
            mtxtInputFilter.Visible = false;
            dplIsRealised.Visible = false;

            if (dgvDetainedLicenses.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDetainedLicenses.GridView.Rows)
                    row.ContextMenuStrip = guna2ContextMenuStrip1;
            }
        }

        private void _RefreshNumOfRecords()
        {
            lbRecordsValue.Text = dgvDetainedLicenses.GridView.Rows.Count.ToString();
        }

        private void _FillDropDownList()
        {
            foreach (DataGridViewColumn Col in dgvDetainedLicenses.GridView.Columns)
                dplFilterItems.Items.Add(Col.HeaderText);
        }

        private void HandleTableWidth()
        {
            dgvDetainedLicenses.GridView.Columns["D.ID"].Width = 120;
            dgvDetainedLicenses.GridView.Columns["L.ID"].Width = 120;
            dgvDetainedLicenses.GridView.Columns["D.Date"].Width = 160;
            dgvDetainedLicenses.GridView.Columns["Is Realised"].Width = 160;
            dgvDetainedLicenses.GridView.Columns["Fine Fees"].Width = 120;
            dgvDetainedLicenses.GridView.Columns["Realise Date"].Width = 200;
            dgvDetainedLicenses.GridView.Columns["N.No"].Width = 120;
            dgvDetainedLicenses.GridView.Columns["Full Name"].Width = 320;
            dgvDetainedLicenses.GridView.Columns["Realise App.ID"].Width = 200;
        }

        private void frmDetainedLicenses_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            _RefreshNumOfRecords();
            _FillDropDownList();

            if (dgvDetainedLicenses.GridView.Rows.Count > 0)
            {
                dgvDetainedLicenses.GridView.Columns["D.Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvDetainedLicenses.GridView.Columns["Realise Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                isTableEmpty = false;

                HandleTableWidth();
            }

            guna2ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            guna2ContextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void VisibleAllTableRows()
        {
            foreach (DataGridViewRow row in dgvDetainedLicenses.GridView.Rows)
                row.Visible = true;
        }

        private void dplFilterItems_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            VisibleAllTableRows();

            if (dplFilterItems.SelectedIndex != 0 && dplFilterItems.SelectedItem != "Is Realised")
            {
                mtxtInputFilter.Visible = true;
                dplIsRealised.Visible = false;

                mtxtInputFilter.Clear();

                switch (dplFilterItems.SelectedItem.ToString())
                {
                    case "D.ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "L.ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Fine Fees":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Realise App.ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "D.Date":
                        mtxtInputFilter.Mask = "00/00/0000";
                        break;
                    case "Realise Date":
                        mtxtInputFilter.Mask = "00/00/0000";
                        break;
                    default:
                        mtxtInputFilter.Mask = "";
                        break;
                }
            }
            else if (dplFilterItems.SelectedItem == "Is Realised")
            {
                dplIsRealised.SelectedIndex = 0;
                mtxtInputFilter.Visible = false;
                dplIsRealised.Visible = true;
            }
            else
            {
                dplIsRealised.Visible = false;
                mtxtInputFilter.Visible = false;
            }
        }

        private void mtxtInputFilter_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDetainedLicenses.GridView.Rows)
            {
                string value = row.Cells[dplFilterItems.SelectedItem].Value.ToString().ToLower();

                if (dplFilterItems.SelectedItem == "D.Date" || dplFilterItems.SelectedItem == "Realise Date")
                    value = ((DateTime)row.Cells[dplFilterItems.SelectedItem.ToString()].Value).ToString("ddMMyyyy");

                if (value.Contains(mtxtInputFilter.Text.ToLower()))
                    row.Visible = true;
                else
                {
                    if (dgvDetainedLicenses.GridView.CurrentRow == row)
                        dgvDetainedLicenses.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvDetainedLicenses.GridView.Rows[0].Selected = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindDetainedLicenseByRealisedStatus(bool realisedStatus)
        {
            foreach (DataGridViewRow row in dgvDetainedLicenses.GridView.Rows)
            {
                if ((bool)row.Cells["Is Realised"].Value == realisedStatus)
                    row.Visible = true;
                else
                {
                    if (dgvDetainedLicenses.GridView.CurrentRow == row)
                        dgvDetainedLicenses.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvDetainedLicenses.GridView.Rows[0].Selected = true;
            }
        }

        private void dplIsRealised_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            switch (dplIsRealised.SelectedItem.ToString())
            {
                case "Yes":
                    FindDetainedLicenseByRealisedStatus(true);
                    break;
                case "No":
                    FindDetainedLicenseByRealisedStatus(false);
                    break;
                default:
                    VisibleAllTableRows();
                    break;
            }
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicenseForm = new frmDetainLicense();
            DetainLicenseForm.ShowDialog();

            _RefreshTable();
            _RefreshNumOfRecords();

            if (dgvDetainedLicenses.GridView.Rows.Count == 1 && isTableEmpty)
            {
                isTableEmpty = false;
                HandleTableWidth();
                _FillDropDownList();
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalLicense LocalLicense = clsLocalLicense.Find((int)dgvDetainedLicenses.GridView.CurrentRow.Cells["L.ID"].Value);

            frmPersonDetails PersonDetailsForm = new frmPersonDetails(LocalLicense.Driver.PersonID);
            PersonDetailsForm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalLicenseDetails LocalLicenseDetailsForm = new frmLocalLicenseDetails((int)dgvDetainedLicenses.GridView.CurrentRow.Cells["L.ID"].Value);
            LocalLicenseDetailsForm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLocalLicense LocalLicense = clsLocalLicense.Find((int)dgvDetainedLicenses.GridView.CurrentRow.Cells["L.ID"].Value);

            frmPersonLicensesHistory PersonLicenseHistoryForm = new frmPersonLicensesHistory(LocalLicense.Driver.PersonInfo);
            PersonLicenseHistoryForm.ShowDialog();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            clsDetainedLicense DetainedLicense = clsDetainedLicense.Find((int)dgvDetainedLicenses.GridView.CurrentRow.Cells[0].Value);

            if (DetainedLicense.IsRealised)
                realiseDetainedLicenseToolStripMenuItem.Enabled = false;
            else
                realiseDetainedLicenseToolStripMenuItem.Enabled = true;
        }

        private void btnRealiseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmRealiseDetainedLicense RealiseDetainedLicenseForm = new frmRealiseDetainedLicense();
            RealiseDetainedLicenseForm.ShowDialog();

            _RefreshTable();
        }

        private void realiseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DetainID = (int)dgvDetainedLicenses.GridView.CurrentRow.Cells[0].Value;

            frmRealiseDetainedLicense RealiseDetainedLicenseForm = new frmRealiseDetainedLicense(DetainID);
            RealiseDetainedLicenseForm.ShowDialog();

            _RefreshTable();
        }
    }
}
