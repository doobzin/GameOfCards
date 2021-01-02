namespace Game_Of_Cards.Interfaces
{
    public interface IGameRule
    {
        bool IsApplicable(IGameContext context);
        IGamePlayer Execute();
    }
}
