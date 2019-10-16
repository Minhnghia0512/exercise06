using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace UnitTestProject1
{
    [TestClass]
    public class UniTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(200000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(200000, acc.Balance());
        }
        [TestMethod]
        public void Testdposit()
        {
            Account acc2 = new Account(2000);
            Assert.IsNotNull(acc2);
            Assert.IsInstanceOfType(acc2, typeof(Account));
            acc2.Deposit(2000);
            Assert.AreEqual(4000, acc2.Balance());
        }
        [TestMethod]
        public void TestdWithDraw()
        {
            Account acc3 = new Account(2000);
            Assert.IsNotNull(acc3);
            Assert.IsInstanceOfType(acc3, typeof(Account));
            acc3.Withdraw(1000);
            Assert.AreEqual(1000, acc3.Balance());


        }
    }

}
