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
using DBAccess;
using Entities;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DatabaseHandler dbHandler;
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                dbHandler = new DatabaseHandler(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CompanyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
            catch (Exception e)
            {
                MessageBox.Show($"A connection to the database could not be created: {Environment.NewLine}{Environment.NewLine}{e.Message}");
                this.Close();
                Application.Current.Shutdown();
            }
            lbxEmployeesTable.ItemsSource = dbHandler.GetEmployees();
        }

        private void btnNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            NewEmployeeWindow window = new NewEmployeeWindow();
            window.Owner = this;
            if (window.ShowDialog() == false)
            {
                if (window.NewEmployee != null)
                {
                    dbHandler.AddEmployee(window.NewEmployee);
                }
                lbxEmployeesTable.ItemsSource = dbHandler.GetEmployees();
            }
        }
    }
}