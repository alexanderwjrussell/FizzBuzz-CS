using System;

namespace FizzBuzz_CS
{
	public static class FizzBuzz
	{
		public static string Get(int number)
		{
			if (number % 15 == 0) return "FizzBuzz";
			if(number % 3 == 0) return "Fizz";
			if (number % 5 == 0) return "Buzz";
			return number.ToString();
		}
	}
}