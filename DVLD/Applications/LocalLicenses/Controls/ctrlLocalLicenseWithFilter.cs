using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlLocalLicenseWithFilter : UserControl
    {
        public event Action<int> OnLocalLicenseSelected;

        protected virtual void LocalLicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLocalLicenseSelected;

            if (handler != null)
                handler(LicenseID);
        }

        public ctrlLocalLicenseWithFilter()
        {
            InitializeComponent();
        }

        private void btnSearchForLicense_Click(object sender, EventArgs e)
        {
            if (txtLicenseID.Text == "")
            {
                MessageBox.Show("Please Write License ID First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsLocalLicense LocalLicense = clsLocalLicense.Find(int.Parse(txtLicenseID.Text));

            if (LocalLicense != null)
            {
                ctrlLocalLicense1.SelectLicense(LocalLicense);

                if (OnLocalLicenseSelected != null)
                {
                    OnLocalLicenseSelected(LocalLicense.LicenseNumber);
                }

                txtLicenseID.Text = "";
            }
            else
                MessageBox.Show($"No Local License Found With ID: {txtLicenseID.Text}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DeleteDataFromCard()
        {
            txtLicenseID.Text = "";
            ctrlLocalLicense1.DefaultValuesOfTheCard();
        }

        public void DisableFilter()
        {
            gbFilter.Enabled = false;
        }

        public void AfterSelectLocalLicense(clsLocalLicense LocalLicense)
        {
            ctrlLocalLicense1.SelectLicense(LocalLicense);
            txtLicenseID.Text = LocalLicense.LicenseNumber.ToString();
            DisableFilter();
        }

    }
}
