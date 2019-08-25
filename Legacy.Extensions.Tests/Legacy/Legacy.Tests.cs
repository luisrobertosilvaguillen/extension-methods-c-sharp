using System;
using Legacy.Legacy.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Legacy.Extensions.Tests
{
    [TestClass]
    public class Legacy
    {
        /// <summary>
        /// Date to legacy format century 20
        /// </summary>
        [TestMethod]
        public void DateToLegacyFormat_C20()
        {
            var dateTime = new DateTime(1920, 12, 31);
            Assert.AreEqual("0201231", dateTime.ToLegacyFormat());
        }
        /// <summary>
        /// Date to legacy format century 21
        /// </summary>
        [TestMethod]
        public void DateToLegacyFormat_C21()
        {
            var dateTime = new DateTime(2013, 12, 31);
            Assert.AreEqual("1131231", dateTime.ToLegacyFormat());
        }

        /// <summary>
        /// Name to legacy format
        /// </summary>
        [TestMethod]
        public void NameToLegacyFormat()
        {
            var name = "Simón Bolivar";
            Assert.AreEqual("BOLIVAR, SIMÓN", name.ToLegacyFormat());
        }
    }
}
