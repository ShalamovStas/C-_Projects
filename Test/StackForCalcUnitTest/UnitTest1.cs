using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackForCalc;

namespace StackForCalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, PolishCalc.Compute("25*"));
            Assert.AreEqual(50, PolishCalc.Compute("25*5*"));
            Assert.AreEqual(15, PolishCalc.Compute("25*5+"));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(10, PolishCalc.ComputeWithBetterWay("25*"));
        }

    }
}
