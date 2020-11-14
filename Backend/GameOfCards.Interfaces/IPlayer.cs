

namespace Game_Of_Cards.Interfaces
{
    public interface IPlayer
    {
        string Name { get; }
        int Score { get; }
        IHand Hand { get; }

        void RecieveCard(ICard selectedCard);
    }
}
