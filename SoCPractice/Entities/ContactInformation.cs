using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public struct ContactInformation
    {
        private string firstname;
        private string lastname;
        private string titleOfCourtesy;
        private string title;
        private string position;

        public ContactInformation(string firstname, string lastname, string titleOfCourtesy, string title, string position)
        {
            //Validates and sets firstname
            if (String.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException(nameof(this.firstname));
            }
            this.firstname = firstname;

            //Validates and sets lastname
            if (String.IsNullOrWhiteSpace(lastname))
            {
                throw new ArgumentException(nameof(this.lastname));
            }
            this.lastname = lastname;

            //Validates and sets titleOfCourtesy
            if (String.IsNullOrWhiteSpace(titleOfCourtesy))
            {
                throw new ArgumentException(nameof(this.titleOfCourtesy));
            }
            this.titleOfCourtesy = titleOfCourtesy;

            //Validates and sets title
            if (String.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException(nameof(this.title));
            }
            this.title = title;

            //Validates and sets position
            if (String.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentException(nameof(this.position));
            }
            this.position = position;
        }

        //PROPERTIES
        public string Firstname { get { return firstname; } }
        public string Lastname { get { return firstname; } }
        public string TitleOfCourtesy { get { return titleOfCourtesy; } }
        public string Title { get { return title; } }
        public string Position { get { return position; } }

        //METHODS
        public override string ToString()
        {
            return $"{Firstname}, {Lastname}, {TitleOfCourtesy}, {Title}, {Position}";
        }
    }
}
