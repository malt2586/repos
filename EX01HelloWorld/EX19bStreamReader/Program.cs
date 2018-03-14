using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EX19bStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 19.1
            //Creates new empty list
            List<int> values = new List<int>();

            //Closes and disposes the reader when finished
            using (StreamReader reader = new StreamReader("C:\\Users\\malt2586\\source\\repos\\EX01HelloWorld\\EX19bStreamReader\\Values.txt"))
            {
                //Read as long it is not the end of the stream
                while (!reader.EndOfStream)
                {
                    //Reads a line from the text file, parses it to an int, and adds it to the list
                    values.Add(int.Parse(reader.ReadLine()));
                }
            }

            //Prints sum and average to console
            Console.WriteLine(values.Sum());
            Console.WriteLine(values.Average());

            //Opgave 19.2
            //Creates new empty list
            List<int> boxVolumes = new List<int>();

            //Closes and disposes the reader when finished
            using (StreamReader reader = new StreamReader("C:\\Users\\malt2586\\source\\repos\\EX01HelloWorld\\EX19bStreamReader\\Boxes.txt"))
            {
                //Read as long it is not the end of the stream
                while (!reader.EndOfStream)
                {
                    //Reads a line from file, splits it, and adds it to a string[]
                    string[] array = reader.ReadLine().Split(',');

                    //Parses values in the array to an int, calculates the volume(int1 * int2 * int3)
                    int boxVolume = int.Parse(array[0]) * int.Parse(array[1]) * int.Parse(array[2]); 

                    //Adds the calculated volume to the list
                    boxVolumes.Add(boxVolume);
                }
            }

            //Prints all values in list to console
            foreach (int volume in boxVolumes)
            {
                Console.WriteLine(volume);
            }

            //Finds smallest volume in list and prints to console
            int minVolume = int.MaxValue;
            foreach (int volume in boxVolumes)
            {
                if (volume < minVolume)
                {
                    minVolume = volume;
                }
            }
            Console.WriteLine(minVolume);

            //Finds largest volume in list and prints to console
            int maxVolume = 0;
            foreach (int volume in boxVolumes)
            {
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                }
            }
            Console.WriteLine(maxVolume);

            //Prints average of all volumes in list to console 
            Console.WriteLine(boxVolumes.Average());

            //Opgave 19.3
            //Creates empty lists
            List<string> fornavn = new List<string>();
            List<string> efternavn = new List<string>();
            List<int> alder = new List<int>();

            //Closes and disposes the reader when finished
            using (StreamReader reader = new StreamReader("C:\\Users\\malt2586\\source\\repos\\EX01HelloWorld\\EX19bStreamReader\\Persons.txt"))
            {
                //Read as long it is not the end of the stream
                while (!reader.EndOfStream)
                {
                    //Reads a line from file, splits it, and adds it to a string[]
                    string[] array = reader.ReadLine().Split(',');

                    //Adds values in array to lists
                    fornavn.Add(array[0]);
                    efternavn.Add(array[1]);
                    alder.Add(int.Parse(array[2]));
                }
            }

            //Prints name of the oldest person from the lists
            Console.WriteLine($"\n{fornavn[alder.IndexOf(alder.Max())]} er ældst.");

            //Prints name of the youngest person from the lists
            Console.WriteLine($"\n{fornavn[alder.IndexOf(alder.Min())]} er yngst.");

            //Finds longest surname(Fornavn) in list "fornavn" and prints to console
            int maxFornavn = 0;
            int maxFornavnIndex = 0;
            foreach (string s in fornavn)
            {
                if (s.Length > maxFornavn)
                {
                    maxFornavn = s.Length;
                    maxFornavnIndex = fornavn.IndexOf(s);
                }
            }
            Console.WriteLine($"\n{fornavn[maxFornavnIndex]} her det længste fornavn.");

            //Finds shortest surname(Fornavn) in list "fornavn" and prints to console
            int minFornavn = int.MaxValue;
            int minFornavnIndex = 0;
            foreach (string s in fornavn)
            {
                if (s.Length < minFornavn)
                {
                    minFornavn = s.Length;
                    minFornavnIndex = fornavn.IndexOf(s);
                }
            }
            Console.WriteLine($"\n{fornavn[minFornavnIndex]} har det korteste fornavn.");

            //Finds longest name(Fornavn + Efternavn) in lists ("fornavn", "efternavn") and prints to console
            int maxNavn = 0;
            int maxNavnIndex = 0;
            for (int i = 0; i < fornavn.Count; i++)
            {
                if (fornavn[i].Length + efternavn[i].Length > maxNavn)
                {
                    maxNavn = fornavn[i].Length + efternavn[i].Length;
                    maxNavnIndex = i;
                }
            }
            Console.WriteLine($"\n{fornavn[maxNavnIndex]} {efternavn[maxNavnIndex]} her det længste navn.");

            //Finds shortest name(Fornavn + Efternavn) in lists ("fornavn", "efternavn") and prints to console
            int minNavn = int.MaxValue;
            int minNavnIndex = 0;
            for (int i = 0; i < fornavn.Count; i++)
            {
                if (fornavn[i].Length + efternavn[i].Length < minNavn)
                {
                    minNavn = fornavn[i].Length + efternavn[i].Length;
                    minNavnIndex = i;
                }
            }
            Console.WriteLine($"\n{fornavn[minNavnIndex]} {efternavn[minNavnIndex]} har det korteste navn.");

            //Wait for key press to exit
            Console.ReadKey();
        }

        //Opgave 19.1 ekstra
        //Method returning a list<int> of values from a text file
        private static List<int> GetNumbersFromFile(string url)
        {
            //Creates new empty list
            List<int> values = new List<int>();

            //Closes and disposes the reader when finished
            using (StreamReader reader = new StreamReader(url))
            {
                //Read as long it is not the end of the stream
                while (!reader.EndOfStream)
                {
                    //Reads a line from the text file, parses it to an int, and adds it to the list
                    values.Add(int.Parse(reader.ReadLine()));
                }
            }

            //Returns the list<int> "values"
            return values;
        }

        //Opgave 19.2 ekstra
        //Method returning a list<int> of values from a text file
        private static List<int> GetVolumesFromFile(string url)
        {
            //Creates new empty list
            List<int> boxVolumes = new List<int>();

            //Closes and disposes the reader when finished
            using (StreamReader reader = new StreamReader(url))
            {
                //Read as long it is not the end of the stream
                while (!reader.EndOfStream)
                {
                    //Reads a line from file, splits it, and adds it to a string[]
                    string[] array = reader.ReadLine().Split(',');

                    //Parses values in the array to an int, calculates the volume(int1 * int2 * int3)
                    int boxVolume = int.Parse(array[0]) * int.Parse(array[1]) * int.Parse(array[2]);

                    //Adds the calculated volume to the list
                    boxVolumes.Add(boxVolume); 
                }

                //Returns theh list<int> "boxVolumes"
                return boxVolumes;
            }
        }
    }
}
