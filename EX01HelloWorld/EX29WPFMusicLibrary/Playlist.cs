using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX29WPFMusicLibrary
{
    class Playlist
    {
        //PROPERTIES
        public string Name { get; private set; }
        public List<Track> Tracks { get; private set; }

        //CONSTRUCTORS
        public Playlist(string name)
        {
            Name = name;
            Tracks = new List<Track>();
        }

        //METHODS
        //Adds track to playlist
        public void AddTrack(Track t)
        {
            Tracks.Add(t);
        }

        //Removes track from playlist
        public void RemoveTrack(Track t)
        {
            Tracks.Remove(t);
        }

        //Finds and returns shortest track in playlist
        public Track FindShortestTrack()
        {
            //Index of shortest track
            int trackIndex = 0;
            //Length of shortest track
            int minTrackLength = int.MaxValue;
            //New Track object
            Track track;
            //Itterates through list
            foreach (Track t in Tracks)
            {
                //Evaluates if track is shorter
                if ((t.Min * 60) + t.Sec <= minTrackLength)
                {
                    //Sets values of shortes track (length, index)
                    minTrackLength = (t.Min * 60) + t.Sec;
                    trackIndex = Tracks.IndexOf(t);
                }
            }
            //Evaluates if list is empty
            if (Tracks.Count != 0)
            {
                //New track object from playlist
                track = Tracks[trackIndex];
            }
            else
            {
                //New empty track object
                track = new Track("", "", 0, 0);
            }
            //Returns track object
            return track;
        }

        //Overrides ToString() - returns "Name" property
        public override string ToString()
        {
            return Name;
        }
    }
}
