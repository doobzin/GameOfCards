using GameRulesEngine.Core;
using GameRulesEngine.Core.Contracts;
using Scoreboard.Core.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Scoreboard.Core
{
    public class Scoreboard : IScoreBoard
    {
        private readonly List<IPlayer> _players;
        private readonly RuleEvaluator _ruleEvaluator;

        public Scoreboard(IRule[] rules)
        {
            _players = new List<IPlayer>();
            _ruleEvaluator = new RuleEvaluator(rules);
        }

        public IPlayer Winner { get; set; }
        public bool IsGameOver { get; set; }

        public void AddPlayer(IPlayer player)
        {
            _players.Add(player);
        }

        public void UpdateGameStatus(IPlayer player)
        {
            var context = new ContextDto
            {
                CurrentPlayer = player
            };

            var winner = _ruleEvaluator.Exceute(context).ToList();

            if (winner.Any())
            {
                Winner = winner.First();
                IsGameOver = true;
            }
        }
    }
}
