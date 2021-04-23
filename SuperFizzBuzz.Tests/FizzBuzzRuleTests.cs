using System;
using Xunit;
using SuperFizzBuzz;

namespace SuperFizzBuzz.Tests
{
    public class FizzBuzzRuleTests
    {
        [Fact]
        public void WhenTokenIsNull_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => new FizzBuzzRule(3, null!));
        }

        [Fact]
        public void WhenDivisorIsZero_Throws()
        {
            Assert.Throws<ArgumentException>(() => new FizzBuzzRule(0, "Fizz"));
        }

        [Fact]
        public void WhenDivisorIsNegative_Throws()
        {
            Assert.Throws<ArgumentException>(() => new FizzBuzzRule(-3, "Fizz"));
        }
    }
}