using GameRulesEngine.Core.Contracts;

namespace Scoreboard.Core.Contracts
{
    public interface IScoreBoard
    {
        bool IsGameOver { get; set; }
        IPlayer Winner { get; set; }
        void UpdateGameStatus(IPlayer player);
    }
}
