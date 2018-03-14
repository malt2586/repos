using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        //FIELDS
        private int id;
        private string firstName;
        private string lastName;
        //private string name;
        private int salary;
        //private int annualSalary;
        
        //PROPERTIES
        public int ID
        {
            get { return id; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Name
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int AnnualSalary
        {
            get
            {
                return salary * 12;
            }
        }

        //CONSTRUCTORS
        public Employee(int id, string firstName, string lastName, int salary)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        //METHODS
        public int RaiseSalary(int percent)
        {
            int newSalary;
            newSalary = salary + ((salary / 100) * percent);
            salary = newSalary;
            return salary;
        }
        public override string ToString()
        {
            return $"Employee[Name: {Name}, Salary: {Salary}]";
        }
    }
}
