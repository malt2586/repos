using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EX29WPFMusicLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creates new Playlist object
        private Playlist playlist { get; set; }
        private List<Playlist> playlists = new List<Playlist>();
        
        public MainWindow()
        {
            InitializeComponent();

            //Adds new playlist objects to list "playlists"
            playlists.Add(new Playlist("Playlist-1"));
            playlists.Add(new Playlist("Playlist-2"));

            //Sets source of ComboBox items to list "playlists"
            cbPlaylists.ItemsSource = playlists;

            //Sets source of ListBox items to list in playlist
            lbxTracks.ItemsSource = playlist.Tracks;
        }

        //EVENT HANDLERS
        //_Click on button "btnAddTrack"
        private void btnAddTrack_Click(object sender, RoutedEventArgs e)
        {
            //Evaluates if any of the TextBox are empty
            if (
                tbxArtist.Text.Length != 0 || 
                tbxTitle.Text.Length != 0 || 
                tbxMin.Text.Length != 0 || 
                tbxSec.Text.Length != 0
                )
            {
                //Creates new Track object
                Track t = new Track(tbxArtist.Text, tbxTitle.Text, Convert.ToInt32(tbxMin.Text), Convert.ToInt32(tbxSec.Text));
                //Adds track to playlist
                playlist.AddTrack(t);
                //Updates items in ListBox
                lbxTracks.Items.Refresh();
                //Updates shortest track
                lblShortestTrack.Content = playlist.FindShortestTrack().ToString();
                //Clears content from TextBox
                tbxArtist.Clear();
                tbxTitle.Clear();
                tbxMin.Clear();
                tbxSec.Clear();
            }
            
        }

        //_Click on button "btnRemoveTrack"
        private void btnRemoveTrack_Click(object sender, RoutedEventArgs e)
        {
            //Evaluates if an item is selected
            if (lbxTracks.SelectedItem != null)
            {
                //Removes selected item from playlist
                playlist.RemoveTrack(lbxTracks.SelectedItem as Track);
            }
            //Updates items in ListBox
            lbxTracks.Items.Refresh();
            //Updates shortest track
            lblShortestTrack.Content = playlist.FindShortestTrack().ToString();
        }

        //_SelectionChanged for ComboBox "cbPlaylists"
        private void cbPlaylists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Sets playlist to selected item in ComboBox
            playlist = cbPlaylists.SelectedItem as Playlist;
            //Sets window title to playlist name
            Title = playlist.Name;
            //Updates items in ListBox
            lbxTracks.Items.Refresh();
            //Updates shortest track
            lblShortestTrack.Content = playlist.FindShortestTrack().ToString();
        }

        //_Click on button "btnAddPlaylist"
        private void btnAddPlaylist_Click(object sender, RoutedEventArgs e)
        {
            playlists.Add(new Playlist(tbxPlaylist.Text));
            cbPlaylists.Items.Refresh();
        }

        //_Click on button "btnRemovePlaylist"
        private void btnRemovePlaylist_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show($"Press OK if you want to delete the playlist: {playlist.Name}", "Delete Playlist");

            switch (result)
            {
                case MessageBoxResult.None:
                    break;
                case MessageBoxResult.OK:
                    playlists.Remove(cbPlaylists.SelectedItem as Playlist);
                    break;
                case MessageBoxResult.Cancel:
                    break;
                case MessageBoxResult.Yes:
                    break;
                case MessageBoxResult.No:
                    break;
                default:
                    break;
            }
        }

        //METHODS
        //Finds shortest track from all playlists
        private Track FindShortestTrackAll()
        {
            //Index of playlist (shortest track)
            int playlistIndex = 0;
            //Length of shortest track
            int minTrackLength = int.MaxValue;
            //New Track object
            Track track;
            //Itterates through playlists
            foreach (Playlist pl in playlists)
            {
                //Evaluates if track is shorter
                if ((pl.FindShortestTrack().Min * 60) + pl.FindShortestTrack().Sec <= minTrackLength)
                {
                    //Sets values of shortes track/playlist (length, index)
                    minTrackLength = (pl.FindShortestTrack().Min * 60) + pl.FindShortestTrack().Sec;
                    playlistIndex = playlists.IndexOf(pl);
                }
            }

            track = playlists[playlistIndex].FindShortestTrack();
            return track;
        }
    }
}
