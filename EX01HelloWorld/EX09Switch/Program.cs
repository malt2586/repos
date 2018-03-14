using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string caseSwitch;

            ////Opgave 9.1
            //Console.Write("Indtast et dyr: ");
            //caseSwitch = Console.ReadLine();

            //switch (caseSwitch)
            //{
            //    case "Undulat":
            //        Console.WriteLine("En undulat er en fugl.");
            //        break;
            //    case "Papegøje":
            //        Console.WriteLine("En papegøje er en fugl med fjer.");
            //        break;
            //    case "Hund":
            //        Console.WriteLine("En hund har fire ben.");
            //        break;
            //    case "Kat":
            //        Console.WriteLine("En kat har fire ben og en hale.");
            //        break;
            //    case "Gris":
            //        Console.WriteLine("En gris smager godt.");
            //        break;
            //    default:
            //        Console.WriteLine($"{caseSwitch} er ikke et dyr.");
            //        break;
            //}

            //Console.ReadKey();

            //Opgave 9.2
            Console.Write("Indtast en karakter: ");
            caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "-3":
                    Console.WriteLine("-3: For den ringe præstation. Karakteren -3 gives for den helt uacceptable præstation.");
                    break;
                case "00":
                    Console.WriteLine("00: For den utilstrækkelige præstation. Karakteren 00 gives for den utilstrækkelige præstation, der ikke demonstrerer en acceptabel grad af opfyldelse af fagets/fagelementets mål.");
                    break;
                case "02":
                    Console.WriteLine("02: For den tilstrækkelige præstation. Karakteren 02 gives for den tilstrækkelige præstation, der demonstrerer den minimalt acceptable grad af opfyldelse af fagets/fagelementets mål.");
                    break;
                case "4":
                    Console.WriteLine("4: For den jævne præstation. Karakteren 4 gives for den jævne præstation, der demonstrerer en mindre grad af opfyldelse af fagets/fagelementets mål, med adskillige væsentlige mangler.");
                    break;
                case "7":
                    Console.WriteLine("7: For den gode præstation. Karakteren 7 gives for den gode præstation, der demonstrerer opfyldelse af fagets/fagelementets mål, med en del mangler.");
                    break;
                case "10":
                    Console.WriteLine("10: For den fortrinlige præstation. Karakteren 10 gives for den fortrinlige præstation, der demonstrerer omfattende opfyldelse af fagets/fagelementets mål, med nogle mindre væsentlige mangler.");
                    break;
                case "12":
                    Console.WriteLine("12: For den fremragende præstation. Karakteren 12 gives for den fremragende præstation, der demonstrerer udtømmende opfyldelse af fagets/fagelementets mål, med ingen eller få uvæsentlige mangler.");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
