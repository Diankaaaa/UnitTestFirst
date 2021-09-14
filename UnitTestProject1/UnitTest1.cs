using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestFirst;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Math.Round(Math.Sinh(60 * Math.PI / 180),4), Math.Round(UnitTestFirst.Program.sh(60*Math.PI/180),4));
        }
    }
}
