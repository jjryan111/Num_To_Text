using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1; 
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.GetOnes(0), "");

        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Program.GetOnes(1), "One");

        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(Program.GetOnes(9), "Nine");

        }


        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(Program.GetNum(1), "One");

        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(Program.GetNum(10), "Ten");

        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(Program.GetNum(21), "Twenty-One");

        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(Program.GetNum(120), "Twenty");

        }
    }
}

