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
using AspIT.MSJ.TinyApp.Core;
using AspIT.MSJ.TinyApp.DataAccess;

namespace AspIT.MSJ.TinyApp.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //FIELDS
        private DatabaseHandler dbHandler;

        //CONSTRUCTORS
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                dbHandler = new DatabaseHandler(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AspIT.MSJ.TinyAppDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
            catch (Exception e)
            {
                MessageBox.Show("Der kunne desværre ikke oprettes forbindelse til databasen: " + $"{Environment.NewLine}{Environment.NewLine}{e.Message}");
                this.Close();
                Application.Current.Shutdown();
            }
        }

        //EVENT HANDLERS
        private void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (!UserCredentials.IsUsernameValid(tbxUserName.Text))
            {
                MessageBox.Show("Brugernavne kan kun indeholde bogstaver og være mellem 4 og 8 karakterer lange.");
            }
            else
            {
                UserCredentials logInCredentials = new UserCredentials(tbxUserName.Text, pbxPassword.Password);
                try
                {
                    if (!dbHandler.IsValid(logInCredentials))
                    {
                        MessageBox.Show("Forkert brugernavn eller kodeord.");
                    }
                    else
                    {
                        AppWindow appWindow = new AppWindow();
                        this.Close();
                        appWindow.Show();
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = "Der skete en fejl. Prøv at genstarte programmet";
                    errorMessage += Environment.NewLine + Environment.NewLine + ex.Message;
                    MessageBox.Show(errorMessage);
                }
            }
            
        }
    }
}
