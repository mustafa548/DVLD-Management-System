using System.Configuration;

namespace DVLD_Business
{
    public class clsSettings
    {
        public static string appPassword = ConfigurationManager.AppSettings["AppPassword"];

        public static string fromEmail = ConfigurationManager.AppSettings["FromEmail"];

    }
}
