using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraEX01BmiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 0;
            double weight = 0;
            double bmi;
            string[] bmiBeskrivelseArray = new string[] { "Du er undervægtig. Tænk over at indtage flere kalorier.", "Din vægt ligger indenfor normalen – fortsæt din livsstil.", "Du er overvægtig. Sørg for at have et fokus på din kost og motion.", "Du ligger i kategorien fedme. Lav en livsstilsændring nu, i morgen er det måske for sent.", "Du har svær fedme. Snak eventuelt med en diætist, så du nemmere kan ændre din livsstil." };

            //Parsing af input til variabler
            Console.WriteLine("Indtast højde i meter:");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast vægt i kg:");
            weight = double.Parse(Console.ReadLine());
            
            //Beregning af BMI
            bmi = (weight / (height * height));

            //Returnering af BMI og beskrivelse
            Console.WriteLine($"Din BMI: {bmi}");
            if (bmi < 18.5)
            {
                Console.WriteLine(bmiBeskrivelseArray[0]);
            }
            else if (bmi < 25)
            {
                Console.WriteLine(bmiBeskrivelseArray[1]);
            }
            else if (bmi < 30)
            {
                Console.WriteLine(bmiBeskrivelseArray[2]);
            }
            else if (bmi < 40)
            {
                Console.WriteLine(bmiBeskrivelseArray[3]);
            }
            else if (bmi >= 40)
            {
                Console.WriteLine(bmiBeskrivelseArray[4]);
            }

            Console.ReadKey();
        }
    }
}
