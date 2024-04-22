using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task11.Data;
using Task11.DTOs;
using Task11.Exceptions;
using Task11.Mapper;
using Task11.Models;
using Task11.ViewModels;

namespace Task11.Services
{
    public interface IOperationTypeService
    {
        Task<IEnumerable<OperationTypeViewModel>> GetAll();
        Task<OperationTypeViewModel> GetById(int? id);
        Task Create(OperationTypeDto operationTypeDto);
        Task Update(int id, OperationTypeDto operationTypeDto);
        Task Delete(int id);
    }

    public class OperationTypeService: IOperationTypeService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public OperationTypeService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OperationTypeViewModel>> GetAll()
        {
            var operationType = await _context.OperationTypes.ToListAsync();

            var operationTypeViewModel = _mapper.Map<IEnumerable<OperationTypeViewModel>>(operationType);

            return operationTypeViewModel;
        }

        public async Task<OperationTypeViewModel> GetById(int? id)
        {
            var operationType = await _context.OperationTypes.FirstOrDefaultAsync(o => o.Id == id);
            
            if (operationType == null)
                throw new NotFoundException("Operation type not found");

            var operationTypeViewModel = _mapper.Map<OperationTypeViewModel>(operationType);

            return operationTypeViewModel;
        }

        public async Task Create(OperationTypeDto operationTypeDto)
        {
            var operationType = _mapper.Map<OperationType>(operationTypeDto);
            _context.OperationTypes.Add(operationType);

            await _context.SaveChangesAsync();
        }

        public async Task Update(int id, OperationTypeDto operationTypeDto)
        {
            var operationType = await _context.OperationTypes.FirstOrDefaultAsync(o => o.Id == id);
            
            if (operationType == null)
                throw new NotFoundException("Operation type not found");

            operationType.Name = operationTypeDto.Name;
            operationType.IsIncome = operationTypeDto.IsIncome;
            operationType.Description = operationTypeDto.Description;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var operationType = await _context.OperationTypes.FirstOrDefaultAsync(o => o.Id == id);
            
            if (operationType == null)
                throw new NotFoundException("Operation type not found");

            _context.OperationTypes.Remove(operationType);
            await _context.SaveChangesAsync();
        }
    }
}
