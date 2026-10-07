using DVLD_Business;

namespace DVLD
{
    public class clsValidation
    {
        public static bool IsValidNationalIDNumber(string NationalIDNumber)
        {
            if (clsPerson.IsPersonExists(NationalIDNumber))
                return false;

            return true;
        }

        public static bool IsValidPhoneNumber(string Phone, string CountryName)
        {
            int LengthOfPhoneNumber = clsCountry.Find(CountryName).LengthOfPhoneNumber;

            if (clsPerson.IsPersonExistsByPhone(Phone))
                return false;

            if (Phone.Length != LengthOfPhoneNumber)
                return false;

            return true;
        }

        public static bool IsValidEmail(string Email)
        {
            if (!Email.Contains("@gmail.com"))
                return false;

            return true;
        }

        public static bool IsValidUserName(string UserName)
        {
            if (clsUser.IsUserExists(UserName))
                return false;

            return true;
        }

    }
}
