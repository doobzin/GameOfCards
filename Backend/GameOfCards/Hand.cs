using Game_Of_Cards.Interfaces;
using System.Collections.Generic;

namespace Game_Of_Cards
{
    public class Hand : IHand
    {
        private readonly IPlayer _player;
        private readonly List<ICard> _cards;

        public Hand(IPlayer player)
        {
            TotalValue = 0;
            Count = 0;

            _player = player;
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