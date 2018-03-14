using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.BasicOOP.Game
{
    class Player
    {
        //FIELDS
        private string playerName;
        private bool isPlayerTurn;

        //PROPERTIES
        public bool IsPlayerTurn
        {
            get { return isPlayerTurn; }
            set
            {
                isPlayerTurn = value;
            }
        }
        public string PlayerName
        {
            get { return playerName; }
            set
            {
                if (Char.IsLetter(value.First()) && value.Length <= 16 && value.Length >= 6 && IsAllLettersOrDigits(value))
                {
                    playerName = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        //CONSTRUCTORS
        public Player()
        {

        }
        public Player(string name)
        {
            PlayerName = name;
        }

        //METHODS
        static bool IsAllLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
