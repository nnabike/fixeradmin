using System;
using Fixer.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fixer.Tests
{
    [TestClass]
    public class BusinessLayerTests
    {
        BusinessLayer businessLayer = new BusinessLayer();
        [TestMethod]
        public void ConvertTableDataToJson()
        {
            var tableName = "Attributes";
            var expected = "{ }";
            var json = businessLayer.GetTableData(tableName);
            Assert.AreEqual(expected, json);
        }
    }
}
