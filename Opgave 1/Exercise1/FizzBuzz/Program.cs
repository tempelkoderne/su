using System;

namespace FizzBuzz
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				var fizz = Buzzer.Buzz(i);
				Console.WriteLine(fizz);
			}
			var Tester = new Tester();
			Tester.Test(Buzzer.Buzz(40) == "FizzBuzz", false, "testtest");
			Console.WriteLine("The tests were a great {0}!", Tester.State);
		}
	}
}
