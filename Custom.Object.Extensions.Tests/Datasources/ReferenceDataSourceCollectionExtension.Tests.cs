using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using Custom.Object.Extensions.Datasources.Impl;

namespace Custom.Object.Extensions.Datasources.Tests
{
    [TestClass]
    public class ReferenceDataSourceCollectionExtension
    {
        /// <summary>
        /// Using the extension GetItemsByCode to fetch a IEnumerable<ReferenceDataItem> from IReferenceDataSource Array 
        /// </summary>
        [TestMethod]
        public void GetAllItemsByCode_Array()
        {
            var sources = new IReferenceDataSource[]
            {
                new XmlReferenceDataSource(),
                new SqlReferenceDataSource(),
                new ApiReferenceDataSource()
            };
            var items = sources.GetAllItemsByCode("A");
            Assert.AreEqual(3, items.Count());
        }

        /// <summary>
        /// Using the extension GetItemsByCode to fetch a IEnumerable<ReferenceDataItem> from an ArrayList
        /// </summary>
        [TestMethod]
        public void GetAllItemsByCode_ArrayList()
        {
            var sources = new ArrayList()
            {
                new XmlReferenceDataSource(),
                new SqlReferenceDataSource(),
                new ApiReferenceDataSource(),
				"This is not a reference Datasource"
            };
            var items = sources.GetAllItemsByCode("A");
            Assert.AreEqual(3, items.Count());
        }

        /// <summary>
        /// Using the extension GetItemsByCode to fetch a IEnumerable<ReferenceDataItem> from List<IReferenceDataSource>
        /// </summary>
        [TestMethod]
        public void GetAllItemsByCode_IEnumerable()
        {
            var sources = new List<IReferenceDataSource>
            {
                new XmlReferenceDataSource(),
                new SqlReferenceDataSource(),
                new ApiReferenceDataSource()
            };
            var items = sources.GetAllItemsByCode("A");
            Assert.AreEqual(3, items.Count());
        }
    }
}
