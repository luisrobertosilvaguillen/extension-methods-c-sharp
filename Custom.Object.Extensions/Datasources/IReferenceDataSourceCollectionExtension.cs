using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Custom.Object.Extensions.Datasources
{
    public static class IReferenceDataSourceCollectionExtension
    {
        public static IEnumerable<ReferenceDataItem> GetAllItemsByCode(this IEnumerable sources, string code)
        {
            var items = new List<ReferenceDataItem>();
            foreach (var source in sources)
            {
                var refDataSource = source as IReferenceDataSource;
                if (refDataSource != null)
                    items.AddRange(refDataSource.GetItemsByCode(code));
            }
            return items;
        }

        public static IEnumerable<ReferenceDataItem> GetAllItemsByCode(this IEnumerable<IReferenceDataSource> sources, string code)
        {
            return sources.SelectMany(x=> x.GetItemsByCode(code));
        }
    }
}
