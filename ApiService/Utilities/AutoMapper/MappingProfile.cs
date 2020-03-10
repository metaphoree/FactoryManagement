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
        public MappingProfile()
        {
            Mapping_CustomerVM();
            Mapping_ItemCategoryVM();
            Mapping_ItemVM();
        }
        public void Mapping_CustomerVM()
        {
            // GET
            CreateMap<Customer, CustomerVM>()
                   .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                    .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
                     .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                         .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
                         .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
                         .ForMember(dest => dest.CellNo, act => act.MapFrom(src => src.Number))
                         .ForMember(dest => dest.AlternateCellNo, act => act.MapFrom(src => src.AlternateNumber_1))
                          .ForMember(dest => dest.CustomerId, act => act.MapFrom(src => src.Id))
                     .ForAllOtherMembers(act => act.Ignore());
            // UPDATE + ADDITION
            CreateMap<CustomerVM, Customer>()
                   .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                    .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
                     .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                         .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
                         .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
                         .ForMember(dest => dest.Number, act => act.MapFrom(src => src.CellNo))
                         .ForMember(dest => dest.AlternateNumber_1, act => act.MapFrom(src => src.AlternateCellNo))                         
                     .ForAllOtherMembers(act => act.Ignore());

            //            CreateMap<UpdateCustomerViewModel, Customer>()
            //.ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
            //.ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
            //.ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
            //    .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
            //        .ForMember(dest => dest.Number, act => act.MapFrom(src => src.CellNo))
            //    .ForMember(dest => dest.AlternateNumber_1, act => act.MapFrom(src => src.AlternateCellNo))
            //.ForAllOtherMembers(act => act.Ignore());




            //CreateMap<AddCustomerViewModel, Address>()
            //    .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
            //    .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
            //    .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            //    .ForAllOtherMembers(act => act.Ignore());


            //CreateMap<AddCustomerViewModel, Phone>()
            //    .ForMember(dest => dest.Number, act => act.MapFrom(src => src.CellNo))
            //    .ForMember(dest => dest.AlternateNumber_1, act => act.MapFrom(src => src.AlternateCellNo))
            //    .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            //    .ForAllOtherMembers(act => act.Ignore());
        }
        public void Mapping_UpdateCustomerViewModelmm()
        {
            //CreateMap<UpdateCustomerViewModel, Address>()
            //    .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
            //    .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
            //    .ForAllOtherMembers(act => act.Ignore());


            //CreateMap<UpdateCustomerViewModel, Phone>()
            //    .ForMember(dest => dest.Number, act => act.MapFrom(src => src.CellNo))
            //    .ForMember(dest => dest.AlternateNumber_1, act => act.MapFrom(src => src.AlternateCellNo))
            //    .ForAllOtherMembers(act => act.Ignore());
        }
        public void Mapping_ItemCategoryVM()
        {
            // GET
            CreateMap<ItemCategory, ItemCategoryVM>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
             .ForAllOtherMembers(act => act.Ignore());

            // ADDITION + UPDATE 
            CreateMap<ItemCategoryVM, ItemCategory>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForAllOtherMembers(act => act.Ignore());

            //  CreateMap<List<ItemCategory>, List<ItemCategoryVM>>();
        }
        public void Mapping_ItemVM()
        {
            // GET 
            CreateMap<Item, ItemVM>()
                  .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                  .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                  .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                  .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
                  .ForMember(dest => dest.CategoryId, act => act.MapFrom(src => src.CategoryId))
                  .ForMember(dest => dest.CategoryName, act => act.MapFrom(src => src.ItemCategory.Name))
                  .ForAllOtherMembers(act => act.Ignore());


            // ADDITION + UPDATE 
            CreateMap<ItemVM, Item>()
                  .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                  .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                  .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
                  .ForMember(dest => dest.CategoryId, act => act.MapFrom(src => src.CategoryId))
                  .ForAllOtherMembers(act => act.Ignore());
        }
        public void Mapping_CustomerListView()
        {

 //           CreateMap<Customer, ListCustomerVM>()
 //                    .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
 //                     .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
 //                    .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
 //                     .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
 //                      .ForMember(dest => dest.CustomerId, act => act.MapFrom(src => src.Id))
 //                       .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
 //         .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
 //         .ForMember(dest => dest.CellNo, act => act.MapFrom(src => src.Number))
 //.ForMember(dest => dest.AlternateCellNo, act => act.MapFrom(src => src.AlternateNumber_1))
 //                       .ForAllOtherMembers(act => act.Ignore());

            //            CreateMap<Address, ListCustomerVM>()
            //         .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
            //          .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
            //            .ForAllOtherMembers(act => act.Ignore());


            //            CreateMap<Phone, ListCustomerVM>()
            //.ForMember(dest => dest.CellNo, act => act.MapFrom(src => src.Number))
            // .ForMember(dest => dest.AlternateCellNo, act => act.MapFrom(src => src.AlternateNumber_1))
            //   .ForAllOtherMembers(act => act.Ignore());
        }

    }
}
