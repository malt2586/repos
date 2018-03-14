using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.BasicOOP.Game
{
    class GameController
    {
        //PROPERTIES
        public List<Player> PlayerList { get; set; }
        public int DiceRolls { get; set; }

        //CONSTRUCTORS
        public GameController() { }
        public GameController(int nPlayer, int nRolls)
        {
            PlayerList = new List<Player>();
            for (int i = 0; i < nPlayer; i++)
            {
                PlayerList.Add(new Player($"Player{i + 1}"));
            }

            DiceRolls = nRolls;
        }

        //METHODS
        public void StartGame()
        {
            Console.Write("Press Enter to start game.");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {

            }
        }
    }
}
