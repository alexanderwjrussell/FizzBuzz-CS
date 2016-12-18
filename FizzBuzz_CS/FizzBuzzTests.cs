using NUnit.Framework;
using System;
namespace FizzBuzz_CS
{
	[TestFixture]
	public class FizzBuzzTests
	{

		[TestCase(3, "Fizz")]
		[TestCase(5, "Buzz")]
		[TestCase(15, "FizzBuzz")]
		[TestCase(2, "2")]
		public void Should_ReturnCorrectValues_ForTestCases(int number, string result)
		{
			Assert.That(FizzBuzz.Get(number), Is.EqualTo(result));
		}
	}
}
