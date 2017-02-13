﻿using System;

namespace FizzBuzz
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine("{0}", i);
				}
			}
		}
	}
}