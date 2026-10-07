using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmApplicationTypes : Form
    {
        public frmApplicationTypes()
        {
            InitializeComponent();
        }

        private void _RefreshTable()
        {
            dgvApplicationTypes.DataSource = clsApplicationType.GetAllApplicationTypes();

            if (dgvApplicationTypes.GridView.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvApplicationTypes.GridView.Rows)
                    row.ContextMenuStrip = guna2ContextMenuStrip1;
            }
        }

        private void _RefreshNumOfRecords()
        {
            lbRecordsValue.Text = dgvApplicationTypes.GridView.Rows.Count.ToString();
        }

        private void HandleTableWidth()
        {
            dgvApplicationTypes.GridView.Columns["ID"].Width = 120;
            dgvApplicationTypes.GridView.Columns["Title"].Width = 300;
            dgvApplicationTypes.GridView.Columns["Fees"].Width = 100;
        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
            _RefreshTable();
            _RefreshNumOfRecords();

            if (dgvApplicationTypes.GridView.Rows.Count > 0)
                HandleTableWidth();

            guna2ContextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            guna2ContextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType UpdateApplicationTypeForm = new frmUpdateApplicationType((int)dgvApplicationTypes.GridView.CurrentRow.Cells["ID"].Value);
            UpdateApplicationTypeForm.ShowDialog();

            _RefreshTable();
        }
    }
}
