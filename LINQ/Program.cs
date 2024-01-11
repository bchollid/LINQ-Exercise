using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>() {"Last Of Us", "Cult of the Lamb", "Baldur's Gate 3", "Age of Empires 4", "World of Warcraft", "The Finals" };
            var orderedByLength = videoGames.OrderBy(nameOfGame => nameOfGame.Length);
            foreach(var game in orderedByLength)
            {
                Console.WriteLine(game);
            }
            Console.ReadLine();
        }
    }
}
