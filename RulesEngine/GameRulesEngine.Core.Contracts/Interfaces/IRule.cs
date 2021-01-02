

namespace GameRulesEngine.Core.Contracts
{
    public interface IRule
    {
        bool IsApplicable(IContext context);
        IPlayer Execute();
    }
}
