using Game_Of_Cards;
using NUnit.Framework;

namespace GameOfCardsTests
{
    public class PlayerTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void Player_Paramless_CTOR_ShouldReturnDefaults()
        {
            var sut = new Player();

            Assert.AreEqual("Player", sut.Name);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void Player_Param_CTOR_ShouldReturnSetValues()
        {
            var sut = new Player("testPlayer");

            Assert.IsTrue(sut.Score is 0);
            Assert.IsTrue(sut.Hand.TotalValue is 0);
            Assert.AreEqual("testPlayer", sut.Name);
        }
    }
}
