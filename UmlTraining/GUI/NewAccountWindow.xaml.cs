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
using Entities;

namespace GUI
{
    /// <summary>
    /// Interaction logic for NewAccountWindow.xaml
    /// </summary>
    public partial class NewAccountWindow : Window
    {
        public Account NewAccount { get; private set; }
        public NewAccountWindow()
        {
            InitializeComponent();
        }

        private void BtnAddAccount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NewAccount = new Account(tbxID.Text, tbxName.Text, int.Parse(tbxBalance.Text));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.{Environment.NewLine}{Environment.NewLine}{ex.Message}");
            }
        }
    }
}
