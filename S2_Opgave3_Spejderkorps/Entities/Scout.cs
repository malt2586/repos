using System;

namespace Entities
{
    public class Scout
    {
        //FIELDS
        private DateTime birthday;
        private string firstName;
        private string lastName;
        private byte marks;

        //CONSTRUCTORS
        public Scout(DateTime birthday, string firstName, string lastName, byte marks)
        {
            this.birthday = birthday;
            this.firstName = firstName;
            this.lastName = lastName;
            this.marks = marks;
        }

        //PROPERTIES
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public byte Marks { get { return marks; } set { marks = value; } }

        //METHODS
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Birthday: {Birthday}, Marks: {Marks}";
        }
    }
}