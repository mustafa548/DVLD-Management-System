using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDataAccessRequestLocalLicense
    {
        public static DataTable GetAllRequests()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT RequestID AS [Request ID], LicenseClasses.Name AS [Driving Class], Persons.NationalIDNumber AS [National No], 
                            [Full Name] = Persons.FirstName + ' ' + Persons.SecondName + ' ' + Persons.ThirdName + ' ' + Persons.LastName,
                            Applications.ApplicationDate AS Date, PassedTests AS [Passed Tests], CASE Applications.ApplicationStatus 
	                            WHEN 1 THEN 'New'
	                            WHEN 2 THEN 'Canceled'
	                            WHEN 3 THEN 'Completed'
                            END AS Status
                            FROM RequestsLocalLicenses
                            INNER JOIN LicenseClasses ON LicenseClasses.LicenseClassID = RequestsLocalLicenses.LicenseClassID
                            INNER JOIN Applications ON Applications.ApplicationNumber = RequestsLocalLicenses.ApplicationNumber
                            INNER JOIN Persons ON Applications.PersonID = Persons.PersonID;";

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
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddNewRequest(int LicenseClassID, int ApplicationNumber, int PassedTests)
        {
            int RequestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO RequestsLocalLicenses (ApplicationNumber, LicenseClassID, PassedTests)
                            VALUES (@ApplicationNumber, @LicenseClassID, @PassedTests)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@PassedTests", PassedTests);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedRequest))
                    RequestID = insertedRequest;
            }
            catch (Exception ex)
            {
                RequestID = -1;
            }
            finally
            {
                connection.Close();
            }

            return RequestID;
        }

        public static bool UpdateRequestInfo(int RequestID, int ApplicationNumber, int LicenseClassID, int PassedTests)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE RequestsLocalLicenses
                            SET ApplicationNumber = @ApplicationNumber,
                            LicenseClassID = @LicenseClassID,
                            PassedTests = @PassedTests
                            WHERE RequestID = @RequestID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@PassedTests", PassedTests);
            command.Parameters.AddWithValue("@RequestID", RequestID);

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

        public static bool DeleteRequest(int RequestID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM RequestsLocalLicenses WHERE RequestID = @RequestID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RequestID", RequestID);

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

        public static bool GetRequestByID(int RequestID, ref int ApplicationNumber, ref int LicenseClassID, ref int PassedTests)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM RequestsLocalLicenses WHERE RequestID = @RequestID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RequestID", RequestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ApplicationNumber = (int)reader["ApplicationNumber"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    PassedTests = (int)reader["PassedTests"];
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

        public static bool DoesPersonHaveActiveOrCompletedRequest(int PersonID, int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT TOP 1 Found = 1 FROM RequestsLocalLicenses
                            INNER JOIN Applications ON Applications.ApplicationNumber = RequestsLocalLicenses.ApplicationNumber
                            WHERE Applications.PersonID = @PersonID AND LicenseClassID = @LicenseClassID AND Applications.ApplicationStatus <> 2;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
            }
            catch (Exception ex)
            {
                //isFound = false;
                throw;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }
}
