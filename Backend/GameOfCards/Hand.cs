using System.Collections.Generic;

namespace Game_Of_Cards
{
    public class Hand
    {
        private readonly IPlayer _player;
        private readonly List<Card> _cards;

        public Hand(IPlayer player)
        {
            TotalValue = 0;
            Count = 0;

            _player = player;
            _cards = new List<Card>();
        }

        public int TotalValue { get; private set; }
        public int Count { get; private set; }

        public List<Card> Add(Card card)
        {
            _cards.Add(card);

            Count++;
            TotalValue += card.Value;

            return _cards;
        }
    }
}