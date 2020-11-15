using Game_Of_Cards.Interfaces;

namespace Game_Of_Cards.RulesEngine
{
    public class Context : IContext
    {
        public IPlayer CurrentPlayer { get; set; }
    }
}