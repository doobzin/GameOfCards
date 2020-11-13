

namespace Game_Of_Cards
{
    public interface IPlayer
    {
        string Name { get; }
        int Score { get; }
        Hand Hand { get; }

        void RecieveCard(Card selectedCard);
    }
}
