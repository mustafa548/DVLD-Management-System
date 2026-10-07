using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDataAccessTests
    {
        public static int AddNewTest(bool Result, string Notes, int TestAppointmentID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Tests (Result, Notes, TestAppointmentID)
                            VALUES (@Result, @Notes, @TestAppointmentID)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Result", Result);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            if (Notes == "")
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedTest))
                    TestID = insertedTest;
            }
            catch (Exception ex)
            {
                TestID = -1;
            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }

        public static bool GetTestByID(int TestID, ref bool Result, ref string Notes, ref int TestAppointmentID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Tests WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Result = (bool)reader["Result"];
                    TestAppointmentID = (int)reader["TestAppointmentID"];

                    if (reader["Notes"] == System.DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];
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
