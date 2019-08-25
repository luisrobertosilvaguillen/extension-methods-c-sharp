using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom.Object.Extensions.Datasources.Impl
{
    public class SqlReferenceDataSource : IReferenceDataSource
    {
        public IEnumerable<ReferenceDataItem> GetItems()
        {
            return new List<ReferenceDataItem> {
                new ReferenceDataItem() { Code="A",  Description = "Item from SQL 1" },
                new ReferenceDataItem() { Code="B",  Description = "Item from SQL 2" }
            };
        }
    }
}
