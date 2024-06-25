using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_Common.ViewModels
{
    public class OperationTypeViewModelCommon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsIncome { get; set; }
        public string? Description { get; set; }
    }
}
