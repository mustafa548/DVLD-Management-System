using DVLD.Properties;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlLocalLicense : UserControl
    {
        public ctrlLocalLicense()
        {
            InitializeComponent();
        }

        private void _LoadDate(clsLocalLicense LocalLicense)
        {
            lbClassValue.Text = LocalLicense.LicenseClass.Name;
            lbNameValue.Text = LocalLicense.Driver.PersonInfo.GetFullName();
            lbLicenseIDValue.Text = LocalLicense.LicenseNumber.ToString();
            lbNationalIDNumberValue.Text = LocalLicense.Driver.PersonInfo.NationalIDNumber;
            lbGenderValue.Text = LocalLicense.Driver.PersonInfo.GetGenderAsString();

            if (LocalLicense.Driver.PersonInfo.IsMale())
                pbGender.Image = Resources.Man_32;
            else
                pbGender.Image = Resources.Woman_32;

            lbIssueDateValue.Text = LocalLicense.IssueDate.ToString("dd/MM/yyyy");
            lbIssueReasonValue.Text = LocalLicense.GetIssueReasonAsString();

            if (LocalLicense.Remarks != "")
                lbNotesValue.Text = LocalLicense.Remarks;

            if (LocalLicense.IsActive)
                lbIsActiveValue.Text = "Yes";
            else
                lbIsActiveValue.Text = "No";

            lbDateOfBirthValue.Text = LocalLicense.Driver.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            lbExpirationDateValue.Text = LocalLicense.ExpirationDate.ToString("dd/MM/yyyy");

            if (LocalLicense.IsDetained)
                lbIsDetainedValue.Text = "Yes";
            else
                lbIsDetainedValue.Text = "No";

            pbPersonImage.ImageLocation = clsImageHandling.GetImagePath(LocalLicense.Driver.PersonInfo.ImagePath);
        }

        public void DefaultValuesOfTheCard()
        {
            lbClassValue.Text = "???";
            lbNameValue.Text = "???";
            lbLicenseIDValue.Text = "???";
            lbNationalIDNumberValue.Text = "???";
            lbGenderValue.Text = "???";
            lbIssueDateValue.Text = "???";
            lbIssueReasonValue.Text = "???";
            lbNotesValue.Text = "No Notes";
            lbIsActiveValue.Text = "???";
            lbDateOfBirthValue.Text = "???";
            lbExpirationDateValue.Text = "???";
            lbIsDetainedValue.Text = "???";
            pbPersonImage.Image = Resources.Male_512;
        }

        public void SelectLicense(int LicenseID)
        {
            clsLocalLicense LocalLicense = clsLocalLicense.Find(LicenseID);

            if (LocalLicense != null)
                _LoadDate(LocalLicense);
        }

        public void SelectLicense(clsLocalLicense License)
        {
            _LoadDate(License);
        }

    }
}
