﻿namespace Task11.Models
{
    public class Income
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<FinancialOperation> FinancialOperations { get; set; }
    }
}
