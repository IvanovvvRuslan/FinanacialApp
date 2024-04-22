using System.ComponentModel.DataAnnotations.Schema;

namespace Task11.ViewModels
{
    public class FinancialOperationViewModel
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }

        public OperationTypeViewModel OperationType { get; set; }

        [NotMapped]
        public string OperationTypeName 
        {
            get
            {
                //return OperationType.Name;
                return OperationType != null ? OperationType.Name : null;
            }
        }
    }
}
