namespace CovidTracker.Models
{
    public class IndexVM
    {
        /// <summary>
        /// All available dates in the report.
        /// </summary>
        public List<DateTime> ReportDates { get; set; }

        /// <summary>
        /// The date for which the data is filtered, or null if no date is selected.
        /// </summary>
        public DateTime? ActiveDate { get; set; }

        /// <summary>
        /// A list of line items sorted by active date unless that date is null.
        /// </summary>
        public List<StateDayLineItem> Items { get; set; }
    }
}
