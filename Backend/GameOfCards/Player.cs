using Game_Of_Cards.Interfaces;

namespace Game_Of_Cards
{
    public class Player : PlayerBase, IPlayer
    {
        public Player()
            :this("Player")
        {
        }

        public Player(string name)
        {
            Name = name;
            Hand = new Hand(this);
        }

        public string Name { get; set; }

        public int Score { get => Hand.TotalValue; }

    }
}