
using GameRulesEngine.Core.Contracts;

namespace Scoreboard.Core.Interface
{
    public interface IScoreboard
    {
        bool IsGameOver { get; set; }
        void UpdateGameStatus(IPlayer player);
    }
}
