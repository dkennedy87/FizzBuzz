using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class SuperFizzBuzz
    {
        private readonly int Min;
        private readonly int Max;
        private readonly List<Divisor> Divisors;

        public SuperFizzBuzz(int min, int max, List<Divisor> divisors)
        {
            Min = min <= max ? min : max;
            Max = min > max ? min : max;
            Divisors = divisors ?? new List<Divisor> {
                new Divisor{ Value = 3, Token = "Fizz" },
                new Divisor{ Value = 5, Token = "Buzz" }
            };
        }

        public List<string> generate()
        {
            var results = new List<string>();

            for (int i = Min; i <= Max; i++)
            {
                var output = GetStringForIndex(i, Divisors);
                
                results.Add(output);
            }

            return results;
        }

        public static string GetStringForIndex(int i, List<Divisor> divisors)
        {
            var output = string.Empty;
            foreach(var divisor in divisors)
            {
                output = (i % divisor.Value == 0) ? ($"{output}{divisor.Token}") : output;

            }

            return output == string.Empty ? i.ToString() : output;
        }

        public void display(List<string> list)
        {
            Console.WriteLine("\n---");
            foreach (var str in list)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("---\n");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
