using System.Xml;

namespace System
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Datetime to a Xml given mode Format, by default is utc
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static string ToXmlFormat(this DateTime dateTime, XmlDateTimeSerializationMode mode = XmlDateTimeSerializationMode.Utc)
        {
            return XmlConvert.ToString(dateTime, mode);
        }
    }
}
