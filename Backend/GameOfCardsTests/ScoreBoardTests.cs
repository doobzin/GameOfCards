using Game_Of_Cards;
using NUnit.Framework;

namespace GameOfCardsTests
{
    public class ScoreBoardTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_CurrentDeck_ShouldRemoveSelectedCard1()
        {
            var sut = new ScoreBoard();

            sut.AddPlayer(new Player());
        }
    }
}
