using System.Text.Json.Serialization;

namespace ApiInterface.Models
{
    public class StateDayLineItemJSON
    {
        //Need fields: Date, State, Total, Positive, Negative, and Hospitalization Rates (current & cumulative).
        //Other fields will be ignored for now.

        [JsonPropertyName("date")]
        public int? Date { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }

        [JsonPropertyName("positive")]
        public int? Positive { get; set; }

        [JsonPropertyName("negative")]
        public int? Negative { get; set; }

        [JsonPropertyName("totalTestResults")]
        public int? TotalTestResults { get; set; }

        [JsonPropertyName("hospitalizedCurrently")]
        public int? HospitalizedCurrently { get; set; }

        [JsonPropertyName("hospitalizedCumulative")]
        public int? HospitalizedCumulative { get; set; }
    }
}
