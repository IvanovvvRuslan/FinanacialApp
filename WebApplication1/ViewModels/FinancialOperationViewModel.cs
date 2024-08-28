using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Task11.ViewModels
{
    public class FinancialOperationViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }

        [JsonIgnore]
        public OperationTypeViewModel OperationType { get; set; }

        [NotMapped]
        public int OperationTypeId
        {
            get 
            {
                return OperationType != null ? OperationType.Id : 0;
            }
        }

        [NotMapped]
        public string OperationTypeName 
        {
            get
            {
                return OperationType != null ? OperationType.Name : null;
            }
        }

        [NotMapped]
        public bool? OperationTypeIsIncome
        {
            get
            {
                return OperationType != null ? OperationType.IsIncome : null;
            }
        }
    }
}
