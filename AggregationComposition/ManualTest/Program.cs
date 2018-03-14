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
            Employee empl = new Employee("Napoleon", "Bonaparte", "1234567890", 60000, 2000, 4000); 
            Department dept = new Department(new List<Employee>(), 400000);
            dept.Add(empl);
            dept.Add(empl);
            dept.Remove(empl);

            Console.WriteLine("Monthly payout: " + empl.GetMonthlyPayout());
            Console.WriteLine("Yearly payout: " + empl.GetYearlyPayout());
            Console.WriteLine(empl.GetMonthlyPayout() * 12 + empl.ChristmasBonus);

            Console.WriteLine(dept.GetEmployeeBy("1234567890"));
            Console.WriteLine(dept.GetEmployeeBy("Napoleon", "Bonaparte"));

            dept.Add(empl);
            Console.WriteLine(dept.MonthlyPayout);
            Console.WriteLine(dept.YearlyPayout);

            Console.WriteLine(dept.IsBudgetExceeded);

            Console.ReadKey();
        }
    }
}
