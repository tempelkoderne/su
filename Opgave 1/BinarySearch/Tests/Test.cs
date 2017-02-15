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
            IComparable[] arr = gen.NextArray (10, 10);
            Assert.AreEqual (Search.Binary (arr, -40), -1, "TestTooLow1");
        }
        [Test ()]
        public void TestTooHigh ()
        {
            IComparable [] arr = gen.NextArray (10, 10);
            Assert.AreEqual(Search.Binary(arr, 40), -1, "TestTooHigh1");
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
            IComparable[] arr = new IComparable[] { };

            for (int i = -100; i <= 100; i++) {
                Assert.AreEqual (Search.Binary (arr, i) == -1, true, 
                                 "TestEmptyArray, i = {0}", i);
            }
        }
    }
}
