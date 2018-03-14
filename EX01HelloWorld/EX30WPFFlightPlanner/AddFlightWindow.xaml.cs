using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace EX30WPFFlightPlanner
{
    /// <summary>
    /// Interaction logic for AddFlightWindow.xaml
    /// </summary>
    public partial class AddFlightWindow : Window
    {
        //FIELDS
        private Flight newFlight;

        //PROPERTIES
        public Flight NewFlight
        {
            get { return newFlight; }
        }

        //CONSTRUCTORS
        public AddFlightWindow()
        {
            InitializeComponent();
        }

        //EVENT HANDLERS
        
        private void btnAddFlight_Click(object sender, RoutedEventArgs e)
        {
            int result;
            int.TryParse(tbxLoadCapacity.Text, out result);
            newFlight = new Flight(tbxFlightNumber.Text, tbxDeparture.Text, tbxDestination.Text, result);
            Close();
        }
    }
}
