
using Game_Of_Cards;
using Game_Of_Cards.Interfaces;
using Game_Of_Cards.RulesEngine;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GameOfCardsRuresEngineTests
{
    public class RuleEvaluatorTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void RuleEvaluator_Exceute_GivenDealer_NotReachedHandCountLimit_ShouldReturnNoWinner()
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

            var rules = new IRule[]
                {
                    new Game2117Rules(players)
                };

            var context = new Context
            {
                CurrentPlayer = dealer,
            };


            var sut = new RuleEvaluator(rules).Exceute(context).ToList();

            Assert.AreEqual(0, sut.Count);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void RuleEvaluator_Exceute_GivenDealer_ReachedHandCountLimit_ShouldReturnWinner()
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

            var rules = new IRule[]
                {
                    new Game2117Rules(players)
                };

            var context = new Context
            {
                CurrentPlayer = dealer,
            };


            var sut = new RuleEvaluator(rules).Exceute(context);

            Assert.AreEqual(1, sut.Count());
            Assert.AreEqual(dealer, sut.First());
        }
    }
}
