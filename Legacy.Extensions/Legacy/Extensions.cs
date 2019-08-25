using System;

namespace Legacy.Legacy.Extensions
{
    public static class LegacyExtensions
    {
        /// <summary>
        /// Let's supose we have an legacy proyect wich need to express dates with the follow format:
        /// If year is less than 2000, the format must set an '0' before the date 'yyMMddd' (1930/12/31 must be expressed as 0301231)
        /// Otherwise, the format must set an '1' before the date 'yyMMddd'  (2013/12/31 must be expressed as 1131231)
        /// </summary>
        /// <param name="dateTime">Date to parse</param>
        /// <returns></returns>
        public static string ToLegacyFormat(this DateTime dateTime) {
            return dateTime.Year > 1999 ? dateTime.ToString("1yyMMdd") : dateTime.ToString("0yyMMdd");
        }
        /// <summary>
        /// Let's supose we have an legacy proyect wich need to express names with the follow format:
        /// Given a name with format => Firtsname Lastname (Eg.: Simón Bolivar), this function must return
        /// the name with format => LASTNAME, FIRSTNAME (Eg.: BOLIVAR, SIMÓN)
        /// </summary>
        /// <param name="name">Name of a person with format: Firtsname Lastname</param>
        /// <returns></returns>
        public static string ToLegacyFormat(this string name)
        {
            var segmentedName = name.ToUpper().Split(' ');
            return $"{segmentedName[1]}, {segmentedName[0]}";
        }
    }
}
