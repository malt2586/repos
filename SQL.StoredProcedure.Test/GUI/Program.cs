using DBAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class Program
    {
        static DBHandler dBHandler; 

        static void Main(string[] args)
        {
            dBHandler = new DBHandler(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StoredProcedure.TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            List<Person> list = dBHandler.GetAllPerson();
        }
    }
}
