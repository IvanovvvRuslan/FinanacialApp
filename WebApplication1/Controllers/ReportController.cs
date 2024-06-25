using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Text.Json;
using Task11.Exceptions;
using Task11.Reports;
using Task11.Services;

namespace Task11.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : Controller
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        // GET: DailyReport
        [HttpGet("daily/{dateTime}")]
        public async Task<ActionResult<Report>> GetDailyReport([FromRoute] DateTime dateTime)
        {
            var dailyReport = await _reportService.GetDailyReport(dateTime);

            if (dailyReport == null)
                return NotFound();

            return Ok(dailyReport);
        }

        //GET: PeriodReport
        [HttpGet("period/{startDate}/{endDate}")]
        public async Task<ActionResult<Report>> GetPeriodReport([FromRoute] DateTime startDate, [FromRoute] DateTime endDate)
        {
            var periodReport = await _reportService.GetPeriodReport(startDate, endDate);

            if (periodReport == null)
                return NotFound();

            return Ok(periodReport);
        }

        //GET: Exception                                        2 DELETE !!!
        [HttpGet("dateException")]
        public IActionResult GetDateException()
        { 
           throw new InvalidDateException("Invalid date exception test text");
        }

        //GET: Exception
        [HttpGet("exception")]
        public IActionResult GetException()
        {
            throw new Exception();
        }
    }
}
