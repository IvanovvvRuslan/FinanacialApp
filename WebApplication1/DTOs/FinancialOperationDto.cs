namespace Task11.DTOs
{
    public class FinancialOperationDto
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }

        public int OperationTypeId { get; set; }
        //public OperationTypeDto OperationType { get; set; }
    }
}
