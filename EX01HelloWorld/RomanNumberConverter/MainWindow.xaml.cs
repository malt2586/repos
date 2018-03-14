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

namespace RomanNumberConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //FIELDS
        private Converter converter;

        //CONSTRUCTORS
        public MainWindow()
        {
            InitializeComponent();

            converter = new Converter();
        }

        //EVENT HANDLERS
        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            //Evaluates if input is valid roman
            if (converter.IsRoman(tbxInput.Text))
            {
                //Sets label content to converted value
                lblOutput.Content = converter.ToDecimal(tbxInput.Text);
            }
            //Evaluates if input is valid decimal
            if (converter.IsDecimal(tbxInput.Text))
            {
                //Sets label content to converted value
                lblOutput.Content = converter.ToRoman(tbxInput.Text);
            }
        }
    }
}
