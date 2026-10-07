using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmTestTypes : Form
    {
        public frmTestTypes()
        {
            InitializeComponent();
        }

        private void _RefreshTable()
        {
            dgvTestTypes.DataSource = clsTestType.GetAllTestTypes();

            if (dgvTestTypes.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTestTypes.GridView.Rows)
                    row.ContextMenuStrip = guna2ContextMenuStrip1;
            }
        }

        private void _RefreshNumOfRecords()
        {
            lbRecordsValue.Text = dgvTestTypes.GridView.Rows.Count.ToString();
        }

        private void HandleTableWidth()
        {
            dgvTestTypes.GridView.Columns["ID"].Width = 120;
            dgvTestTypes.GridView.Columns["Title"].Width = 150;
            dgvTestTypes.GridView.Columns["Description"].Width = 400;
            dgvTestTypes.GridView.Columns["Fees"].Width = 100;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            _RefreshNumOfRecords();

            if (dgvTestTypes.GridView.Rows.Count > 0)
                HandleTableWidth();

            guna2ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            guna2ContextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestType UpdateTestTypeForm = new frmUpdateTestType((int)dgvTestTypes.GridView.CurrentRow.Cells["ID"].Value);
            UpdateTestTypeForm.ShowDialog();

            _RefreshTable();
        }
    }
}
