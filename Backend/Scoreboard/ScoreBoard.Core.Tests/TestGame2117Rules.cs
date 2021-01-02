using GameRulesEngine.Core.Contracts;
using System.Collections.Generic;

namespace ScoreBoard.Core.Tests
{
    internal class TestGame2117Rules : IRule
    {
        private readonly List<IPlayer> _list;

        public TestGame2117Rules(List<IPlayer> list)
        {
            _list = list;
        }

        public IPlayer Execute()
        {
            throw new System.NotImplementedException();
        }

        public bool IsApplicable(IContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}