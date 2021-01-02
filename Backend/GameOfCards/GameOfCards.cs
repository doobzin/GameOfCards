using Game_Of_Cards.Contracts;
using Scoreboard.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_Of_Cards
{
    public class GameOfCards
    {
        public GameOfCards(IScoreBoard scoreboard)
        {
            var generator = new Generator();
            CurrentDeck = generator.Deck;
            
            ScoreBoard = scoreboard;
            CanStillDeal = true;
        }

        public IDictionary<string, string> CurrentDeck { get; private set; }
        public bool CanStillDeal { get; private set; }

        public IScoreBoard ScoreBoard { get; private set; }

        public void DealTo(IGamePlayer player)
        {
            if (CanStillDeal)
            {
                var listOfCards = Enumerable.ToList(CurrentDeck);

                var selectedCard = SelectACard(listOfCards);

                UpdateCurrentDeck(listOfCards, selectedCard);

                UpdateScoreBoard(player);

                var card = selectedCard.FromKeyValuePair();
                player.RecieveCard(card);
            }
        }

        private void UpdateScoreBoard(IGamePlayer player)
        {
            ScoreBoard.UpdateGameStatus(player);

            if (ScoreBoard.IsGameOver)
            {
                CanStillDeal = false;
            }
        }

        private void UpdateCurrentDeck(List<KeyValuePair<string, string>> listOfCards, KeyValuePair<string, string> selectedCard)
        {
            CurrentDeck = listOfCards.RemoveFromDeck(selectedCard);
        }

        private static KeyValuePair<string, string> SelectACard(List<KeyValuePair<string, string>> listOfCards)
        {
            var random = new Random();
            return listOfCards[random.Next(listOfCards.Count)];
        }
    }
}
