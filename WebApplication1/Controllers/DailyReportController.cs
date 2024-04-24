using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Task11.Reports;
using Task11.Services;

namespace Task11.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DailyReportController : Controller
    {
        private readonly IDailyReportService _dailyReportService;

        public DailyReportController(IDailyReportService dailyReportService)
        {
            _dailyReportService = dailyReportService;
        }

        // GET: DailyReport
        [HttpGet("{dateTime}")]
        public async Task<ActionResult<DailyReport>> GetDailyReport ([FromRoute]DateTime dateTime)
        {
            
            var dailyReport = await _dailyReportService.GetDailyReport(dateTime);
            
            return Ok(dailyReport);
        }
    }
}
