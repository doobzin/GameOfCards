using Game_Of_Cards.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Game_Of_Cards
{
    public static class GameOfCardsExtentions
    {
        public static IDictionary<string, string> RemoveFromDeck(this List<KeyValuePair<string, string>> keyValuePairs, KeyValuePair<string, string> selectedCard)
        {
            _ = keyValuePairs.Remove(selectedCard);
            return keyValuePairs.ToDictionary(o => o.Key, o => o.Value);
        }

        public static IDictionary<string, string> ToDictionary(this KeyValuePair<string, string> keyValuePair)
        {
            return new[] { keyValuePair }.ToDictionary(o => o.Key, o => o.Value);
        }

        public static Card FromDictionary(this Dictionary<string, string> dictionary)
        {
            var cardName = dictionary.First().Key;
            var cardValue = dictionary[dictionary.First().Key];
            return new Card(cardName, cardValue);
        }

        public static ICard FromKeyValuePair(this KeyValuePair<string, string> keyValuePair)
        {
            var cardName = keyValuePair.Key;
            var cardValue = keyValuePair.Value;
            return new Card(cardName, cardValue);
        }
    }
}
