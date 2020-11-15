using Game_Of_Cards.Interfaces;

namespace Game_Of_Cards.RulesEngine
{
    public interface IRule
    {
        bool IsApplicable(IContext context);
        IPlayer Execute(IContext context);
    }
}