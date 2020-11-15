
using Game_Of_Cards;
using Game_Of_Cards.Interfaces;
using Game_Of_Cards.RulesEngine;
using NUnit.Framework;
using System.Collections.Generic;

namespace GameOfCardsRuresEngineTests
{
    public class Game2117RulesTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void Game2117Rules_IsApplicable_Then_Execute_IsGameOver_GivenDealerHandCount_NotReached_ShouldReturnFalse()
        {
            var dealersHand = new Hand();
            dealersHand.Add(new Card("card-4", "4"));
            dealersHand.Add(new Card("card-10", "10"));

            var playersHand = new Hand();
            playersHand.Add(new Card("card-J", "10"));
            playersHand.Add(new Card("card-10", "10"));

            var dealer = new Dealer
            {
                Hand = dealersHand
            };
            var player = new Player
            {
                Hand = playersHand
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
                winner = sut.Execute(context);
            }

            Assert.IsFalse(isTheGameOver);
            Assert.IsNull(winner, "If the game is not over, then there should be no winner");
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void Game2117Rules_IsApplicable_Then_Execute_IsGameOver_GivenDealerHandCount_Reached_ShouldReturnTrue()
        {
            var dealersHand = new Hand();

            for (int i = 0; i < 9; i++)
            {
                dealersHand.Add(new Card("card-4", "4"));
                dealersHand.Add(new Card("card-10", "10"));
            }

            var playersHand = new Hand();
            playersHand.Add(new Card("card-J", "10"));
            playersHand.Add(new Card("card-10", "10"));

            var dealer = new Dealer
            {
                Hand = dealersHand
            };
            var player = new Player
            {
                Hand = playersHand
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
            var winner = sut.Execute(context);

            Assert.IsTrue(isTheGameOver);
            Assert.IsNotNull(winner, "If the game is over, then there should be a winner");
            Assert.AreEqual(dealer, winner);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void Game2117Rules_IsApplicable_Then_Execute_IsGameOver_GivenPlayerHandCount_NotReached_ShouldReturnFalse()
        {
            var dealersHand = new Hand();
            dealersHand.Add(new Card("card-4", "4"));
            dealersHand.Add(new Card("card-10", "10"));

            var playersHand = new Hand();
            playersHand.Add(new Card("card-J", "10"));
            playersHand.Add(new Card("card-10", "10"));

            var dealer = new Dealer
            {
                Hand = dealersHand
            };
            var player = new Player
            {
                Hand = playersHand
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
                winner = sut.Execute(context);
            }

            Assert.IsFalse(isTheGameOver);
            Assert.IsNull(winner, "If the game is not over, then there should be no winner");
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void Game2117Rules_IsApplicable_Then_Execute_IsGameOver_GivenPlayerHandCount_Reached_ShouldReturnTrue()
        {
            var dealersHand = new Hand();

            dealersHand.Add(new Card("card-4", "4"));
            dealersHand.Add(new Card("card-10", "10"));

            var playersHand = new Hand();
            for (int i = 0; i < 12; i++)
            {
                playersHand.Add(new Card("card-J", "10"));
                playersHand.Add(new Card("card-10", "10"));
            }

            var dealer = new Dealer
            {
                Hand = dealersHand
            };
            var player = new Player
            {
                Hand = playersHand
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
            var winner = sut.Execute(context);

            Assert.IsTrue(isTheGameOver);
            Assert.IsNotNull(winner, "If the game is over, then there should be a winner");
            Assert.AreEqual(player, winner);
        }

    }
}
