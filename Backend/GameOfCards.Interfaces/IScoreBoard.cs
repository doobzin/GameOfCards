
namespace Game_Of_Cards.Interfaces
{
    public interface IScoreBoard
    {
        bool IsGameOver { get; }

        void UpdateGameStatus(IPlayer player);
    }
}
