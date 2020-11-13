
using Game_Of_Cards;
using NUnit.Framework;

namespace GameOfCardsTests
{
    public class GameOfCardsTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_Player_Score_ShouldUpdate()
        {
            var scoreboard = new ScoreBoard();

            var sut = new GameOfCards(scoreboard);

            var humanPlayer = new Player();

            sut.DealTo(humanPlayer);

            Assert.IsTrue(humanPlayer.Score != 0);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_CurrentDeck_ShouldRemoveSelectedCard()
        {
            var scoreboard = new ScoreBoard();

            var sut = new GameOfCards(scoreboard);

            Assert.IsTrue(sut.CurrentDeck.Count is 52);

            sut.DealTo(new Dealer("testDealer"));

            Assert.IsTrue(sut.CurrentDeck.Count is 51);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void GameOfCards_ScoreBoard_CTOR_ShouldDefalt()
        {
            var scoreboard = new ScoreBoard();

            var sut = new GameOfCards(scoreboard);

            Assert.IsTrue(sut.CanStillDeal);
            Assert.IsTrue(sut.CurrentDeck.Count is 52);
            Assert.IsTrue(sut.ScoreBoard.IsGameOver is false);
            Assert.IsTrue(sut.ScoreBoard.WinnerTotalScore is 0);
        }

    }
}
