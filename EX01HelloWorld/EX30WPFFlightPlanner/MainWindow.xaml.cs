using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EX30WPFFlightPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //FIELDS
        private List<Flight> flightList = new List<Flight>();

        //PROPERTIES
        public List<Flight> FlightList
        {
            get { return flightList; }
        }
        public MainWindow()
        {
            InitializeComponent();

            //Adds new Flight objects to "flightList"
            flightList.Add(new Flight("SK939", "AAL", "CPH", 10000));
            flightList.Add(new Flight("PA544", "BLL", "FUE", 12000));
            flightList.Add(new Flight("JC431", "CPH", "NYC", 15000));

            //Sets items source for ListBox to List<Flight>
            lbxFlights.ItemsSource = flightList;


            //Sets title on main window
            Title = $"Flight Planner";
        }

        //EVENT HANDLERS
        //_Click on Button "btnAddLuggage" adds luggage to List<Luggage> "luggage" for selected flight
        private void btnAddLuggage_Click(object sender, RoutedEventArgs e)
        {

            flightList[lbxFlights.SelectedIndex].Passengers.ElementAt(lbxPassengers.SelectedIndex).AddLuggage(new Luggage(int.Parse(tbxAddLuggage.Text)));

            lbxPassengers.Items.Refresh();

            lblAvailableLoadCapacity.Content = flightList[lbxFlights.SelectedIndex].AvailableLoadCapacity();
        }
        //_Click on Button "btnRemoveLuggage" removes luggage from List<Luggage> "luggage" for selected flight
        private void btnRemoveLuggage_Click(object sender, RoutedEventArgs e)
        {
            var luggageWindow = new RemoveLuggageWindow(flightList[lbxFlights.SelectedIndex].Passengers.ElementAt(lbxPassengers.SelectedIndex).Luggage);
            luggageWindow.Owner = this;
            if (luggageWindow.ShowDialog() == false)
            {
                flightList[lbxFlights.SelectedIndex].Passengers.ElementAt(lbxPassengers.SelectedIndex).RemoveLuggage(luggageWindow.L);

                lbxPassengers.Items.Refresh();
            }

            lblAvailableLoadCapacity.Content = flightList[lbxFlights.SelectedIndex].AvailableLoadCapacity();
        }
        //_SelectionChanged for ListBox "lbxFlights"
        private void lbxFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxFlights.SelectedItem == null)
            {
                lbxPassengers.ItemsSource = null;

                lblFlightNumber.Content = "N/A";
                lblDestination.Content = "N/A";
                lblDeparture.Content = "N/A";
                lblTotalLoadCapacity.Content = "N/A";
                lblAvailableLoadCapacity.Content = "N/A";
                lblNumberOfPassengers.Content = "N/A";

                Title = $"Flight Planner";
            }
            else
            {
                lbxPassengers.ItemsSource = flightList[lbxFlights.SelectedIndex].Passengers;

                lblFlightNumber.Content = flightList[lbxFlights.SelectedIndex].FlightNumber;
                lblDestination.Content = flightList[lbxFlights.SelectedIndex].Destination;
                lblDeparture.Content = flightList[lbxFlights.SelectedIndex].Departure;
                lblTotalLoadCapacity.Content = flightList[lbxFlights.SelectedIndex].TotalLoadCapacity;
                lblAvailableLoadCapacity.Content = flightList[lbxFlights.SelectedIndex].AvailableLoadCapacity();
                lblNumberOfPassengers.Content = flightList[lbxFlights.SelectedIndex].Passengers.Count;

                Title = $"Flight Planner - {lbxFlights.SelectedItem}";
            }
        }

        private void btnNewFlight_Click(object sender, RoutedEventArgs e)
        {
            var flightWindow = new AddFlightWindow();
            flightWindow.Owner = this;
            if (flightWindow.ShowDialog() == false)
            {
                flightList.Add(flightWindow.NewFlight);
                lbxFlights.Items.Refresh();
            }
        }

        private void btnAddPassenger_Click(object sender, RoutedEventArgs e)
        {
            var passengerWindow = new AddPassengerWindow();
            passengerWindow.Owner = this;
            if (passengerWindow.ShowDialog() == false)
            {
                flightList[lbxFlights.SelectedIndex].Passengers.Add(passengerWindow.NewPassenger);
                lbxPassengers.Items.Refresh();

                lblAvailableLoadCapacity.Content = flightList[lbxFlights.SelectedIndex].AvailableLoadCapacity();
                lblNumberOfPassengers.Content = flightList[lbxFlights.SelectedIndex].Passengers.Count;
            }
        }

        private void btnRemovePassenger_Click(object sender, RoutedEventArgs e)
        {
            if (lbxPassengers.SelectedItem != null)
            {
                flightList[lbxFlights.SelectedIndex].Passengers.RemoveAt(lbxPassengers.SelectedIndex);
                lbxPassengers.Items.Refresh();
            }
        }
    }
}
