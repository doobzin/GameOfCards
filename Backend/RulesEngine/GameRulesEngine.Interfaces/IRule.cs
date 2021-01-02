
namespace GameRulesEngine.Interfaces
{
    public interface IRule
    {
        bool IsApplicable(IContext context);
        IPlayer Execute();
    }
}