using System;

namespace FizzBuzzArolla
{
    public class Kata
    {
        public static string FizzBuzz(int number)
        {
            if (isDivisibleBy3(number) && isDivisibleBy5(number)) return "FizzBuzz";
            if (isDivisibleBy3(number)) return "Fizz";
            if (isDivisibleBy5(number)) return "Buzz";
            return number.ToString();
        }

        private static bool isDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }

        private static bool isDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }
    }
}
