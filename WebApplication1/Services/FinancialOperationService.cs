using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Task11.Data;
using Task11.DTOs;
using Task11.Exceptions;
using Task11.Models;
using Task11.ViewModels;

namespace Task11.Services
{
    public interface IFinancialOperationService
    {
        Task<IEnumerable<FinancialOperationViewModel>> GetAll();
        Task<FinancialOperationViewModel> GetById(int? id);
        Task Create(FinancialOperationDto financialOperationDto);
        Task Update(int id, FinancialOperationDto financialOperationDto);
        Task Delete(int id);
    }

    public class FinancialOperationService : IFinancialOperationService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FinancialOperationService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FinancialOperationViewModel>> GetAll()
        {
            var financialOperations = await _context.FinancialOperations.ToListAsync();

            var financialOperationsViewModel = _mapper.Map<IEnumerable<FinancialOperationViewModel>>(financialOperations);

            return financialOperationsViewModel;
        }

        public async Task<FinancialOperationViewModel> GetById(int? id)
        {
            var financialOperation = await _context.FinancialOperations.FirstOrDefaultAsync(f => f.Id == id);

            if (financialOperation == null)
                throw new NotFoundException("Financial operation not found");

            var financialOperationViewModel = _mapper.Map<FinancialOperationViewModel>(financialOperation);

            return financialOperationViewModel;
        }

        public async Task Create(FinancialOperationDto financialOperationDto)
        {
            var financialOperation = _mapper.Map<FinancialOperation>(financialOperationDto);
            _context.FinancialOperations.Add(financialOperation);

            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, FinancialOperationDto financialOperationDto)
        {
            var financialOperation = await _context.FinancialOperations.FirstOrDefaultAsync(f => f.Id == id);

            if (financialOperation == null)
                throw new NotFoundException("Financial operation not found");

            financialOperation.Date = financialOperationDto.Date;
            financialOperation.Amount = financialOperationDto.Amount;
            financialOperation.Description = financialOperationDto.Description;
            financialOperation.OperationTypeId = financialOperationDto.OperationTypeId;

            await _context.SaveChangesAsync();
        }
        
        public async Task Delete(int id)
        {
            var financialOperation = await _context.FinancialOperations.FirstOrDefaultAsync(f => f.Id == id);

            if (financialOperation == null)
                throw new NotFoundException("Financial operation not found");

            _context.FinancialOperations.Remove(financialOperation);
            await _context.SaveChangesAsync();
        }
    }
}
