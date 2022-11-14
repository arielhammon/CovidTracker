using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.Json;
using ApiInterface.Models;
using CovidTracker.Models;

namespace CovidTracker.ApiInterface.Logic
{
    public interface ICovidApi
    {
        Task<List<StateDayLineItem>> GetHistoricalData();
    }

    /// <summary>
    /// Represents the CovidTracking project API by The Atlantic.
    /// </summary>
    public class CovidApiTheAtlantic : ICovidApi
    {
        private static readonly HttpClient client = new HttpClient();
        private const string API_URL = "https://api.covidtracking.com/v1/states/daily.json";

        public async Task<List<StateDayLineItem>> GetHistoricalData()
        {
            var streamTask = client.GetStreamAsync(API_URL);
            var items = await JsonSerializer.DeserializeAsync<List<StateDayLineItemJSON>>(await streamTask);
            if (items == null)
                return new List<StateDayLineItem>();
            else
                return items.Select(x => ModelConverter.Convert(x)).ToList();
        }
    }
}
