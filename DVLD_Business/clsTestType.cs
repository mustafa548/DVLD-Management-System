using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsTestType
    {
        public int TestTypeID { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public decimal Fees { get; set; }

        public clsTestType()
        {
            TestTypeID = -1;
            Type = "";
            Description = "";
            Fees = 0;
        }

        private clsTestType(int TestTypeID, string Type, string Description, decimal Fees)
        {
            this.TestTypeID = TestTypeID;
            this.Type = Type;
            this.Description = Description;
            this.Fees = Fees;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsDataAccessTestTypes.GetAllTestTypes();
        }

        public static clsTestType Find(int TestTypeID)
        {
            string Type = "";
            string Description = "";
            decimal Fees = 0;

            if (clsDataAccessTestTypes.GetTestTypeByID(TestTypeID, ref Type, ref Description, ref Fees))
            {
                return new clsTestType(TestTypeID, Type, Description, Fees);
            }
            else
                return null;
        }

        public bool UpdateTestType()
        {
            return clsDataAccessTestTypes.UpdateTestType(this.TestTypeID, this.Type, this.Description, this.Fees);
        }
    }
}
