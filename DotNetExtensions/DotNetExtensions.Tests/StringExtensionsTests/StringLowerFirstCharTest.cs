using System;
using DotNetExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetExtensions.Tests
{
    [TestClass]
    public class StringLowerFirstCharTest
    {
        [TestMethod]
        public void StringIsNull()
        {
            string test = null;
            Assert.IsTrue(test.LowerFirstChar() == null);
        }

        [TestMethod]
        public void StringIsEmpty()
        {
            string test = "";
            Assert.IsTrue(test.LowerFirstChar() == "");
        }

        [TestMethod]
        public void StringIsOneCharacterLong()
        {
            string test = "A";
            Assert.IsTrue(test.LowerFirstChar() == "a");
        }

        [TestMethod]
        public void StringIsMoreThanOneCharacterLong()
        {
            string test = "AA";
            Assert.IsTrue(test.LowerFirstChar() == "aA");
        }
    }
}
