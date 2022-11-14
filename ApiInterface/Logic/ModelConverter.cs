using CovidTracker.Models;
using ApiInterface.Models;

namespace CovidTracker.ApiInterface.Logic
{
    public static class ModelConverter
    {
        public static StateDayLineItem Convert(StateDayLineItemJSON other)
        {
            return new StateDayLineItem
            {
                Date = other.Date.ToDate(),
                State = other.State,
                Positive = other.Positive,
                Negative = other.Negative,
                TotalTestResults = other.TotalTestResults,
                HospitalizedCurrently = other.HospitalizedCurrently,
                HospitalizedCumulative = other.HospitalizedCumulative
            };
        }
    }
}
