using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DotNetExtensions.Tests.StringBuilderExtensionsTests
{
    [TestClass]
    public class StringBuilderAppendIfThereTest
    {
        [TestMethod]
        public void ValueIsEmpty()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendIfThere("");
            Assert.IsTrue(builder.ToString() == "");
        }

        [TestMethod]
        public void ValueIsNull()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendIfThere(null);
            Assert.IsTrue(builder.ToString() == "");
        }

        [TestMethod]
        public void ValueHasValue()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendIfThere("test");
            Assert.IsTrue(builder.ToString() == "test");
        }
    }
}
