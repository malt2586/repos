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
    /// Interaction logic for AddPassengerWindow.xaml
    /// </summary>
    public partial class AddPassengerWindow : Window
    {
        //FIELDS
        private Passenger newPassenger;

        //PROPERTIES
        public Passenger NewPassenger
        {
            get { return newPassenger; }
        }

        //CONSTRUCTORS
        public AddPassengerWindow()
        {
            InitializeComponent();
        }

        //EVENT HANDLERS
        private void btnAddPassenger_Click(object sender, RoutedEventArgs e)
        {
            int result;
            int.TryParse(tbxLuggage.Text, out result);
            Luggage luggage = new Luggage(result);
            newPassenger = new Passenger(tbxTicketNumber.Text, tbxFirstName.Text, tbxLastName.Text, luggage);
            Close();
        }
    }
}
