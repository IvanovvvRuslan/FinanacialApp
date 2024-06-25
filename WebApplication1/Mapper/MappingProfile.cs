using AutoMapper;
using Task11.DTOs;
using Task11.Models;
using Task11.ViewModels;
using Task11_Common.ViewModels;

namespace Task11.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<FinancialOperation, FinancialOperationViewModel>()
                .ForMember(dest => dest.OperationTypeName, opt => opt.MapFrom(src => src.OperationType.Name));
            CreateMap<OperationType, OperationTypeViewModel>();

            CreateMap<FinancialOperation, FinancialOperationDto>();
            CreateMap<OperationType, OperationTypeDto>();

            CreateMap<OperationTypeDto, OperationType>();
            CreateMap<FinancialOperationDto, FinancialOperation>();

            CreateMap<OperationTypeDto, OperationTypeViewModelCommon>().ReverseMap();
        }
    }
}
