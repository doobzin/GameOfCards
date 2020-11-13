using Game_Of_Cards;
using NUnit.Framework;
using System.Collections.Generic;

namespace GameOfCardsTests
{
    public class HandTests
    {
        [Test]
        [Author("Siphamandla Dube")]
        public void Hand_Param_CTOR_ShouldReturnSetValues()
        {
            var sut = new Hand(new Player());

            Assert.IsTrue(sut.TotalValue is 0);
            Assert.IsTrue(sut.Count is 0);
        }

        [Test]
        [Author("Siphamandla Dube")]
        public void Hand_Add_ShouldReturnAddCard_And_UpdateValues()
        {
            var card = new Card(new Dictionary<string, string> 
            { 
                { "Diamonds-2", "2" } 
            });

            var sut = new Hand(new Player());
            
            List<Card> result = sut.Add(card);

            Assert.IsTrue(result.Count is 1);

            Assert.IsTrue(sut.TotalValue is 2);
            Assert.IsTrue(sut.Count is 1);
        }
    }
}
