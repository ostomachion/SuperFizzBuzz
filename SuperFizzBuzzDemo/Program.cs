using System;
using SuperFizzBuzz;

var fizzBuzz = new FizzBuzz(
    new FizzBuzzRule(3, "Fizz"),
    new FizzBuzzRule(7, "Buzz"),
    new FizzBuzzRule(38, "Bazz")
);

foreach (var output in fizzBuzz.Run(-12,145))
{
    Console.WriteLine(output);
}
