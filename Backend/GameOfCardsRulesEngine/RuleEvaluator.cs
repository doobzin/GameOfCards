
using Game_Of_Cards.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Game_Of_Cards.RulesEngine
{
    public class RuleEvaluator
    {
        private readonly IEnumerable<IRule> _rules;

        public RuleEvaluator(IRule[] rules)
        {
            _rules = rules;
        }

        public IEnumerable<IPlayer> Exceute(IContext context)
        {
            return _rules
                .Where(o => o.IsApplicable(context))
                .Select(o => o.Execute(context));
        }
    }
}
