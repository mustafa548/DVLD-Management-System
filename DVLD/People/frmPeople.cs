using System;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD
{
    public partial class frmPeople : Form
    {
        public frmPeople()
        {
            InitializeComponent();
        }

        private bool isTableEmpty = true;

        private void _RefreshTable()
        {
            dgvPeople.GridView.DataSource = clsPerson.GetAllPeople();

            foreach (DataGridViewColumn Col in dgvPeople.GridView.Columns)
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;

            dplFilterItems.SelectedIndex = 0;
            dplGender.SelectedIndex = 0;
            mtxtInputFilter.Clear();
            mtxtInputFilter.Visible = false;
            dplGender.Visible = false;

            if (dgvPeople.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPeople.GridView.Rows)
                    row.ContextMenuStrip = guna2ContextMenuStrip1;
            }
        }

        private void _RefreshNumOfRecords()
        {
            lbRecordsValue.Text = dgvPeople.GridView.Rows.Count.ToString();
        }

        private void _FillDropDownList()
        {
            foreach (DataGridViewColumn Col in dgvPeople.GridView.Columns)
                dplFilterItems.Items.Add(Col.HeaderText);
        }

        private void HandleTableWidth()
        {
            dgvPeople.GridView.Columns["Person ID"].Width = 120;
            dgvPeople.GridView.Columns["National ID Number"].Width = 200;
            dgvPeople.GridView.Columns["First Name"].Width = 160;
            dgvPeople.GridView.Columns["Second Name"].Width = 160;
            dgvPeople.GridView.Columns["Third Name"].Width = 160;
            dgvPeople.GridView.Columns["Last Name"].Width = 160;
            dgvPeople.GridView.Columns["Date Of Birth"].Width = 200;
            dgvPeople.GridView.Columns["Country"].Width = 180;
            dgvPeople.GridView.Columns["Phone"].Width = 200;
            dgvPeople.GridView.Columns["Email"].Width = 300;
            dgvPeople.GridView.Columns["Address"].Width = 180;
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            _RefreshNumOfRecords();
            _FillDropDownList();

            if (dgvPeople.GridView.Rows.Count > 0)
            {
                dgvPeople.GridView.Columns["Date Of Birth"].DefaultCellStyle.Format = "dd/MM/yyyy";
                isTableEmpty = false;

                HandleTableWidth();
            }

            guna2ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            guna2ContextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void dplFilterItems_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            VisibleAllTableRows();

            if (dplFilterItems.SelectedIndex != 0 && dplFilterItems.SelectedItem != "Gender")
            {
                mtxtInputFilter.Visible = true;
                dplGender.Visible = false;

                mtxtInputFilter.Clear();

                switch(dplFilterItems.SelectedItem.ToString())
                {
                    case "Person ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Phone":
                        mtxtInputFilter.Mask = "0000-000-0000";
                        break;
                    case "Date Of Birth":
                        mtxtInputFilter.Mask = "00/00/0000";
                        break;
                    default:
                        mtxtInputFilter.Mask = "";
                        break;
                }
            }
            else if (dplFilterItems.SelectedItem == "Gender")
            {
                dplGender.SelectedIndex = 0;
                mtxtInputFilter.Visible = false;
                dplGender.Visible = true;
            }
            else
            {
                dplGender.Visible = false;
                mtxtInputFilter.Visible = false;
            }
        }

        private void mtxtInputFilter_TextChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvPeople.GridView.Rows)
            {
                string value = row.Cells[dplFilterItems.SelectedItem.ToString()].Value.ToString().ToLower();

                if (dplFilterItems.SelectedItem == "Date Of Birth")
                    value = ( (DateTime)row.Cells[dplFilterItems.SelectedItem.ToString()].Value ).ToString("ddMMyyyy");

                if (value.Contains(mtxtInputFilter.Text.ToLower()))
                    row.Visible = true;
                else
                {
                    if (dgvPeople.GridView.CurrentRow == row)
                        dgvPeople.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvPeople.GridView.Rows[0].Selected = true;
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddAndEditPerson AddAndEditPersonForm = new frmAddAndEditPerson();
            AddAndEditPersonForm.ShowDialog();

            _RefreshTable();
            _RefreshNumOfRecords();

            if (dgvPeople.GridView.Rows.Count == 1 && isTableEmpty)
            {
                isTableEmpty = false;
                HandleTableWidth();
                _FillDropDownList();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.GridView.CurrentRow.Cells[0].Value;

            frmAddAndEditPerson AddAndEditPersonForm = new frmAddAndEditPerson(PersonID);
            AddAndEditPersonForm.ShowDialog();

            _RefreshTable();
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.GridView.CurrentRow.Cells[0].Value;

            var message = MessageBox.Show($"Are You Sure You Want Delete This Person With ID = {PersonID}", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (message == DialogResult.Yes)
            {
                string DeletedImagePerson = clsPerson.Find(PersonID).ImagePath;

                if (clsPerson.DeletePerson(PersonID))
                {
                    await clsImageHandling.DeleteImageFromFolder(DeletedImagePerson);

                    MessageBox.Show("Person Deleted Successfully", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error: Can't Delete This Person", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _RefreshTable();
                _RefreshNumOfRecords();

                if (dgvPeople.GridView.Rows.Count == 0)
                {
                    isTableEmpty = true;
                    dplFilterItems.Items.Clear();
                    dplFilterItems.Items.Add("None");
                }
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails PersonDetailsForm = new frmPersonDetails((int) dgvPeople.GridView.CurrentRow.Cells[0].Value);
            PersonDetailsForm.ShowDialog();

            _RefreshTable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindPersonByGender(string gender)
        {
            foreach (DataGridViewRow row in dgvPeople.GridView.Rows)
            {
                string value = row.Cells["Gender"].Value.ToString().ToLower();

                if (value == gender.ToLower())
                    row.Visible = true;
                else
                {
                    if (dgvPeople.GridView.CurrentRow == row)
                        dgvPeople.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvPeople.GridView.Rows[0].Selected = true;
            }
        }
        private void VisibleAllTableRows()
        {
            foreach (DataGridViewRow row in dgvPeople.GridView.Rows)
                row.Visible = true;
        }

        private void dplGender_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            if (dplGender.SelectedItem == "All")
                VisibleAllTableRows();
            else
                FindPersonByGender(dplGender.SelectedItem);
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSendEmail SendEmailForm = new frmSendEmail(dgvPeople.GridView.CurrentRow.Cells["Email"].Value.ToString());
            SendEmailForm.ShowDialog();
        }

        private void whatsAppMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSendWhatsAppMessage SendWhatsAppMessageForm = new frmSendWhatsAppMessage((int)dgvPeople.GridView.CurrentRow.Cells[0].Value);
            SendWhatsAppMessageForm.ShowDialog();
        }
    }
}
