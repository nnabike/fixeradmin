using System;
using Fixer.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fixer.Tests
{
    [TestClass]
    public class DataLayerTests
    {
        DataLayer dataLayer = new DataLayer();
        [TestMethod]
        public void TestConnection()
        {
            string tableName = "Attributes";
            Assert.AreEqual(2, dataLayer.GetTableData(tableName).Rows.Count);
        }

        [TestMethod]
        public void GetDataOffset()
        {
            string tableName = "AttributeContent";
            Assert.AreEqual(1, dataLayer.GetPagedData(tableName, 1).Rows.Count);
        }
    }
}
