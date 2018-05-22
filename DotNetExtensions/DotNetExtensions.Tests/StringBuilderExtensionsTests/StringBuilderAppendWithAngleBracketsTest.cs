using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetExtensions.Tests.StringBuilderExtensionsTests
{
    [TestClass]
    public class StringBuilderAppendWithAngleBracketsTest
    {
        [TestMethod]
        public void ValueIsEmpty()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithAngleBrackets("");
            Assert.IsTrue(builder.ToString() == "[]");
        }

        [TestMethod]
        public void ValueIsNull()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithAngleBrackets(null);
            Assert.IsTrue(builder.ToString() == "[]");
        }

        [TestMethod]
        public void ValueHasValue()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithAngleBrackets("test");
            Assert.IsTrue(builder.ToString() == "[test]");
        }
    }
}
