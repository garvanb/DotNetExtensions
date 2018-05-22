using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DotNetExtensions.Tests
{
    [TestClass]
    public class StringBuilderAppendWithNewTabbedLineTest
    {
        [TestMethod]
        public void StringBuilderIsEmpty()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithNewTabbedLine("test");
            Assert.IsTrue(builder.ToString() == string.Format("{0}{1}{2}", "\t", "test", Environment.NewLine));
        }
    }
}
