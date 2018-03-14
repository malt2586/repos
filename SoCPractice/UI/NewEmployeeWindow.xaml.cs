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
using DBAccess;
using Entities;

namespace UI
{
    /// <summary>
    /// Interaction logic for NewEmployeeWindow.xaml
    /// </summary>
    public partial class NewEmployeeWindow : Window
    {
        //PROPERTIES
        public Employee NewEmployee { get; private set; }
        public bool[] IsHourlyPaidArray { get; }
        public char[] SexArray { get; }
        public string[] EmploymentArray { get; }
        public string[] StatusArray { get; }

        public NewEmployeeWindow()
        {
            InitializeComponent();

            IsHourlyPaidArray = new bool[2] { true, false };
            SexArray = new char[2] { 'M', 'F' };
            EmploymentArray = new string[3] { "Fulltime", "Parttime", "AgeReduction" };
            StatusArray = new string[3] { "Permanent", "TimeLimited", "Temporary" };

            Enum[] @enum = new Enum[3] { Status.Fulltime, Status.Parttime, Status.AgeReduction };

            cbxIsHourlyPaid.ItemsSource = IsHourlyPaidArray;
            cbxSex.ItemsSource = SexArray;
            cbxEmployment.ItemsSource = EmploymentArray;
            cbxStatus.ItemsSource = StatusArray;
            
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!int.TryParse(tbxEmployeeId.Text, out int employeeId))
                {
                    throw new ArgumentException("EmployeeId");
                }
                NewEmployee = new Employee(tbxFirstName.Text, tbxLastName.Text, tbxTitleOfCourtesy.Text, tbxTitle.Text, tbxPosition.Text, IsHourlyPaidArray[cbxIsHourlyPaid.SelectedIndex], employeeId, DateTime.Parse(tbxHireDate.Text), SexArray[cbxSex.SelectedIndex]);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Check input for errors. {Environment.NewLine}{Environment.NewLine}{ex.Message}");
            }
            
        }

        private void cbxIsHourlyPaid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbxSex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbxEmployment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbxStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}