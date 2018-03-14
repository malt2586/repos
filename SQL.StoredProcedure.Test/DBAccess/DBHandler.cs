using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public class DBHandler : CommonDB
    {
        public DBHandler(string conString) : base(conString)
        {
        }

        public List<Person> GetAllPerson()
        {
            Dictionary<int, Person> dictionary = new Dictionary<int, Person>();

            DataSet ds = ExecuteQuery("GetAllPersonProcedure");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Person p = new Person
                (
                    row.Field<int>("Id"),
                    row.Field<string>("Name"),
                    row.Field<DateTime>("BirthDate"),
                    row.Field<string>("Gender")
                );
                dictionary.Add(p.ID, p);
            }
            foreach (DataRow row in ds.Tables[1].Rows)
            {
                ContactInformation cInfo = new ContactInformation
                {
                    PersonID = row.Field<int>("PersonId"),
                    ContactType = row.Field<string>("ContactType"),
                    Address = row.Field<string>("Address"),
                    Phone = row.Field<string>("Phone"),
                    Email = row.Field<string>("Email")
                };
                dictionary[cInfo.PersonID].ContactInformation.Add(cInfo);
            }

            return dictionary.Values.ToList();
        }
    }
}
