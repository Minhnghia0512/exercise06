using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestMethodAccount()
        {
            Account acc = new Account(2000000);

            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(Account));
            Assert.AreEqual(2000000, acc.Balance());
        }
    }
}
