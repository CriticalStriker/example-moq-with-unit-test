using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoqExample;

namespace UnitTest
{
	[TestClass]
	public class UnitTest
	{
		HandleString mHandleString;

		[TestInitialize]
		public void TestInit()
		{
			mHandleString = new HandleString();
		}

		[TestCleanup]
		public void TestCleanup()
		{
			mHandleString = null;
		}

		[TestMethod]
		public void TestMethod1()
		{
			String rvalue = mHandleString.Concat("barak", "obama");
			Assert.AreEqual("barak obama", rvalue);
		}

		[TestMethod]
		public void TestMethod2()
		{
			List<string> first = new List<string>();
			first.Add("a");

			List<string> second = new List<string>();
			second.Add("a");

			CollectionAssert.AreEqual(first, second);
		}

		[TestMethod]
		public void TestMethod3()
		{
			List<string> first = new List<string>();
			first.Add("a");
			first.Add("b");
			first.Add("c");
			CollectionAssert.AllItemsAreUnique(first);
		}

		[TestMethod]
		public void TestMethod4()
		{
			List<string> first = new List<string>();
			first.Add("a");
			first.Add("b");
			first.Add("c");
			CollectionAssert.Contains(first, "c");
			CollectionAssert.DoesNotContain(first, "x");
			CollectionAssert.AllItemsAreInstancesOfType(first, typeof(string));
		}

		[TestMethod]
		public void TestMethod5()
		{
			List<string> str1 = new List<string>();
			List<string> str2 = new List<string>();
			CollectionAssert.ReferenceEquals(str1, str2);
		}

		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException), "zero divide free")]
		public void TestMethod6()
		{
			HandleMath handleMath = new HandleMath();
			int result = handleMath.Devide(10, 0);
			Assert.AreEqual(10, result);
		}
	}
}
