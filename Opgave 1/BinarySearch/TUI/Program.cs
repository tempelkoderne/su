using System;
using Library;

namespace TUI
{
    class MainClass
    {
        private static void PrintArray(object[] array)
        {
            Console.WriteLine ("Test Array: {0}", Show.Array (array));
        }

        private static void TestArray(IComparable[] array)
        {
            PrintArray (array);

            Console.WriteLine ("Binary search");
            for (int i = 0; i <= 11; i++)
            {
                int result = Search.Binary (array, i);
                if (result == -1)
                {
                    Console.WriteLine ("{0} was not found.", i);
                }
                else
                {
                    Console.WriteLine ("{0} was found in index {1}.", i, result);
                }
            }



            Console.WriteLine ("Linear search");
            for (int i = 0; i <= 11; i++) 
            {
                int result = Search.Linear(array, i);

                if (result == -1) {
                    Console.WriteLine ("{0} was not found.", i);
                } else {
                    Console.WriteLine ("{0} was found in index {1}.", i, result);
                }

            }
        }

        public static void Main (string[] args)
        {
            Generator gen = new Generator ();

            TestArray (gen.NextArray(1000, 10));
            TestArray (gen.NextArray(1000, 10));
            TestArray (gen.NextArray(1000, 10));
            TestArray (gen.NextArray (1000, 10));
            Console.WriteLine("Amount of Operations in the binary:" + ComparisonCountedInt.HardComparisonIntBin);
            Console.WriteLine("Amount of Operations in the Linear:" + ComparisonCountedInt.HardComparisonIntLin);
            //Er det ikke underligt at den leder efter 10 og 11 men at 
            //generatoren aldrig laver de tal?
        }
    }
}