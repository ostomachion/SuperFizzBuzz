﻿using System;
using System.Collections.Generic;

namespace SuperFizzBuzz
{
    public class FizzBuzz
    {
        public IEnumerable<FizzBuzzRule> RuleSet { get; }

        public FizzBuzz(IEnumerable<FizzBuzzRule> ruleSet)
        {
            this.RuleSet = ruleSet;
        }

        public string Run(int value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Run(int min, int max)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Run(IEnumerable<int> values)
        {
            throw new NotImplementedException();
        }
    }
}
