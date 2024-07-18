using System.ComponentModel.DataAnnotations.Schema;

namespace Task11.Models
{
    public class OperationType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        public bool IsIncome { get; set; }
        public string? Description { get; set; }

        public ICollection<FinancialOperation> FinancialOperations { get; set; }
    }
}
