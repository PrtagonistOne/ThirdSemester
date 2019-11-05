using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_4
{
    class Playlist
    {
        public int Seconds { get; set; }
        public int Minutes { get; set; }
        public int Hours { get; set; }

        List<Song> songs = new List<Song>();

        public Playlist() { }

        public void addSong(int size, string artistName, string songName, string songLength, int songMinutes, int songSeconds)
        {
            Song t = new Song(artistName, songName, songLength, songMinutes, songSeconds);
            songs.Add(t);
            Console.WriteLine("Song added");
        }

        public void Display()
        {
            int countAddedSongs = 0;
            for (int i = 0; i < songs.Count; i++)
            {
                
                Minutes += songs[i].SongMinutes;
                Seconds += songs[i].SongSeconds;
                if (Seconds >= 60)
                {
                    Minutes++;
                    Seconds -= 60;
                }
                if (Minutes >= 60)
                {
                    Hours++;
                    Minutes -= 60;
                }
                countAddedSongs++;
            }

            Console.WriteLine($"Songs added: {countAddedSongs}\nPlaylist lenght: {Hours}h {Minutes}m {Seconds}s");
        }

    }
}
