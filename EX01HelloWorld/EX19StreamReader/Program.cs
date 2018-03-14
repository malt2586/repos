using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EX19StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Opgave 19.1
            //double sum = 0;
            //int counter = 0;

            ////Creates new object of class "StreamReader"
            //StreamReader streamReader = new StreamReader("C:\\Users\\malt2586\\source\\repos\\EX01HelloWorld\\EX19StreamReader\\Values.txt");

            ////While loop reading lines from "Values.txt" and parses them to "sum", and increments "counter"
            //while (!streamReader.EndOfStream)
            //{
            //    sum = sum + int.Parse(streamReader.ReadLine());
            //    counter++;
            //}
            //streamReader.Close();

            ////Prints "sum" and average(sum/counter) to console
            //Console.WriteLine($"Sum: {sum}\nGennemsnit: {sum / counter}");

            ////Opgave 19.1 ekstra
            ////Creates new list "list"
            //List<double> list = new List<double>();

            ////While loop reading lines from "Values.txt" and adds values to list
            //while (!streamReader.EndOfStream)
            //{
            //    list.Add(int.Parse(streamReader.ReadLine()));
            //}
            //streamReader.Close();

            ////Prints the sum of all values from list and the average(sum of values / number of values) to console
            //Console.WriteLine($"Sum: {list.Sum()}\nGennemsnit: {list.Average()}");

            ////Opgave 19.1 ekstra ekstra
            ////Calls method "GetNumberFromFile" with text file "Values.txt" url
            //List<double> list = GetNumbersFromFile("C:\\Users\\malt2586\\source\\repos\\EX01HelloWorld\\EX19StreamReader\\Values.txt");

            ////Prints the sum of all values from list and the average(sum of values / number of values) to console
            //Console.WriteLine($"Sum: {list.Sum()}\nGennemsnit: {list.Average()}");

            ////Opgave 19.2-19.2 ekstra ekstra
            //List<Box> list = GetBoxesFromFile("C:\\Users\\malt2586\\source\\repos\\EX01HelloWorld\\EX19StreamReader\\Boxes.txt");

            //foreach (Box box in list)
            //{
            //    box.PrintInfo();
            //}

            //int minVol = int.MaxValue;
            //int maxVol = 0;
            //int minSurface = int.MaxValue;
            //int maxSurface = 0;

            //foreach (Box box in list)
            //{
            //    box.CalculateVolume();
            //    box.CalculateSurface();
            //    if (box.Volume < minVol)
            //    {
            //        minVol = box.Volume;
            //    }
            //    if (box.Volume > maxVol)
            //    {
            //        maxVol = box.Volume;
            //    }
            //    if (box.Surface < minSurface)
            //    {
            //        minSurface = box.Surface;
            //    }
            //    if (box.Surface > maxSurface)
            //    {
            //        maxSurface = box.Surface;
            //    }
            //}
            //Console.WriteLine($"Mindste volumen: {minVol} cm3");
            //Console.WriteLine($"Højeste volumen: {maxVol} cm3");
            //Console.WriteLine($"Mindste overfladeareal: {minSurface} cm2");
            //Console.WriteLine($"Højeste overfladeareal: {maxSurface} cm2");

            //Opgave 19.3
            List<Person> list = GetPersonsFromFile("C:\\Users\\malt2586\\source\\repos\\EX01HelloWorld\\EX19StreamReader\\Persons.txt");

            //Finds and prints the Person object in list with the highest age(Alder)
            int maxAlder = 0;
            int maxAlderIndex = 0;
            foreach (Person person in list)
            {
                if (person.Alder > maxAlder)
                {
                    maxAlder = person.Alder;
                    maxAlderIndex = list.IndexOf(person);
                }
            }
            Console.WriteLine($"{list[maxAlderIndex].Fornavn} er ældst. Han/hun er {maxAlder} år gammel.");

            //Finds and prints the Person object in list with the lowest age(Alder)
            int minAlder = int.MaxValue;
            int minAlderIndex = 0;
            foreach (Person person in list)
            {
                if (person.Alder < minAlder)
                {
                    minAlder = person.Alder;
                    minAlderIndex = list.IndexOf(person);
                }
            }
            Console.WriteLine($"{list[minAlderIndex].Fornavn} er yngst. Han/hun er {minAlder} år gammel.");

            //Finds and prints the Person object in list with the longest surname(Fornavn)
            int maxFornavn = 0;
            int maxFornavnIndex = 0;
            foreach (Person person in list)
            {
                if (person.Fornavn.Length > maxFornavn)
                {
                    maxFornavn = person.Fornavn.Length;
                    maxFornavnIndex = list.IndexOf(person);
                }
            }
            Console.WriteLine($"{list[maxFornavnIndex].Fornavn} har det længste fornavn.");

            //Finds and prints the Person object in list with the shortest surname(Fornavn)
            int minFornavn = int.MaxValue;
            int minFornavnIndex = 0;
            foreach (Person person in list)
            {
                if (person.Fornavn.Length < minFornavn)
                {
                    minFornavn = person.Fornavn.Length;
                    minFornavnIndex = list.IndexOf(person);
                }
            }
            Console.WriteLine($"{list[minFornavnIndex].Fornavn} har det korteste fornavn.");

            //Finds and prints the Person object in list with the longest name(Fornavn + Efternavn)
            int maxNavn = 0;
            int maxNavnIndex = 0;
            foreach (Person person in list)
            {
                if (person.Fornavn.Length + person.Efternavn.Length > maxNavn)
                {
                    maxNavn = person.Fornavn.Length + person.Efternavn.Length;
                    maxNavnIndex = list.IndexOf(person);
                }
            }
            Console.WriteLine($"{list[maxNavnIndex].Fornavn} {list[maxNavnIndex].Efternavn} har det længste navn.");

            //Finds and prints the Person object in list with the shortest name(Fornavn + Efternavn)
            int minNavn = int.MaxValue;
            int minNavnIndex = 0;
            foreach (Person person in list)
            {
                if (person.Fornavn.Length + person.Efternavn.Length < minNavn)
                {
                    minNavn = person.Fornavn.Length + person.Efternavn.Length;
                    minNavnIndex = list.IndexOf(person);
                }
            }
            Console.WriteLine($"{list[minNavnIndex].Fornavn} {list[minNavnIndex].Efternavn} har det korteste navn.");

            //Opgave 19.3 ekstra
            Console.WriteLine($"{FindOldestPerson(list).Fornavn} er ældst");
            Console.WriteLine($"{FindYoungestPerson(list).Fornavn} er yngst");
            Console.WriteLine($"{FindPersonLongestSurname(list).Fornavn} har det længste fornavn.");
            Console.WriteLine($"{FindPersonShortestSurname(list).Fornavn} har det korteste fornavn.");
            Console.WriteLine($"{FindPersonLongestName(list).Fornavn} {FindPersonLongestName(list).Efternavn} har det længste navn.");
            Console.WriteLine($"{FindPersonShortestName(list).Fornavn} {FindPersonShortestName(list).Efternavn} har det korteste navn.");

            //Wait for key press to exit
            Console.ReadKey();
        }

        ////Opgave 19.1 ekstra ekstra
        ////Method taking a string(url) of a text file and returning a List<double>
        //private static List<double> GetNumbersFromFile(string url)
        //{
        //    //Creates new empty list
        //    List<double> list = new List<double>();

        //    //Creates new StreamReader from text file(url)
        //    StreamReader streamReader = new StreamReader(url);

        //    ////While loop reading lines from text file (url) and adds values to list
        //    while (!streamReader.EndOfStream)
        //    {
        //        list.Add(int.Parse(streamReader.ReadLine()));
        //    }
        //    streamReader.Close();
        //    return list;
        //}

        ////Opgave 19.2
        ////Method taking a string(url) of a text file and returning a List<Box>
        //private static List<Box> GetBoxesFromFile(string url)
        //{
        //    //Creates new empty list
        //    List<Box> list = new List<Box>();

        //    //Creates new StreamReader from text file(url)
        //    StreamReader streamReader = new StreamReader(url);

        //    ////While loop reading lines from text file (url), creates a Box object and adds it to list
        //    while (!streamReader.EndOfStream)
        //    {
        //        string[] array;
        //        array = streamReader.ReadLine().Split(new Char[] { ',' });
        //        list.Add(new Box(int.Parse(array[0]), int.Parse(array[1]), int.Parse(array[2])));
        //    }
        //    streamReader.Close();
        //    return list;
        //}

        //Opgave 19.3-19.3 ekstra
        //Method taking a string(url) of a text file and returning a List<Box>
        private static List<Person> GetPersonsFromFile(string url)
        {
            //Creates new empty list
            List<Person> list = new List<Person>();

            //Creates new StreamReader from text file(url)
            StreamReader streamReader = new StreamReader(url);

            ////While loop reading lines from text file (url), creates a Person object and adds it to list
            while (!streamReader.EndOfStream)
            {
                string[] array;
                array = streamReader.ReadLine().Split(new Char[] { ',' });
                list.Add(new Person(array[0], array[1], int.Parse(array[2])));
            }
            streamReader.Close();
            return list;
        }

        //Method returning Person object of a list with the highest age(Alder)
        private static Person FindOldestPerson(List<Person> persons)
        {
            int maxAlder = 0;
            int maxAlderIndex = 0;
            foreach (Person person in persons)
            {
                if (person.Alder > maxAlder)
                {
                    maxAlder = person.Alder;
                    maxAlderIndex = persons.IndexOf(person);
                }
            }
            Person p = persons[maxAlderIndex];
            return p;
        }

        //Method returning Person object of a list with the lowest age(Alder)
        private static Person FindYoungestPerson(List<Person> persons)
        {
            int minAlder = int.MaxValue;
            int minAlderIndex = 0;
            foreach (Person person in persons)
            {
                if (person.Alder < minAlder)
                {
                    minAlder = person.Alder;
                    minAlderIndex = persons.IndexOf(person);
                }
            }
            Person p = persons[minAlderIndex];
            return p;
        }

        //Method returning Person object of a list with the longest surname(Fornavn)
        private static Person FindPersonLongestSurname(List<Person> persons)
        {
            int maxFornavn = 0;
            int maxFornavnIndex = 0;
            foreach (Person person in persons)
            {
                if (person.Fornavn.Length > maxFornavn)
                {
                    maxFornavn = person.Fornavn.Length;
                    maxFornavnIndex = persons.IndexOf(person);
                }
            }
            Person p = persons[maxFornavnIndex];
            return p;
        }

        //Method returning Person object of a list with the shortest surname(Fornavn)
        private static Person FindPersonShortestSurname(List<Person> persons)
        {
            int minFornavn = int.MaxValue;
            int minFornavnIndex = 0;
            foreach (Person person in persons)
            {
                if (person.Fornavn.Length < minFornavn)
                {
                    minFornavn = person.Fornavn.Length;
                    minFornavnIndex = persons.IndexOf(person);
                }
            }
            Person p = persons[minFornavnIndex];
            return p;
        }

        //Method returning Person object of a list with the longest name (Fornavn + Efternavn)
        private static Person FindPersonLongestName(List<Person> persons)
        {
            int maxNavn = 0;
            int maxNavnIndex = 0;
            foreach (Person person in persons)
            {
                if (person.Fornavn.Length + person.Efternavn.Length > maxNavn)
                {
                    maxNavn = person.Fornavn.Length + person.Efternavn.Length;
                    maxNavnIndex = persons.IndexOf(person);
                }
            }
            Person p = persons[maxNavnIndex];
            return p;
        }

        //Method returning Person object of a list with the shortest name (Fornavn + Efternavn)
        private static Person FindPersonShortestName(List<Person> persons)
        {
            int minNavn = int.MaxValue;
            int minNavnIndex = 0;
            foreach (Person person in persons)
            {
                if (person.Fornavn.Length + person.Efternavn.Length < minNavn)
                {
                    minNavn = person.Fornavn.Length + person.Efternavn.Length;
                    minNavnIndex = persons.IndexOf(person);
                }
            }
            Person p = persons[minNavnIndex];
            return p;
        }
    }
}
