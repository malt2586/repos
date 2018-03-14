using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.BasicOOP.OOPTest
{
    class OOPTest
    {
        static void Main(string[] args)
        {
            //Car c1 = new Car();
            //c1.Make = "Ford";
            //c1.Model = "Taurus";
            //c1.manufacturingDate = new DateTime(2000, 3, 10);

            //c1.Make = "Mustang";
            //c1.Model = "Shelby";
            //c1.manufacturingDate = new DateTime(1990, 10, 10);

            //Car c2 = new Car();
            //c2.Make = "Audi";
            //c2.Model = "A8";
            //c2.manufacturingDate = new DateTime(2010, 1, 1);

            //Car c3 = new Car();
            //c3.Make = "Volvo";
            //c3.Model = "V2004";
            //c3.manufacturingDate = new DateTime(2004, 11, 9);

            //Car c4 = new Car();
            //c4.Make = "Nissan";
            //c4.Model = "Entity";
            //c4.manufacturingDate = new DateTime(1999, 5, 20);

            //Console.WriteLine(c1.CurrentAge());
            //Console.WriteLine(c3.ToString());
            //Console.ReadKey();

            //Student st1 = new Student("Mads Mikkelsen", "T2", new DateTime(2010, 1, 1));
            //Student st2 = new Student("Lars Mikkelsen", "S2", new DateTime(2011, 4, 22));
            //Student st3 = new Student("Anders Madsen", "V1", new DateTime(2015, 2, 9));
            //Student st4 = new Student("Mette Jorsø", "S1", new DateTime(2017, 12, 19));
            //Student st5 = new Student("Sofie Lassen Kalke", "V3", new DateTime(2018, 2, 10));
            //Console.ReadKey();

            Student st1 = new Student("Mads Mikkelsen", "T2", new DateTime(2010, 1, 1));
            Console.WriteLine(st1.TimeFromAdmission());
            Console.WriteLine(st1.TimeUntilGraduation());
            Console.ReadKey();
        }
    }
}
