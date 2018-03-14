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
using System.IO;
using Microsoft.Win32;

namespace EX27WPFHeroGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List containing Female surnames
        private List<string> femaleFirstNames = new List<string>() { "Cameron", "June", "Cena", "Prue", "Liz", "Edora" };
        //List containing Male surnames
        private List<string> maleFirstNames = new List<string>() { "Jack", "Oscar", "Bruce", "Tom", "Warren", "Fred", "Pat", "John" };
        //List containing lastnames
        private List<string> lastNames = new List<string>() { "Willis", "Hopkinson", "Cena", "Diaz", "Hanks", "Halliwell", "Carna", "Cruze" };
        //Random number generator
        private Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        //Event handler for button "btnFemaleHeroes"
        private void btnFemaleHeroes_Click(object sender, RoutedEventArgs e)
        {
            //Clears items in the list box
            lbxHeroNames.Items.Clear();

            //Variable for number of names to generate
            int numberOfHeroes;

            //Parses value from text box to variable "numberOfHeroes" (returns 0 if parse fails, else returns value)
            int.TryParse(tbxNumberOfHeroes.Text, out numberOfHeroes);

            //Runs untill specified number of names has been generated
            for (int i = 0; i < numberOfHeroes; i++)
            {
                string firstName;
                string lastName;
                string newHero;

                //Picks random first name from list
                firstName = femaleFirstNames[rnd.Next(0, femaleFirstNames.Count)];
                //Picks random last name from list
                lastName = lastNames[rnd.Next(0, lastNames.Count)];
                //Combines picked names
                newHero = $"{firstName} {lastName}";

                //Evaluates if name exists
                if (lbxHeroNames.Items.Contains(newHero))
                {
                    //Decrements "i" with 1 if name exists
                    i--;
                }
                else
                {
                    //Adds name list box if it doesn't exists
                    lbxHeroNames.Items.Add(newHero);
                }
            }
        }

        //Event handler for button "btnMaleHeroes"
        private void btnMaleHeroes_Click(object sender, RoutedEventArgs e)
        {
            lbxHeroNames.Items.Clear();

            int numberOfHeroes;

            int.TryParse(tbxNumberOfHeroes.Text, out numberOfHeroes);

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string firstName;
                string lastName;
                string newHero;

                firstName = maleFirstNames[rnd.Next(0, maleFirstNames.Count)];
                lastName = lastNames[rnd.Next(0, lastNames.Count)];
                newHero = $"{firstName} {lastName}";

                if (lbxHeroNames.Items.Contains(newHero))
                {
                    i--;
                }
                else
                {
                    lbxHeroNames.Items.Add(newHero);
                }
            }
        }

        //Event handler for button "btnClear"
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //Clears items in list box
            lbxHeroNames.Items.Clear();
        }

        //Event handler for button "btnSaveHeroes"
        private void btnSaveHeroes_Click(object sender, RoutedEventArgs e)
        {
            //Creates new List<string> object and initialises
            List<string> heroesNames = new List<string>();
            //Creates new SaveFileDialog object and initialises
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //Runs through all items in list box
            foreach (string name in lbxHeroNames.Items)
            {
                //Adds hero name to list
                heroesNames.Add(name);
            }

            //Opens windows save file dialog
            if (saveFileDialog.ShowDialog() == true)
            {
                //Writes all names to specified file
                File.WriteAllLines(saveFileDialog.FileName, heroesNames);
            }

            ////Opens and closes the StreamWriter
            //using (StreamWriter writer = new StreamWriter("Heroes.txt"))
            //{
            //    //Runs for all items in list box
            //    foreach (string name in lbxHeroNames.Items)
            //    {
            //        //Writes name to file
            //        writer.WriteLine(name);
            //    }
            //}
        }
    }
}
