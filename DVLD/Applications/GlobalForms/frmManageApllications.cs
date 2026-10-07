using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmManageApllications : Form
    {
        public frmManageApllications()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalLicenses_Click(object sender, EventArgs e)
        {
            frmRequestedLocalLicenses RequestedLocalLicensesForm = new frmRequestedLocalLicenses();
            RequestedLocalLicensesForm.ShowDialog();
        }

        private void btnInternationalLicenses_Click(object sender, EventArgs e)
        {
            frmInternationalLicenses InternationalLicensesForm = new frmInternationalLicenses();
            InternationalLicensesForm.ShowDialog();
        }
    }
}
