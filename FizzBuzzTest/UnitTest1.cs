using Xunit;
using FizzBuzzArolla;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        [Fact]
        public void Should_return_fizz_with_number_3()
        {
            Assert.Equal("Fizz", Kata.FizzBuzz(3));
        }

        [Fact]
        public void Should_return_buzz_with_number_5()
        {
            Assert.Equal("Buzz", Kata.FizzBuzz(5));
        }

        [Fact]
        public void Should_return_FizzBuzz_with_number_15()
        {
            Assert.Equal("FizzBuzz", Kata.FizzBuzz(15));
        }

        [Fact]
        public void Should_return_1_with_number_1()
        {
            Assert.Equal("1", Kata.FizzBuzz(1));
        }
    }
}
