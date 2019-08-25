using System.Collections.Generic;
using System.Linq;

namespace Custom.Object.Extensions.Datasources
{
    public static class IReferenceDataSourceExtension
    {
        public static IEnumerable<ReferenceDataItem> GetItemsByCode(this IReferenceDataSource source, string code)
        {
            return source.GetItems().Where(x => x.Code == code);
        }
    }
}
