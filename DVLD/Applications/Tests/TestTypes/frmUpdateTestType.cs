using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmUpdateTestType : Form
    {
        private int _TestTypeID;

        private clsTestType TestType;

        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            TestType = clsTestType.Find(_TestTypeID);

            if (TestType != null)
            {
                lbIDValue.Text = TestType.TestTypeID.ToString();
                txtTitle.Text = TestType.Type;
                txtDescription.Text = TestType.Description;
                txtFees.Text = TestType.Fees.ToString();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtFees.Text == "" || txtDescription.Text == "")
            {
                MessageBox.Show("Please Enter Title And Description And Fees First.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TestType.Type = txtTitle.Text;
            TestType.Description = txtDescription.Text;
            TestType.Fees = Convert.ToDecimal(txtFees.Text);

            if (TestType.UpdateTestType())
            {
                MessageBox.Show("Saved Completed Successfully", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Can't Update This Test Type", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
