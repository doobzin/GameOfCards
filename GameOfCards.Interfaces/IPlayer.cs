
using System.Collections.Generic;

namespace GameOfCards
{
    public interface IPlayer
    {
        string Name { get; }
        int Score { get; }
        Hand Hand { get; }

        void RecieveCard(Card selectedCard);
    }
}
