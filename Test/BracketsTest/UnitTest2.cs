using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace BracketsTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Sequence()
        {
            Assert.AreEqual(true, Program.Check("[]{}"));
        }
    }
}
