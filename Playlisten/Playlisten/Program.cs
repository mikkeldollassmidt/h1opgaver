using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Playlisten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects and initiliazing tracks to playlist.
            Playlist p = new Playlist();
            GUI g = new GUI();
            p.InitializeTracks();

            // WHile loop to stay in menu.
            while (true)
            {
                // Creates main menu.
                g.MainMenu();

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        p.ShowPlaylist();
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Write the song name:");
                        string songName = Console.ReadLine();
                        Console.WriteLine("Write the artist name:");
                        string artistName = Console.ReadLine();
                        p.AddTrack($"{songName}", $"{artistName}");
                        Console.Clear();
                        Console.WriteLine("Song added.");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
