using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_Common.ViewModels
{
    public class FinancialOperationViewModelCommon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Enter a valid amount")]
        public decimal Amount { get; set; }
        public string? Description { get; set; }

        public int OperationTypeId { get; set; }

        public OperationTypeViewModelCommon OperationTypeViewModelCommon { get; set; }

        [NotMapped]
        public string OperationTypeName { get; set; }
    }
}
