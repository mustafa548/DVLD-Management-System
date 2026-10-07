using DVLD.Properties;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlInternationalLicense : UserControl
    {
        public ctrlInternationalLicense()
        {
            InitializeComponent();
        }

        public void SelectInternationalLicense(int InternationalLicenseID)
        {
            clsInternationalLicense InternationalLicense = clsInternationalLicense.Find(InternationalLicenseID);

            if (InternationalLicense != null)
            {
                lbNameValue.Text = InternationalLicense.LocalLicense.Driver.PersonInfo.GetFullName();
                lbIntLicenseIDValue.Text = InternationalLicense.LicenseNumber.ToString();
                lbLicenseIDValue.Text = InternationalLicenseID.ToString();
                lbNationalIDNumberValue.Text = InternationalLicense.LocalLicense.Driver.PersonInfo.NationalIDNumber;
                lbGenderValue.Text = InternationalLicense.LocalLicense.Driver.PersonInfo.GetGenderAsString();

                if (InternationalLicense.LocalLicense.Driver.PersonInfo.IsMale())
                    pbGender.Image = Resources.Man_32;
                else
                    pbGender.Image = Resources.Woman_32;

                lbIssueDateValue.Text = InternationalLicense.IssueDate.ToString("dd/MM/yyyy");
                lbApplicationIDValue.Text = InternationalLicense.ApplicationNumber.ToString();

                if (InternationalLicense.IsActive())
                    lbIsActiveValue.Text = "Yes";
                else
                    lbIsActiveValue.Text = "No";

                lbDateOfBirthValue.Text = InternationalLicense.LocalLicense.Driver.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
                lbDriverIDValue.Text = InternationalLicense.LocalLicense.DriverID.ToString();
                lbExpirationDateValue.Text = InternationalLicense.ExpiryDate.ToString("dd/MM/yyyy");

                pbPersonImage.ImageLocation = clsImageHandling.GetImagePath(InternationalLicense.LocalLicense.Driver.PersonInfo.ImagePath);
            }
        }

    }
}
