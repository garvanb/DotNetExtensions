using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DotNetExtensions.Tests.StringBuilderExtensionsTests
{
    [TestClass]
    public class StringBuilderAddTabTest
    {
        [TestMethod]
        public void AddTab()
        {
            StringBuilder builder = new StringBuilder();
            builder.AddTab();
            Assert.IsTrue(builder.ToString() == "\t");
        }
    }
}
