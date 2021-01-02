using GameRulesEngine.Core.Contracts;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GameRulesEngine.Core.Tests
{
    public class RuleEvaluatorTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void RuleEvaluator_Exceute_GivenDealer_NotReachedHandCountLimit_ShouldReturnNoWinner()
        {
            var dealer = new DealerDto
            {
                HandCount = 14
            };
            var player = new PlayerDto
            {
                HandCount = 20
            };

            var players = new List<IPlayer>
            {
                dealer,
                player
            };

            var rules = new IRule[]
                {
                    new TestGame2117Rules(players)
                };

            var context = new ContextDto
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
            var dealer = new DealerDto
            {
                HandCount = 17,
                Score = 22
            };
            var player = new PlayerDto
            {
                HandCount = 20,
                Score = 11
            };

            var players = new List<IPlayer>
            {
                dealer,
                player
            };

            var rules = new IRule[]
                {
                    new TestGame2117Rules(players)
                };

            var context = new ContextDto
            {
                CurrentPlayer = dealer,
            };


            var sut = new RuleEvaluator(rules).Exceute(context);

            Assert.AreEqual(1, sut.Count());
            Assert.AreEqual(dealer, sut.First());
        }
    }
}