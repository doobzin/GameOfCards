using Game_Of_Cards;
using Game_Of_Cards.Interfaces;
using Game_Of_Cards.RulesEngine;
using NUnit.Framework;
using System.Collections.Generic;

namespace GameOfCardsTests
{
    public class ScoreBoardTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void ScoreBoard_CurrentDeck_ShouldRemoveSelectedCard1()
        {
            var player = new Player();
            var dealer = new Dealer();

            var rules = new IRule[]
            {
                new Game2117Rules(new List<IPlayer> { player, dealer })
            };

            var sut = new ScoreBoard(rules);

            sut.AddPlayer(player);
            sut.AddPlayer(dealer);
        }
    }
}
