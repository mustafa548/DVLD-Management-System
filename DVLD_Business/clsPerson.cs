using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {
        enum enMode {enAddNewPersonMode, enUpdatePersonInfoMode};

        private enMode Mode;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public clsDataAccessPerson.enGender Gender { get; set; }
        public string NationalIDNumber { get; set; }
        public string ImagePath { get; set; }
        public int CountryID { get; set; }

        public clsCountry CountryInfo { get; set; }

        public void SetMale()
        {
            Gender = clsDataAccessPerson.enGender.enMale;
        }

        public void SetFemale()
        {
            Gender = clsDataAccessPerson.enGender.enFemale;
        }

        public clsPerson()
        {
            PersonID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            Email = "";
            Phone = "";
            Address = "";
            DateOfBirth = DateTime.Now;
            Gender = clsDataAccessPerson.enGender.enMale;
            NationalIDNumber = "";
            ImagePath = "";
            CountryID = 0;
            CountryInfo = null;

            Mode = enMode.enAddNewPersonMode;
        }

        private clsPerson(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName,
            string Email, string Phone, string Address,
            DateTime DateOfBirth, clsDataAccessPerson.enGender Gender, string NationalIDNumber, string ImagePath, int CountryID)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.NationalIDNumber = NationalIDNumber;
            this.ImagePath = ImagePath;
            this.CountryID = CountryID;

            this.CountryInfo = clsCountry.Find(this.CountryID);

            Mode = enMode.enUpdatePersonInfoMode;
        }

        public static DataTable GetAllPeople()
        {
            return clsDataAccessPerson.GetAllPeople();
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string Email = "";
            string Phone = "";
            string Address = "";
            DateTime DateOfBirth = DateTime.Now;
            clsDataAccessPerson.enGender Gender = clsDataAccessPerson.enGender.enMale;
            string NationalIDNumber = "";
            string ImagePath = "";
            int CountryID = 0;

            if (clsDataAccessPerson.GetPersonByID(PersonID, ref FirstName, ref SecondName, ref ThirdName,
                    ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth,
                    ref Gender, ref NationalIDNumber, ref ImagePath, ref CountryID))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, Email, Phone, Address, DateOfBirth, Gender, NationalIDNumber, ImagePath, CountryID);
            }
            else
                return null;
        }

        public static clsPerson Find(string NationalIDNumber)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string Email = "";
            string Phone = "";
            string Address = "";
            DateTime DateOfBirth = DateTime.Now;
            clsDataAccessPerson.enGender Gender = clsDataAccessPerson.enGender.enMale;
            string ImagePath = "";
            int CountryID = 0;

            if (clsDataAccessPerson.GetPersonByNationalIDNumber(ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                    ref LastName, ref Email, ref Phone, ref Address, ref DateOfBirth,
                    ref Gender, NationalIDNumber, ref ImagePath, ref CountryID))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, Email, Phone, Address, DateOfBirth, Gender, NationalIDNumber, ImagePath, CountryID);
            }
            else
                return null;
        }

        public static clsPerson FindByPhone(string Phone)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            string Email = "";
            string Address = "";
            DateTime DateOfBirth = DateTime.Now;
            clsDataAccessPerson.enGender Gender = clsDataAccessPerson.enGender.enMale;
            string NationalIDNumber = "";
            string ImagePath = "";
            int CountryID = 0;

            if (clsDataAccessPerson.GetPersonByPhone(ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                    ref LastName, ref Email, Phone, ref Address, ref DateOfBirth,
                    ref Gender, ref NationalIDNumber, ref ImagePath, ref CountryID))
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, Email, Phone, Address, DateOfBirth, Gender, NationalIDNumber, ImagePath, CountryID);
            }
            else
                return null;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsDataAccessPerson.DeletePerson(PersonID);
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsDataAccessPerson.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Email, this.Phone, this.Address, 
                this.DateOfBirth, this.Gender, this.NationalIDNumber, this.ImagePath, this.CountryID);

            return this.PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsDataAccessPerson.UpdatePersonInfo(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.Email, this.Phone, this.Address,
                this.DateOfBirth,this.Gender, this.NationalIDNumber,this.ImagePath, this.CountryID);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.enAddNewPersonMode:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.enUpdatePersonInfoMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.enUpdatePersonInfoMode:
                    if (_UpdatePerson())
                        return true;
                    else
                        return false;
            }

            return false;
        }

        public static bool IsPersonExists(int PersonID)
        {
            return clsDataAccessPerson.IsPersonExists(PersonID);
        }

        public static bool IsPersonExists(string NationalIDNumber)
        {
            return clsDataAccessPerson.IsPersonExists(NationalIDNumber);
        }

        public static bool IsPersonExistsByPhone(string Phone)
        {
            return clsDataAccessPerson.IsPersonExistsByPhone(Phone);
        }
        public string GetGenderAsString()
        {
            return this.Gender == clsDataAccessPerson.enGender.enMale ? "Male" : "Female"; 
        }

        public bool IsMale()
        {
            return this.Gender == clsDataAccessPerson.enGender.enMale;
        }

        public string GetFullName()
        {
            return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
        }
    }
}
