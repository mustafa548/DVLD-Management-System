using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDataAccessTestAppointment
    {
        public static DataTable GetAllTestAppointmentsByRequestAndTestType(int RequestID, int TestTypeID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT TestAppointmentID AS [Appointment ID], AppointmentDate AS [Appointment Date], 
                                PaidFees AS [Paid Fees], IsLocked AS [Is Locked] FROM TestAppointments WHERE RequestID = @RequestID AND TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RequestID", RequestID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        public static int AddNewTestAppointment(DateTime AppointmentDate, bool IsLocked, decimal PaidFees, int RequestID, int TestTypeID, int RetakeTestAppNumber)
        {
            int TestAppointmentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO TestAppointments (AppointmentDate, IsLocked, PaidFees, RequestID, TestTypeID, RetakeTestAppNumber)
                            VALUES (@AppointmentDate, @IsLocked, @PaidFees, @RequestID, @TestTypeID, @RetakeTestAppNumber)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@RequestID", RequestID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            if (RetakeTestAppNumber == -1)
                command.Parameters.AddWithValue("@RetakeTestAppNumber", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestAppNumber", RetakeTestAppNumber);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedTestAppointment))
                    TestAppointmentID = insertedTestAppointment;
            }
            catch (Exception ex)
            {
                TestAppointmentID = -1;
            }
            finally
            {
                connection.Close();
            }

            return TestAppointmentID;
        }

        public static bool UpdateTestAppointmentInfo(int TestAppointmentID, DateTime AppointmentDate, bool IsLocked, decimal PaidFees, int RequestID, int TestTypeID, int RetakeTestAppNumber)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE TestAppointments 
                            SET AppointmentDate = @AppointmentDate,
                            IsLocked = @IsLocked,
                            PaidFees = @PaidFees,
                            RequestID = @RequestID,
                            TestTypeID = @TestTypeID,
                            RetakeTestAppNumber = @RetakeTestAppNumber
                            WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@RequestID", RequestID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            if (RetakeTestAppNumber == -1)
                command.Parameters.AddWithValue("@RetakeTestAppNumber", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestAppNumber", RetakeTestAppNumber);

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

        public static bool IsTestAppointmentUnocked(int RequestID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT TOP 1 Found = 1 FROM TestAppointments
                                WHERE RequestID = @RequestID AND IsLocked = 0;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RequestID", RequestID);

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

        public static bool GetTestAppointmentByID(int TestAppointmentID, ref DateTime AppointmentDate, ref bool IsLocked, ref decimal PaidFees, ref int RequestID, ref int TestTypeID, ref int RetakeTestAppNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    IsLocked = (bool)reader["IsLocked"];
                    PaidFees = (decimal)reader["PaidFees"];
                    RequestID = (int)reader["RequestID"];
                    TestTypeID = (int)reader["TestTypeID"];

                    if (reader["RetakeTestAppNumber"] == System.DBNull.Value)
                        RetakeTestAppNumber = -1;
                    else
                        RetakeTestAppNumber = (int)reader["RetakeTestAppNumber"];
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

        public static int GetNumOfTestTrialByRequest(int CurrentTestAppointmentID, int RequestID, int TestTypeID)
        {
            int NumOfTestTrials = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT COUNT(*) FROM TestAppointments WHERE RequestID = @RequestID AND TestTypeID = @TestTypeID AND TestAppointmentID <> @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@RequestID", RequestID);
            command.Parameters.AddWithValue("@TestAppointmentID", CurrentTestAppointmentID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int numOfTrials))
                    NumOfTestTrials = numOfTrials;
            }
            catch (Exception ex)
            {
                NumOfTestTrials = 0;
            }
            finally
            {
                connection.Close();
            }

            return NumOfTestTrials;
        }

        public static bool DoesPassTestTypesByRequest(int RequestID, int TestTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT TOP 1 Found = 1 FROM TestAppointments
                            INNER JOIN Tests ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                            WHERE RequestID = @RequestID AND Tests.Result = 1 AND TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@RequestID", RequestID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
