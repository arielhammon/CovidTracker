namespace CovidTracker.Models
{
    public class StateDayLineItem
    {
        public DateTime? Date { get; set; }

        public string? State { get; set; }

        public int? Positive { get; set; }

        public int? Negative { get; set; }

        public int? TotalTestResults { get; set; }

        public int? HospitalizedCurrently { get; set; }

        public int? HospitalizedCumulative { get; set; }
    }
}
