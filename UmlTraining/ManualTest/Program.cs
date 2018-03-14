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
            //Opgave 3.1 Rektangel
            Rectangle rectangle = new Rectangle(50, 30);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(rectangle.GetArea());
            Console.WriteLine(rectangle.GetPerimeter());
            Console.WriteLine();

            //Opgave 3.2 Cirkel
            Circle circle = new Circle(25);
            Console.WriteLine(circle.ToString());
            Console.WriteLine(circle.GetArea());
            Console.WriteLine(circle.GetCircumference());
            Console.WriteLine();

            //Opgave 3.3 Terning
            Die die = new Die();
            Die die1 = new Die(7);
            Console.WriteLine("Die with 6 sides: " + die.Sides);
            Console.WriteLine("Die with 'x' sides: " + die1.Sides);
            Console.WriteLine($"Die(6) rolls: {die.Roll()}, currentFace: {die.CurrentFace}");
            Console.WriteLine($"Die({die1.Sides}) rolls: {die1.Roll()}, currentFace: {die1.CurrentFace}");
            Console.WriteLine();

            //Opgave 3.4 Ansat
            Employee employee = new Employee(10, "Malthe", "Skov", 20000);
            Console.WriteLine(employee.ToString());
            Console.WriteLine("Annual Salary: " + employee.AnnualSalary);
            Console.WriteLine($"Raise Salary 5%: {employee.RaiseSalary(5)}");
            Console.WriteLine();

            //Opgave 3.5 Bankkonto
            Account acc1 = new Account("one", "Unknown", 10000);
            Account acc2 = new Account("two", "Known", 25000);
            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2.ToString());
            Console.WriteLine(acc1.Credit(5000));
            Console.WriteLine(acc1.Debit(16000));
            Console.WriteLine(acc1.Debit(10000));
            Console.WriteLine(acc1.TransferTo(acc2, 6000));
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc2.TransferTo(acc1, 10000));
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2.ToString());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
