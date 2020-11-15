
using Game_Of_Cards;
using Game_Of_Cards.Interfaces;
using Game_Of_Cards.RulesEngine;
using NUnit.Framework;
using System.Collections.Generic;

namespace GameOfCardsTests
{
    public class GameOfCardsTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_Player_Score_ShouldUpdate()
        {
            var scoreboard = new ScoreBoard(new IRule[] { });

            var sut = new GameOfCards(scoreboard);

            var humanPlayer = new Player();

            sut.DealTo(humanPlayer);

            Assert.IsTrue(humanPlayer.Score != 0);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_CurrentDeck_ShouldRemoveSelectedCard()
        {
            var scoreboard = new ScoreBoard(new IRule[] { });

            var sut = new GameOfCards(scoreboard);

            Assert.IsTrue(sut.CurrentDeck.Count is 52);

            sut.DealTo(new Dealer("testDealer"));

            Assert.IsTrue(sut.CurrentDeck.Count is 51);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_ScoreBoard_CTOR_ShouldDefalt()
        {
            var scoreboard = new ScoreBoard(new IRule[] { });

            var sut = new GameOfCards(scoreboard);

            Assert.IsTrue(sut.CanStillDeal);
            Assert.IsTrue(sut.CurrentDeck.Count is 52);
            Assert.IsTrue(scoreboard.IsGameOver is false);
            Assert.IsNull(scoreboard.Winner);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_PlayerHandCount_GreaterThen_21_ShouldWin()
        {
            var player = new Player();
            var dealer = new Dealer();

            var rules = new IRule[]
            {
                new Game2117Rules(new List<IPlayer> { player, dealer })
            };

            var scoreboard = new ScoreBoard(rules);
            scoreboard.AddPlayer(player);
            scoreboard.AddPlayer(dealer);

            var sut = new GameOfCards(scoreboard);

            var times = sut.CurrentDeck.Count;

            for (int i = 0; i < times; i++)
            {
                sut.DealTo(player);
            }

            Assert.IsFalse(sut.CanStillDeal);
            Assert.IsTrue(sut.CurrentDeck.Count is 31);
            Assert.IsTrue(scoreboard.IsGameOver is true);
            Assert.AreEqual(player, scoreboard.Winner);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_DealerHandCount_GreaterThen_17_ShouldWin()
        {
            var player = new Player();
            var dealer = new Dealer();

            var rules = new IRule[]
            {
                new Game2117Rules(new List<IPlayer> { player, dealer })
            };

            var scoreboard = new ScoreBoard(rules);
            scoreboard.AddPlayer(player);
            scoreboard.AddPlayer(dealer);

            var sut = new GameOfCards(scoreboard);

            var times = sut.CurrentDeck.Count;

            for (int i = 0; i < times; i++)
            {
                sut.DealTo(dealer);
            }

            Assert.IsFalse(sut.CanStillDeal);
            Assert.IsTrue(sut.CurrentDeck.Count is 35);
            Assert.IsTrue(scoreboard.IsGameOver is true);
            Assert.AreEqual(dealer, scoreboard.Winner);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_Dealer_Vs_Player_And_Player_ShouldWin()
        {
            var player = new Player();
            var dealer = new Dealer();

            var rules = new IRule[]
            {
                new Game2117Rules(new List<IPlayer> { player, dealer })
            };

            var scoreboard = new ScoreBoard(rules);
            scoreboard.AddPlayer(player);
            scoreboard.AddPlayer(dealer);

            var sut = new GameOfCards(scoreboard);

            var times = sut.CurrentDeck.Count;

            for (int i = 0; i < times; i++)
            {
                sut.DealTo(dealer);
                sut.DealTo(player);
                sut.DealTo(player);
                sut.DealTo(player);
            }

            Assert.IsFalse(sut.CanStillDeal);
            Assert.IsTrue(sut.CurrentDeck.Count is 24);
            Assert.IsTrue(scoreboard.IsGameOver is true);
            Assert.AreEqual(player, scoreboard.Winner);
        }
    }
}
