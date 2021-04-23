using System;
using Xunit;
using SuperFizzBuzz;

namespace SuperFizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        [InlineData(99999999)]
        [InlineData(-3)]
        [InlineData(-603)]
        public void WhenValueDivisibleByRule_ShouldOutputToken(int value)
        {
            // Given
            var fizzBuzz = new FizzBuzz(
                new FizzBuzzRule(3, "Fizz"),
                new FizzBuzzRule(5, "Buzz"));
            
            // When
            var output = fizzBuzz.Run(value);

            // Then
            Assert.Equal("Fizz", output);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(3375)]
        [InlineData(0)]
        [InlineData(-34875)]
        public void WhenValueDivisibleByTwoRules_ShouldOutputBothToken(int value)
        {
            // Given
            var fizzBuzz = new FizzBuzz(
                new FizzBuzzRule(3, "Fizz"),
                new FizzBuzzRule(5, "Buzz"));
            
            // When
            var output = fizzBuzz.Run(value);

            // Then
            Assert.Equal("FizzBuzz", output);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(3375)]
        [InlineData(0)]
        [InlineData(-34875)]
        public void WhenValueDivisibleByTwoRulesInReverseOrder_ShouldOutputBothTokens(int value)
        {
            // Given
            var fizzBuzz = new FizzBuzz(
                new FizzBuzzRule(5, "Buzz"),
                new FizzBuzzRule(3, "Fizz"));
            
            // When
            var output = fizzBuzz.Run(value);

            // Then
            Assert.Equal("BuzzFizz", output);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(0)]
        [InlineData(-8)]
        [InlineData(65536)]
        public void WhenValueDivisibleByTwoCoprimeRules_ShouldOutputBothTokens(int value)
        {
            // Given
            var fizzBuzz = new FizzBuzz(
                new FizzBuzzRule(2, "Fizz"),
                new FizzBuzzRule(4, "Buzz"));
            
            // When
            var output = fizzBuzz.Run(value);

            // Then
            Assert.Equal("FizzBuzz", output);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(2)]
        [InlineData(7)]
        [InlineData(1234567890)]
        public void WhenRuleIsOne_ShouldAlwaysOutput(int value)
        {
            // Given
            var fizzBuzz = new FizzBuzz(
                new FizzBuzzRule(1, "One"));
            
            // When
            var output = fizzBuzz.Run(value);

            // Then
            Assert.Equal("One", output);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(13)]
        [InlineData(88888888)]
        [InlineData(-1)]
        [InlineData(-1000)]
        public void WhenValueNotDivisibleByAnyRule_ShouldOutputValue(int value)
        {
            // Given
            var fizzBuzz = new FizzBuzz(
                new FizzBuzzRule(3, "Fizz"));
            
            // When
            var output = fizzBuzz.Run(value);

            // Then
            Assert.Equal(value.ToString(), output);
        }
    }
}
