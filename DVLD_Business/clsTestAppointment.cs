using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        enum enMode { enAddNewTestAppointmentMode, enUpdateTestAppointmentInfoMode };

        private enMode Mode;

        public int TestAppointmentID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public bool IsLocked { get; set; }

        public decimal PaidFees { get; set; }

        public int RequestID { get; set; }

        public int TestTypeID { get; set; }

        public int RetakeTestAppNumber { get; set; }

        public clsRequestLocalLicense Request { get; set; }

        public clsTestType TestType { get; set; }

        public clsApplication RetakeTestApplication { get; set; }

        public clsTestAppointment()
        {
            TestAppointmentID = -1;
            AppointmentDate = DateTime.Now;
            IsLocked = false;
            PaidFees = 0;
            RequestID = -1;
            TestTypeID = -1;
            RetakeTestAppNumber = -1;

            Request = null;
            TestType = null;
            RetakeTestApplication = null;

            Mode = enMode.enAddNewTestAppointmentMode;
        }

        private clsTestAppointment(int TestAppointmentID, DateTime AppointmentDate, bool IsLocked, decimal PaidFees, int RequestID, int TestTypeID, int RetakeTestAppNumber)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.AppointmentDate = AppointmentDate;
            this.IsLocked = IsLocked;
            this.PaidFees = PaidFees;
            this.RequestID = RequestID;
            this.TestTypeID = TestTypeID;
            this.RetakeTestAppNumber = RetakeTestAppNumber;

            this.Request = clsRequestLocalLicense.FindRequestByID(RequestID);
            this.TestType = clsTestType.Find(TestTypeID);
            this.RetakeTestApplication = clsApplication.Find(RetakeTestAppNumber);

            Mode = enMode.enUpdateTestAppointmentInfoMode;
        }

        public static DataTable GetAllTestAppointmentsByRequestAndTestType(int RequestID, int TestTypeID)
        {
            return clsDataAccessTestAppointment.GetAllTestAppointmentsByRequestAndTestType(RequestID, TestTypeID);
        }

        public static clsTestAppointment Find(int TestAppointmentID)
        {
            DateTime AppointmentDate = DateTime.Now;
            bool IsLocked = false;
            decimal PaidFees = 0;
            int RequestID = -1;
            int TestTypeID = -1;
            int RetakeTestAppNumber = -1;

            if (clsDataAccessTestAppointment.GetTestAppointmentByID(TestAppointmentID, ref AppointmentDate, ref IsLocked, ref PaidFees, ref RequestID, ref TestTypeID, ref RetakeTestAppNumber))
            {
                return new clsTestAppointment(TestAppointmentID, AppointmentDate, IsLocked, PaidFees, RequestID, TestTypeID, RetakeTestAppNumber);
            }
            else
                return null;
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsDataAccessTestAppointment.AddNewTestAppointment(this.AppointmentDate, this.IsLocked, this.PaidFees, this.RequestID, this.TestTypeID, this.RetakeTestAppNumber);

            return this.TestAppointmentID != -1;
        }

        private bool _UpdateTestAppointment()
        {
            return clsDataAccessTestAppointment.UpdateTestAppointmentInfo(this.TestAppointmentID, this.AppointmentDate, this.IsLocked, this.PaidFees, this.RequestID, this.TestTypeID, this.RetakeTestAppNumber);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNewTestAppointmentMode:
                    if (_AddNewTestAppointment())
                    {
                        Mode = enMode.enUpdateTestAppointmentInfoMode;
                        return true;
                    }
                    else
                        return false;
                case enMode.enUpdateTestAppointmentInfoMode:
                    if (_UpdateTestAppointment())
                        return true;
                    else
                        return false;
            }

            return false;
        }

        public static bool IsTestAppointmentUnlocked(int RequestID)
        {
            return clsDataAccessTestAppointment.IsTestAppointmentUnocked(RequestID);
        }

        public static int GetNumOfTestTrialByRequest(int CurrentTestAppointmentID, int RequestID, int TestTypeID)
        {
            return clsDataAccessTestAppointment.GetNumOfTestTrialByRequest(CurrentTestAppointmentID, RequestID, TestTypeID);
        }

        public static bool DoesPassTestTypesByRequest(int RequestID, int TestTypeID)
        {
            return clsDataAccessTestAppointment.DoesPassTestTypesByRequest(RequestID, TestTypeID);
        }

    }
}
