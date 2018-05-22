using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DotNetExtensions.Tests
{
    [TestClass]
    public class StringBuilderAppendWithTabsAndNewLineTest
    {
        [TestMethod]
        public void StringBuilderIsEmptyAndTabCountIsZero()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithTabsAndNewLine(0, "test");
            Assert.IsTrue(builder.ToString() == string.Format("{0}{1}", "test", Environment.NewLine));
        }

        [TestMethod]
        public void StringBuilderIsEmptyAndTabCountIsOne()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithTabsAndNewLine(1, "test");
            Assert.IsTrue(builder.ToString() == string.Format("{0}{1}{2}", "\t", "test", Environment.NewLine));
        }

        [TestMethod]
        public void StringBuilderIsEmptyAndTabCountIsTwo()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithTabsAndNewLine(2, "test");
            Assert.IsTrue(builder.ToString() == string.Format("\t\t{0}{1}", "test", Environment.NewLine));
        }
    }
}
