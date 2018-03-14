namespace Entities
{
    public struct ContactInformation
    {
        // FIELDS
        private int personID;
        private string contactType;
        private string address;
        private string phone;
        private string email;

        // PROPERTIES
        public int PersonID { get => personID; set => personID = value; }
        public string ContactType { get => contactType; set => contactType = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        // CONSTRUCTORS
        public ContactInformation(int personID, string contactType, string address, string phone, string email) : this()
        {
            PersonID = personID;
            ContactType = contactType;
            Address = address;
            Phone = phone;
            Email = email;
        }
    }
}