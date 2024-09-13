using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task11_Common.ViewModels
{
    public class OperationTypeViewModelCommon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        public bool IsIncome { get; set; }
        
        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }
    }
}
