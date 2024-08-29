namespace Task11.ViewModels
{
    public class OperationTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsIncome { get; set; }
        public string? Description { get; set; }

        public ICollection<FinancialOperationViewModel> FinancialOperations { get; set; }
    }
}
