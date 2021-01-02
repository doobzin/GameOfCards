using Game_Of_Cards.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Of_Cards.Interfaces
{
    public interface IGameScoreboard
    {
        bool IsGameOver { get; }

        void UpdateGameStatus(IGamePlayer player);
    }
}
