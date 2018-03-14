using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ManualTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Malthe", "Skov", "Mr", "CEO", "Sales", true, 1234567890, new DateTime(2000, 1, 1), 'M');

            string str1 = "Fulltime";
            string str2 = "Permanent";

            employee.MyStatus = (Status) Enum.Parse(typeof(Status), str1) | (Status) Enum.Parse(typeof(Status), str2);

            var arr = Enum.GetValues(typeof(Status));
            var arr1 = Enum.GetNames(typeof(Status));
        }
    }
}
