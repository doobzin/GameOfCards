

namespace GameRulesEngine.Core.Contracts
{
    public class PlayerDto : IPlayer
    {
        public int HandCount { get; set; }
        public decimal Score { get; set; }
    }
}
