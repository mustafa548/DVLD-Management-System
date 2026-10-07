using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDataAccessInternationalLicense
    {
        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT InternationalLicenseID AS [Int. License ID], InternationalLicenses.ApplicationNumber AS [Application ID], LocalLicenses.DriverID AS [Driver ID],
                            InternationalLicenses.LicenseNumber AS [L.License ID], InternationalLicenses.IssueDate AS [Issue Date], ExpiryDate AS [Expiration Date],
                            CAST (
                                CASE 
                                    WHEN ExpiryDate > CAST(GETDATE() AS DATE) THEN 1
                                    ELSE 0
                                END AS BIT
                            ) AS [Is Active]
                            FROM InternationalLicenses
                            INNER JOIN LocalLicenses ON LocalLicenses.LicenseNumber = InternationalLicenses.LicenseNumber;";

            SqlCommand command = new SqlCommand(query, connection);

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
                throw;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static DataTable GetAllInternationalLicensesByPerson(int PersonID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT InternationalLicenseID AS [Int.License ID], InternationalLicenses.ApplicationNumber AS [Application ID], InternationalLicenses.LicenseNumber AS [L.License ID],
                            InternationalLicenses.IssueDate AS [Issue Date], ExpiryDate AS [Expiration Date],
                            CAST (
                                CASE 
                                    WHEN ExpiryDate > CAST(GETDATE() AS DATE) THEN 1
                                    ELSE 0
                                END AS BIT
                            ) AS [Is Active] FROM InternationalLicenses
                            INNER JOIN LocalLicenses ON LocalLicenses.LicenseNumber = InternationalLicenses.LicenseNumber
                            INNER JOIN Drivers ON LocalLicenses.DriverID = Drivers.DriverID
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
                throw;
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddNewInternationalLicense (DateTime IssueDate, DateTime ExpiryDate, int ApplicationNumber, int LicenseNumber)
        {
            int InternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO InternationalLicenses (IssueDate, ExpiryDate, ApplicationNumber, LicenseNumber)
                            VALUES (@IssueDate, @ExpiryDate, @ApplicationNumber, @LicenseNumber)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
            command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);
            command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedInternationalLicense))
                    InternationalLicenseID = insertedInternationalLicense;
            }
            catch (Exception ex)
            {
                InternationalLicenseID = -1;
            }
            finally
            {
                connection.Close();
            }

            return InternationalLicenseID;
        }

        public static bool GetInternationalLicenseByID(int InternationalLicenseID, ref DateTime IssueDate, ref DateTime ExpiryDate,
            ref int ApplicationNumber, ref int LicenseNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpiryDate = (DateTime)reader["ExpiryDate"];
                    ApplicationNumber = (int)reader["ApplicationNumber"];
                    LicenseNumber = (int)reader["LicenseNumber"];
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

        public static bool IsInternationalLicenseExistsByDriverID(int DriverID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT TOP 1 Found = 1 FROM InternationalLicenses
                            INNER JOIN LocalLicenses ON InternationalLicenses.LicenseNumber = LocalLicenses.LicenseNumber
                            WHERE LocalLicenses.DriverID = @DriverID AND InternationalLicenses.ExpiryDate > CAST(GETDATE() AS DATE);";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
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

    }
}
