using NUnit.Framework;
using System;
namespace Tests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			Assert.AreEqual(7, 7);
		}
	}
}
