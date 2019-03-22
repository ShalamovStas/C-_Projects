﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LimitedStack;

namespace UnitTestProjectBase
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod, Timeout(500), Description("Push должен работать быстро, даже при большом лимите на размер стека")]
        public void Push_ShouldTakeConstantTime()
        {
            int limit = 100000;
            var stack = new LimitedSizeStack<int>(limit);
            for (int i = 0; i < 5 * limit; ++i)
            {
                stack.Push(0);
            }
            Assert.AreEqual(limit, stack.Count);
        }
    }
}
