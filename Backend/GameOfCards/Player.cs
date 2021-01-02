using Game_Of_Cards.Contracts;

namespace Game_Of_Cards
{
    public class Player : PlayerBase, IGamePlayer
    {
        public Player()
            :this("Player")
        {
        }

        public Player(string name)
        {
            Name = name;
            Hand = new Hand();
        }

        public string Name { get; set; }

        public decimal Score { get => Hand.TotalValue;  }

        public int HandCount { get => Hand.Count; }
    }
}