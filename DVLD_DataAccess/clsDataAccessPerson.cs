using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDataAccessPerson
    {
        public enum enGender {enMale = 0, enFemale = 1};

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT PersonID AS [Person ID], NationalIDNumber AS [National ID Number], FirstName AS [First Name], SecondName AS [Second Name], ThirdName AS [Third Name], LastName AS [Last Name],
                            CASE Gender
	                            WHEN 0 THEN 'Male'
	                            WHEN 1 THEN 'Female'
                            END AS Gender, DateOfBirth AS [Date Of Birth], Countries.CountryName AS [Country], Phone, Email, Address FROM Persons
                            INNER JOIN Countries ON Countries.CountryID = Persons.CountryID;";

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
            catch(Exception ex)
            {
                // Error Handling
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName,
            string Email, string Phone, string Address,
            DateTime DateOfBirth, enGender Gender, string NationalIDNumber, string ImagePath, int CountryID)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"INSERT INTO Persons (FirstName, SecondName, ThirdName, LastName, Email, Phone, Address, DateOfBirth, Gender, NationalIDNumber, ImagePath, CountryID)
                            VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @Email, @Phone, @Address, @DateOfBirth, @Gender, @NationalIDNumber, @ImagePath, @CountryID)
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);

            bool value = false; // 0

            if (Gender == enGender.enFemale)
                value = true; // 1
            else
                value = false;

            command.Parameters.AddWithValue("@Gender", value);
            command.Parameters.AddWithValue("@NationalIDNumber", NationalIDNumber);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            if (Address != "")
                command.Parameters.AddWithValue("@Address", Address);
            else
                command.Parameters.AddWithValue("@Address", System.DBNull.Value);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedPerson))
                    PersonID = insertedPerson;
            }
            catch(Exception ex)
            {
                PersonID = -1;
            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool UpdatePersonInfo(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName,
            string Email, string Phone, string Address,
            DateTime DateOfBirth, enGender Gender, string NationalIDNumber, string ImagePath, int CountryID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE Persons
                            SET FirstName = @FirstName
                            ,SecondName = @SecondName
                            ,ThirdName = @ThirdName
                            ,LastName = @LastName
                            ,Email = @Email
                            ,Phone = @Phone
                            ,Address = @Address
                            ,DateOfBirth = @DateOfBirth
                            ,Gender = @Gender
                            ,NationalIDNumber = @NationalIDNumber
                            ,ImagePath = @ImagePath
                            ,CountryID = @CountryID
                            WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);


            bool value = false; // 0

            if (Gender == enGender.enFemale)
                value = true; // 1
            else
                value = false;

            command.Parameters.AddWithValue("@Gender", value);
            command.Parameters.AddWithValue("@NationalIDNumber", NationalIDNumber);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

            if (Address != "")
                command.Parameters.AddWithValue("@Address", Address);
            else
                command.Parameters.AddWithValue("@Address", System.DBNull.Value);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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

        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"DELETE FROM Persons WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsPersonExists(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Persons WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    isFound = true;
            }
            catch(Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetPersonByID(int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
            ref string Email, ref string Phone, ref string Address,
            ref DateTime DateOfBirth, ref enGender Gender, ref string NationalIDNumber, ref string ImagePath, ref int CountryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Persons WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (bool)reader["Gender"] ? enGender.enFemale : enGender.enMale;
                    NationalIDNumber = (string)reader["NationalIDNumber"];
                    CountryID = (int)reader["CountryID"];

                    if (reader["Address"] != System.DBNull.Value)
                        Address = (string)reader["Address"];
                    else
                        Address = "";

                    if (reader["ImagePath"] != System.DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

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

        public static bool GetPersonByNationalIDNumber(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
            ref string Email, ref string Phone, ref string Address,
            ref DateTime DateOfBirth, ref enGender Gender, string NationalIDNumber, ref string ImagePath, ref int CountryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Persons WHERE NationalIDNumber = @NationalIDNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalIDNumber", NationalIDNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (bool)reader["Gender"] ? enGender.enFemale : enGender.enMale;
                    CountryID = (int)reader["CountryID"];

                    if (reader["Address"] != System.DBNull.Value)
                        Address = (string)reader["Address"];
                    else
                        Address = "";

                    if (reader["ImagePath"] != System.DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

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

        public static bool GetPersonByPhone(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
            ref string Email, string Phone, ref string Address,
            ref DateTime DateOfBirth, ref enGender Gender, ref string NationalIDNumber, ref string ImagePath, ref int CountryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT * FROM Persons WHERE Phone = @Phone;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Phone", Phone);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    NationalIDNumber = (string)reader["NationalIDNumber"];
                    Gender = (bool)reader["Gender"] ? enGender.enFemale : enGender.enMale;
                    CountryID = (int)reader["CountryID"];

                    if (reader["Address"] != System.DBNull.Value)
                        Address = (string)reader["Address"];
                    else
                        Address = "";

                    if (reader["ImagePath"] != System.DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

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


        public static bool IsPersonExists(string NationalIDNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Persons WHERE NationalIDNumber = @NationalIDNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalIDNumber", NationalIDNumber);

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

        public static bool IsPersonExistsByPhone(string Phone)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT Found = 1 FROM Persons WHERE Phone = @Phone;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Phone", Phone);

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
