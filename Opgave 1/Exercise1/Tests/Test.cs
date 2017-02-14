using NUnit.Framework;
using System;
using FizzBuzz;

namespace Tests
{
	[TestFixture()]
	public class Test
	{
		/* Smoke tests */
		[Test()]
		public void Test3YieldsFizz()
		{
			Assert.AreEqual(Buzzer.Buzz(3), "Fizz");
		}
		[Test()]
		public void Test5YieldsBuzz()
		{
			Assert.AreEqual(Buzzer.Buzz(5), "Buzz");
		}
		[Test()]
		public void Test15YieldsFizzBuzz()
		{
			Assert.AreEqual(Buzzer.Buzz(15), "FizzBuzz");
		}
		[Test()]
		public void Test43Yields43()
		{
			Assert.AreEqual(Buzzer.Buzz(43), "43");
		}
		[Test()]



		/* Border case tests */
		public void Test1()
		{
			Assert.AreEqual(Buzzer.Buzz(1), "1");
		}
		public void Test100()
		{
			Assert.AreEqual(Buzzer.Buzz(100), "Buzz");
		}



		/* Additional tests */
		public void Test0YieldsFizzBuzz()
		{
			Assert.AreEqual(Buzzer.Buzz(0), "FizzBuzz");
		}
		public void TestNegative15YieldsFizzBuzz()
		{
			Assert.AreEqual(Buzzer.Buzz(-15), "FizzBuzz");
		}
		public void Test102YieldsFizz()
		{
			Assert.AreEqual(Buzzer.Buzz(102), "Fizz");
		}
	}
}
