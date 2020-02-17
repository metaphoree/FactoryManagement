using AutoMapper;
using Entities.DbModels;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {

            // CreateMap<Account,AccountDto>();
            CreateMap<AddCustomerViewModel, Customer>();
            CreateMap<AddCustomerViewModel, Address>();
            CreateMap<AddCustomerViewModel, Phone>()
                .ForMember(dest => dest.Number, act=> act.MapFrom(src => src.CellNo));
        }

    }
}
