using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace DotNetExtensions.Tests.StringBuilderExtensionsTests
{
    [TestClass]
    public class StringBuilderAddTabsTest
    {
        [TestMethod]
        public void AddNoTab()
        {
            StringBuilder builder = new StringBuilder();
            builder.AddTabs(0);
            Assert.IsTrue(builder.ToString() == "");
        }

        [TestMethod]
        public void AddOneTab()
        {
            StringBuilder builder = new StringBuilder();
            builder.AddTabs(1);
            Assert.IsTrue(builder.ToString() == "\t");
        }

        [TestMethod]
        public void AddTwoTabs()
        {
            StringBuilder builder = new StringBuilder();
            builder.AddTabs(2);
            Assert.IsTrue(builder.ToString() == "\t\t");
        }
    }
}
