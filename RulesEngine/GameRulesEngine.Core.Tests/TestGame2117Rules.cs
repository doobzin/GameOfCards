using GameRulesEngine.Core.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace GameRulesEngine.Core.Tests
{
    internal class TestGame2117Rules : IRule
    {
        private readonly List<IPlayer> _players;

        public TestGame2117Rules(List<IPlayer> players)
        {
            _players = players;
        }

        public IPlayer Execute()
        {
            var highScore = _players.Max(o => o.Score);
            return _players.First(o => o.Score == highScore);
        }

        public bool IsApplicable(IContext context)
        {
            var currentPlayer = context.CurrentPlayer;
            if (currentPlayer.GetType().Name is nameof(DealerDto) && currentPlayer.HandCount >= 16)
            {
                return true;
            }
            if (currentPlayer.GetType().Name is nameof(PlayerDto) && currentPlayer.HandCount >= 20)
            {
                return true;
            }
            return false;
        }
    }
}