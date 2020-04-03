using System;

namespace Boardgames.ConsoleApp
{
    class Program
    {
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
                    Console.WriteLine("Leif's Quest, 4 spelare, Isaac Childres, 90 minuter per spelare");
                }
                else if (input == "2")
                {
                    Console.WriteLine("UNDER CONSTRUCTION");
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
