using Game_Of_Cards.Interfaces;

namespace Game_Of_Cards.RulesEngine
{
    public interface IContext
    {
        IPlayer CurrentPlayer { get; }
    }
}