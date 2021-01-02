using GameRulesEngine.Core.Contracts;

namespace Plugins.Core
{
    public class Player : IPlayer
    {
        public decimal Score { get; set; }

        public int HandCount { get; set; }
    }
}
