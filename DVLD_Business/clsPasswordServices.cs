using BCrypt.Net;

namespace DVLD_Business
{
    public class clsPasswordServices
    {
        public static string HashPassword(string Password)
        {
            return BCrypt.Net.BCrypt.HashPassword(Password);
        }

        public static bool VerifyPassword(string Password, string PasswordHash)
        {
            return BCrypt.Net.BCrypt.Verify(Password, PasswordHash);
        }

    }
}
