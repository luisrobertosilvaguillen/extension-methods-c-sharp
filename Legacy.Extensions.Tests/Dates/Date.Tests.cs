using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;

namespace Legacy.Extensions.Tests.Dates
{
    [TestClass]
    public class Dates
    {
        /// <summary>
        /// Notice that in this case we can use the extension directly because  ToXmlFormat is in System namesapace
        /// </summary>
        [TestMethod]
        public void DateToXmlUtcFormat()
        {
            var dateTime = new DateTime(2015, 4, 2, 12, 30, 15, 233);
            Assert.AreEqual("2015-04-02T12:30:15.233Z", dateTime.ToXmlFormat());
            Assert.AreEqual("2015-04-02T12:30:15.233Z", DateTimeExtensions.ToXmlFormat(dateTime, XmlDateTimeSerializationMode.Utc));
        }
        /// <summary>
        /// Notice that in this case we can use the extension directly because  ToXmlFormat is in System namesapace
        /// </summary>
        [TestMethod]
        public void DateToXmlLocalFormat()
        {
            var dateTime = new DateTime(2015, 4, 2, 12, 30, 15, 233);
            Assert.AreEqual("2015-04-02T12:30:15.233-03:00", dateTime.ToXmlFormat(XmlDateTimeSerializationMode.Local));
            Assert.AreEqual("2015-04-02T12:30:15.233-03:00", DateTimeExtensions.ToXmlFormat(dateTime, XmlDateTimeSerializationMode.Local));
        }
    }
}
