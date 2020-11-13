using System.Collections.Generic;
using System.Linq;

namespace Game_Of_Cards
{
    public class Generator
    {
        private const string DIAMONDS = "Diamonds"; 
        private const string HEARTS = "Hearts"; 
        private const string SPADES = "Spades"; 
        private const string Clubs = "Clubs";

        public Generator()
        {
            Deck = GetDefaultNumbers();
        }

        public IDictionary<string, string> Deck { get; private set; }

        private IDictionary<string, string> GetDefaultNumbers()
        {
            var dic = new Dictionary<string, string>();
            SetNumericCards(dic);
            SetNonNumericCards(dic);
            return dic;
        }

        private void SetNumericCards(IDictionary<string, string> dic)
        {
            var allNumericCards = Enumerable.Range(1, 10);
            foreach (var card in allNumericCards)
            {
                dic.Add(ComposeKey(DIAMONDS, card.ToString()), card.ToString());
                dic.Add(ComposeKey(HEARTS, card.ToString()), card.ToString());
                dic.Add(ComposeKey(SPADES, card.ToString()), card.ToString());
                dic.Add(ComposeKey(Clubs, card.ToString()), card.ToString());
            }
        }

        private void SetNonNumericCards(IDictionary<string, string> dic)
        {
            var allNonNumericCards = new string[] { "J", "Q", "K" };
            var cardValue = 10;
            foreach (var card in allNonNumericCards)
            {
                dic.Add(ComposeKey(DIAMONDS, card), cardValue.ToString());
                dic.Add(ComposeKey(HEARTS, card), cardValue.ToString());
                dic.Add(ComposeKey(SPADES, card), cardValue.ToString());
                dic.Add(ComposeKey(Clubs, card), cardValue.ToString());
            }
        }

        private string ComposeKey(string cardName, string card)
        {
            return string.Join("-", cardName, card.ToString());
        }

        public IDictionary<string, string> Generate()
        {
            return GetDefaultNumbers();
        }
    }
}