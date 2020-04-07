using Boardgames.ConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace Boardgames.ConsoleApp
{
    class Program
    {
        private static List<Boardgame> _games = new List<Boardgame> { new Boardgame("Leif's Quest", "2-4", "Isaac Childres", "90") };

        static void Main(string[] args)
        {
            Console.WriteLine("Boardgame Catalogue of Fear and Death and Nice");

            Console.WriteLine();
            bool keepgoing = true;
            
            while (keepgoing)
            {
                Console.WriteLine("1: Lista spelen");
                Console.WriteLine("2: Lägg till spel");
                Console.WriteLine("9: Avsluta");
                
                var input = Console.ReadLine();

                if (input == "1")
                {
                    foreach (var boardgame in _games)
                    {
                        Console.WriteLine(boardgame);
                    }
                    Console.WriteLine();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Hejsan här lägger man till spel.");
                    Console.WriteLine("1: Ange spelets namn:");
                    var addGameName = Console.ReadLine();

                    Console.WriteLine("2: Ange spelar-antal:");
                    var addGamePlayers = Console.ReadLine();

                    Console.WriteLine("3: Ange designer:");
                    var addGameDesigner = Console.ReadLine();

                    Console.WriteLine("4: Ange spelets längd i minuter per spelare:");
                    var addGameLength = Console.ReadLine();

                    var game = new Boardgame(addGameName, addGamePlayers, addGameDesigner, addGameLength);
                    _games.Add(game);
                }
                else if (input == "9")
                {
                    keepgoing = false;
                }
                else
                {
                    Console.WriteLine("Skriv rätt ditt nöt");
                }
            }
        }
    }
}
