using System;

namespace Problem_4
{
    class Song
    {
        private string artistName;
        private string songName;
        private string songLength;
        public int songMinutes;
        public int songSeconds;

        
        public string ArtistName
        {
            get { return artistName;  }
            set 
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
                }
                else artistName = value;
            }
        }
        public string SongName
        {
            get { return songName; }
            set 
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongException("Song name should be between 3 and 30");
                }
                else songName = value;
            }
        }
        public string SongLength
        {
            get { return songLength; }
            
            set
            {
                string[] duration = value.Split(":");
                int minutes = int.Parse(duration[0]);
                int seconds = int.Parse(duration[1]);
                if (seconds < 0 || seconds > 59 || minutes > 14)
                {
                    throw new InvalidSongLengthException("Invalid Song Length");
                }
                else songLength = value;
            }
        }
        public int SongMinutes
        {
            get { return songMinutes; }
            set
            {
                if (value > 14 || value < 0)
                {
                    throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
                }
                else songMinutes = value;
                
            }
        }
        public int SongSeconds
        {
            get { return songSeconds; }
            set 
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException("Song second should be between 0 and 59");
                }
                else songSeconds = value;
                
            }
        }

        public Song(string artistName, string songName, string songLength, int songMinutes, int songSeconds)
        {
            if ((artistName.Length < 3 || artistName.Length > 20) && (songName.Length < 3 || songName.Length > 30) &&
                (songMinutes <0 || songMinutes> 14) && (songSeconds<0 || songSeconds >59))
            { throw new InvalidSongException("Invalid Song."); }

            else
            ArtistName = artistName;
            SongName = songName;
            SongLength = songLength;
            SongMinutes = songMinutes;
            SongSeconds = songSeconds;
        }

    }
}
