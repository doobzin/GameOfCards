using GameRulesEngine.Core.Contracts;
using NUnit.Framework;
using System.Collections.Generic;

namespace ScoreBoard.Core.Tests
{
    public class GameScoreboardTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void Scoreboard_CurrentDeck_ShouldRemoveSelectedCard()
        {
            var player = new PlayerDto();
            var dealer = new DealerDto();

            var rules = new IRule[]
            {
                new TestGame2117Rules(new List<IPlayer> { player, dealer })
            };

            var sut = new Scoreboard.Core.Scoreboard(rules);

            sut.AddPlayer(player);
            sut.AddPlayer(dealer);

            Assert.IsFalse(sut.IsGameOver);
            Assert.IsNull(sut.Winner);
        }
    }
}
