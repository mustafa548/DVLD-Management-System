using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        public int ApplicationTypeID { get; set; }

        public string ApplicationName { get; set; }

        public decimal ApplicationFees { get; set; }

        public clsApplicationType()
        {
            ApplicationTypeID = -1;
            ApplicationName = "";
            ApplicationFees = 0;
        }

        private clsApplicationType(int ApplicationTypeID, string ApplicationName, decimal ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationName   = ApplicationName;
            this.ApplicationFees   = ApplicationFees;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsDataAccessApplicationTypes.GetAllApplicationTypes();
        }

        public static clsApplicationType Find(int ApplicationTypeID)
        {
            string ApplicationName = "";
            decimal ApplicationFees    = 0;

            if (clsDataAccessApplicationTypes.GetApplicationTypeByID(ApplicationTypeID, ref ApplicationName, ref ApplicationFees))
            {
                return new clsApplicationType(ApplicationTypeID, ApplicationName, ApplicationFees);
            }
            else
                return null;
        }

        public bool UpdateApplicationType()
        {
            return clsDataAccessApplicationTypes.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationName, this.ApplicationFees);
        }
    }
}
