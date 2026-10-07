using System;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsApplication
    {
        public enum enMode { enAddNewApplicationMode, enUpdateApplicationInfoMode };

        protected enMode Mode;

        public int ApplicationNumber { get; set; }

        public clsDataAccessApplication.enStatus Status { get; set; }

        public DateTime Date { get; set; }

        public int ApplicationTypeID { get; set; }

        public int PersonID { get; set; }

        public DateTime StatusDate { get; set; }

        public int CreatedByUserID { get; set; }

        public clsUser CreatedByUser { get; set; }

        public clsApplicationType ApplicationType { get; set; }

        public clsPerson PersonInfo { get; set; }

        public clsApplication()
        {
            ApplicationNumber = -1;
            Status = clsDataAccessApplication.enStatus.enNew;
            Date = DateTime.Now;
            StatusDate = Date;
            ApplicationTypeID = -1;
            PersonID = -1;
            CreatedByUserID = -1;

            CreatedByUser = null;
            ApplicationType = null;
            PersonInfo = null;

            Mode = enMode.enAddNewApplicationMode;
        }

        protected clsApplication(int ApplicationNumber, clsDataAccessApplication.enStatus Status, DateTime Date, int ApplicationTypeID, int PersonID, DateTime StatusDate, int CreatedByUserID)
        {
            this.ApplicationNumber = ApplicationNumber;
            this.Status = Status;
            this.Date = Date;
            this.ApplicationTypeID = ApplicationTypeID;
            this.PersonID = PersonID;
            this.StatusDate = StatusDate;
            this.CreatedByUserID = CreatedByUserID;

            this.CreatedByUser = clsUser.Find(CreatedByUserID);
            this.PersonInfo = clsPerson.Find(PersonID);
            this.ApplicationType = clsApplicationType.Find(ApplicationTypeID);

            Mode = enMode.enUpdateApplicationInfoMode;
        }

        public static clsApplication Find(int ApplicationNumber)
        {
            clsDataAccessApplication.enStatus Status = clsDataAccessApplication.enStatus.enNew;
            DateTime Date = DateTime.Now;
            int ApplicationTypeID = -1;
            int PersonID = -1;
            DateTime StatusDate = DateTime.Now;
            int CreatedByUserID = -1;

            if (clsDataAccessApplication.GetApplicationByID(ApplicationNumber, ref Status, ref Date, ref ApplicationTypeID, ref PersonID, ref StatusDate, ref CreatedByUserID))
            {
                return new clsApplication(ApplicationNumber, Status, Date, ApplicationTypeID, PersonID, StatusDate, CreatedByUserID);
            }
            else
                return null;
        }

        public static bool DeleteApplication(int ApplicationNumber)
        {
            return clsDataAccessApplication.DeleteApplication(ApplicationNumber);
        }

        private bool _AddNewApplication()
        {
            this.ApplicationNumber = clsDataAccessApplication.AddNewApplication(this.Status, this.Date, this.ApplicationTypeID, this.PersonID, this.StatusDate, this.CreatedByUserID);

            return this.ApplicationNumber != -1;
        }

        private bool _UpdateApplication()
        {
            return clsDataAccessApplication.UpdateApplicationInfo(this.ApplicationNumber, this.Status, this.Date, this.ApplicationTypeID, this.PersonID, this.StatusDate, this.CreatedByUserID);
        }

        public virtual bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNewApplicationMode:
                    if (_AddNewApplication())
                    {
                        Mode = enMode.enUpdateApplicationInfoMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.enUpdateApplicationInfoMode:
                    if (_UpdateApplication())
                        return true;
                    else
                        return false;
            }

            return false;
        }

        public bool IsCanceledStatus()
        {
            return this.Status == clsDataAccessApplication.enStatus.enCanceled;
        }

        public bool IsCompletedStatus()
        {
            return this.Status == clsDataAccessApplication.enStatus.enCompleted;
        }

        public bool CancelStatus()
        {
            this.Status = clsDataAccessApplication.enStatus.enCanceled;
            this.StatusDate = DateTime.Now;
            return this.Save();
        }

        public bool CompleteStatus()
        {
            this.Status = clsDataAccessApplication.enStatus.enCompleted;
            this.StatusDate = DateTime.Now;
            return this.Save();
        }

        public string GetStatusAsString()
        {
            if (Status == clsDataAccessApplication.enStatus.enNew)
                return "New";
            else if (Status == clsDataAccessApplication.enStatus.enCanceled)
                return "Canceled";

            return "Completed";
        }

    }
}
