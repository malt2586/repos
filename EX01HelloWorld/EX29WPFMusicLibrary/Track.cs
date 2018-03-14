using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX29WPFMusicLibrary
{
    class Track
    {
        //PROPERTIES
        string Artist;
        string Title;
        public int Min { get; private set; }
        public int Sec { get; private set; }

        //CONSTRUCTORS
        public Track(string artist, string title, int min, int sec)
        {
            Artist = artist;
            Title = title;
            Min = min;
            Sec = sec;
        }

        //METHODS
        //Overrides ToString() - returns properties in string format "Title: Artist (mm:ss)"
        public override string ToString()
        {
            //Evaluates if string property "Artist" is empty
            if (Artist == "")
            {
                //Returns string message
                return "No tracks in playlist";
            }
            else
            {
                //Returns properties in string format
                return $"{Title}: {Artist} ({Min}:{Sec.ToString("D2")})";
            }
        }
    }
}
