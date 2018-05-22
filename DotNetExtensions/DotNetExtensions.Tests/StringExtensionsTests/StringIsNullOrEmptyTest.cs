using System;
using DotNetExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetExtensions.Tests
{
    [TestClass]
    public class StringIsNullOrEmptyTest
    {
        [TestMethod]
        public void StringIsNull()
        {
            string test = null;
            Assert.IsTrue(test.IsNullOrEmpty());
        }

        [TestMethod]
        public void StringIsEmpty()
        {
            string test = "";
            Assert.IsTrue(test.IsNullOrEmpty());
        }

        [TestMethod]
        public void StringHasValue()
        {
            string test = "test";
            Assert.IsFalse(test.IsNullOrEmpty());
        }
    }
}
