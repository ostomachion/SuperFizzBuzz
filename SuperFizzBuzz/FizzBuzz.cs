using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperFizzBuzz
{
    public class FizzBuzz
    {
        public IEnumerable<FizzBuzzRule> RuleSet { get; }

        public FizzBuzz(params FizzBuzzRule[] ruleSet)
        {
            this.RuleSet = ruleSet;
        }

        public string Run(int value)
        {
            var tokens = RuleSet
                .Where(rule => value % rule.Divisor == 0)
                .Select(rule => rule.Token);

            return tokens.Any() ?
                String.Join("", tokens) :
                value.ToString();
        }

        public IEnumerable<string> Run(int min, int max)
        {
            if (max < min)
            {
                throw new ArgumentException("Max cannot be less than min.", nameof(max));
            }

            for (var i = min; i <= max; i++)
            {
                yield return Run(i);
            }
        }

        public IEnumerable<string> Run(IEnumerable<int> values)
        {
            if (values is null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return values.Select(x => Run(x));
        }
    }
}
