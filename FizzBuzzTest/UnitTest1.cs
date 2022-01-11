using System;
using Xunit;
using FizzBuzzArolla;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        [Fact]
        public void should_return_fizz_with_number_3()
        {
            Assert.Equal("Fizz", Kata.FizzBuzz(3));
        }

        [Fact]
        public void should_return_buzz_with_number_5()
        {
            Assert.Equal("Buzz", Kata.FizzBuzz(5));
        }
    }
}
