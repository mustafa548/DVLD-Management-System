using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmDrivers : Form
    {
        public frmDrivers()
        {
            InitializeComponent();
        }

        private void _RefreshTable()
        {
            dgvDrivers.GridView.DataSource = clsDriver.GetAllDrivers();

            foreach (DataGridViewColumn Col in dgvDrivers.GridView.Columns)
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void _RefreshNumOfRecords()
        {
            lbRecordsValue.Text = dgvDrivers.GridView.Rows.Count.ToString();
        }

        private void _FillDropDownList()
        {
            foreach (DataGridViewColumn Col in dgvDrivers.GridView.Columns)
                dplFilterItems.Items.Add(Col.HeaderText);
        }

        private void HandleTableWidth()
        {
            dgvDrivers.GridView.Columns["Driver ID"].Width = 150;
            dgvDrivers.GridView.Columns["Person ID"].Width = 150;
            dgvDrivers.GridView.Columns["National No"].Width = 130;
            dgvDrivers.GridView.Columns["Full Name"].Width = 320;
            dgvDrivers.GridView.Columns["Date"].Width = 150;
            dgvDrivers.GridView.Columns["Active Licenses"].Width = 160;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            _RefreshNumOfRecords();
            _FillDropDownList();

            if (dgvDrivers.GridView.Rows.Count > 0)
            {
                dgvDrivers.GridView.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";

                HandleTableWidth();
            }
        }

        private void VisibleAllTableRows()
        {
            foreach (DataGridViewRow row in dgvDrivers.GridView.Rows)
                row.Visible = true;
        }

        private void dplFilterItems_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            VisibleAllTableRows();

            if (dplFilterItems.SelectedIndex != 0)
            {
                mtxtInputFilter.Visible = true;

                mtxtInputFilter.Clear();

                switch (dplFilterItems.SelectedItem.ToString())
                {
                    case "Driver ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Person ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Active Licenses":
                        mtxtInputFilter.Mask = "0";
                        break;
                    case "Date":
                        mtxtInputFilter.Mask = "00/00/0000";
                        break;
                    default:
                        mtxtInputFilter.Mask = "";
                        break;
                }
            }
            else
                mtxtInputFilter.Visible = false;
        }

        private void mtxtInputFilter_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDrivers.GridView.Rows)
            {
                string value = row.Cells[dplFilterItems.SelectedItem].Value.ToString().ToLower();

                if (dplFilterItems.SelectedItem == "Date")
                    value = ((DateTime)row.Cells[dplFilterItems.SelectedItem.ToString()].Value).ToString("ddMMyyyy");

                if (value.Contains(mtxtInputFilter.Text.ToLower()))
                    row.Visible = true;
                else
                {
                    if (dgvDrivers.GridView.CurrentRow == row)
                        dgvDrivers.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvDrivers.GridView.Rows[0].Selected = true;
            }
        }

    }
}
