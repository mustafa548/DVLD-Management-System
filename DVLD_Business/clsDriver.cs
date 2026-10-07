using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsDriver
    {
        enum enMode { enAddNewDriverMode, enUpdateDriveInfoMode };

        private enMode Mode;

        public int DriverID { get; set; }

        public int PersonID { get; set; }

        public DateTime CreatedDate { get; set; }

        public clsPerson PersonInfo { get; set; }

        public clsDriver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedDate = DateTime.Now;

            PersonInfo = null;

            Mode = enMode.enAddNewDriverMode;
        }

        private clsDriver(int DriverID, int PersonID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedDate = CreatedDate;

            this.PersonInfo = clsPerson.Find(PersonID);

            Mode = enMode.enUpdateDriveInfoMode;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDataAccessDriver.GetAllDriver();
        }

        public static clsDriver Find(int DriverID)
        {
            int PersonID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDataAccessDriver.GetDriverByID(DriverID, ref PersonID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedDate);
            }
            else
                return null;
        }

        public static clsDriver FindByPerson(int PersonID)
        {
            int DriverID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDataAccessDriver.GetDriverByPersonID(ref DriverID, PersonID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedDate);
            }
            else
                return null;
        }

        private bool _AddNewDriver()
        {
            this.DriverID = clsDataAccessDriver.AddNewDriver(this.PersonID, this.CreatedDate);

            return this.DriverID != -1;
        }

        private bool _UpdateDriver()
        {
            return clsDataAccessDriver.UpdateDriverInfo(this.DriverID, this.PersonID, this.CreatedDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNewDriverMode:
                    if (_AddNewDriver())
                    {
                        Mode = enMode.enUpdateDriveInfoMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.enUpdateDriveInfoMode:
                    if (_UpdateDriver())
                        return true;
                    else
                        return false;
            }

            return false;
        }
    }
}
