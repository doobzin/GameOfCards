
using Game_Of_Cards.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Game_Of_Cards
{
    public class ScoreBoard : IScoreBoard
    {
        private readonly List<IPlayer> _players;

        public ScoreBoard()
        {
            _players = new List<IPlayer>();
        }

        public IPlayer Winner { get; private set; }
        public bool IsGameOver { get; private set; }

        public void AddPlayer(IPlayer player)
        {
            _players.Add(player);
        }

        public void UpdateGameStatus(IPlayer player)
        {
            var currentPlayer = _players.Find(o => o.Name == player.Name);
            if (currentPlayer != null)
            {
                if (currentPlayer.GetType().Name is nameof(Dealer) && currentPlayer.Hand.Count >= 16)
                {
                    GameOver();
                }
                else if (currentPlayer.GetType().Name is nameof(Player) && currentPlayer.Hand.Count >= 20)
                {
                    GameOver();
                }
            }
        }

        private void GameOver()
        {
            var highScore = _players.Max(o => o.Score);
            Winner = _players.First(o => o.Score == highScore);
            IsGameOver = true;
        }
    }
}