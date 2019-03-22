using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace BracketsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RightSequence1()
        {
            Assert.AreEqual(true, Program.Check("[{}][]"));
        }

        [TestMethod]
        public void RightSequence2()
        {
            Assert.AreEqual(false, Program.Check("[{}][]{"));
        }
    }
}
