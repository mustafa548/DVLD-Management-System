using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDataAccessLocalLicense
    {
        public enum enIssueReason {enFirstTime = 1, enReplacementForLost = 2, enReplacementForDamaged = 3, enRenew = 4}

        public static DataTable GetAllLocalLicensesByPerson(int PersonID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT LicenseNumber AS [License ID], ApplicationNumber AS [App ID], LicenseClasses.Name AS [Class Name],
                            IssueDate AS [Issue Date], ExpirationDate AS [Expiration Date], IsActive AS [Is Active] FROM LocalLicenses
                            INNER JOIN LicenseClasses ON LicenseClasses.LicenseClassID = LocalLicenses.LicenseClassID
                            INNER JOIN Drivers ON Drivers.DriverID = LocalLicenses.DriverID
                            WHERE Drivers.PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Error Handling
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddNewLocalLicense(enIssueReason IssueReason, DateTime IssueDate, DateTime ExpirationDate,
            string Remarks, int LicenseClassID, int ApplicationNumber, int DriverID, bool IsActive, bool IsDetained)
        {
            int LicenseNumber = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO LocalLicenses (IssueReason, IssueDate, ExpirationDate, Remarks, LicenseClassID, ApplicationNumber, DriverID, IsActive, IsDetained)
                            VALUES (@IssueReason, @IssueDate, @ExpirationDate, @Remarks, @LicenseClassID, @ApplicationNumber, @DriverID, @IsActive, @IsDetained);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IssueReason", (int)IssueReason);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IsDetained", IsDetained);

            if (Remarks == "")
                command.Parameters.AddWithValue("@Remarks", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Remarks", Remarks);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedLocalLicense))
                    LicenseNumber = insertedLocalLicense;
            }
            catch (Exception ex)
            {
                LicenseNumber = -1;
            }
            finally
            {
                connection.Close();
            }

            return LicenseNumber;
        }

        public static bool UpdateLocalLicenseInfo(int LicenseNumber, enIssueReason IssueReason, DateTime IssueDate, DateTime ExpirationDate,
            string Remarks, int LicenseClassID, int ApplicationNumber, int DriverID, bool IsActive, bool IsDetained)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE LocalLicenses
                            SET IssueReason = @IssueReason,
                            IssueDate = @IssueDate,
                            ExpirationDate = @ExpirationDate,
                            Remarks = @Remarks,
                            LicenseClassID = @LicenseClassID,
                            ApplicationNumber = @ApplicationNumber,
                            DriverID = @DriverID,
                            IsActive = @IsActive,
                            IsDetained = @IsDetained
                            WHERE LicenseNumber = @LicenseNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IssueReason", (int)IssueReason);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
            command.Parameters.AddWithValue("@IsDetained", IsDetained);

            if (Remarks == "")
                command.Parameters.AddWithValue("@Remarks", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Remarks", Remarks);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                rowsAffected = 0;
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected > 0;
        }

        public static bool GetLocalLicenseByID(int LicenseNumber, ref enIssueReason IssueReason, ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref string Remarks, ref int LicenseClassID, ref int ApplicationNumber, ref int DriverID, ref bool IsActive, ref bool IsDetained)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM LocalLicenses WHERE LicenseNumber = @LicenseNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    IssueReason = (enIssueReason)reader["IssueReason"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    ApplicationNumber = (int)reader["ApplicationNumber"];
                    DriverID = (int)reader["DriverID"];
                    IsDetained = (bool)reader["IsDetained"];

                    if (reader["Remarks"] == System.DBNull.Value)
                        Remarks = "";
                    else
                        Remarks = (string)reader["Remarks"];
                }
                else
                    isFound = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int GetLicenseNumberByAppNumber(int ApplicationNumber)
        {
            int LicenseNumber = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT LicenseNumber FROM LocalLicenses WHERE ApplicationNumber = @ApplicationNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int findedLicenseNumber))
                    LicenseNumber = findedLicenseNumber;

            }
            catch (Exception ex)
            {
                LicenseNumber = -1;
            }
            finally
            {
                connection.Close();
            }

            return LicenseNumber;
        }

    }
}
