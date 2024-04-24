using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Task11.Data;
using Task11.Exceptions;
using Task11.Models;
using Task11.Reports;
using Task11.ViewModels;

namespace Task11.Services
{
    public interface IDailyReportService
    { 
        Task<DailyReport> GetDailyReport(DateTime dateTime);
    }

    public class DailyReportService: IDailyReportService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DailyReportService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DailyReport> GetDailyReport(DateTime dateTime)
        {
            var financialOperations = await _context.FinancialOperations
                .Include(o => o.OperationType)
                .Where(f => f.Date.Date == dateTime.Date)
                .AsNoTracking()
                .ToListAsync();

            decimal totalIncome = 0;
            decimal totalExpense = 0;

            foreach (var operation in financialOperations) 
            {
                var operationType = await _context.OperationTypes
                    .AsNoTracking()
                    .FirstOrDefaultAsync(o => o.Id == operation.OperationTypeId);

                if (operationType == null)
                    throw new NotFoundException("Operation type not found");

                if (operationType.IsIncome == true)
                {
                    totalIncome += operation.Amount;
                }
                else
                { 
                    totalExpense += operation.Amount;
                }
            }

            DailyReport dailyReport = new DailyReport()
            { 
                Date = dateTime.Date,
                TotalIncome = totalIncome,
                TotalExpenses = totalExpense,
                Operations = _mapper.Map<List<FinancialOperationViewModel>>(financialOperations)
            };

            return dailyReport;
        }
    }
}
