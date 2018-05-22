using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DotNetExtensions.Tests.StringBuilderExtensionsTests
{
    [TestClass]
    public class StringBuilderAddLineTest
    {
        [TestMethod]
        public void AddLine()
        {
            StringBuilder builder = new StringBuilder();
            builder.AddLine();
            Assert.IsTrue(builder.ToString() == Environment.NewLine);
        }
    }
}
