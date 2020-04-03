namespace Boardgames.ConsoleApp.Models
{
    public class Boardgame
    {
        public Boardgame(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}