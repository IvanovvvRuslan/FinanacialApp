namespace Task11.Models
{
    public class FinancialOperation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public OperationType OperationType { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }

        public int? IncomeId { get; set; }
        public Income Incomes { get; set; }

        public int? ExpenseId { get; set; }
        public Expense Expenses { get; set; }
    }

    public enum OperationType
    { 
        Income,
        Expense
    }
}
