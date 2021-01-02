using Game_Of_Cards.Contracts;

namespace Game_Of_Cards
{
    public class Dealer : PlayerBase, IGamePlayer
    {
        public Dealer()
            :this("Dealer")
        {
        }

        public Dealer(string name)
        {
            Name = name;
            Hand = new Hand();
        }

        public string Name { get; private set; }

        public decimal Score { get => Hand.TotalValue; internal set { _ = value; } }

        public int HandCount { get => Hand.Count; set { _ = value; } }
    }
}