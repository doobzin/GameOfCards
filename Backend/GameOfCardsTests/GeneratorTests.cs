using Game_Of_Cards;
using NUnit.Framework;

namespace GameOfCardsTests
{
    public class GeneratorTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void Generator_Deck_Default_ShouldReturn_52Cards()
        {
            var sut = new Generator();

            var result = sut.Deck;

            Assert.IsTrue(result.Count is 52);
        }
    }
}