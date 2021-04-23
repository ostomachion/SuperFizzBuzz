using System;
namespace SuperFizzBuzz
{
    public class FizzBuzzRule
    {
        public int Divisor { get; }
        public string Token { get; }

        public FizzBuzzRule(int divisor, string token)
        {
            if (divisor <= 0)
                throw new ArgumentException("Divisor must be positive.", nameof(divisor));
                
            Divisor = divisor;
            Token = token ?? throw new ArgumentNullException(nameof(token));
        }
    }
}