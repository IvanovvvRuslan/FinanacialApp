using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task11.Data;
using Task11.Exceptions;
using Task11.Models;
using Task11.Reports;
using Task11.ViewModels;

namespace Task11.Services
{
    public interface IReportService
    {
        Task<Report> GetDailyReport(DateTime date);
        Task<Report> GetPeriodReport(DateTime startDate, DateTime endDate);
    }

    public class ReportService: IReportService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ReportService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Report> GetDailyReport(DateTime date)
        {
            return await GetReport(date, date);
        }

        public async Task<Report> GetPeriodReport(DateTime startDate, DateTime endDate)
        {
            return await GetReport(startDate, endDate);
        }

        private async Task<Report> GetReport(DateTime startDate, DateTime endDate)
        {
            decimal totalIncome = 0;
            decimal totalExpense = 0;

            if (startDate > endDate)
            {
                throw new InvalidOperationException("The start date must be less than or equal to the end date.");
            }


            var financialOperations = await _context.FinancialOperations
                .Include(o => o.OperationType)
                .Where(f => f.Date.Date >= startDate.Date && f.Date.Date <= endDate.Date)
                .AsNoTracking()
                .ToListAsync();

            foreach (var operation in financialOperations)
            {
                var operationType = await _context.OperationTypes
                    .AsNoTracking()
                    .FirstOrDefaultAsync(o => o.Id == operation.OperationTypeId);

                if (operationType.IsIncome == true)
                {
                    totalIncome += operation.Amount;
                }
                else
                {
                    totalExpense += operation.Amount;
                }
            }

            Report report = new Report()
            {
                StartDate = startDate,
                EndDate = endDate,
                TotalIncome = totalIncome,
                TotalExpense = totalExpense,
                Operations = _mapper.Map<List<FinancialOperationViewModel>>(financialOperations)
            };

            return report;
        }
    }
}
