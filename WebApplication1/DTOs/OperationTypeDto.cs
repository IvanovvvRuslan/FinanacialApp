using Task11.Models;

namespace Task11.DTOs
{
    public class OperationTypeDto
    {
        public string Name { get; set; }
        public bool IsIncome { get; set; }
        public string? Description { get; set; }

        public ICollection<FinancialOperationDto> FinancialOperations { get; set; }
    }
}
