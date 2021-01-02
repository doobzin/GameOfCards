using GameRulesEngine.Core.Contracts;
using NUnit.Framework;
using Plugins.Core;
using System.Collections.Generic;

namespace Plugins.Game_2117_Rules.Tests
{
    public class Game2117RulesTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void Game2117Rules_IsApplicable_Then_Execute_IsGameOver_GivenDealerHandCount_NotReached_ShouldReturnFalse()
        {
            var dealer = new Dealer
            {
                HandCount = 14,
            };
            var player = new Player
            {
                HandCount = 20
            };

            var players = new List<IPlayer>
            {
                dealer,
                player
            };

            var context = new Context
            {
                CurrentPlayer = dealer,
            };

            var sut = new Game2117Rules(players);

            var isTheGameOver = sut.IsApplicable(context);

            IPlayer winner = null;
            if (isTheGameOver)
            {
                winner = sut.Execute();
            }

            Assert.IsFalse(isTheGameOver);
            Assert.IsNull(winner, "If the game is not over, then there should be no winner");
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void Game2117Rules_IsApplicable_Then_Execute_IsGameOver_GivenDealerHandCount_Reached_ShouldReturnTrue()
        {
            var dealer = new Dealer
            {
                HandCount = 17,
                Score = 1
            };
            var player = new Player
            {
                HandCount = 20,
                Score = 0
            };

            var players = new List<IPlayer>
            {
                dealer,
                player
            };

            var context = new Context
            {
                CurrentPlayer = dealer,
            };

            var sut = new Game2117Rules(players);

            var isTheGameOver = sut.IsApplicable(context);

            Assert.IsTrue(isTheGameOver);
            var winner = sut.Execute();

            Assert.IsTrue(isTheGameOver);
            Assert.IsNotNull(winner, "If the game is over, then there should be a winner");
            Assert.AreEqual(dealer, winner);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void Game2117Rules_IsApplicable_Then_Execute_IsGameOver_GivenPlayerHandCount_NotReached_ShouldReturnFalse()
        {
            var dealer = new Dealer
            {
                HandCount = 10
            };
            var player = new Player
            {
                HandCount = 10
            };

            var players = new List<IPlayer>
            {
                dealer,
                player
            };

            var context = new Context
            {
                CurrentPlayer = player,
            };

            var sut = new Game2117Rules(players);

            var isTheGameOver = sut.IsApplicable(context);

            IPlayer winner = null;
            if (isTheGameOver)
            {
                winner = sut.Execute();
            }

            Assert.IsFalse(isTheGameOver);
            Assert.IsNull(winner, "If the game is not over, then there should be no winner");
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void Game2117Rules_IsApplicable_Then_Execute_IsGameOver_GivenPlayerHandCount_Reached_ShouldReturnTrue()
        {
            var dealer = new Dealer
            {
                HandCount = 14,
                Score = 0
            };
            var player = new Player
            {
                HandCount = 22,
                Score = 1
            };

            var players = new List<IPlayer>
            {
                dealer,
                player
            };

            var context = new Context
            {
                CurrentPlayer = player,
            };

            var sut = new Game2117Rules(players);

            var isTheGameOver = sut.IsApplicable(context);

            Assert.IsTrue(isTheGameOver);
            var winner = sut.Execute();

            Assert.IsTrue(isTheGameOver);
            Assert.IsNotNull(winner, "If the game is over, then there should be a winner");
            Assert.AreEqual(player, winner);
        }

    }
}