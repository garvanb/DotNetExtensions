using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DotNetExtensions.Tests
{
    [TestClass]
    public class StringBuilderAppendWithNewLineTest
    {
        [TestMethod]
        public void StringBuilderIsEmpty()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendWithNewLine("test");
            Assert.IsTrue(builder.ToString() == string.Format("{0}{1}", "test", Environment.NewLine));
        }
    }
}
