using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Checkcountnpush()
        {
            myStack s1 = new myStack(10);
            s1.push(1);
            s1.push(2);
            s1.push(3);
            Assert.AreEqual(3, s1.Count());
        }
        [TestMethod]
        public void CheckPop()
        {
            myStack s2 = new myStack(10);
            s2.push(1);
            s2.push(2);
            s2.push(3);          
            Assert.AreEqual(3, s2.pop());
            Assert.AreEqual(2, s2.peek());
        }
        [TestMethod]
        public void Checkpeek()
        {
            myStack s3 = new myStack(10);
            s3.push(1);
            s3.push(2);
            s3.push(3);
            Assert.AreEqual(3, s3.peek());
        }
    }

}
