using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsLicenseClass
    {

        public int LicenseClassID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Fees { get; set; }

        public int ValidtyLength { get; set; }

        public int MinAge { get; set; }

        public clsLicenseClass()
        {
            LicenseClassID = 0;
            Name = "";
            Description = "";
            Fees = 0;
            ValidtyLength = 0;
            MinAge = 0;
        }

        private clsLicenseClass(int LicenseClassID, string Name, string Description, decimal Fees, int ValidtyLength, int MinAge)
        {
            this.LicenseClassID = LicenseClassID;
            this.Name = Name;
            this.Description = Description;
            this.Fees = Fees;
            this.ValidtyLength = ValidtyLength;
            this.MinAge = MinAge;
        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsDataAccessLicenseClass.GetAllLicenseClasses();
        }

        public static clsLicenseClass Find(int LicenseClassID)
        {
            string Name = "";
            string Description = "";
            decimal Fees = 0;
            int ValidtyLength = 0;
            int MinAge = 0;

            if (clsDataAccessLicenseClass.GetLicenseClassByID(LicenseClassID, ref Name, ref Description, ref Fees, ref ValidtyLength, ref MinAge))
                return new clsLicenseClass(LicenseClassID, Name, Description, Fees, ValidtyLength, MinAge);
            else
                return null;
        }

        public static clsLicenseClass Find(string Name)
        {
            int LicenseClassID = 0;
            string Description = "";
            decimal Fees = 0;
            int ValidtyLength = 0;
            int MinAge = 0;

            if (clsDataAccessLicenseClass.GetLicenseClassByName(ref LicenseClassID, Name, ref Description, ref Fees, ref ValidtyLength, ref MinAge))
                return new clsLicenseClass(LicenseClassID, Name, Description, Fees, ValidtyLength, MinAge);
            else
                return null;
        }

    }
}
