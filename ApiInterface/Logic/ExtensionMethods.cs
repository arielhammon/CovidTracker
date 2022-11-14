namespace CovidTracker.ApiInterface.Logic
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Converts 8 digit integers in the format of yyyymmdd to DateTime values.
        /// Example: 20161108 will be converted to 2016-11-08.
        /// Null values will return null values.
        /// </summary>
        public static DateTime? ToDate(this int? yyyymmdd)
        {
            if (yyyymmdd == null) return null;
            string str = Convert.ToString((int)yyyymmdd);
            int year = Convert.ToInt32(str.Substring(0, 4));
            int month = Convert.ToInt32(str.Substring(4, 2));
            int day = Convert.ToInt32(str.Substring(6, 2));
            return new DateTime(year, month, day);
        }

        public static string ToString(this DateTime? datetime, string format)
        {
            if (datetime == null) return "";
            return ((DateTime)datetime).ToString(format);
        }

        /// <summary>
        /// Formats an integer in number format.
        /// Example: 12345 will be converted to 12,345 in the en-US culture.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static string ToNumberFormat(this int? n)
        {
            if (n == null) return "";
            return ((int)n).ToString("N0");
        }
    }
}
