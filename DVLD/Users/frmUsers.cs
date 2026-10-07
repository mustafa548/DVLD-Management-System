using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private bool isTableEmpty = true;

        private void _RefreshTable()
        {
            dgvUsers.GridView.DataSource = clsUser.GetAllUsers();

            foreach (DataGridViewColumn Col in dgvUsers.GridView.Columns)
                Col.SortMode = DataGridViewColumnSortMode.NotSortable;

            dplFilterItems.SelectedIndex = 0;
            dplIsActive.SelectedIndex = 0;
            mtxtInputFilter.Clear();
            mtxtInputFilter.Visible = false;
            dplIsActive.Visible = false;

            if (dgvUsers.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvUsers.GridView.Rows)
                    row.ContextMenuStrip = guna2ContextMenuStrip1;
            }
        }

        private void _RefreshNumOfRecords()
        {
            lbRecordsValue.Text = dgvUsers.GridView.Rows.Count.ToString();
        }

        private void _FillDropDownList()
        {
            foreach (DataGridViewColumn Col in dgvUsers.GridView.Columns)
                dplFilterItems.Items.Add(Col.HeaderText);
        }

        private void HandleTableWidth()
        {
            dgvUsers.GridView.Columns["User ID"].Width = 120;
            dgvUsers.GridView.Columns["Person ID"].Width = 150;
            dgvUsers.GridView.Columns["Full Name"].Width = 400;
            dgvUsers.GridView.Columns["User Name"].Width = 200;
            dgvUsers.GridView.Columns["Is Active"].Width = 120;
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            _RefreshNumOfRecords();
            _FillDropDownList();

            if (dgvUsers.GridView.Rows.Count > 0)
            {
                isTableEmpty = false;

                HandleTableWidth();
            }

            guna2ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            guna2ContextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddAndEditUser AddAndEditUserForm = new frmAddAndEditUser();
            AddAndEditUserForm.ShowDialog();

            _RefreshTable();
            _RefreshNumOfRecords();

            if (dgvUsers.GridView.Rows.Count == 1 && isTableEmpty)
            {
                isTableEmpty = false;
                HandleTableWidth();
                _FillDropDownList();
            }

        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.GridView.CurrentRow.Cells[0].Value;

            frmAddAndEditUser AddAndEditUserForm = new frmAddAndEditUser(UserID);
            AddAndEditUserForm.ShowDialog();

            _RefreshTable();
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.GridView.CurrentRow.Cells[0].Value;

            var message = MessageBox.Show($"Are You Sure You Want Delete This User With ID = {UserID}", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (message == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(UserID))
                    MessageBox.Show("User Deleted Successfully", "Deleted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error: Can't Delete This User", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _RefreshTable();
                _RefreshNumOfRecords();

                if (dgvUsers.GridView.Rows.Count == 0)
                {
                    isTableEmpty = true;
                    dplFilterItems.Items.Clear();
                    dplFilterItems.Items.Add("None");
                }
            }
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
                    case "User ID":
                        mtxtInputFilter.Mask = "0000";
                        break;
                    case "Person ID":
                        mtxtInputFilter.Mask = "0000";
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
                mtxtInputFilter.Visible = false;
                dplIsActive.Visible = false;
            }
        }

        private void mtxtInputFilter_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsers.GridView.Rows)
            {
                string value = row.Cells[dplFilterItems.SelectedItem.ToString()].Value.ToString().ToLower();

                if (value.Contains(mtxtInputFilter.Text.ToLower()))
                    row.Visible = true;
                else
                {
                    if (dgvUsers.GridView.CurrentRow == row)
                        dgvUsers.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvUsers.GridView.Rows[0].Selected = true;
            }
        }

        private void FindUserByActiveStatus(bool activeStatus)
        {
            foreach (DataGridViewRow row in dgvUsers.GridView.Rows)
            {
                if ((bool)row.Cells["Is Active"].Value == activeStatus)
                    row.Visible = true;
                else
                {
                    if (dgvUsers.GridView.CurrentRow == row)
                        dgvUsers.GridView.CurrentCell = null;

                    row.Visible = false;
                }

                dgvUsers.GridView.Rows[0].Selected = true;
            }
        }

        private void VisibleAllTableRows()
        {
            foreach (DataGridViewRow row in dgvUsers.GridView.Rows)
                row.Visible = true;
        }

        private void dplIsActive_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            switch (dplIsActive.SelectedItem.ToString())
            {
                case "Yes":
                    FindUserByActiveStatus(true);
                    break;
                case "No":
                    FindUserByActiveStatus(false);
                    break;
                default:
                    VisibleAllTableRows();
                    break;
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo UserInfoForm = new frmUserInfo((int)dgvUsers.GridView.CurrentRow.Cells[0].Value);
            UserInfoForm.ShowDialog();

            _RefreshTable();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSendEmail SendEmailForm = new frmSendEmail(clsUser.Find((int)dgvUsers.GridView.CurrentRow.Cells["User ID"].Value).PersonInfo.Email);
            SendEmailForm.ShowDialog();
        }

        private void whatsAppMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSendWhatsAppMessage SendWhatsAppMessageForm = new frmSendWhatsAppMessage((int)dgvUsers.GridView.CurrentRow.Cells["Person ID"].Value);
            SendWhatsAppMessageForm.ShowDialog();
        }
    }
}
