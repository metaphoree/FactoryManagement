using AutoMapper;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Item;
using Entities.ViewModels.ItemCategoryView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {


            Mapping_AddCustomerViewModel();
            Mapping_UpdateCustomerViewModel();
            Mapping_UpdateItemCategoryVM();
            Mapping_AddItemCategoryVM();
            Mapping_UpdateItemVM();
            Mapping_AddItemVM();
            Mapping_CustomerListView();
        }

        public void Mapping_AddCustomerViewModel() {
            CreateMap<AddCustomerViewModel, Customer>()
                   .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                    .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
                     .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                     .ForAllOtherMembers(act => act.Ignore());

            CreateMap<AddCustomerViewModel, Address>()
                .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
                .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForAllOtherMembers(act => act.Ignore());


            CreateMap<AddCustomerViewModel, Phone>()
                .ForMember(dest => dest.Number, act => act.MapFrom(src => src.CellNo))
                .ForMember(dest => dest.AlternateNumber_1, act => act.MapFrom(src => src.AlternateCellNo))
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForAllOtherMembers(act => act.Ignore());
        }
        public void Mapping_UpdateCustomerViewModel() {
            CreateMap<UpdateCustomerViewModel, Customer>()
            .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
            .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForAllOtherMembers(act => act.Ignore());

            CreateMap<UpdateCustomerViewModel, Address>()
                .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
                .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
                .ForAllOtherMembers(act => act.Ignore());


            CreateMap<UpdateCustomerViewModel, Phone>()
                .ForMember(dest => dest.Number, act => act.MapFrom(src => src.CellNo))
                .ForMember(dest => dest.AlternateNumber_1, act => act.MapFrom(src => src.AlternateCellNo))
                .ForAllOtherMembers(act => act.Ignore());
        }
        public void Mapping_UpdateItemCategoryVM() {

            CreateMap<UpdateItemCategoryViewModel, ItemCategory>()
                  .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                     .ForAllOtherMembers(act => act.Ignore());

        }

        public void Mapping_AddItemCategoryVM()
        {

            CreateMap<AddItemCategoryViewModel, ItemCategory>()
                  .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                   .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForAllOtherMembers(act => act.Ignore());

        }

        public void Mapping_UpdateItemVM()
        {

            CreateMap<UpdateItemVM, Item>()
                  .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                  .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
                  .ForMember(dest => dest.CategoryId, act => act.MapFrom(src => src.CategoryId))
                     .ForAllOtherMembers(act => act.Ignore());
        }
        public void Mapping_AddItemVM()
        {

            CreateMap<AddItemVM, Item>()
                  .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                   .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
                  .ForMember(dest => dest.CategoryId, act => act.MapFrom(src => src.CategoryId))
                   .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForAllOtherMembers(act => act.Ignore());

        }



        public void Mapping_CustomerListView() {

            CreateMap<Customer, ListCustomerVM>()
                     .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                      .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                     .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
                      .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                       .ForMember(dest => dest.CustomerId, act => act.MapFrom(src => src.Id))
                        .ForAllOtherMembers(act => act.Ignore());

            CreateMap<Address, ListCustomerVM>()
         .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
          .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
            .ForAllOtherMembers(act => act.Ignore());


            CreateMap<Phone, ListCustomerVM>()
.ForMember(dest => dest.CellNo, act => act.MapFrom(src => src.Number))
 .ForMember(dest => dest.AlternateCellNo, act => act.MapFrom(src => src.AlternateNumber_1))
   .ForAllOtherMembers(act => act.Ignore());


        }








    }
}
