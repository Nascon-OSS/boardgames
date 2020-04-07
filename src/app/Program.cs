using Boardgames.ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Boardgames.ConsoleApp
{
    class Program
    {
        //private static List<Boardgame> _games = new List<Boardgame> { new Boardgame("Leif's Quest", "2-4", "Isaac Childres", "90") };

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
                    using (var db = new BoardgameContext())
                    {
                        foreach (var boardgame in db.Boardgames)
                        {
                            Console.WriteLine(boardgame);
                        }
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

                    var game = new Boardgame(addGameName, addGamePlayers, addGameLength);

                    using var db = new BoardgameContext();

                    var designer = db.Gamedesigners.FirstOrDefault(d => d.Name == addGameDesigner) ?? new Gamedesigner(addGameDesigner);

                    game.GameDesigner = designer;

                    db.Boardgames.Add(game);
                    db.SaveChanges();

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
    public class BoardgameContext : DbContext
    {
        public DbSet<Boardgame> Boardgames { get; set; }
        public DbSet<Gamedesigner> Gamedesigners { get; set; }

        public BoardgameContext() : this(new DbContextOptions<BoardgameContext>())
        {
        }

        public BoardgameContext(DbContextOptions<BoardgameContext> options) :base(options)
        {
            //Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=boardgames.db");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Gamedesigner>().HasData(new Gamedesigner("Lars Olsson") {Id = 1});
            modelBuilder.Entity<Boardgame>().HasData(new Boardgame { Id = 1, Name = "Leffes' Quest", MinPlayers = 2, MaxPlayers = 5, GameDesignerId = 1, PlayTime = 30 });
        }
    }
}
