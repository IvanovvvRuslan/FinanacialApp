using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task11_Common.ViewModels
{
    public class FinancialOperationViewModelCommon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Date is required")]
        public DateTime? Date { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }
        public string? Description { get; set; }

        [Required(ErrorMessage = "Operation Type is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select an operation type")]
        public int OperationTypeId { get; set; }

        public OperationTypeViewModelCommon OperationTypeViewModelCommon { get; set; }

        [NotMapped]
        public string OperationTypeName { get; set; }
        public bool OperationTypeIsIncome { get; set; }
    }
}
