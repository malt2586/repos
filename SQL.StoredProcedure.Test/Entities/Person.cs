using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        // FIELDS
        private int id;
        private string name;
        private DateTime birthDate;
        private string gender;
        private List<ContactInformation> contactInformation;

        // PROPERTIES
        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Gender { get => gender; set => gender = value; }
        public List<ContactInformation> ContactInformation { get => contactInformation; set => contactInformation = value; }

        // CONSTRUCTORS
        public Person(int id, string name, DateTime birthDate, string gender)
        {
            ID = id;
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            ContactInformation = new List<ContactInformation>();
        }
        public Person(int id, string name, DateTime birthDate, string gender, string contactType, string address, string phone, string email)
        {
            ID = id;
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            ContactInformation = new List<ContactInformation>()
            {
                new ContactInformation
                {
                    ContactType = contactType,
                    Address = address,
                    Phone = phone,
                    Email = email
                }
            };
        }
    }
}
