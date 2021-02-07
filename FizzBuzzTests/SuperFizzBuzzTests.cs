using Xunit;
using FizzBuzz;
using System.Collections.Generic;

namespace FizzBuzzTests
{
    public class SuperFizzBuzzTests
    {
        [Fact]
        public void ShouldReturnToken_GivenSingleFactorWithSingleDivisor()
        {
            var divisors = new List<Divisor> { new Divisor { Value = 3, Token = "Fizz" } };
            var result = SuperFizzBuzz.GetStringForIndex(3, divisors);
            var expected = "Fizz";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnToken_GivenSingleFactor_WithMultipleDivisors()
        {
            var divisors = new List<Divisor> { new Divisor { Value = 3, Token = "Fizz" }, new Divisor { Value = 5, Token = "Buzz" } };
            var result = SuperFizzBuzz.GetStringForIndex(12, divisors);
            var expected = "Fizz";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnTokens_GivenMultipleFactors_WithMultipleDivisors()
        {
            var divisors = new List<Divisor> { new Divisor { Value = 3, Token = "Fizz" }, new Divisor { Value = 5, Token = "Buzz" } };
            var result = SuperFizzBuzz.GetStringForIndex(15, divisors);
            var expected = "FizzBuzz";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnIndex_GivenNoFactors_WithSingleDivisor()
        {
            var divisors = new List<Divisor> { new Divisor { Value = 3, Token = "Fizz" } };
            var result = SuperFizzBuzz.GetStringForIndex(4, divisors);
            var expected = "4";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnIndex_GivenNoFactors_WithMultipleDivisors()
        {
            var divisors = new List<Divisor> { new Divisor { Value = 3, Token = "Fizz" }, new Divisor { Value = 5, Token = "Buzz" } };
            var result = SuperFizzBuzz.GetStringForIndex(4, divisors);
            var expected = "4";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnCorrectList_GivenBasic35FizzBuzz()
        {
            var fizzBuzz = new SuperFizzBuzz(1, 15, new List<Divisor> { new Divisor { Value = 3, Token = "Fizz" }, new Divisor { Value = 5, Token = "Buzz" } });
            var result = fizzBuzz.generate();
            var expected = new List<string>{ "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"};
            Assert.Equal(expected, result);
        }
    }
}
