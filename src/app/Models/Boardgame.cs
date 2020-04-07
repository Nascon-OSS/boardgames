using System.Linq;

namespace Boardgames.ConsoleApp.Models
{
    public class Boardgame
    {
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

        public string Name { get; set; }
        public int MinPlayers { get; }
        public int MaxPlayers { get; }
        public Designer Designer { get; }
        public int PlayTime { get; }

        public override string ToString()
        {
            return $"{Name}, {MinPlayers}-{MaxPlayers} spelare. Design: {Designer.Name}. {PlayTime} min per spelare.";
        }
    }

    public class Designer
    {
        public Designer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString() => Name;
    }
}