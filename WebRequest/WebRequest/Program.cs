using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebRequestOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMenu();
        }

        /// <summary>
        /// Returns collection of all paragraphs from Wikipedia article based on search input.
        /// </summary>
        static IEnumerable<HtmlNode> GetFromWeb(string searchInput)
        {
            var html = @"https://en.wikipedia.org/wiki/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html + searchInput);
            var nodes = htmlDoc.DocumentNode.Descendants("p");
            return nodes;
        }

        /// <summary>
        /// Search Wikipedia based on user input. 
        /// </summary>
        static void WikiSearch()
        {
            Console.Clear();
            Console.Write("Search input: ");
            string searchInput = Console.ReadLine();
            var nodes = GetFromWeb(searchInput);
            if (nodes.Count() > 1)
            {
                NavigateParagraphs(nodes);
            }
            else
            {
                Console.Clear();
                Console.Write("Your search gave no results... Press any key to continue.");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Controls navigation through paragraphs. 
        /// </summary>
        static void NavigateParagraphs(IEnumerable<HtmlNode> nodes)
        {
            List<HtmlNode> paragraphs = nodes.ToList();
            HtmlNode currParagraph = paragraphs.First();

            Console.Clear();
            Console.WriteLine(currParagraph.InnerText);
            Console.Write("\nUse arrow keys to navigate article [left/right]\nPress Enter to return...");

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (paragraphs.IndexOf(currParagraph) > 0)
                        {
                            currParagraph = paragraphs.ElementAt(paragraphs.IndexOf(currParagraph) - 1);
                            Console.Clear();
                            Console.WriteLine(currParagraph.InnerText);
                            Console.Write("\nUse arrow keys to navigate article [left/right]\nPress Enter to return...");
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (paragraphs.IndexOf(currParagraph) < paragraphs.Count - 1)
                        {
                            currParagraph = paragraphs.ElementAt(paragraphs.IndexOf(currParagraph) + 1);
                            Console.Clear();
                            Console.WriteLine(currParagraph.InnerText);
                            Console.Write("\nUse arrow keys to navigate article [left/right]\nPress Enter to return...");
                        }
                        break;
                    default:
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.Enter);
        }

        /// <summary>
        /// Controls program execution based on user input.
        /// </summary>
        static void ConsoleMenu()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.Clear();
                Console.WriteLine("WebRequest - Menu.\n\nSearch Wikipedia [1]\nExit [2]");
                Console.Write("Select option: ");
                keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        WikiSearch();
                        break;
                    default:
                        break;
                }
            } while (keyInfo.Key != ConsoleKey.D2);
        }

        //static string GetWebPage(string input)
        //{
        //    string output = "";
        //    string httpBaseString = "https://en.wikipedia.org/wiki/";
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{httpBaseString}{input}");
        //    using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //    {
        //        Stream receiveStream = response.GetResponseStream();
        //        using(StreamReader readStream = new StreamReader(receiveStream))
        //        {
        //            output = readStream.ReadToEnd();
        //        }
        //    }
        //    return output;
        //}
    }
}
