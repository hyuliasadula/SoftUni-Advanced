using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songsInPlaylist = new Queue<string>(songs);
            string command = "";

            while (songsInPlaylist.Count != 0)
            {
                command = Console.ReadLine();
                
                if (command == "Play")
                {
                    songsInPlaylist.Dequeue();
                    
                }
                else if (command.StartsWith("Add "))
                {
                    string songToAdd = command.Substring(4);
                    if (!songsInPlaylist.Contains(songToAdd))
                    {
                        songsInPlaylist.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsInPlaylist));
                    
                }
            }

            if (songsInPlaylist.Count == 0)
            {
                Console.WriteLine("No more songs!");
                
            }
        }
    }
}
