using System;
using System.Collections;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    /*
     * 
     * 
     * 
     * 
     * You will be given a sequence of songs, separated by a comma and a single space. After that, you will be given commands until there are no songs enqueued. When there are no more songs in the queue print "No more songs!" and stop the program.
        The possible commands are:
        •	"Play" - plays a song (removes it from the queue)
        •	"Add {song}" - adds the song to the queue, if it isn't contained already, otherwise print "{song} is already contained!"
        •	"Show" - prints all songs in the queue, separated by a comma and a white space (start from the first song in the queue to the last)

     Input                                  Output
    All Over Again, Watch Me                Watch Me is already contained!
    Play                                    Watch Me, Love Me Harder, Promises
    Add Watch Me                            No more songs!
    Add Love Me Harder
    Add Promises
    Show
    Play
    Play
    Play
    Play

     */
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
