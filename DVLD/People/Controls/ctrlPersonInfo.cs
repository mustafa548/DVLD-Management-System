using DVLD.Properties;
using DVLD_Business;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonInfo : UserControl
    {
        private int _PersonID;

        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void _FillDataToCard(clsPerson PersonInfo)
        {
            lbPersonIDValue.Text = PersonInfo.PersonID.ToString();
            lbNameValue.Text = PersonInfo.GetFullName();
            lbNationalIDNumberValue.Text = PersonInfo.NationalIDNumber;
            lbGenderValue.Text = PersonInfo.GetGenderAsString();

            if (PersonInfo.IsMale())
                pbGender.Image = Resources.Man_32;
            else
                pbGender.Image = Resources.Woman_32;

            lbAddressValue.Text = PersonInfo.Address;
            lbEmailValue.Text = PersonInfo.Email;
            lbDateOfBirthValue.Text = PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            lbPhoneValue.Text = PersonInfo.Phone;
            lbCountryValue.Text = PersonInfo.CountryInfo.CountryName;

            pbPersonImage.ImageLocation = clsImageHandling.GetImagePath(PersonInfo.ImagePath) + "?t=" + DateTime.Now.Ticks;

            llbEditPerson.Visible = true;
        }

        public void SelectPerson(int PersonID)
        {
            clsPerson PersonInfo = clsPerson.Find(PersonID);

            if (PersonInfo != null)
            {
                _PersonID = PersonID;
                _FillDataToCard(PersonInfo);
            }
        }

        public void SelectPerson(clsPerson Person)
        {
            if (Person != null)
            {
                _PersonID = Person.PersonID;
                _FillDataToCard(Person);
            }
        }

        public void DeleteDataFromCard()
        {
            lbPersonIDValue.Text = "???";
            lbNameValue.Text = "???";
            lbNationalIDNumberValue.Text = "???";
            lbGenderValue.Text = "???";
            pbGender.Image = Resources.Man_32;
            lbAddressValue.Text = "???";
            lbEmailValue.Text = "???";
            lbDateOfBirthValue.Text = "???";
            lbPhoneValue.Text = "???";
            lbCountryValue.Text = "???";

            pbPersonImage.Image = Resources.Male_512;

            llbEditPerson.Visible = false;
        }

        private async void llbEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddAndEditPerson EditPersonInfo = new frmAddAndEditPerson(_PersonID);
            
            if (EditPersonInfo.ShowDialog() == DialogResult.OK)
            {
                await Task.Delay(300);
                SelectPerson(_PersonID);
            }
        }
    }
}
