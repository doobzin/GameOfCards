

namespace GameRulesEngine.Core.Contracts
{
    public class DealerDto : IPlayer
    {
        public int HandCount { get; set; }

        public decimal Score { get; set; }
    }
}
