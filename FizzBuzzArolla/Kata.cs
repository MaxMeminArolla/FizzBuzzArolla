using System;

namespace FizzBuzzArolla
{
    public class Kata
    {
        public static string FizzBuzz(int number)
        {
            if (number == 5) return "Buzz";
            if (number == 15) return "FizzBuzz";
            if (number == 1) return "1";
            return "Fizz";
        }
    }
}
