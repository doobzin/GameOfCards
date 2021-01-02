using Game_Of_Cards.Contracts;
using System.Collections.Generic;

namespace Game_Of_Cards
{
    public class Hand : IHand
    {
        private readonly List<ICard> _cards;

        public Hand()
        {
            TotalValue = 0;
            Count = 0;

            _cards = new List<ICard>();
        }

        public int TotalValue { get; private set; }
        public int Count { get; private set; }

        public List<ICard> Add(ICard card)
        {
            _cards.Add(card);

            Count++;
            TotalValue += card.Value;

            return _cards;
        }
    }
}