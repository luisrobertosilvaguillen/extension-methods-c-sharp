using System.Collections.Generic;

namespace Custom.Object.Extensions.Datasources
{
    public interface IReferenceDataSource
    {
        IEnumerable<ReferenceDataItem> GetItems();
    }
}
