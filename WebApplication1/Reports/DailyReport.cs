using Task11.Models;

namespace Task11.Reports
{
    public class DailyReport
    {
        public DateTime Date { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public List<FinancialOperation> Operations { get; set; }
    }
}
