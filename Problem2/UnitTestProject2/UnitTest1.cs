using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void check1()
        {
            MyQueue s1 = new MyQueue(10);
            s1.Enqueue(1);
            s1.Enqueue(2);
            s1.Enqueue(3);
            //Assert.AreEqual(3, s1.Count());
            Assert.AreEqual(1, s1.Dequeue());
        }
    }
}
