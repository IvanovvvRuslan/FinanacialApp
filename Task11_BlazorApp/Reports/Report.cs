using Task11_Common.ViewModels;

namespace Task11_BlazorApp.Reports
{
    public class Report
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public List<FinancialOperationViewModelCommon> Operations { get; set; }
    }
}
