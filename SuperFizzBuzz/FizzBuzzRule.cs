using System;
namespace SuperFizzBuzz
{
    /// <summary>
    /// Represents a single rule for a <c>FizzBuzz</c> object containing a divisor and a token.
    /// </summary>
    public class FizzBuzzRule
    {
        /// <summary>
        /// The divisor to test against. The rule accepts any number divisible by this divisor.
        /// </summary>
        public int Divisor { get; }

        /// <summary>
        /// The token to output if the rule accepts a number.
        /// </summary>
        public string Token { get; }

        /// <summary>
        /// Initializes a new instance of the <c>FizzBuzzRule</c> class with the given divisor and token.
        /// </summary>
        /// <param name="divisor">The divisor to test against.</param>
        /// <param name="token">The token to output if the rule accepts a number.</param>
        public FizzBuzzRule(int divisor, string token)
        {
            if (divisor <= 0)
                throw new ArgumentException("Divisor must be positive.", nameof(divisor));
                
            Divisor = divisor;
            Token = token ?? throw new ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Determines wheter this rules accepts the provided value.
        /// </summary>
        /// <param name="value">The value to test.</param>
        /// <returns>True if the value is divisible by this rule's divisor; otherwise, false.</returns>
        public bool Accepts(int value) => value % Divisor == 0;
    }
}