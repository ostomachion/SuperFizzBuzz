using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperFizzBuzz
{
    public class FizzBuzz
    {
        public IEnumerable<FizzBuzzRule> RuleSet { get; }

        /// <summary>
        /// Initializes a new instance of <c>FizzBuzz</c> using the provied <c>FizzBuzzRule</c> objects.
        /// </summary>
        /// <param name="ruleSet">The <c>FizzBuzzRule</c> objects to use.</param>
        public FizzBuzz(params FizzBuzzRule[] ruleSet)
        {
            this.RuleSet = ruleSet;
        }

        /// <summary>
        /// Runs the provided number through the rule-set. If no rule is matched, the number is returned as a string,
        /// otherwise, the matched rules' tokens are concatenated and returned.
        /// </summary>
        /// <param name="value">The number to run through the rule-set.</param>
        /// <returns>
        /// The result of running the provided number through the rule-set. If no rule is matched, the number is
        /// returned as a string, otherwise, the matched rules' tokens are concatenated and returned.
        /// </returns>
        public string Run(int value)
        {
            var tokens = RuleSet
                .Where(rule => rule.Accepts(value))
                .Select(rule => rule.Token);

            return tokens.Any() ?
                String.Join("", tokens) :
                value.ToString();
        }

        /// <summary>
        /// Runs a range of integers from <paramref name="min"/> to <paramref name="max"/> inclusive through the rule-set.
        /// </summary>
        /// <param name="min">The start of the range to run.</param>
        /// <param name="max">The inclusive end of the range to run.</param>
        /// <returns>The result of running each integer in the provided range through the rule-set.</returns>
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

        /// <summary>
        /// Runs the provided collection of integers through the rule-set.
        /// </summary>
        /// <param name="values">The collection of integers to run through the rule-set.</param>
        /// <returns>The result of running each integer in the provided collection through the rule-set.</returns>
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
