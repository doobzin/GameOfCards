﻿using Game_Of_Cards.Contracts;

namespace Game_Of_Cards
{
    public abstract class PlayerBase
    {
        protected PlayerBase()
        {
        }

        public IHand Hand { get; set; }

        public void RecieveCard(ICard selectedCard)
        {
            Hand.Add(selectedCard);
        }
    }
}
