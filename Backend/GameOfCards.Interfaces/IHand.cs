using System.Collections.Generic;

namespace Game_Of_Cards.Interfaces
{
    public interface IHand
    {
        int TotalValue { get; }
        int Count { get; }

        List<ICard> Add(ICard card);
    }
}