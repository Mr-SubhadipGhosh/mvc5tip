using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace EmployeeMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIndex()
        {
            Assert.IsNotNull("yes");
        }
        [TestMethod]
        public void TestEdit()
        {
            Assert.AreEqual("yes", "yes" );

        }
    }
}
