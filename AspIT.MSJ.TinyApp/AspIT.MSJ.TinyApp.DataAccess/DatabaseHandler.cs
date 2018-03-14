using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspIT.MSJ.TinyApp.Core;
using System.Data.SqlClient;

namespace AspIT.MSJ.TinyApp.DataAccess
{
    public class DatabaseHandler
    {
        //FIELDS
        private readonly string connectionString;

        //CONSTRUCTORS
        public DatabaseHandler(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException(nameof(connectionString));
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (ArgumentException) { throw; }
            catch (InvalidOperationException) { throw; }
            catch (SqlException) { throw; }

            this.connectionString = connectionString;
        }

        //METHODS
        public List<UserCredentials> GetAll()
        {
            List<UserCredentials> allCredentials = new List<UserCredentials>(0);
            string query = "SELECT * FROM UserCredentials";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string username = reader["Username"].ToString();
                        string password = reader["Password"].ToString();
                        UserCredentials credentials = new UserCredentials(username, password);
                        allCredentials.Add(credentials);
                    }
                }
            }
            catch (ObjectDisposedException) { throw; }
            catch (InvalidOperationException) { throw; }
            catch (InvalidCastException) { throw; }
            catch (SqlException) { throw; }
            catch (System.IO.IOException) { throw; }

            return allCredentials;
        }

        public void Add(UserCredentials credentials)
        {
            try
            {
                string query = "INSERT INTO UserCredentials (Username, Password) " + $"VALUES('{credentials.Username}', '{credentials.Password}')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (InvalidOperationException) { throw; }
            catch (SqlException) { throw; }
        }

        public bool IsValid(UserCredentials credentials)
        {
            try
            {
                string query = "SELECT * FROM UserCredentials WHERE " + $"Username = '{credentials.Username}' AND Password = '{credentials.Password}'";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (ObjectDisposedException) { throw; }
            catch (InvalidOperationException) { throw; }
            catch (InvalidCastException) { throw; }
            catch (SqlException) { throw; }
            catch (System.IO.IOException) { throw; }
        }
    }
}
