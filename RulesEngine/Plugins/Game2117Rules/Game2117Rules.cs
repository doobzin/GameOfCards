
using GameRulesEngine.Core.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Plugins.Game_2117_Rules
{
    public class Game2117Rules : IRule
    {
        private readonly IEnumerable<IPlayer> _players;

        public Game2117Rules(IEnumerable<IPlayer> players)
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
            if (currentPlayer.GetType().Name is "Dealer" && currentPlayer.HandCount >= 16)
            {
                return true;
            }
            if (currentPlayer.GetType().Name is "Player" && currentPlayer.HandCount >= 20)
            {
                return true;
            }
            return false;
        }
    }
}
