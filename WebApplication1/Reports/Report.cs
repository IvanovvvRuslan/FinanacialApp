using Task11.Models;
using Task11.ViewModels;

namespace Task11.Reports
{
    public class Report
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public List<FinancialOperationViewModel> Operations { get; set; }
    }
}
