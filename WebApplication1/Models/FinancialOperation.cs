﻿namespace Task11.Models
{
    public class FinancialOperation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }

        public int OperationTypeId { get; set; }
        public OperationType OperationType { get; set; }
    }
}
