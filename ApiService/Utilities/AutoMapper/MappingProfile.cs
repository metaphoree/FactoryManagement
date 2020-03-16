using AutoMapper;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Item;
using Entities.ViewModels.ItemCategoryView;
using Entities.ViewModels.ItemStatus;
using Entities.ViewModels.Staff;
using Entities.ViewModels.Stock;
using Entities.ViewModels.Supplier;
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
            Mapping_StockVM();
            Mapping_SupplierVM();
            Mapping_StaffVM();
            Mapping_ItemStatusVM();
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
        public void Mapping_StaffVM()
        {
            // GET
            CreateMap<Staff, StaffVM>()
                   .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                    .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
                     .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                         .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
                         .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
                         .ForMember(dest => dest.CellNo, act => act.MapFrom(src => src.Number))
                         .ForMember(dest => dest.AlternateCellNo, act => act.MapFrom(src => src.AlternateNumber_1))
                          .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                     .ForAllOtherMembers(act => act.Ignore());
            // UPDATE + ADDITION
            CreateMap<StaffVM, Staff>()
                   .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                    .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
                     .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                         .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
                         .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
                         .ForMember(dest => dest.Number, act => act.MapFrom(src => src.CellNo))
                         .ForMember(dest => dest.AlternateNumber_1, act => act.MapFrom(src => src.AlternateCellNo))
                     .ForAllOtherMembers(act => act.Ignore());
        }
        public void Mapping_SupplierVM()
        {
            // GET
            CreateMap<Supplier, SupplierVM>()
                   .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                    .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
                     .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                         .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
                         .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
                         .ForMember(dest => dest.CellNo, act => act.MapFrom(src => src.Number))
                         .ForMember(dest => dest.AlternateCellNo, act => act.MapFrom(src => src.AlternateNumber_1))
                          .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                     .ForAllOtherMembers(act => act.Ignore());
            // UPDATE + ADDITION
            CreateMap<SupplierVM, Supplier>()
                   .ForMember(dest => dest.Email, act => act.MapFrom(src => src.Email))
                    .ForMember(dest => dest.ImageUrl, act => act.MapFrom(src => src.ImageUrl))
                     .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
                         .ForMember(dest => dest.PresentAddress, act => act.MapFrom(src => src.PresentAddress))
                         .ForMember(dest => dest.PermanentAddress, act => act.MapFrom(src => src.PermanentAddress))
                         .ForMember(dest => dest.Number, act => act.MapFrom(src => src.CellNo))
                         .ForMember(dest => dest.AlternateNumber_1, act => act.MapFrom(src => src.AlternateCellNo))
                     .ForAllOtherMembers(act => act.Ignore());
        }

        public void Mapping_StockVM()
        {
            // GET
            CreateMap<Stock, StockVM>()
                   .ForMember(dest => dest.ExpiryDate, act => act.MapFrom(src => src.ExpiryDate))
                    .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.ItemId))
                     .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                     .ForMember(dest => dest.ItemName, act => act.MapFrom(src => src.Item.Name))
                         .ForMember(dest => dest.ItemStatus, act => act.MapFrom(src => src.ItemStatus.Name))
                         .ForMember(dest => dest.ItemStatusId, act => act.MapFrom(src => src.ItemStatus.Id))
                         .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
                          .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
                     .ForAllOtherMembers(act => act.Ignore());
            // UPDATE + ADDITION
            CreateMap<StockVM, Stock>()
              .ForMember(dest => dest.ExpiryDate, act => act.MapFrom(src => src.ExpiryDate))
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                         .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
                           .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.ItemId))
                            .ForMember(dest => dest.ItemStatusId, act => act.MapFrom(src => src.ItemStatusId))
                     .ForAllOtherMembers(act => act.Ignore());
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


        public void Mapping_ItemStatusVM()
        {
            // GET
            CreateMap<ItemStatus, ItemStatusVM>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
             .ForAllOtherMembers(act => act.Ignore());

            // ADDITION + UPDATE 
            //CreateMap<ItemCategoryVM, ItemCategory>()
            //.ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            //.ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            //.ForAllOtherMembers(act => act.Ignore());

            //  CreateMap<List<ItemCategory>, List<ItemCategoryVM>>();
        }









    }
}
