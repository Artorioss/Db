using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;
using System.Data;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        Db db = Db.getInstance();
        [TestMethod]
        public void tryGettingNonExistentUser()
        {
            Assert.IsNull(db.getUserData("test", "1234"));
        }

        [TestMethod]
        public void receivingNonExistentReceipt()
        {
            Assert.IsNull(db.getReceiptsDataById(0));
        }

        [TestMethod]
        public void receivingExistentReceipt()
        {
            Assert.IsNull(db.getReceiptsDataById(1));
        }

        [TestMethod]
        public void gettingAllRowsFromTable()
        {
            Assert.IsNotNull(db.getAllRows("Поступления"));
        }

        [TestMethod]
        public void deletingNonExistingEntry()
        {
            Assert.IsFalse(db.deleteReceipt(9000));
        }
    }
}
