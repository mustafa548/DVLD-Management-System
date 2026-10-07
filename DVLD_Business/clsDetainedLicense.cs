using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsDetainedLicense
    {
        enum enMode { enAddNewDetainedLicenseMode, enUpdateDetainedLicenseInfoMode };

        private enMode Mode;

        public int DetainedLicenseID { get; set; }

        public DateTime DetainedDate { get; set; }

        public DateTime? RealiseDate { get; set; }

        public decimal Fine { get; set; }

        public int LicenseNumber { get; set; }

        public int ApplicationNumber { get; set; }

        public bool IsRealised { get; set; }

        public clsLocalLicense LocalLicense { get; set; }

        public clsApplication RealiseApplication { get; set; }

        public clsDetainedLicense()
        {
            DetainedLicenseID = -1;
            DetainedDate = DateTime.Now;
            RealiseDate = null;
            Fine = 0;
            LicenseNumber = -1;
            ApplicationNumber = -1;
            IsRealised = false;

            LocalLicense = null;
            RealiseApplication = null;

            Mode = enMode.enAddNewDetainedLicenseMode;
        }

        private clsDetainedLicense(int DetainedLicenseID, DateTime DetainedDate, DateTime? RealiseDate, decimal Fine, int LicenseNumber,
            int ApplicationNumber, bool IsRealised)
        {
            this.DetainedLicenseID = DetainedLicenseID;
            this.DetainedDate = DetainedDate;
            this.RealiseDate = RealiseDate;
            this.Fine = Fine;
            this.LicenseNumber = LicenseNumber;
            this.ApplicationNumber = ApplicationNumber;
            this.IsRealised = IsRealised;

            this.LocalLicense = clsLocalLicense.Find(LicenseNumber);
            this.RealiseApplication = clsApplication.Find(ApplicationNumber);

            Mode = enMode.enUpdateDetainedLicenseInfoMode;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDataAccessDetainedLicenses.GetAllDetainedLicenses();
        }

        public static clsDetainedLicense Find(int DetainedLicenseID)
        {
            DateTime DetainedDate = DateTime.Now;
            DateTime? RealiseDate = null;
            decimal Fine = 0;
            int LicenseNumber = -1;
            int ApplicationNumber = -1;
            bool IsRealised = false;

            if (clsDataAccessDetainedLicenses.GetDetainedLicenseByID(DetainedLicenseID, ref DetainedDate, ref RealiseDate, ref Fine, ref LicenseNumber, ref ApplicationNumber, ref IsRealised))
            {
                return new clsDetainedLicense(DetainedLicenseID, DetainedDate, RealiseDate, Fine, LicenseNumber, ApplicationNumber, IsRealised);
            }
            else
                return null;
        }

        public static clsDetainedLicense FindByLicenseNumber(int LicenseNumber)
        {
            DateTime DetainedDate = DateTime.Now;
            DateTime? RealiseDate = null;
            decimal Fine = 0;
            int DetainedLicenseID = -1;
            int ApplicationNumber = -1;
            bool IsRealised = false;

            if (clsDataAccessDetainedLicenses.GetDetainedLicenseByLicenseNumber(ref DetainedLicenseID, ref DetainedDate, ref RealiseDate, ref Fine, LicenseNumber, ref ApplicationNumber, ref IsRealised))
            {
                return new clsDetainedLicense(DetainedLicenseID, DetainedDate, RealiseDate, Fine, LicenseNumber, ApplicationNumber, IsRealised);
            }
            else
                return null;
        }

        private bool _AddNewDetainedLicense()
        {
            this.DetainedLicenseID = clsDataAccessDetainedLicenses.AddNewDetainedLicense(this.DetainedDate, this.RealiseDate, this.Fine, this.LicenseNumber, this.ApplicationNumber, this.IsRealised);

            return this.DetainedLicenseID != -1;
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDataAccessDetainedLicenses.UpdateDetainedLicenseInfo(this.DetainedLicenseID, this.DetainedDate, this.RealiseDate, this.Fine, this.LicenseNumber, this.ApplicationNumber, this.IsRealised);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNewDetainedLicenseMode:
                    if (_AddNewDetainedLicense())
                    {
                        Mode = enMode.enUpdateDetainedLicenseInfoMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.enUpdateDetainedLicenseInfoMode:
                    if (_UpdateDetainedLicense())
                        return true;
                    else
                        return false;
            }

            return false;
        }

    }
}
