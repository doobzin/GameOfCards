using GameRulesEngine.Core.Contracts;

namespace Plugins.Core
{
    public class Context : IContext
    {
        public IPlayer CurrentPlayer { get; set; }
    }
}
