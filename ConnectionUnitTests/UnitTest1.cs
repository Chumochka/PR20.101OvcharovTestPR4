using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConnectionUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConTest()
        {
            string expected = "Open";

            ConTest.Class1 mainClass = new ConTest.Class1();
            string actual = mainClass.Connect();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelectTest()
        {
            string expected = "Федоров";

            ConTest.Class1 mainClass = new ConTest.Class1();
            string actual = mainClass.SelectFunc();

            Assert.AreEqual(expected, actual);
        }
    }
}
