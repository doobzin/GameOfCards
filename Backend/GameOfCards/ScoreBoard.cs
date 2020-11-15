
using Game_Of_Cards.Interfaces;
using Game_Of_Cards.RulesEngine;
using System.Collections.Generic;
using System.Linq;

namespace Game_Of_Cards
{
    public class ScoreBoard : IScoreBoard
    {
        private readonly List<IPlayer> _players;
        private readonly RuleEvaluator _ruleEvaluator;

        public ScoreBoard(IRule[] rules)
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
            var context = new Context
            { 
                CurrentPlayer = player 
            };

            var winner = _ruleEvaluator.Exceute(context).ToList();

            if (winner.Count() != 0)
            {
                Winner = winner.First();
                IsGameOver = true;
            }
        }
    }
}