using System.Collections.Generic;
using CovidTracker.Models;
using CovidTracker.ApiInterface.Logic;

namespace CovidTracker.Data
{
    public interface IDataProvider
    {
        Task<List<StateDayLineItem>> HistoricalData();
    }

    public class DataProvider : IDataProvider
    {
        private readonly ICovidApi _api;

        public DataProvider(ICovidApi api)
        {
            _api = api;
        }

        public async Task<List<StateDayLineItem>> HistoricalData()
        {
            return await _api.GetHistoricalData();
        }
    }

    public class DefaultDataProvider : IDataProvider
    {
        private readonly ICovidApi _api;

        public DefaultDataProvider()
        {
            _api = new CovidApiTheAtlantic();
        }

        public async Task<List<StateDayLineItem>> HistoricalData()
        {
            return await _api.GetHistoricalData();
        }
    }
}