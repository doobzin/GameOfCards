using Game_Of_Cards;
using NUnit.Framework;

namespace GameOfCardsTests
{
    public class DealerTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void Dealer_Paramless_CTOR_ShouldReturnDefaults()
        {
            var sut = new Dealer();

            Assert.IsTrue(sut.Score is 0);
            Assert.AreEqual("Dealer", sut.Name);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void Dealer_Param_CTOR_ShouldReturnSetValues()
        {
            var sut = new Dealer("testDealer");

            Assert.IsTrue(sut.Score is 0);
            Assert.AreEqual("testDealer", sut.Name);
        }
    }
}
