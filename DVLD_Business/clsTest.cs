using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsTest
    {
        public int TestID { get; set; }

        public bool Result { get; set; }

        public string Notes { get; set; }

        public int TestAppointmentID { get; set; }

        public clsTestAppointment TestAppointment { get; set; }

        public clsTest()
        {
            TestID = -1;
            Result = false;
            Notes = "";
            TestAppointmentID = -1;

            TestAppointment = null;
        }

        private clsTest(int TestID, bool Result, string Notes, int TestAppointmentID)
        {
            this.TestID = TestID;
            this.Result = Result;
            this.Notes = Notes;
            this.TestAppointmentID = TestAppointmentID;

            this.TestAppointment = clsTestAppointment.Find(TestAppointmentID);
        }

        public static clsTest Find(int TestID)
        {
            bool Result = false;
            string Notes = "";
            int TestAppointmentID = -1;

            if (clsDataAccessTests.GetTestByID(TestID, ref Result, ref Notes, ref TestAppointmentID))
            {
                return new clsTest(TestID, Result, Notes, TestAppointmentID);
            }
            else
                return null;
        }

        public bool AddNewTest()
        {
            this.TestID = clsDataAccessTests.AddNewTest(this.Result, this.Notes, this.TestAppointmentID);

            return this.TestID != -1;
        }

    }
}
