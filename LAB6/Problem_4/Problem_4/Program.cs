using System;

namespace Problem_4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input the amount of song to add: ");
            int n = int.Parse(Console.ReadLine());

            Playlist song = new Playlist();

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(';', ':');
                string length = s[2] + ":" + s[3];
                try
                {
                    song.addSong(n, s[0], s[1], length, int.Parse(s[2]), int.Parse(s[3]));
                }
                catch (InvalidSongException ise)
                { Console.WriteLine(ise.Message); }

                catch (InvalidArtistNameException iane)
                { Console.WriteLine(iane.Message); }

                catch (InvalidSongNameException isne)
                { Console.WriteLine(isne.Message); }

                catch (InvalidSongLengthException isle)
                { Console.WriteLine(isle.Message); }

                catch (InvalidSongMinutesException isme)
                { Console.WriteLine(isme.Message); }

                catch (InvalidSongSecondsException isse)
                { Console.WriteLine(isse.Message); }
            }

            song.Display();

        }
    }
}
