using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Entities;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //PROPERTIES
        public List<Box> BoxList { get; set; }
        public Box NewBox { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            BoxList = new List<Box>();
            lbxSendtPackets.ItemsSource = BoxList;
            
        }

        private void btnCalcPrice_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NewBox = new Box(int.Parse(tbxLength.Text), int.Parse(tbxHeight.Text), int.Parse(tbxWidth.Text), double.Parse(tbxWeight.Text));
                tbxPrice.Text = NewBox.Price.ToString("C2");
            }
            catch (Exception)
            {
                MessageBox.Show("Fejl i input.");
            }
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            if (NewBox != null)
            {
                BoxList.Add(NewBox);
                NewBox = null;
                tbxLength.Text = null;
                tbxWidth.Text = null;
                tbxHeight.Text = null;
                tbxWeight.Text = null;
                tbxPrice.Text = null;
                lbxSendtPackets.Items.Refresh();
            }
        }

        private void tbxLength_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]+");
            return !regex.IsMatch(text);
        }
    }
}
