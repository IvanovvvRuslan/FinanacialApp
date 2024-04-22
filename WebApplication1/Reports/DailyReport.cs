using Task11.Models;
using Task11.ViewModels;

namespace Task11.Reports
{
    public class DailyReport
    {
        public DateTime Date { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpenses { get; set; }
        public List<FinancialOperationViewModel> Operations { get; set; }
    }
}
