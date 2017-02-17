using NUnit.Framework;
using System;
using Library;

namespace Tests
{
    [TestFixture ()]
    public class Test
    {
        Generator gen = new Generator ();

        [Test ()]
        public void TestTooLow ()
        {
            IComparable [] arr = gen.NextArray (10, 10);
            Assert.AreEqual (Search.Binary (arr, -40), -1, "TestTooLow1");
        }
        [Test ()]
        public void TestTooHigh ()
        {
            IComparable [] arr = gen.NextArray (10, 10);
            Assert.AreEqual (Search.Binary (arr, 40), -1, "TestTooHigh1");
        }
        [Test ()]
        public void TestElement ()
        {
            //IComparable [] arr = gen.NextArray (10, 10);
            IComparable [] arr = new IComparable [5] { 0, 1, 2, 3, 4 };
            Assert.AreNotEqual (Search.Binary (arr, 3), -1, "TestElement1");
        }
        [Test ()]
        public void TestEmptyArray ()
        {
            IComparable [] arr = new IComparable [] { };

            for (int i = -100; i <= 100; i++) 
            {
                Assert.AreEqual (Search.Binary (arr, i) == -1, true,
                                 "TestEmptyArray, i = {0}", i);
            }
        }

        [Test ()]
        public void TestBin ()
        {
            for (int i = 1; i <= 5000; i++) 
            {
                Console.WriteLine (ComparisonCountedInt.HardComparisonIntBin);
                IComparable [] arr = gen.NextArray (10, 10);
                Search.Binary (arr, 11);
                Assert.LessOrEqual (ComparisonCountedInt.HardComparisonIntBin, Math.Ceiling (Math.Log (10, 2))*i, "Binary Search doesn't works!");
            }

        }
        [Test ()]
        public void TestLin ()
        {
            for (int i = 1; i <= 5000; i++) {
                Console.WriteLine (ComparisonCountedInt.HardComparisonIntLin);
                IComparable [] arr = gen.NextArray (10, 10);
                Search.Linear(arr, 11);
                Assert.LessOrEqual (ComparisonCountedInt.HardComparisonIntLin, 10 * i, "Linear Search doesn't work!");
            }

        }
         [Test ()]
        public void TestLinvsBin ()
        {
            for (int i = 1; i <= 100; i++) {
                Console.WriteLine (ComparisonCountedInt.HardComparisonIntLin);
                IComparable [] arr = gen.NextArray (10000, 10);
                Search.Linear (arr, 11);
                Search.Binary (arr, 11);
                Assert.LessOrEqual (ComparisonCountedInt.HardComparisonIntBin, ComparisonCountedInt.HardComparisonIntLin, "Binary search is not more effektive");
            }

        }



    }

}
