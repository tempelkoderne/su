using System;

namespace FizzBuzz
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// FizzBuzz loop
			for (int i = 1; i <= 100; i++)
			{
				var fizz = Buzzer.Buzz(i);
				Console.WriteLine(fizz);
			}

			// Tests
			var Tester = new Tester();

			Tester.Test(Buzzer.Buzz(40) == "FizzBuzz", false, "is 40 FizzBuzz?");
			Tester.Test(Buzzer.Buzz(15) == "FizzBuzz", true, "is 15 FizzBuzz?");
			Tester.Test(Buzzer.Buzz(-15) == "FizzBuzz", true, "is -15 FizzBuzz?");
			Tester.Test(Buzzer.Buzz(0) == "FizzBuzz", true, "is 0 FizzBuzz?");

			Tester.Test(Buzzer.Buzz(10) == "Buzz", true, "is 10 Buzz?");
			Tester.Test(Buzzer.Buzz(11) == "Buzz", false, "is 11 Buzz?");
			Tester.Test(Buzzer.Buzz(0) == "Buzz", false, "is 0 Buzz?");

			Tester.Test(Buzzer.Buzz(9) == "Fizz", true, "is 9 Fizz?");
			Tester.Test(Buzzer.Buzz(8) == "Fizz", false, "is 8 Fizz?");
			Tester.Test(Buzzer.Buzz(0) == "Fizz", false, "is 0 Fizz?");

			Console.WriteLine("The tests were a great, great {0}!", Tester.State);
		}
	}
}
// GitHub test.
// Peter er en glad fisk.
// Anders er en musling.