using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmInternationalLicenses : Form
    {
        public frmInternationalLicenses()
        {
            InitializeComponent();
        }

        private bool isTableEmpty = true;

        private void _RefreshTable()
        {
            dgvInternationalLicenses.GridView.DataSource = clsInternationalLicense.GetAllInternationalLicenses();

            foreach (DataGridViewColumn Col in dgvInternationalLicenses.GridView.Columns)
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;

            dplFilterItems.SelectedIndex = 0;
            dplIsActive.SelectedIndex = 0;
            mtxtInputFilter.Clear();
            mtxtInputFilter.Visible = false;
            dplIsActive.Visible = false;

            if (dgvInternationalLicenses.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvInternationalLicenses.GridView.Rows)
                    row.ContextMenuStrip = guna2ContextMenuStrip1;
            }
        }

        private void _RefreshNumOfRecords()
        {
            lbRecordsValue.Text = dgvInternationalLicenses.GridView.Rows.Count.ToString();
        }

        private void _FillDropDownList()
        {
            foreach (DataGridViewColumn Col in dgvInternationalLicenses.GridView.Columns)
                dplFilterItems.Items.Add(Col.HeaderText);
        }

        private void HandleTableWidth()
        {
            dgvInternationalLicenses.GridView.Columns["Int. License ID"].Width = 180;
            dgvInternationalLicenses.GridView.Columns["Application ID"].Width = 150;
            dgvInternationalLicenses.GridView.Columns["Driver ID"].Width = 160;
            dgvInternationalLicenses.GridView.Columns["L.License ID"].Width = 180;
            dgvInternationalLicenses.GridView.Columns["Issue Date"].Width = 160;
            dgvInternationalLicenses.GridView.Columns["Expiration Date"].Width = 200;
            dgvInternationalLicenses.GridView.Columns["Is Active"].Width = 120;
        }

        private void frmInternationalLicenses_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            _RefreshNumOfRecords();
            _FillDropDownList();

            if (dgvInternationalLicenses.GridView.Rows.Count > 0)
            {
                dgvInternationalLicenses.GridView.Columns["Issue Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvInternationalLicenses.GridView.Columns["Expiration Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
                isTableEmpty = false;

                HandleTableWidth();
            }

            guna2ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            guna2ContextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void VisibleAllTableRows()
        {
            foreach (DataGridViewRow row in dgvInternationalLicenses.GridView.Rows)
                row.Visible = true;
        }

        private void dplFilterItems_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            VisibleAllTableRows();

            if (dplFilterItems.SelectedIndex != 0 && dplFilterItems.SelectedItem != "Is Active")
            {
                mtxtInputFilter.Visible = true;
                dplIsActive.Visible = false;

                mtxtInputFilter.Clear();

                switch (dplFilterItems.SelectedItem.ToString())
                {
                    case "Int. License ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Application ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Driver ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "L.License ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Issue Date":
                        mtxtInputFilter.Mask = "00/00/0000";
                        break;
                    case "Expiration Date":
                        mtxtInputFilter.Mask = "00/00/0000";
                        break;
                    default:
                        mtxtInputFilter.Mask = "";
                        break;
                }
            }
            else if (dplFilterItems.SelectedItem == "Is Active")
            {
                dplIsActive.SelectedIndex = 0;
                mtxtInputFilter.Visible = false;
                dplIsActive.Visible = true;
            }
            else
            {
                dplIsActive.Visible = false;
                mtxtInputFilter.Visible = false;
            }

        }

        private void mtxtInputFilter_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvInternationalLicenses.GridView.Rows)
            {
                string value = row.Cells[dplFilterItems.SelectedItem].Value.ToString().ToLower();

                if (dplFilterItems.SelectedItem == "Issue Date" || dplFilterItems.SelectedItem == "Expiration Date")
                    value = ((DateTime)row.Cells[dplFilterItems.SelectedItem].Value).ToString("ddMMyyyy");

                if (value.Contains(mtxtInputFilter.Text.ToLower()))
                    row.Visible = true;
                else
                {
                    if (dgvInternationalLicenses.GridView.CurrentRow == row)
                        dgvInternationalLicenses.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvInternationalLicenses.GridView.Rows[0].Selected = true;
            }
        }

        private void FindInternationalLicenseByActiveStatus(bool activeStatus)
        {
            foreach (DataGridViewRow row in dgvInternationalLicenses.GridView.Rows)
            {
                if ((bool)row.Cells["Is Active"].Value == activeStatus)
                    row.Visible = true;
                else
                {
                    if (dgvInternationalLicenses.GridView.CurrentRow == row)
                        dgvInternationalLicenses.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvInternationalLicenses.GridView.Rows[0].Selected = true;
            }
        }

        private void dplIsActive_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            switch (dplIsActive.SelectedItem.ToString())
            {
                case "Yes":
                    FindInternationalLicenseByActiveStatus(true);
                    break;
                case "No":
                    FindInternationalLicenseByActiveStatus(false);
                    break;
                default:
                    VisibleAllTableRows();
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewInternationalLicense_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicenses AddInternationalLicenseForm = new frmAddInternationalLicenses();
            AddInternationalLicenseForm.ShowDialog();

            _RefreshTable();
            _RefreshNumOfRecords();

            if (dgvInternationalLicenses.GridView.Rows.Count == 1 && isTableEmpty)
            {
                isTableEmpty = false;
                HandleTableWidth();
                _FillDropDownList();
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.Find((int)dgvInternationalLicenses.GridView.CurrentRow.Cells["Driver ID"].Value);

            frmPersonDetails PersonDetailsForm = new frmPersonDetails(Driver.PersonID);
            PersonDetailsForm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseInfo InternationalLicenseForm = new frmInternationalLicenseInfo((int)dgvInternationalLicenses.GridView.CurrentRow.Cells[0].Value);
            InternationalLicenseForm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.Find((int)dgvInternationalLicenses.GridView.CurrentRow.Cells["Driver ID"].Value);

            frmPersonLicensesHistory PersonLicenseHistoryForm = new frmPersonLicensesHistory(Driver.PersonInfo);
            PersonLicenseHistoryForm.ShowDialog();
        }
    }
}
