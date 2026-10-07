using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUpdateApplicationType : Form
    {
        private int _ApplicationTypeID;

        private clsApplicationType ApplicationType;

        public frmUpdateApplicationType(int ApplicationTypeId)
        {
            InitializeComponent();

            _ApplicationTypeID = ApplicationTypeId;
        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            ApplicationType = clsApplicationType.Find(_ApplicationTypeID);

            if (ApplicationType != null)
            {
                lbIDValue.Text = ApplicationType.ApplicationTypeID.ToString();
                txtTitle.Text = ApplicationType.ApplicationName;
                txtFees.Text = ApplicationType.ApplicationFees.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtFees.Text == "")
            {
                MessageBox.Show("Please Enter Title And Fees First.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationType.ApplicationName = txtTitle.Text;
            ApplicationType.ApplicationFees = Convert.ToDecimal(txtFees.Text);

            if (ApplicationType.UpdateApplicationType())
            {
                MessageBox.Show("Saved Completed Successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Can't Update This Application Type", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
