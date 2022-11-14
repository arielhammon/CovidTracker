using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

using CovidTracker.Models;
using CovidTracker.Data;
using CovidTracker.ApiInterface.Logic;

namespace CovidTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<ViewResult> Index(string ReportDates)
        {

            IDataProvider dp = new DefaultDataProvider();
            var list = await dp.HistoricalData();
            
            ViewBag.ReportDates = new SelectList(list.Select(x => x.Date)
                .Distinct()
                .OrderByDescending(x => x)
                .Select(x => x.ToString("M-d-yyyy")));

            DateTime? selectDate;
            if (string.IsNullOrEmpty(ReportDates))
                selectDate = list.Select(x => x.Date).Max(); //most recent date
            else
                selectDate = Convert.ToDateTime(ReportDates);
            list = list.Where(x => x.Date == selectDate).OrderByDescending(x => x.Positive).ToList();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}