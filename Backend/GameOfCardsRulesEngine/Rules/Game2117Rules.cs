
using Game_Of_Cards.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Game_Of_Cards.RulesEngine
{
    public class Game2117Rules : IRule
    {
        private readonly IEnumerable<IPlayer> _players;

        public Game2117Rules(IEnumerable<IPlayer> players)
        {
            _players = players;
        }

        public IPlayer Execute(IContext context)
        {
            var highScore = _players.Max(o => o.Score);
            return _players.First(o => o.Score == highScore);
        }

        public bool IsApplicable(IContext context)
        {
            var currentPlayer = context.CurrentPlayer;
            if (currentPlayer.GetType().Name is "Dealer" && currentPlayer.Hand.Count >= 16)
            {
                return true;
            }
            if (currentPlayer.GetType().Name is "Player" && currentPlayer.Hand.Count >= 20)
            {
                return true;
            }
            return false;
        }
    }
}
