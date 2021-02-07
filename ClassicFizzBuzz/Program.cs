using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz;

namespace ClassicFizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.Clear();

            var menuOption = GetMenuInput("Press 1 to play FizzBuzz or 2 to quit: ");
            switch (menuOption)
            {
                case 1:
                    Play();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        private static void Play()
        {
            var min = string.Empty;
            while(min == string.Empty)
            {
                Console.Write("\nPlease enter the first number in the range: ");
                min = Console.ReadLine();
            }

            var max = string.Empty;
            while(max == string.Empty)
            {
                Console.Write("Please enter the last number in the range: ");
                max = Console.ReadLine();
            }

            var divisors = new List<Divisor>();

            var addAnotherDivisor = true;
            while (addAnotherDivisor)
            {
                var divisor = string.Empty;
                while(divisor == string.Empty){ 
                    Console.Write("Please enter the divisor value: ");
                    divisor = Console.ReadLine();
                }

                var token = string.Empty;
                while(token == string.Empty)
                {
                    Console.Write("Please enter the word for this divisor: ");
                    token = Console.ReadLine().Trim();
                }

                divisors.Add(new Divisor { Value = Convert.ToInt32(divisor), Token = token });

                addAnotherDivisor = GetMenuInput("Press 1 to enter another, Press 2 to continue: ") == 1;
                Console.WriteLine("");
            }

            Console.Clear();

            var fizzBuzz = new SuperFizzBuzz(Convert.ToInt32(min), Convert.ToInt32(max), divisors);

            fizzBuzz.display(fizzBuzz.generate());

            MainMenu();
        }

        private static int GetMenuInput(string message)
        {
            Console.Write(message);
            var menuOption = Convert.ToInt32(Console.ReadKey().Key);
            switch (menuOption)
            {
                case 49: //1
                case 97: //numpad 1
                    return 1;
                case 50: //2
                case 98: //numpad 2
                    return 2;
                default:
                    Console.WriteLine("\nYou pressed an invalid key, please try again.");
                    Console.WriteLine(menuOption);
                    return GetMenuInput(message);
            }
        }
    }
}
