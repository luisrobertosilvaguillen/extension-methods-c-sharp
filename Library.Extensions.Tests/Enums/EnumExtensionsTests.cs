using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.Extensions.Enums;

namespace Library.Extensions.Tests
{
    [TestClass]
    public class EnumExtensionsTests
    {
        /// <summary>
        /// Getting the name of the enum value
        /// </summary>
        [TestMethod]
        public void GetName()
        {
            var toyota = EBrand.Toyota;
            Assert.AreEqual("Toyota", toyota.GetName());
        }
        /// <summary>
        /// Getting the description of the enum value
        /// </summary>
        [TestMethod]
        public void GetDescription()
        {
            Assert.AreEqual("Toyota", EBrand.Toyota.GetDescription());
            Assert.AreEqual("Ford", EBrand.Ford.GetDescription());
            Assert.AreEqual("Aston Martin", EBrand.AstonMartin.GetDescription());
            Assert.AreEqual("BMW", EBrand.BMW.GetDescription());
        }

    }
}
