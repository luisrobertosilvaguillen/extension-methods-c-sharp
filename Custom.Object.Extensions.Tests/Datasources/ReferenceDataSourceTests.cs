using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom.Object.Extensions.Datasources.Impl;

namespace Custom.Object.Extensions.Datasources.Tests
{
    [TestClass]
    public class ReferenceDataSourceTests
    {
        /// <summary>
        /// Validating if all datasources are working 
        /// </summary>
        [TestMethod]
        public void GetItems()
        {
            IReferenceDataSource source;
            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
        }
        /// <summary>
        /// Using the extension GetItemsByCode to fetch a IEnumerable<ReferenceDataItem> from ApiReferenceDataSource 
        /// </summary>
        [TestMethod]
        public void GetItemsByCodeApi()
        {
            var source = new ApiReferenceDataSource();
            Assert.AreEqual(1, source.GetItemsByCode("A").Count());
        }
        /// <summary>
        /// Using the extension GetItemsByCode to fetch a IEnumerable<ReferenceDataItem> from SqlReferenceDataSource 
        /// </summary>
        [TestMethod]
        public void GetItemsByCodeSql()
        {
            var source = new SqlReferenceDataSource();
            Assert.AreEqual(1, source.GetItemsByCode("A").Count());
        }
        /// <summary>
        /// Using the extension GetItemsByCode to fetch a IEnumerable<ReferenceDataItem> from XmlReferenceDataSource 
        /// </summary>
        [TestMethod]
        public void GetItemsByCodeXml()
        {
            var source = new XmlReferenceDataSource();
            Assert.AreEqual(1, source.GetItemsByCode("A").Count());
        }
    }
}
