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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EX23WPFMessageBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("En eller anden tekst", "En titel");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("En eller anden tekst", "En titel", MessageBoxButton.OKCancel);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("En eller anden tekst", "En titel", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Noget tekst", "En titel", MessageBoxButton.YesNoCancel);

            switch (result)
            {
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Du trykkede cancel!", "WHAT?");
                    break;
                case MessageBoxResult.Yes:
                    MessageBox.Show("Du trykkede ja!", "JA!!");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Du trykkede nej!", "NEJ!!");
                    break;
                default:
                    break;
            }
        }
    }
}
