using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30WPFFlightPlanner
{
    public class Passenger
    {
        //FIELDS & PROPERTIES
        private string TicketNumber { get;}
        private string FirstName { get; }
        private string LastName { get; }

        private List<Luggage> luggage = new List<Luggage>();

        public List<Luggage> Luggage
        {
            get { return luggage; }
        }

        //CONSTRUCTORS
        public Passenger(string ticketNumber, string firstName, string lastName, Luggage l)
        {
            TicketNumber = ticketNumber;
            FirstName = firstName;
            LastName = lastName;
            //Evaluates if weight is larger than 0
            if (l.Weight > 0)
            {
                //Adds luggage to list
                luggage.Add(l);
            }
        }

        //METHODS
        //Adds luggage to list
        public void AddLuggage(Luggage l)
        {
            //Evaluates if weight is higher than 0
            if (l.Weight > 0)
            {
                //Adds luggage to list
                luggage.Add(l);
            }
        }

        //Removes luggage from list
        public void RemoveLuggage(Luggage l)
        {
            //Removes luggage from list
            luggage.Remove(l);
        }

        //Returns total weight of luggage
        public int TotalLuggageWeight()
        {
            //Sets totalLuggageWeight
            int totalLuggageWeight = 0;
            //Itterates through list
            foreach (Luggage l in luggage)
            {
                //Adds luggage weight to totalLuggageWeight
                totalLuggageWeight = totalLuggageWeight + l.Weight;
            }
            //Returns totalLuggageWeight
            return totalLuggageWeight;
        }

        //Returns representation of class in string format "1111: FirstName LastName - 00(kg)"
        public override string ToString()
        {
            //Returns properties in string format
            return $"{TicketNumber}: {FirstName} {LastName} - {TotalLuggageWeight()}(kg)";
        }
    }
}
