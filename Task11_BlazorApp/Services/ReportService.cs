using Task11_BlazorApp.Reports;

namespace Task11_BlazorApp.Services
{
    public interface IReportService
    {
        Task<Report> GetDailyReport(DateTime? dateTime);
        Task<Report> GetPeriodReport(DateTime? startDate, DateTime? endDate);
    }

    public class ReportService: IReportService
    {
        private readonly HttpClient _httpClient;

        public ReportService(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient("API");
        }

        public async Task<Report> GetDailyReport(DateTime? dateTime)
        {
            if (!dateTime.HasValue)
            {
                throw new InvalidDataException("Date is required");
            }
            
            var dateString = dateTime.Value.ToString("yyyy-MM-dd");
            var report = await _httpClient.GetFromJsonAsync<Report>($"api/report/daily/{dateString}");

            return report;
        }

        public async Task<Report> GetPeriodReport(DateTime? startDate, DateTime? endDate)
        {
            if (!startDate.HasValue || !endDate.HasValue)
            {
                throw new InvalidDataException("Both dates are required");
            }

            var startDateString = startDate.Value.ToString("yyyy-MM-dd");
            var endDateString = endDate.Value.ToString("yyyy-MM-dd");
            var report = await _httpClient.GetFromJsonAsync<Report>($"api/report/period/{startDateString}/{endDateString}");

            return report;
        }
    }
}
