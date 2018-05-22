using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DotNetExtensions.Tests
{
    [TestClass]
    public class StringBuilderAppendWithNewTabbedLinesTest
    {
        [TestMethod]
        public void StringBuilderIsEmptyAndIntLinesIsZero()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithNewTabbedLines("test", 0);
            Assert.IsTrue(builder.ToString() == string.Format("\t{0}", "test"));
        }

        [TestMethod]
        public void StringBuilderIsEmptyAndIntLinesIsOne()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithNewTabbedLines("test", 1);
            Assert.IsTrue(builder.ToString() == string.Format("\t{0}{1}", "test", Environment.NewLine));
        }

        [TestMethod]
        public void StringBuilderIsEmptyAndIntLinesIsTwo()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithNewTabbedLines("test", 2);
            Assert.IsTrue(builder.ToString() == string.Format("\t{0}{1}{2}", "test", Environment.NewLine, Environment.NewLine));
        }
    }
}
