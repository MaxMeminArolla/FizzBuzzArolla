using System;
using Xunit;
using FizzBuzzArolla;

namespace FizzBuzzTest
{
    public class UnitTest1
    {
        [Fact]
        public void should_fizz_number_3()
        {
            Assert.True(Kata.FizzBuzz(3));
        }
    }
}
