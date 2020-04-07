using System.Collections.Generic;
using System.Linq;

namespace Boardgames.ConsoleApp.Models
{
    public class Boardgame
    {
        public Boardgame()
        {

        }
        public Boardgame(string name, string playersString, string gameLength)
        {
            // 1-3
            var playersNums = playersString.Split('-').Select(int.Parse).ToArray();
            Name = name;
            MinPlayers = playersNums[0];
            MaxPlayers = playersNums[1];
            PlayTime = int.Parse(gameLength);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int GameDesignerId { get; set; }
        public Gamedesigner GameDesigner { get; set; }
        public int PlayTime { get; set; }

        public override string ToString()
        {
            return $"{Name}, {MinPlayers}-{MaxPlayers} spelare. Design: {GameDesigner?.Name}. {PlayTime} min per spelare.";
        }
    }

    public class Gamedesigner
    {
        public Gamedesigner()
        {

        }
        public Gamedesigner(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Boardgame> Boardgames { get; set; }

        public override string ToString() => Name;
    }
}