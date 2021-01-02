using GameRulesEngine.Core.Contracts;

namespace Plugins.Core
{
    public class Dealer : IPlayer
    {
        public decimal Score { get; set; }
        public int HandCount { get; set; }
    }
}
