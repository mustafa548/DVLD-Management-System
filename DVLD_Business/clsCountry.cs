using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsCountry
    {
        public int CountryID { get; set; }

        public string CountryName { get; set; }

        public string CountryCode { get; set; }

        public int LengthOfPhoneNumber { get; set; }


        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
            CountryCode = "";
            LengthOfPhoneNumber = 0;
        }

        private clsCountry(int CountryID, string CountryName, string CountryCode, int LengthOfPhoneNumber)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.CountryCode = CountryCode;
            this.LengthOfPhoneNumber = LengthOfPhoneNumber;
        }

        public static DataTable GetAllCountries()
        {
            return clsDataAccessCountry.GetAllCountries();
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";
            string CountryCode = "";
            int LengthOfPhoneNumber = 0;

            if (clsDataAccessCountry.GetCountryByID(CountryID, ref CountryName, ref CountryCode, ref LengthOfPhoneNumber))
                return new clsCountry(CountryID, CountryName, CountryCode, LengthOfPhoneNumber);
            else
                return null;
        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = 0;
            string CountryCode = "";
            int LengthOfPhoneNumber = 0;

            if (clsDataAccessCountry.GetCountryByName(ref CountryID, CountryName, ref CountryCode, ref LengthOfPhoneNumber))
                return new clsCountry(CountryID, CountryName, CountryCode, LengthOfPhoneNumber);
            else
                return null;
        }

    }
}
