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

namespace EX26WPFDiceGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creates new object of class "Random"
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            //Sets label content to a random number between [1 : 7[
            lblDice.Content = rnd.Next(1, 7);

            //Sets label content to "0"
            lblScore.Content = 0;

            //Reads highscore from file and sets label content
            using (StreamReader reader = new StreamReader(@"HighScore.txt"))
            {
                lblHighScore.Content = int.Parse(reader.ReadLine());
            }

            if (rbLife1.IsChecked == true)
            {
                lblLife.Content = 1;
            }
            if (rbLife3.IsChecked == true)
            {
                lblLife.Content = 3;
            }
            if (rbLife5.IsChecked == true)
            {
                lblLife.Content = 5;
            }
        }

        private void btnLower_Click(object sender, RoutedEventArgs e)
        {
            //Creates new variable of type "int" and sets it to a random number between [1 : 7[
            int newRoll = rnd.Next(1, 7);
            //Creates new variable of type "int" and sets it to the value of the label
            int oldRoll = (int)lblDice.Content;

            //Evaluates if player guess is correct
            if (newRoll <= oldRoll)
            {
                //Increments the score by one if guess is correct
                lblScore.Content = (int)lblScore.Content + 1;
            }
            else
            {
                //Evaluates if the player has more than 1 life left
                if ((int)lblLife.Content > 1)
                {
                    //Decrements player life by 1
                    lblLife.Content = (int)lblLife.Content - 1;

                    MessageBox.Show($"Desværre - {newRoll} er højere end {oldRoll}. Prøv igen.", "Prøv Igen");
                }
                else
                {
                    //Displays a message box if guess is wrong
                    MessageBox.Show($"Desværre - du tabte. Du endte med en score på {lblScore.Content}", "Game Over!");

                    //Sets label content to "0"
                    lblScore.Content = 0;
                }
            }

            //Sets label content to the value of variable "newRoll"
            lblDice.Content = newRoll;

            //Evaluates if the current score is higher than the highscore
            if ((int)lblScore.Content > (int)lblHighScore.Content)
            {
                //Sets current score as the new highscore
                lblHighScore.Content = lblScore.Content;

                //Writes new highscore to file
                using (StreamWriter writer = new StreamWriter(@"HighScore.txt"))
                {
                    writer.Write(lblScore.Content);
                }
            }
        }

        private void btnHigher_Click(object sender, RoutedEventArgs e)
        {
            //Creates new variable of type "int" and sets it to a random number between [1 : 7[
            int newRoll = rnd.Next(1, 7);
            //Creates new variable of type "int" and sets it to the value of the label
            int oldRoll = (int)lblDice.Content;

            //Evaluates if player guess is correct
            if (newRoll >= oldRoll)
            {
                //Increments the score by one if guess is correct
                lblScore.Content = (int)lblScore.Content + 1;
            }
            else
            {
                //Evaluates if the player has more than 1 life left
                if ((int)lblLife.Content > 1)
                {
                    //Decrements player life by 1
                    lblLife.Content = (int)lblLife.Content - 1;

                    MessageBox.Show($"Desværre - {newRoll} er lavere end {oldRoll}. Prøv igen.", "Prøv Igen");
                }
                else
                {
                    //Displays a message box if guess is wrong
                    MessageBox.Show($"Desværre - du tabte. Du endte med en score på {lblScore.Content}", "Game Over!");

                    //Sets label content to "0"
                    lblScore.Content = 0;
                }
            }

            //Sets label content to the value of variable "newRoll"
            lblDice.Content = newRoll;

            //Evaluates if the current score is higher than the highscore
            if ((int)lblScore.Content > (int)lblHighScore.Content)
            {
                //Sets current score as the new highscore
                lblHighScore.Content = lblScore.Content;

                //Writes new highscore to file
                using (StreamWriter writer = new StreamWriter(@"HighScore.txt"))
                {
                    writer.Write(lblScore.Content);
                }
            }
        }

        private void rbLife1_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void rbLife3_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void rbLife5_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
