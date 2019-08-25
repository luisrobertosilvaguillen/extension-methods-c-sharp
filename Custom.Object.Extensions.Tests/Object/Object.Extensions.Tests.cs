using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Custom.Object.Extensions.Datasources;
using System.Collections.Generic;

namespace Custom.Object.Extensions.Object.Tests.Object
{
    [TestClass]
    public class ObjectExtensions
    {
        /// <summary>
        /// Cast any object to Json with a simple extension method (see the ouput from the tests)
        /// </summary>
        [TestMethod]
        public void ToJsonStringTests()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine($"obj1 - {obj1.ToJsonString()}");

            var obj2 = new DateTime(2015, 12, 31);
            Debug.WriteLine($"obj2 - {obj2.ToJsonString()}");

            var obj3 = new ReferenceDataItem { Code = "A", Description = "This is a description" };
            Debug.WriteLine($"obj3 - {obj3.ToJsonString()}");

            var obj4 = new List<ReferenceDataItem> {
                new ReferenceDataItem { Code = "A", Description = "This is a description 1" },
                new ReferenceDataItem { Code = "B", Description = "This is a description 2" }
            };
            Debug.WriteLine($"obj4 - {obj4.ToJsonString()}");
        }

        /// <summary>
        /// Cast any object to Json with a simple extension method (see the ouput from the tests)
        /// </summary>
        [TestMethod]
        public void GetJsonTypeDescriptionTests()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine($"obj1 - {obj1.GetJsonTypeDescription()}");

            var obj2 = new DateTime(2015, 12, 31);
            Debug.WriteLine($"obj2 - {obj2.GetJsonTypeDescription()}");

            var obj3 = new ReferenceDataItem { Code = "A", Description = "This is a description" };
            Debug.WriteLine($"obj3 - {obj3.GetJsonTypeDescription()}");

            var obj4 = new List<ReferenceDataItem> {
                new ReferenceDataItem { Code = "A", Description = "This is a description 1" },
                new ReferenceDataItem { Code = "B", Description = "This is a description 2" }
            };
            Debug.WriteLine($"obj4 - {obj4.GetJsonTypeDescription()}");
        }
    }
}
