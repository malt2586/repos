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

namespace EX21WPFLabelButton
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

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            lblHello.Content = "Hello World";
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            lblColor.Background = Brushes.Blue;

            lblColor.Foreground = Brushes.White;
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            lblColor.Background = Brushes.Red;

            lblColor.Foreground = Brushes.White;
        }

        private void lblRed_MouseEnter(object sender, MouseEventArgs e)
        {
            lblWhite.Background = lblRed.Background;
        }

        private void lblBlue_MouseEnter(object sender, MouseEventArgs e)
        {
            lblWhite.Background = lblBlue.Background;
        }

        private void lblBlue_MouseLeave(object sender, MouseEventArgs e)
        {
            lblWhite.Background = Brushes.White;
        }

        private void lblRed_MouseLeave(object sender, MouseEventArgs e)
        {
            lblWhite.Background = Brushes.White;
        }
    }
}
