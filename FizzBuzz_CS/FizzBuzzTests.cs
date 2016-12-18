using NUnit.Framework;
using System;
namespace FizzBuzz_CS
{
	[TestFixture]
	public class FizzBuzzTests
	{

		FizzBuzz fizzbuzz;

		[SetUp]
		public void SetUp() 
		{
			fizzbuzz = new FizzBuzz();
		}

		[Test]
		public void Should_ReturnFizz_WhenDivisibleBy3()
		{
			Assert.That(fizzbuzz.Get(3), Is.EqualTo("Fizz"));
		}

		[Test]
		public void Should_ReturnBuzz_WhenDivisibleBy5()
		{
			Assert.That(fizzbuzz.Get(5), Is.EqualTo("Buzz"));
		}

		[Test]
		public void Should_ReturnFizzBuzz_WhenDivisibleBy15()
		{
			Assert.That(fizzbuzz.Get(15), Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void Should_ReturnNumber_WhenNotDivisibleBy3or5or15()
		{
			Assert.That(fizzbuzz.Get(2), Is.EqualTo("2"));
		}
	}
}
