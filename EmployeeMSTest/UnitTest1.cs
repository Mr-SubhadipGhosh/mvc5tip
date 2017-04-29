using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeBLL;
namespace EmployeeMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIndex()
        {
            var empLogic = new EmpLogic();
            Assert.AreEqual("abc", empLogic.getEmpFullName(0));
        }
        [TestMethod]
        public void TestEdit()
        {
            var empLogic = new EmpLogic();
            Assert.AreEqual("xyz", empLogic.getEmpFullName(1));

        }
    }
}
