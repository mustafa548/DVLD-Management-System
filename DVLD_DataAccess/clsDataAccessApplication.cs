using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDataAccessApplication
    {
        public enum enStatus {enNew = 1, enCanceled = 2, enCompleted = 3}

        public static int AddNewApplication(enStatus Status, DateTime Date, int ApplicationTypeID, int PersonID, DateTime StatusDate, int CreatedByUserID)
        {
            int ApplicationNumber = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Applications (ApplicationStatus, ApplicationDate, ApplicationTypeID, PersonID, StatusDate, CreatedByUserID)
                            VALUES (@Status, @Date, @ApplicationTypeID, @PersonID, @StatusDate, @CreatedByUserID)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Status", (int)Status);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@StatusDate", StatusDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedApplication))
                    ApplicationNumber = insertedApplication;
            }
            catch (Exception ex)
            {
                ApplicationNumber = -1;
            }
            finally
            {
                connection.Close();
            }

            return ApplicationNumber;
        }

        public static bool UpdateApplicationInfo(int ApplicationNumber, enStatus Status, DateTime Date, int ApplicationTypeID, int PersonID, DateTime StatusDate, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Applications
                            SET ApplicationStatus = @Status,
                            ApplicationDate = @Date,
                            ApplicationTypeID = @ApplicationTypeID,
                            PersonID = @PersonID,
                            StatusDate = @StatusDate,
                            CreatedByUserID = @CreatedByUserID
                            WHERE ApplicationNumber = @ApplicationNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Status", (int)Status);
            command.Parameters.AddWithValue("@Date", Date);
            command.Parameters.AddWithValue("@StatusDate", StatusDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool DeleteApplication(int ApplicationNumber)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM Applications WHERE ApplicationNumber = @ApplicationNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);

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

        public static bool GetApplicationByID(int ApplicationNumber, ref enStatus Status, ref DateTime Date, ref int ApplicationTypeID, ref int PersonID, ref DateTime StatusDate, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Applications WHERE ApplicationNumber = @ApplicationNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Status = (enStatus)reader["ApplicationStatus"];
                    Date = (DateTime)reader["ApplicationDate"];
                    PersonID = (int)reader["PersonID"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    StatusDate = (DateTime)reader["StatusDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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
    }
}
