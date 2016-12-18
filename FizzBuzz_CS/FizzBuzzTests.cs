using NUnit.Framework;
using System;
namespace FizzBuzz_CS
{
	[TestFixture()]
	public class FizzBuzzTests
	{
		[Test()]
		public void Should_ReturnFizz_WhenDivisibleBy3()
		{
			var fizzbuzz = new FizzBuzz();
			var result = fizzbuzz.Get(3);

			Assert.That(result, Is.EqualTo("Fizz"));
		}
	}
}
