namespace _05.Online_Radio_Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class Program
    {
        public static void Main()
        {
            var playlist = new List<Song>();
            var songsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < songsNumber; i++)
            {
                try
                {
                    var songInfo = Console.ReadLine().Split(';');
                    var artistName = songInfo[0];
                    var songName = songInfo[1];
                    var duration = songInfo[2]
                        .Split(':')
                        .Select(int.Parse)
                        .ToArray();
                    var song = new Song(artistName, songName, duration[0], duration[1]);
                    playlist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }

            var totalSeconds = playlist.Sum(p => p.Seconds);
            var totalMinutes = playlist.Sum(p => p.Minutes) + totalSeconds / 60;

            Console.WriteLine($"Songs added: {playlist.Count}");
            Console.WriteLine($"Playlist length: {totalMinutes / 60}h {totalMinutes % 60}m {totalSeconds % 60}s");
        }
    }
}
