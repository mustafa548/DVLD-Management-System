using DVLD.Properties;
using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddAndEditPerson : Form
    {
        enum enMode {enAddNewMode, enEditMode};

        private enMode _Mode;

        private clsPerson _Person;

        private int _PersonID = -1;

        private string _OldImageName;

        private string _NewImageName;

        public delegate void DataBackHandler(int PersonID);

        public event DataBackHandler DataBack;

        public frmAddAndEditPerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Mode = enMode.enEditMode;
        }

        public frmAddAndEditPerson()
        {
            InitializeComponent();
            _Mode = enMode.enAddNewMode;
        }

        private void _FillCountriesInDropDownList()
        {
            DataTable dt = clsCountry.GetAllCountries();

            foreach(DataRow row in dt.Rows)
            {
                dplCountries.Items.Add(row["CountryName"].ToString());
            }
        }

        private void _LoadData()
        {
            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Can't Find This Person ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lbTitle.Text = "Edit Person's Info";

            lbPersonIDValue.Text = _PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalIDNumber.Text = _Person.NationalIDNumber;
            dtpDateOfBirth.SelectedDate = _Person.DateOfBirth;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;

            _OldImageName = _Person.ImagePath;
            pbPersonImage.ImageLocation = clsImageHandling.GetImagePath(_OldImageName);

            _NewImageName = clsImageHandling.GetImagePath(_OldImageName);

            if (_Person.IsMale())
            {
                rdFemale.Checked = false;
                rdMale.Checked = true;
            }
            else
            {
                rdMale.Checked = false;
                rdFemale.Checked = true;
            }

            dplCountries.SelectedItem = _Person.CountryInfo.CountryName;
        }

        private void _DateOfBirthSpecifications()
        {
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.CalendarMaxYear = dtpDateOfBirth.MaxDate.Year;
            dtpDateOfBirth.CalendarMaxDate = dtpDateOfBirth.MaxDate;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
        }

        private void frmAddAndEditPerson_Load(object sender, EventArgs e)
        {
            _FillCountriesInDropDownList();

            _DateOfBirthSpecifications();   
    
            if (_Mode == enMode.enAddNewMode)
            {
                dplCountries.SelectedItem = "Egypt";
                lbTitle.Text = "Add New Person";
                _Person = new clsPerson();
                return;
            }

            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rdMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Male_512;
        }

        private void rdFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Resources.Female_512;
        }

        private void llbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdSelectImage.InitialDirectory = @"D:\";

            ofdSelectImage.Filter = @"Images|*.png;*.jpg;*.jpeg;*.gif";

            if (ofdSelectImage.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = ofdSelectImage.FileName;

                _NewImageName = ofdSelectImage.FileName;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtSecondName.Text == "" || txtThirdName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || dplCountries.SelectedIndex == -1 || dtpDateOfBirth.SelectedDate == null || txtNationalIDNumber.Text == "" || pbPersonImage.ImageLocation == null)
            {
                MessageBox.Show("You Must Fill All Input Fields Before Saving", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ( !(clsValidation.IsValidEmail(txtEmail.Text.Trim()) && (txtPhone.Text.Trim() == _Person.Phone || clsValidation.IsValidPhoneNumber(txtPhone.Text.Trim(), dplCountries.SelectedItem)) && (txtNationalIDNumber.Text.Trim() == _Person.NationalIDNumber || clsValidation.IsValidNationalIDNumber(txtNationalIDNumber.Text.Trim())) ))
            {
                MessageBox.Show("Inputs Must Be Valid First.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Person.FirstName   = txtFirstName.Text.Trim();
            _Person.SecondName  = txtSecondName.Text.Trim();
            _Person.ThirdName   = txtThirdName.Text.Trim();
            _Person.LastName    = txtLastName.Text.Trim();
            _Person.Email       = txtEmail.Text.Trim();
            _Person.Phone       = txtPhone.Text.Trim();
            _Person.Address     = txtAddress.Text.Trim();
            _Person.DateOfBirth = (DateTime)dtpDateOfBirth.SelectedDate;

            if (rdMale.Checked)
                _Person.SetMale();
            else
                _Person.SetFemale();

            _Person.NationalIDNumber = txtNationalIDNumber.Text.Trim();

            if (_NewImageName != clsImageHandling.GetImagePath(_OldImageName))
                _Person.ImagePath    = clsImageHandling.ConvertImageNameToGuid(_NewImageName);

            _Person.CountryInfo      = clsCountry.Find(dplCountries.SelectedItem);
            _Person.CountryID        = _Person.CountryInfo.CountryID;

            if (_Person.Save())
            {
                DataBack?.Invoke(_Person.PersonID);

                if (_NewImageName != clsImageHandling.GetImagePath(_OldImageName))
                {
                    btnSave.Enabled = false;
                    btnClose.Enabled = false;
                    btnClose1.Enabled = false;
                    lbWaiting.Visible = true;

                    try
                    {
                        bool isUploaded = await clsImageHandling.CopyImageToFolder(_NewImageName, _Person.ImagePath);

                        if (!isUploaded)
                        {
                            MessageBox.Show("Can't Save Image Please Check Your Internet", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (_Mode == enMode.enEditMode)
                        {
                            bool isDeleted = await clsImageHandling.DeleteImageFromFolder(_OldImageName);

                            if (!isDeleted)
                            {
                                MessageBox.Show("Can't Delete Image Please Check Your Internet", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Can't Handle Images", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        btnSave.Enabled = true;
                        btnClose.Enabled = true;
                        btnClose1.Enabled = true;
                        lbWaiting.Visible = false;
                    }
                }

                _Mode = enMode.enEditMode;

                lbPersonIDValue.Text = _Person.PersonID.ToString();

                var message = MessageBox.Show("Saved Completed Successfully", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;

                if (message == DialogResult.OK)
                    this.Close();
            }
            else
            {
                var message = MessageBox.Show("Error: Can't Save Person", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNationalIDNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtNationalIDNumber.Text.Trim() != _Person.NationalIDNumber && !clsValidation.IsValidNationalIDNumber(txtNationalIDNumber.Text.Trim()))
                clsUiGlobal.SetError(e, txtNationalIDNumber, "Must Unique", errorProvider1);
            else
                clsUiGlobal.CancelError(e, txtNationalIDNumber, errorProvider1);
        }

        private void txtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtPhone.Text.Trim() != _Person.Phone && !clsValidation.IsValidPhoneNumber(txtPhone.Text.Trim(), dplCountries.SelectedItem))
                clsUiGlobal.SetError(e, txtPhone, "Must Unique And Valid", errorProvider1);
            else
                clsUiGlobal.CancelError(e, txtPhone, errorProvider1);
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!clsValidation.IsValidEmail(txtEmail.Text.Trim()))
                clsUiGlobal.SetError(e, txtEmail, "Not Valid Email", errorProvider1);
            else
                clsUiGlobal.CancelError(e, txtEmail, errorProvider1);
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
