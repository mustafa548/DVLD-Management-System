using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDataAccessDetainedLicenses
    {
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT DetainedLicenseID AS [D.ID], DetainedLicenses.LicenseNumber AS [L.ID], DetainedDate AS [D.Date], IsRealised AS [Is Realised], Fine AS [Fine Fees],
                            RealiseDate AS [Realise Date], Persons.NationalIDNumber AS [N.No], 
                            [Full Name] = Persons.FirstName + ' ' + Persons.SecondName + ' ' + Persons.ThirdName + ' ' + Persons.LastName,
                            DetainedLicenses.ApplicationNumber AS [Realise App.ID] FROM DetainedLicenses
                            INNER JOIN LocalLicenses ON LocalLicenses.LicenseNumber = DetainedLicenses.LicenseNumber
                            INNER JOIN Drivers ON Drivers.DriverID = LocalLicenses.DriverID
                            INNER JOIN Persons ON Persons.PersonID = Drivers.PersonID;";

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

        public static int AddNewDetainedLicense(DateTime DetainedDate, DateTime? RealiseDate, decimal Fine, int LicenseNumber,
            int ApplicationNumber, bool IsRealised)
        {
            int DetainedLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO DetainedLicenses (DetainedDate, RealiseDate, Fine, LicenseNumber, ApplicationNumber, IsRealised)
                            VALUES (@DetainedDate, @RealiseDate, @Fine, @LicenseNumber, @ApplicationNumber, @IsRealised)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainedDate", DetainedDate);
            command.Parameters.AddWithValue("@Fine", Fine);
            command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
            command.Parameters.AddWithValue("@IsRealised", IsRealised);

            if (RealiseDate == null)
                command.Parameters.AddWithValue("@RealiseDate", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@RealiseDate", RealiseDate);

            if (ApplicationNumber == -1)
                command.Parameters.AddWithValue("@ApplicationNumber", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@ApplicationNumber", ApplicationNumber);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedDetainedLicense))
                    DetainedLicenseID = insertedDetainedLicense;
            }
            catch (Exception ex)
            {
                DetainedLicenseID = -1;
            }
            finally
            {
                connection.Close();
            }

            return DetainedLicenseID;
        }

        public static bool UpdateDetainedLicenseInfo(int DetainedLicenseID, DateTime DetainedDate, DateTime? RealiseDate, decimal Fine, int LicenseNumber,
            int ApplicationNumber, bool IsRealised)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE DetainedLicenses
                            SET DetainedDate = @DetainedDate,
                            RealiseDate = @RealiseDate,
                            Fine = @Fine,
                            LicenseNumber = @LicenseNumber,
                            ApplicationNumber = @ApplicationNumber,
                            IsRealised = @IsRealised
                            WHERE DetainedLicenseID = @DetainedLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainedDate", DetainedDate);
            command.Parameters.AddWithValue("@Fine", Fine);
            command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);
            command.Parameters.AddWithValue("@IsRealised", IsRealised);
            command.Parameters.AddWithValue("@DetainedLicenseID", DetainedLicenseID);

            if (RealiseDate == null)
                command.Parameters.AddWithValue("@RealiseDate", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@RealiseDate", RealiseDate);

            if (ApplicationNumber == -1)
                command.Parameters.AddWithValue("@ApplicationNumber", System.DBNull.Value);
            else
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

        public static bool GetDetainedLicenseByID(int DetainedLicenseID, ref DateTime DetainedDate, ref DateTime? RealiseDate, ref decimal Fine, ref int LicenseNumber,
            ref int ApplicationNumber, ref bool IsRealised)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM DetainedLicenses WHERE DetainedLicenseID = @DetainedLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainedLicenseID", DetainedLicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    DetainedDate = (DateTime)reader["DetainedDate"];
                    Fine = (decimal)reader["Fine"];
                    LicenseNumber = (int)reader["LicenseNumber"];
                    IsRealised = (bool)reader["IsRealised"];

                    if (reader["RealiseDate"] == System.DBNull.Value)
                        RealiseDate = null;
                    else
                        RealiseDate = (DateTime?)reader["RealiseDate"];

                    if (reader["ApplicationNumber"] == System.DBNull.Value)
                        ApplicationNumber = -1;
                    else
                        ApplicationNumber = (int)reader["ApplicationNumber"];
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


        public static bool GetDetainedLicenseByLicenseNumber(ref int DetainedLicenseID, ref DateTime DetainedDate, ref DateTime? RealiseDate, ref decimal Fine, int LicenseNumber,
            ref int ApplicationNumber, ref bool IsRealised)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM DetainedLicenses WHERE LicenseNumber = @LicenseNumber AND IsRealised = 0;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseNumber", LicenseNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    DetainedDate = (DateTime)reader["DetainedDate"];
                    Fine = (decimal)reader["Fine"];
                    DetainedLicenseID = (int)reader["DetainedLicenseID"];
                    IsRealised = (bool)reader["IsRealised"];

                    if (reader["RealiseDate"] == System.DBNull.Value)
                        RealiseDate = null;
                    else
                        RealiseDate = (DateTime?)reader["RealiseDate"];

                    if (reader["ApplicationNumber"] == System.DBNull.Value)
                        ApplicationNumber = -1;
                    else
                        ApplicationNumber = (int)reader["ApplicationNumber"];
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
