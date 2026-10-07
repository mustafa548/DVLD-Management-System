using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDataAccessUser
    {
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT UserID AS [User ID], Users.PersonID AS [Person ID], 
                            [Full Name] = Persons.FirstName + ' ' + Persons.SecondName + ' ' + Persons.ThirdName + ' ' +
                            Persons.LastName, UserName AS [User Name], IsActive AS [Is Active]
                            FROM Users
                            INNER JOIN Persons ON Users.PersonID = Persons.PersonID;";

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

        public static int AddNewUser(string UserName, string Password, int PersonID, bool IsActive)
        {
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Users (UserName, Password, PersonID, IsActive, Attempts)
                            VALUES (@UserName, @Password, @PersonID, @IsActive, 3)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedUser))
                    UserID = insertedUser;
            }
            catch (Exception ex)
            {
                UserID = -1;
            }
            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUserInfo(int UserID, string UserName, string Password, int PersonID,
            bool IsActive, int Attempts, DateTime? PasswordBlockedUntil, DateTime? LastAttemptAt)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Users
                            SET UserName = @UserName
                            ,Password = @Password
                            ,PersonID = @PersonID
                            ,IsActive = @IsActive
                            ,Attempts = @Attempts
                            ,PasswordBlockedUntil = @PasswordBlockedUntil
                            ,LastAttemptAt = @LastAttemptAt
                            WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Attempts", Attempts);

            if (PasswordBlockedUntil == null)
                command.Parameters.AddWithValue("@PasswordBlockedUntil", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@PasswordBlockedUntil", PasswordBlockedUntil);

            if (LastAttemptAt == null)
                command.Parameters.AddWithValue("@LastAttemptAt", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@LastAttemptAt", LastAttemptAt);

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

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM Users WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExists(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Users WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool IsUserExists(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Users WHERE UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

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

        public static bool IsUserExistsByPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Users WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool GetUserByID(int UserID, ref string UserName,ref string Password, ref int PersonID,
            ref bool IsActive, ref int Attempts, ref DateTime? PasswordBlockedUntil, ref DateTime? LastAttemptAt)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Users WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserName             = (string)reader["UserName"];
                    Password             = (string)reader["Password"];
                    PersonID             = (int)reader["PersonID"];
                    IsActive             = (bool)reader["IsActive"];
                    Attempts             = (int)reader["Attempts"];

                    if (reader["PasswordBlockedUntil"] == System.DBNull.Value)
                        PasswordBlockedUntil = null;
                    else
                        PasswordBlockedUntil = (DateTime?)reader["PasswordBlockedUntil"];

                    if (reader["LastAttemptAt"] == System.DBNull.Value)
                        LastAttemptAt = null;
                    else
                        LastAttemptAt = (DateTime?)reader["LastAttemptAt"];
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

        public static bool GetUserByUserName(ref int UserID, string UserName, ref string Password, ref int PersonID,
            ref bool IsActive, ref int Attempts, ref DateTime? PasswordBlockedUntil, ref DateTime? LastAttemptAt)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Users WHERE UserName COLLATE SQL_Latin1_General_CP1_CS_AS = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                    Attempts = (int)reader["Attempts"];

                    if (reader["PasswordBlockedUntil"] == System.DBNull.Value)
                        PasswordBlockedUntil = null;
                    else
                        PasswordBlockedUntil = (DateTime?)reader["PasswordBlockedUntil"];

                    if (reader["LastAttemptAt"] == System.DBNull.Value)
                        LastAttemptAt = null;
                    else
                        LastAttemptAt = (DateTime?)reader["LastAttemptAt"];
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
