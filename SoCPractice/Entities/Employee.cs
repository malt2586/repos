using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Flags]
    public enum Status
    {
        None = 0,

        Fulltime = 1 << 0,
        Parttime = 1 << 1,
        AgeReduction = 1 << 2,

        Permanent = 1 << 3,
        TimeLimited = 1 << 4,
        Temporary = 1 << 5,
    }

    public class Employee
    {
        //FIELDS

        //private string firstname;
        //private string lastname;
        //private string titleOfCourtesy;
        //private string title;
        //private string position;

        ContactInformation contact;
        Status status;

        private bool isHourlyPaid;
        private int employeeId;
        private DateTime hireDate;
        private char sex;

        //PROPERTIES
        public ContactInformation Contact { get { return contact; } }

        public Status MyStatus
        {
            get { return status; }
            set
            {
                if ((value.HasFlag(Status.Fulltime) || value.HasFlag(Status.Parttime) || value.HasFlag(Status.AgeReduction)) &&
                    !((value.HasFlag(Status.Fulltime) && value.HasFlag(Status.Parttime)) || 
                    (value.HasFlag(Status.Fulltime) && value.HasFlag(Status.AgeReduction)) || 
                    (value.HasFlag(Status.Parttime) && value.HasFlag(Status.AgeReduction))))
                {
                    if ((value.HasFlag(Status.Permanent) || value.HasFlag(Status.TimeLimited) || value.HasFlag(Status.Temporary)) &&
                        !((value.HasFlag(Status.Permanent) && value.HasFlag(Status.TimeLimited)) ||
                        (value.HasFlag(Status.Permanent) && value.HasFlag(Status.Temporary)) ||
                        (value.HasFlag(Status.TimeLimited) && value.HasFlag(Status.Temporary))))
                    {
                        status = value;
                    }
                }
                else throw new ArgumentException();
            }
        }

        //public string Firstname
        //{
        //    get { return firstname; }
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException(nameof(Firstname));
        //        }
        //        firstname = value;
        //    }
        //}
        //public string Lastname
        //{
        //    get { return lastname; }
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException(nameof(Lastname));
        //        }
        //        lastname = value;
        //    }
        //}
        //public string TitleOfCourtesy
        //{
        //    get { return titleOfCourtesy; }
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException(nameof(TitleOfCourtesy));
        //        }
        //        titleOfCourtesy = value;
        //    }
        //}
        //public string Title
        //{
        //    get { return title; }
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException(nameof(Title));
        //        }
        //        title = value;
        //    }
        //}
        //public string Position
        //{
        //    get { return position; }
        //    set
        //    {
        //        if (String.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException(nameof(Position));
        //        }
        //        position = value;
        //    }
        //}
        public bool IsHourlyPaid
        {
            get { return isHourlyPaid; }
            set { isHourlyPaid = value; }
        }
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public char Sex
        {
            get { return sex; }
            set
            {
                if (!Char.IsLetter(value))
                {
                    throw new ArgumentException(nameof(Sex));
                }
                sex = value;
            }
        }

        //CONSTRUCTORS
        public Employee(string firstname, string lastname, string titleOfCourtesy, string title, string position, bool isHourlyPaid, int employeeId, DateTime hireDate, char sex)
        {
            try
            {
                contact = new ContactInformation(firstname, lastname, titleOfCourtesy, title, position);

                //Firstname = firstname;
                //Lastname = lastname;
                //TitleOfCourtesy = titleOfCourtesy;
                //Title = title;
                //Position = position;

                IsHourlyPaid = isHourlyPaid;
                EmployeeId = employeeId;
                HireDate = hireDate;
                Sex = sex;
            }
            catch (ArgumentException) { throw; }
        }

        //METHODS
        public override string ToString()
        {
            return $"{Contact}, {IsHourlyPaid}, {EmployeeId}, {HireDate}, {Sex}";
        }
    }
}
