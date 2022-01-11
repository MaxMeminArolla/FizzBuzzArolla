namespace FizzBuzzArolla
{
    public class Kata
    {
        public static string FizzBuzz(int number)
        {
            if (IsDivisibleBy3(number) && IsDivisibleBy5(number)) return "FizzBuzz";
            if (IsDivisibleBy3(number)) return "Fizz";
            if (IsDivisibleBy5(number)) return "Buzz";
            return number.ToString();
        }

        private static bool IsDivisibleBy3(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsDivisibleBy5(int number)
        {
            return number % 5 == 0;
        }
    }
}
