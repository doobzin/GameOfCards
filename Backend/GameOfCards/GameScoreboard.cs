using Game_Of_Cards.Contracts;
using GameRulesEngine.Core.Contracts;
using Scoreboard.Core.Contracts;

namespace Game_Of_Cards
{
    public class GameScoreboard : IGameScoreboard
    {
        private readonly IScoreBoard _scoreService;

        public GameScoreboard(IRule[] rules)
        {
            IRule[] _rules = rules;

            _scoreService = new Scoreboard.Core.Scoreboard(_rules);
        }

        public bool IsGameOver { get; set; }

        public IPlayer Winner { get; set; }

        public void UpdateGameStatus(IPlayer player)
        {
            _scoreService.UpdateGameStatus(player);
            IsGameOver = _scoreService.IsGameOver;
            Winner = _scoreService.Winner;
        }
    }
}
