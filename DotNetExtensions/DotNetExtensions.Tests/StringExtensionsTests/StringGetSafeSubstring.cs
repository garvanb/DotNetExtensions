using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetExtensions.Tests
{
    [TestClass]
    public class StringGetSafeSubstring
    {
        [TestMethod]
        public void StringIsNull()
        {
            string test = null;
            Assert.IsTrue(test.GetSafeSubstring(5) == "");
        }

        [TestMethod]
        public void StringIsEmpty()
        {
            string test = "";
            Assert.IsTrue(test.GetSafeSubstring(4) == "");
        }

        [TestMethod]
        public void IndexIsOutOfRange()
        {
            string test = "A";
            Assert.IsTrue(test.GetSafeSubstring(2) == "");
        }

        [TestMethod]
        public void IndexIsInRange()
        {
            string test = "AA";
            Assert.IsTrue(test.GetSafeSubstring(1) == "A");
        }
    }
}
