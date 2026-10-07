using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        private static int ValidtyLength = 1;

        public int InternationalLicenseID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public int ApplicationNumber { get; set; }

        public int LicenseNumber { get; set; }

        public clsApplication Application { get; set; }

        public clsLocalLicense LocalLicense { get; set; }

        public clsInternationalLicense()
        {
            InternationalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpiryDate = DateTime.Now;
            ApplicationNumber = -1;
            LicenseNumber = -1;

            Application = null;
            LocalLicense = null;
        }

        private clsInternationalLicense(int InternationalLicenseID, DateTime IssueDate, DateTime ExpiryDate
            , int ApplicationNumber, int LicenseNumber)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpiryDate = ExpiryDate;
            this.ApplicationNumber = ApplicationNumber;
            this.LicenseNumber = LicenseNumber;

            this.Application = clsApplication.Find(ApplicationNumber);
            this.LocalLicense = clsLocalLicense.Find(LicenseNumber);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsDataAccessInternationalLicense.GetAllInternationalLicenses();
        }

        public static DataTable GetAllInternationalLicensesByPerson(int PersonID)
        {
            return clsDataAccessInternationalLicense.GetAllInternationalLicensesByPerson(PersonID);
        }

        public static clsInternationalLicense Find(int InternationalLicenseID)
        {
            DateTime IssueDate = DateTime.Now;
            DateTime ExpiryDate = DateTime.Now;
            int ApplicationNumber = -1;
            int LicenseNumber = -1;

            if (clsDataAccessInternationalLicense.GetInternationalLicenseByID(InternationalLicenseID, ref IssueDate, ref ExpiryDate, ref ApplicationNumber, ref LicenseNumber))
            {
                return new clsInternationalLicense(InternationalLicenseID, IssueDate, ExpiryDate, ApplicationNumber, LicenseNumber);
            }
            else
                return null;
        }

        public bool AddNewInternationalLicense()
        {
            this.ExpiryDate = this.IssueDate.AddYears(ValidtyLength);

            this.InternationalLicenseID = clsDataAccessInternationalLicense.AddNewInternationalLicense(this.IssueDate, this.ExpiryDate, this.ApplicationNumber, this.LicenseNumber);

            return this.InternationalLicenseID != -1;
        }

        public bool IsActive()
        {
            return this.ExpiryDate > DateTime.Now;
        }

        public static bool IsInternationalLicenseExistsByDriverID(int DriverID)
        {
            return clsDataAccessInternationalLicense.IsInternationalLicenseExistsByDriverID(DriverID);
        }

        public static DateTime GetExpirationDate(DateTime IssueDate)
        {
            return IssueDate.AddYears(ValidtyLength);
        }

    }
}
