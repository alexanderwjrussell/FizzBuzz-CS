using NUnit.Framework;
using System;
namespace FizzBuzz_CS
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		public void Should_ReturnFizz_WhenDivisibleBy3()
		{
			var fizzbuzz = new FizzBuzz();
			var result = fizzbuzz.Get(3);

			Assert.That(result, Is.EqualTo("Fizz"));
		}

		[Test]
		public void Should_ReturnBuzz_WhenDivisibleBy5()
		{
			var fizzbuzz = new FizzBuzz();
			var result = fizzbuzz.Get(5);

			Assert.That(result, Is.EqualTo("Buzz"));
		}

		[Test]
		public void Should_ReturnFizzBuzz_WhenDivisibleBy15()
		{
			var fizzbuzz = new FizzBuzz();
			var result = fizzbuzz.Get(15);

			Assert.That(result, Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void Should_ReturnNumber_WhenNotDivisibleBy3or5or15()
		{
			var fizzbuzz = new FizzBuzz();
			var result = fizzbuzz.Get(2);

			Assert.That(result, Is.EqualTo(2));
		}
	}
}
