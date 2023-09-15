using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlisten
{
    public class Track
    {
        private string _songName;
        private string _artist;

        public string songName
        {
            get { return _songName; }
            private set { _songName = value; }
        }
        public string artist
        {
            get { return _artist; }
            private set { _artist = value; }
        }
        public Track(string songName, string artist)
        {
            _songName = songName;
            _artist = artist;
        }
    }
}
