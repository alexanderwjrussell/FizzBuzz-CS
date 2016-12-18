using System;
using FizzBuzz_CS;

namespace FizzBuzzConsole
{
	public class MainClass
	{
		public static void Main()
		{
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine(FizzBuzz.Get(i));
			}

			Console.ReadKey();
		}
	}
}
