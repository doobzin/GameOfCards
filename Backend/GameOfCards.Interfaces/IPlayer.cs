

namespace Game_Of_Cards.Interfaces
{
    public interface IGamePlayer
    {
        string Name { get; }
        int Score { get; }
        int HandCount { get; }
        IHand Hand { get; }

        void RecieveCard(ICard selectedCard);
    }
}
