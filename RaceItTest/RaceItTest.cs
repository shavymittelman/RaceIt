using RaceItSystem;
using System.Drawing;

namespace RaceItTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStartSetup()
        {
            Game game = new Game();
            game.StartSetup();
            string msg = $"Current Turn: {game.currentturn}, Num Spots: {game.lstspots.Count}";
            Assert.IsTrue(game.currentturn == Game.TurnEnum.Red && game.lstspots.Count == 40, msg);
            TestContext.WriteLine(msg);
        }

        [Test]
        public void TestSwitchTurn()
        {
            Game game = new Game();            
            game.StartSetup();
            string dietxt = game.GenerateDieNumber();
            int dienum = 0;
            int.TryParse(dietxt, out dienum);
            game.SwitchTurn();
            string msg = $"Die Number: {dienum} = Filled Spots: {game.lstspotred.Count(l => l.backcolor == Color.Red) - 1}, Current Turn: {game.currentturn}";
            Assert.IsTrue (dienum == game.lstspotred.Count(l => l.backcolor == Color.Red) - 1 && game.currentturn == Game.TurnEnum.Blue, msg);
            TestContext.WriteLine(msg);
        }
    }
}