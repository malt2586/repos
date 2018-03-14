using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;

namespace DBAccess
{
    public class DatabaseHandler
    {
        //FIELDS
        private readonly string connectionString;

        //PROPERTIES

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
        public List<Employee> GetEmployees()
        {
            List<Employee> allEmployees = new List<Employee>();
            string query = "SELECT * FROM Employees";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string firstname = reader["FirstName"].ToString();
                        string lastname = reader["LastName"].ToString();
                        string titleOfCourtesy = reader["TitleOfCourtesy"].ToString();
                        string title = reader["Title"].ToString();
                        string position = reader["Position"].ToString();
                        bool isHourlyPaid = (bool)reader["IsHourlyPaid"];
                        int employeeId = (int)reader["EmployeeId"];
                        DateTime hireDate = (DateTime)reader["HireDate"];
                        char sex = char.Parse(reader["Sex"].ToString());
                        Employee employee = new Employee(firstname, lastname, titleOfCourtesy, title, position, isHourlyPaid, employeeId, hireDate, sex);
                        allEmployees.Add(employee);
                    }
                }
            }
            catch (ObjectDisposedException) { throw; }
            catch (InvalidOperationException) { throw; }
            catch (InvalidCastException) { throw; }
            catch (SqlException) { throw; }
            catch (System.IO.IOException) { throw; }

            return allEmployees;
        }
        public void AddEmployee(Employee employee)
        {
            try
            {
                string query = $"INSERT INTO Employees VALUES('{employee.Contact.Firstname}', '{employee.Contact.Lastname}', '{employee.Contact.TitleOfCourtesy}', '{employee.Contact.Title}', '{employee.Contact.Position}', '{employee.IsHourlyPaid}', {employee.EmployeeId}, '{employee.HireDate}', '{employee.Sex}')";
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
    }
}
