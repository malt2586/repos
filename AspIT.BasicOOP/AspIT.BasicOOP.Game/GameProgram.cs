using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AspIT.BasicOOP.Game
{
    class GameProgram
    {
        static void Main(string[] args)
        {
            //Die die1 = new Die(1);
            //Console.WriteLine(die1.ToString());
            //Die die2 = new Die(2);
            //Console.WriteLine(die2.ToString());
            //Die die3 = new Die(3);
            //Console.WriteLine(die3.ToString());
            //Die die4 = new Die(4);
            //Console.WriteLine(die4.ToString());
            //Die die5 = new Die(5);
            //Console.WriteLine(die5.ToString());
            //Die die6 = new Die(6);
            //Console.WriteLine(die6.ToString());

            //Die die7 = new Die();
            //die7.Roll();
            //Console.WriteLine(die7.Value);

            Timer timer = new Timer(2000);
            timer.Elapsed += timerElapsed;
            while (DateTime.Now < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 0, 0))
            {
                timer.Enabled = true;
            }

            //Player p1 = new Player();
            //p1.PlayerName = "Martin1";


            Console.ReadKey();
        }

        static void timerElapsed(object sender, ElapsedEventArgs e)
        {
            Die die = new Die();
            die.Roll();
            Console.WriteLine(die.Value);
        }
    }
}
