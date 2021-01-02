

namespace GameRulesEngine.Core.Contracts
{
    public class ContextDto : IContext
    {
        public IPlayer CurrentPlayer { get; set; }
    }
}
