using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX30WPFFlightPlanner
{
    public class Flight
    {
        //PROPERTIES & FIELDS
        public string FlightNumber { get; private set; }
        public string Departure { get; private set; }
        public string Destination { get; private set; }
        public int TotalLoadCapacity { get; private set; }

        //private List<Luggage> luggage = new List<Luggage>();

        private List<Passenger> passengers = new List<Passenger>();

        public List<Passenger> Passengers
        {
            get { return passengers; }
        }

        //public List<Luggage> Luggage
        //{
        //    get { return luggage; }
        //}

        //CONSTRUCTORS
        public Flight(string flightNumber, string departure, string destination, int totalLoadCapacity)
        {
            FlightNumber = flightNumber;
            Departure = departure;
            Destination = destination;
            TotalLoadCapacity = totalLoadCapacity;
        }

        //METHODS
        ////Adds luggage to passenger if possible
        //public bool AddLuggage(Luggage l)
        //{
        //    //Evaluates if weight of luggage is lower than available capacity
        //    if (l.Weight <= AvailableLoadCapacity())
        //    {
        //        //Adds luggage to list and returns true
        //        luggage.Add(l);
        //        return true;
        //    }
        //    else
        //    {
        //        //Returns false if weight is higher than available capacity
        //        return false;
        //    }
        //}
        ////Removes luggage from List<Luggage> "luggage"
        //public void RemoveLuggage(Luggage l)
        //{
        //    //Removes luggage from list
        //    luggage.Remove(l);
        //}

        //Returns value indicating available load capacity
        public int AvailableLoadCapacity()
        {
            //Sets capacity equal total load capacity
            int capacity = TotalLoadCapacity;
            //Itterates through list
            foreach (Passenger p in passengers)
            {
                //Subtracts luggage weight from capacity
                capacity = capacity - p.TotalLuggageWeight();
            }
            //Returns capacity
            return capacity;
        }

        //Returns representation of class in string format "AA111: DPT - DST"
        public override string ToString()
        {
            //Returns string
            return $"{FlightNumber}: {Departure} - {Destination}";
        }
    }
}
