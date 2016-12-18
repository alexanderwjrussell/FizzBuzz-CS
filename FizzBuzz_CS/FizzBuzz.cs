using System;

namespace FizzBuzz_CS
{
	class FizzBuzz
	{
		public FizzBuzz()
		{
		}

		public string Get(int number)
		{
			if(number % 3 == 0) return "Fizz";
			return "Buzz";
		}
	}
}