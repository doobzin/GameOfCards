using Game_Of_Cards.Contracts;
using System.Collections.Generic;

namespace Game_Of_Cards
{
    public class Card : ICard
    {
        private readonly Dictionary<string, string> _dictionary;

        public Card(string name, string value)
        {
            Name = name;
            Value = int.Parse(value);
        }

        public Card(Dictionary<string, string> dictionary)
        {
            _dictionary = dictionary;
            Initialize();
        }

        private void Initialize()
        {
            var card = _dictionary.FromDictionary();

            Name = card.Name;
            Value = card.Value;
        }

        public string Name { get; private set; }
        public int Value { get; private set; }
    }
}