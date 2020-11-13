
using System.Collections.Generic;

namespace Game_Of_Cards
{
    public class ScoreBoard
    {
        private readonly List<IPlayer> _players;

        public ScoreBoard()
        {
            _players = new List<IPlayer>();
        }

        public int WinnerTotalScore { get; set;}
        public bool IsGameOver { get; private set; }

        public void AddPlayer(IPlayer player)
        {
            _players.Add(player);
        }

        internal void UpdateGameStatus(IPlayer player)
        {
            var currentPlayer = _players.Find(o => o.Name == player.Name);
            if (currentPlayer != null)
            {
                if (currentPlayer.GetType() is Dealer && currentPlayer.Hand.Count >= 17)
                {
                    WinnerTotalScore = currentPlayer.Score;
                    IsGameOver = true;
                }
                else if (currentPlayer.GetType() is Player && currentPlayer.Hand.Count >= 21)
                {
                    WinnerTotalScore = currentPlayer.Score;
                    IsGameOver = true;
                }
            }
        }
    }
}