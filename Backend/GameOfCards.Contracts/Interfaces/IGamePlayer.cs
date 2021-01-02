
using GameRulesEngine.Core.Contracts;

namespace Game_Of_Cards.Contracts
{
    public interface IGamePlayer : IPlayer
    {
        string Name { get; }
        IHand Hand { get; }

        void RecieveCard(ICard selectedCard);
    }
}
