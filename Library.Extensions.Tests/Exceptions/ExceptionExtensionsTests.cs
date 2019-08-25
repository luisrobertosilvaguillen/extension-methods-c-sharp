using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library.Extensions.Exceptions;
using System.Diagnostics;

namespace Library.Extensions.Tests.Exceptions
{
    [TestClass]
    public class ExceptionExtensionsTests
    {
        /// <summary>
        /// Verifying if DivideSample.Divide is working as expected
        /// </summary>
        [TestMethod]
        public void DivideBy1()
        {
            Assert.AreEqual(10, DivideSample.Divide(10, 1));
        }
        /// <summary>
        /// This one must throw an exception and you must read the output 
        /// to see the log of the method extension FullMessage
        /// </summary>
        [TestMethod]
        public void DivideBy0()
        {
            try
            {
                DivideSample.Divide(10, 0);
                Assert.Fail("Should throw exception");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.FullMessage());
                Assert.IsInstanceOfType(ex, typeof(ApplicationException));
            }
        }
    }
}
