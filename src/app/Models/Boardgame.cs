using System.Collections.Generic;
using System.Linq;

namespace Boardgames.ConsoleApp.Models
{
    public class Boardgame
    {
        public Boardgame()
        { 

        }
        public Boardgame(string name, string playersString, string designerName, string gameLength)
        {
            // 1-3
            var playersNums = playersString.Split('-').Select(num => int.Parse(num)).ToArray();
            Name = name;
            MinPlayers = playersNums[0];
            MaxPlayers = playersNums[1];
            Designer = new Designer(designerName);
            PlayTime = int.Parse(gameLength);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int MinPlayers { get; }
        public int MaxPlayers { get; }
        public int DesignerId { get; set; }
        public Designer Designer { get; }
        public int PlayTime { get; }
        
        public override string ToString()
        {
            return $"{Name}, {MinPlayers}-{MaxPlayers} spelare. Design: {Designer.Name}. {PlayTime} min per spelare.";
        }
    }

    public class Designer
    {
        public Designer()
        {

        }
        public Designer(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Boardgame> Boardgames { get; set; }
      
        public override string ToString() => Name;
    }
}