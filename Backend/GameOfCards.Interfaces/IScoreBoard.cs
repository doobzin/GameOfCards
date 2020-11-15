
namespace Game_Of_Cards.Interfaces
{
    public interface IScoreBoard
    {
        bool IsGameOver { get; set; }

        void UpdateGameStatus(IPlayer player);
    }
}
