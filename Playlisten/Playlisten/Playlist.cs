using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten
{
    public class Playlist
    {
        private LinkedList<Track> tracks;
        public LinkedList<Track> Tracks
        {
            get { return tracks; }
            private set { tracks = value; }
        }
        public Playlist()
        {
            tracks = new LinkedList<Track>();
        }

        // Loads 3 songs into the playlist to start with.
        public void InitializeTracks()
        {
            tracks.AddLast(new Track("Varm Sommer", "Merro8"));
            tracks.AddLast(new Track("TÆNK PÅ JER", "Benny Jamz"));
            tracks.AddLast(new Track("Karrusel (feat. GMG)", "Gigis"));
        }

        // Adds track to playlist.
        public void AddTrack(string songName, string artist)
        {
            tracks.AddLast(new Track(songName, artist));
        }

        // Showing the whole playlist with a foreach.
        public void ShowPlaylist()
        {
            Console.Clear();
            foreach (var track in tracks)
            {
                Console.WriteLine($"Song: {track.songName}" +
                                $"\nArtist: {track.artist}\r\n");
            }
        }
    }
}
