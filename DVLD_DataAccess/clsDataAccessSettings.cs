using System.Configuration;

namespace DVLD_DataAccess
{
    public class clsDataAccessSettings
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    }
}
