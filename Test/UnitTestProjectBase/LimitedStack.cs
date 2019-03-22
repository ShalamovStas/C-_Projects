using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LimitedStack;

namespace UnitTestProjectBase
{
    [TestClass]
    public class LimitedStack
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void PopAfterPush()
        {
            var stack = new LimitedSizeStack<int>(20);
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
            Assert.AreEqual(0, stack.Pop());
        }

        [TestMethod]
        public void BeEmpty_AfterCreation()
        {
            var stack = new LimitedSizeStack<int>(20);
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void PushAfterPop()
        {
            var stack = new LimitedSizeStack<int>(20);
            stack.Push(0);
            stack.Push(1);
            stack.Pop();
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(0, stack.Pop());
        }

        [TestMethod]
        public void PushAfterEmptyStack()
        {
            var stack = new LimitedSizeStack<int>(20);
            stack.Push(0);
            stack.Push(1);
            stack.Pop();
            stack.Pop();
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
        }

        [TestMethod]
        public void Count_StackSize()
        {
            var stack = new LimitedSizeStack<int>(20);
            stack.Push(0);
            stack.Push(10);
            stack.Push(20);
            Assert.AreEqual(3, stack.Count);
        }

        [TestMethod]
        public void ForgetFirstElement_AfterPushBeyondLimit()
        {
            var stack = new LimitedSizeStack<int>(2);
            stack.Push(0);
            stack.Push(10);
            stack.Push(20);
            Assert.AreEqual(2, stack.Count);
            Assert.AreEqual(20, stack.Pop());
        }

        [TestMethod]
        public void ForgetFirstElement_AfterPushBeyondLimit_Twice()
        {
            var stack = new LimitedSizeStack<int>(2);
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Pop(); // empty!
            stack.Push(0);
            stack.Push(10);
            stack.Push(20);
            Assert.AreEqual(2, stack.Count);
            Assert.AreEqual(20, stack.Pop());
            Assert.AreEqual(10, stack.Pop());
        }

        [TestMethod]
        public void PopPushAfterLimitReached()
        {
            var stack = new LimitedSizeStack<int>(2);
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Push(3);
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
            Assert.AreEqual(0, stack.Count);
        }

        
    }
}
