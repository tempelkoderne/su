using System;

namespace FizzBuzz
{
	public class Tester
	{
		public enum StateType { Success, Failure };

		public StateType State
		{
			get;
			private set;
		}

		public void Test(object actual, object expected, string message)
		{
			if (actual.Equals(expected))
			{
			}
			else
			{
				this.State = StateType.Failure;
				Console.Error.WriteLine(message);
			}
		}
	}
}
