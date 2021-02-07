using System;
using System.Collections.Generic;
using FizzBuzz;

namespace FizzBuzzBazz
{
    class Program
    {
        static void Main(string[] args)
        {
            var Divisors = new List<Divisor>
            {
                new Divisor {Value = 3, Token = "Fizz" },
                new Divisor {Value = 7, Token = "Buzz" },
                new Divisor {Value = 38, Token = "Bazz" },
            };
            Console.WriteLine("Press any key to run FizzBuzz with the given parameters:");
            Console.WriteLine("Range: -12 to 145");
            Console.WriteLine("Multiples of 3: Fizz");
            Console.WriteLine("Multiples of 7: Buzz");
            Console.WriteLine("Multiples of 38: Bazz");

            var fizzBuzz = new SuperFizzBuzz(-12, 145, Divisors);

            fizzBuzz.display(fizzBuzz.generate());
        }
    }
}
