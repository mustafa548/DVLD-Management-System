using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsRequestLocalLicense : clsApplication
    {
        public int RequestID { get; set; }

        public int LicenseClassID { get; set; }

        public int PassedTests { get; set; }

        public clsLicenseClass LicenseClassInfo { get; set; }

        public clsRequestLocalLicense() : base()
        {
            ApplicationNumber = -1;
            RequestID = -1;
            LicenseClassID = -1;
            PassedTests = 0;

            LicenseClassInfo = null;
            CreatedByUser = null;
        }

        private clsRequestLocalLicense(int ApplicationNumber, clsDataAccessApplication.enStatus Status, DateTime Date,
            int ApplicationTypeID, int PersonID, DateTime StatusDate, int RequestID, int LicenseClassID, int PassedTests, int CreatedByUserID) : base(ApplicationNumber, Status, Date, ApplicationTypeID, PersonID, StatusDate, CreatedByUserID)
        {
            this.RequestID = RequestID;
            this.LicenseClassID = LicenseClassID;
            this.PassedTests = PassedTests;

            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
        }

        public static clsRequestLocalLicense FindRequestByID(int RequestID)
        {
            int ApplicationNumber = 0;
            int LicenseClassID = 0;
            int PassedTests = 0;

            if (clsDataAccessRequestLocalLicense.GetRequestByID(RequestID, ref ApplicationNumber, ref LicenseClassID, ref PassedTests))
            {
                clsApplication Application = clsApplication.Find(ApplicationNumber);

                if (Application != null)
                    return new clsRequestLocalLicense(ApplicationNumber, Application.Status, Application.Date, Application.ApplicationTypeID, Application.PersonID, Application.StatusDate, RequestID, LicenseClassID, PassedTests, Application.CreatedByUserID);
            }

            return null;
        }

        public static bool DeleteRequest(int RequestID)
        {
            clsRequestLocalLicense Request = FindRequestByID(RequestID);

            if (Request != null)
            {
                if (!clsDataAccessRequestLocalLicense.DeleteRequest(RequestID))
                    return false;
            }

            return clsApplication.DeleteApplication(Request.ApplicationNumber);
        }

        private bool _AddNewRequest()
        {
            if (!base.Save())
                return false;

            this.RequestID = clsDataAccessRequestLocalLicense.AddNewRequest(this.LicenseClassID, this.ApplicationNumber, this.PassedTests);

            return this.RequestID != -1;
        }

        private bool _UpdateRequest()
        {
            if (!base.Save())
                return false;

            return clsDataAccessRequestLocalLicense.UpdateRequestInfo(this.RequestID, this.ApplicationNumber, this.LicenseClassID, this.PassedTests);
        }

        public override bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNewApplicationMode:
                    if (_AddNewRequest())
                    {
                        Mode = enMode.enUpdateApplicationInfoMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.enUpdateApplicationInfoMode:
                    if (_UpdateRequest())
                        return true;
                    else
                        return false;
            }

            return false;
        }

        public static DataTable GetAllRequests()
        {
            return clsDataAccessRequestLocalLicense.GetAllRequests();
        }

        public static bool DoesPersonHaveActiveOrCompletedRequest(int PersonID, int LicenseClassID)
        {
            return clsDataAccessRequestLocalLicense.DoesPersonHaveActiveOrCompletedRequest(PersonID, LicenseClassID);
        }

    }
}
