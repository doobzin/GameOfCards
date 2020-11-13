
namespace Game_Of_Cards
{
    public abstract class PlayerBase
    {
        protected PlayerBase()
        {
        }

        public Hand Hand { get; set; }

        public void RecieveCard(Card selectedCard)
        {
            Hand.Add(selectedCard);
        }
    }
}
