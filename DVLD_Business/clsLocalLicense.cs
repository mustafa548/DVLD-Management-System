using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLocalLicense
    {
        enum enMode { enAddNewLocalLicenseMode, enUpdateLocalLicenseInfoMode };

        private enMode Mode;

        public int LicenseNumber { get; set; }
        public clsDataAccessLocalLicense.enIssueReason IssueReason { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Remarks { get; set; }
        public int LicenseClassID { get; set; }
        public int ApplicationNumber { get; set; }
        public int DriverID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDetained { get; set; }

        public clsLicenseClass LicenseClass { get; set; }
        public clsApplication Application { get; set; }
        public clsDriver Driver { get; set; }

        public clsLocalLicense()
        {
            LicenseNumber = -1;
            IssueReason = clsDataAccessLocalLicense.enIssueReason.enFirstTime;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Remarks = "";
            LicenseClassID = -1;
            ApplicationNumber = -1;
            DriverID = -1;
            IsActive = false;
            IsDetained = false;

            LicenseClass = null;
            Application = null;
            Driver = null;

            Mode = enMode.enAddNewLocalLicenseMode;
        }

        private clsLocalLicense(int LicenseNumber, clsDataAccessLocalLicense.enIssueReason IssueReason, DateTime IssueDate, DateTime ExpirationDate,
            string Remarks, int LicenseClassID, int ApplicationNumber, int DriverID, bool IsActive, bool IsDetained)
        {
            this.LicenseNumber = LicenseNumber;
            this.IssueReason = IssueReason;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Remarks = Remarks;
            this.LicenseClassID = LicenseClassID;
            this.ApplicationNumber = ApplicationNumber;
            this.DriverID = DriverID;
            this.IsActive = IsActive;
            this.IsDetained = IsDetained;

            this.LicenseClass = clsLicenseClass.Find(LicenseClassID);
            this.Application = clsApplication.Find(ApplicationNumber);
            this.Driver = clsDriver.Find(DriverID);

            Mode = enMode.enUpdateLocalLicenseInfoMode;
        }

        public static DataTable GetAllLocalLicensesByPerson(int PersonID)
        {
            return clsDataAccessLocalLicense.GetAllLocalLicensesByPerson(PersonID);
        }

        public static clsLocalLicense Find(int LicenseNumber)
        {
            clsDataAccessLocalLicense.enIssueReason IssueReason = clsDataAccessLocalLicense.enIssueReason.enFirstTime;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Remarks = "";
            int LicenseClassID = -1;
            int ApplicationNumber = -1;
            int DriverID = -1;
            bool IsActive = false;
            bool IsDetained = false;

            if (clsDataAccessLocalLicense.GetLocalLicenseByID(LicenseNumber, ref IssueReason, ref IssueDate, ref ExpirationDate, ref Remarks, ref LicenseClassID, ref ApplicationNumber, ref DriverID, ref IsActive, ref IsDetained))
            {
                return new clsLocalLicense(LicenseNumber, IssueReason, IssueDate, ExpirationDate, Remarks, LicenseClassID, ApplicationNumber, DriverID, IsActive, IsDetained);
            }
            else
                return null;
        }

        private bool _AddNewLocalLicense()
        {
            this.LicenseNumber = clsDataAccessLocalLicense.AddNewLocalLicense(this.IssueReason, this.IssueDate, this.ExpirationDate, this.Remarks, this.LicenseClassID, this.ApplicationNumber, this.DriverID, this.IsActive, this.IsDetained);

            return this.LicenseNumber != -1;
        }

        private bool _UpdateLocalLicense()
        {
            return clsDataAccessLocalLicense.UpdateLocalLicenseInfo(this.LicenseNumber, this.IssueReason, this.IssueDate, this.ExpirationDate, this.Remarks, this.LicenseClassID, this.ApplicationNumber, this.DriverID, this.IsActive, this.IsDetained);
        }

        public bool Save()
        {
            if (this.LicenseClassID != -1)
            {
                clsLicenseClass LicenseClass = clsLicenseClass.Find(LicenseClassID);

                if (Mode == enMode.enAddNewLocalLicenseMode)
                    this.ExpirationDate = this.IssueDate.AddYears(LicenseClass.ValidtyLength);
            }

            switch (Mode)
            {
                case enMode.enAddNewLocalLicenseMode:
                    if (_AddNewLocalLicense())
                    {
                        Mode = enMode.enUpdateLocalLicenseInfoMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.enUpdateLocalLicenseInfoMode:
                    if (_UpdateLocalLicense())
                        return true;
                    else
                        return false;
            }

            return false;
        }

        public void IssueFirstTime()
        {
            IssueReason = clsDataAccessLocalLicense.enIssueReason.enFirstTime;
        }

        public void RenewIssue()
        {
            IssueReason = clsDataAccessLocalLicense.enIssueReason.enRenew;
        }

        public void IssueReplacementForLost()
        {
            IssueReason = clsDataAccessLocalLicense.enIssueReason.enReplacementForLost;
        }

        public void IssueReplacementForDamaged()
        {
            IssueReason = clsDataAccessLocalLicense.enIssueReason.enReplacementForDamaged;
        }

        public string GetIssueReasonAsString()
        {
            string reason = "";

            switch(IssueReason)
            {
                case clsDataAccessLocalLicense.enIssueReason.enFirstTime:
                    reason = "First Time";
                    break;
                case clsDataAccessLocalLicense.enIssueReason.enRenew:
                    reason = "Renew";
                    break;
                case clsDataAccessLocalLicense.enIssueReason.enReplacementForDamaged:
                    reason = "Replacement For Damaged";
                    break;
                case clsDataAccessLocalLicense.enIssueReason.enReplacementForLost:
                    reason = "Replacement For Lost";
                    break;
                default:
                    reason = "";
                    break;
            }

            return reason;
        }

        public static int GetLicenseNumberByAppNumber(int ApplicationNumber)
        {
            return clsDataAccessLocalLicense.GetLicenseNumberByAppNumber(ApplicationNumber);
        }



    }

}
