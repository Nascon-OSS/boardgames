using Boardgames.ConsoleApp.Models;
using NUnit.Framework;

namespace Boardgames.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var boardgame = new Boardgame("Leif's Quest", "1-4", "50");

            Assert.That(boardgame.Name, Is.EqualTo("Leif's Quest"));
        }
    }
}