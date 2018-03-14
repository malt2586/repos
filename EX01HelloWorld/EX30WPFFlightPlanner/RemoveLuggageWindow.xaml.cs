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
    /// Interaction logic for RemoveLuggageWindow.xaml
    /// </summary>
    public partial class RemoveLuggageWindow : Window
    {
        private List<Luggage> luggage;
        public Luggage L { get; private set; }

        public RemoveLuggageWindow(List<Luggage> l)
        {
            InitializeComponent();

            luggage = l;
            lbxLuggage.ItemsSource = luggage;
        }

        private void btnRemoveLuggage_Click(object sender, RoutedEventArgs e)
        {
            if (lbxLuggage.SelectedItem != null)
            {
                L = (Luggage)lbxLuggage.SelectedItem;
                luggage.Remove(L);
                lbxLuggage.Items.Refresh();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
