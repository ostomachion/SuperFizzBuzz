using System;
using SuperFizzBuzz;

var fizzBuzz = new FizzBuzz(
    new FizzBuzzRule(3, "Fizz"),
    new FizzBuzzRule(5, "Buzz")
);

foreach (var output in fizzBuzz.Run(1, 100))
{
    Console.WriteLine(output);
}
