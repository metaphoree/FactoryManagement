using AutoMapper;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Department;
using Entities.ViewModels.Equipment;
using Entities.ViewModels.EquipmentCategory;
using Entities.ViewModels.ExpenseType;
using Entities.ViewModels.IncomeType;
using Entities.ViewModels.InvoiceType;
using Entities.ViewModels.Item;
using Entities.ViewModels.ItemCategoryView;
using Entities.ViewModels.ItemStatus;
using Entities.ViewModels.Purchase;
using Entities.ViewModels.Sales;
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

            Mapping_DepartmentVM();
            Mapping_EquipmentVM();
            Mapping_EquipmentCategoryVM();
            Mapping_ExpenseTypeVM();
            Mapping_IncomeTypeVM();
            Mapping_InvoiceTypeVM();

            Mapping_Purchase();
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
        public void Mapping_DepartmentVM()
        {
            // GET
            CreateMap<Department, DepartmentVM>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
             .ForAllOtherMembers(act => act.Ignore());

            // ADDITION + UPDATE 
            CreateMap<DepartmentVM, Department>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForAllOtherMembers(act => act.Ignore());

        }

        public void Mapping_EquipmentVM()
        {
            // GET
            CreateMap<Equipment, EquipmentVM>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description))
            .ForMember(dest => dest.EquipmentCategoryId, act => act.MapFrom(src => src.EquipmentCategory.Id))
            .ForMember(dest => dest.MachineNumber, act => act.MapFrom(src => src.MachineNumber))
            .ForMember(dest => dest.Price, act => act.MapFrom(src => src.Price))
            .ForMember(dest => dest.EquipmentCategoryName, act => act.MapFrom(src => src.EquipmentCategory.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
             .ForAllOtherMembers(act => act.Ignore());

            // ADDITION + UPDATE 
            CreateMap<EquipmentVM, Equipment>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForMember(dest => dest.EquipmentCategoryId, act => act.MapFrom(src => src.EquipmentCategoryId))
            .ForMember(dest => dest.Description, act => act.MapFrom(src => src.Description))
            .ForMember(dest => dest.Price, act => act.MapFrom(src => src.Price))
            .ForAllOtherMembers(act => act.Ignore());
        }
        public void Mapping_EquipmentCategoryVM()
        {
            // GET
            CreateMap<EquipmentCategory, EquipmentCategoryVM>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
             .ForAllOtherMembers(act => act.Ignore());

            // ADDITION + UPDATE 
            CreateMap<EquipmentCategoryVM, EquipmentCategory>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForAllOtherMembers(act => act.Ignore());

        }
        public void Mapping_ExpenseTypeVM()
        {
            // GET
            CreateMap<ExpenseType, ExpenseTypeVM>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
             .ForAllOtherMembers(act => act.Ignore());

            // ADDITION + UPDATE 
            CreateMap<ExpenseTypeVM, ExpenseType>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForAllOtherMembers(act => act.Ignore());

        }
        public void Mapping_IncomeTypeVM()
        {
            // GET
            CreateMap<IncomeType, IncomeTypeVM>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
             .ForAllOtherMembers(act => act.Ignore());

            // ADDITION + UPDATE 
            CreateMap<IncomeTypeVM, IncomeType>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForAllOtherMembers(act => act.Ignore());

        }
        public void Mapping_InvoiceTypeVM()
        {
            // GET
            CreateMap<InvoiceType, InvoiceTypeVM>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
            .ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id))
             .ForAllOtherMembers(act => act.Ignore());

            // ADDITION + UPDATE 
            CreateMap<InvoiceTypeVM, InvoiceType>()
            .ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name))
            .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
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

        public void Mapping_Purchase()
        {

            //------------------------------Expense-------------------------------------
            // Addition
            // InvoiceId 
            CreateMap<PurchaseVM, Expense>()
                .ForMember(dest => dest.Amount, act => act.MapFrom(src => src.PaidAmount))
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.SupplierVM.Id))
                .ForMember(dest => dest.EmployeeId, act => act.MapFrom(src => src.EmployeeId))
                .ForMember(dest => dest.ExpenseTypeId, act => act.MapFrom(src => src.ExpenseType.Id))
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForMember(dest => dest.Month, act => act.MapFrom(src => DateTime.Now.Month.ToString("MMM")))
                .ForMember(dest => dest.OccurranceDate, act => act.MapFrom(src => DateTime.Now))
                 .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                .ForAllOtherMembers(act => act.Ignore());


            //-------------------------------Invoice-------------------------------------
            // Addition
            // InvoiceId 
            CreateMap<PurchaseVM, Invoice>()
               .ForMember(dest => dest.AmountAfterDiscount, act => act.MapFrom(src => (src.TotalAmount - src.DiscountAmount)))
               .ForMember(dest => dest.AmountBeforeDiscount, act => act.MapFrom(src => (src.TotalAmount)))
               .ForMember(dest => dest.ClientId, act => act.MapFrom(src => (src.SupplierVM.Id)))
               .ForMember(dest => dest.Discount, act => act.MapFrom(src => src.DiscountAmount))
               .ForMember(dest => dest.Due, act => act.MapFrom(src => src.DueAmount))
               .ForMember(dest => dest.EmployeeId, act => act.MapFrom(src => src.EmployeeId))
               .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
               .ForMember(dest => dest.InvoiceTypeId, act => act.MapFrom(src => src.InvoiceType.Id))
               .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => Guid.NewGuid()))
               .ForMember(dest => dest.IsFullyPaid, act => act.MapFrom(src => !(src.DueAmount > 0)))
               .ForMember(dest => dest.DateOfOcurrance, act => act.MapFrom(src => DateTime.Now))
               .ForAllOtherMembers(act => act.Ignore());



            //----------------------------------Payable-------------------------------------
            // Addition
            // InvoiceId, 
            CreateMap<PurchaseVM, Payable>()
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForMember(dest => dest.Amount, act => act.MapFrom(src => src.DueAmount))
                .ForMember(dest => dest.Month, act => act.MapFrom(src => DateTime.Now.Month.ToString("MMM")))
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.SupplierVM.Id))
                .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                .ForAllOtherMembers(act => act.Ignore());


            //-----------------------------------Purchase-------------------------------------
            // Addition
            // InvoiceId
            CreateMap<PurchaseItemVM, Purchase>()
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForMember(dest => dest.Amount, act => act.MapFrom(src => (src.UnitPrice * src.Quantity)))
                .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.Item.Id))
                .ForMember(dest => dest.ItemCategoryId, act => act.MapFrom(src => src.ItemCategory.Id))
                .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.SupplierVM.Id))
                .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                .ForAllOtherMembers(act => act.Ignore());

            //-------------------------------------Stock-------------------------------------
            // Addition

            CreateMap<PurchaseItemVM, Stock>()
                .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.Item.Id))
                .ForMember(dest => dest.ItemStatusId, act => act.MapFrom(src => src.ItemStatus.Id))
                .ForAllOtherMembers(act => act.Ignore()); ;

            //-------------------------------------StockIn-------------------------------------
            // Addition
            // InvoiceId
            CreateMap<PurchaseItemVM, StockIn>()
                 .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                  .ForMember(dest => dest.ItemStatusId, act => act.MapFrom(src => src.ItemStatus.Id))
                  .ForMember(dest => dest.BatchNumber, act => act.MapFrom(src => Guid.NewGuid()))
                  .ForMember(dest => dest.ExpiryDate, act => act.MapFrom(src => src.ExpiryDate))
                  .ForMember(dest => dest.AddedDateTime, act => act.MapFrom(src => DateTime.Now))
                  .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.Item.Id))
                  .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
                  .ForMember(dest => dest.SupplierId, act => act.MapFrom(src => src.SupplierVM.Id))
                  .ForMember(dest => dest.ExecutorId, act => act.MapFrom(src => src.EmployeeId))
                  .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                  .ForAllOtherMembers(act => act.Ignore());



            //-------------------------------------Transaction-------------------------------------
            // Addition
            // Amount, InvoiceId , PaymentStatus ,TransactionType
            CreateMap<PurchaseVM, Transaction>()
                 .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                 .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.SupplierVM.Id))
                 .ForMember(dest => dest.ExecutorId, act => act.MapFrom(src => src.EmployeeId))
                 .ForMember(dest => dest.Month, act => act.MapFrom(src => DateTime.Now.Month.ToString("MMM")))
                 .ForMember(dest => dest.TransactionId, act => act.MapFrom(src => Guid.NewGuid()))
                 .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                 .ForAllOtherMembers(act => act.Ignore());
        }

        public void Mapping_Sales()
        {

            //------------------------------Expense-------------------------------------
            // Addition
            // InvoiceId 
            CreateMap<SalesVM, Income>()
                .ForMember(dest => dest.Amount, act => act.MapFrom(src => src.PaidAmount))
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.CustomerVM.CustomerId))
                .ForMember(dest => dest.EmployeeId, act => act.MapFrom(src => src.EmployeeId))
                .ForMember(dest => dest.IncomeTypeId, act => act.MapFrom(src => src.IncomeType.Id))
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForMember(dest => dest.Month, act => act.MapFrom(src => DateTime.Now.Month.ToString("MMM")))
                .ForMember(dest => dest.OccurranceDate, act => act.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                .ForAllOtherMembers(act => act.Ignore());


            //-------------------------------Invoice-------------------------------------
            // Addition
            // InvoiceId 
            CreateMap<SalesVM, Invoice>()
               .ForMember(dest => dest.AmountAfterDiscount, act => act.MapFrom(src => (src.TotalAmount - src.DiscountAmount)))
               .ForMember(dest => dest.AmountBeforeDiscount, act => act.MapFrom(src => (src.TotalAmount)))
               .ForMember(dest => dest.ClientId, act => act.MapFrom(src => (src.CustomerVM.CustomerId)))
               .ForMember(dest => dest.Discount, act => act.MapFrom(src => src.DiscountAmount))
               .ForMember(dest => dest.Due, act => act.MapFrom(src => src.DueAmount))
               .ForMember(dest => dest.EmployeeId, act => act.MapFrom(src => src.EmployeeId))
               .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
               .ForMember(dest => dest.InvoiceTypeId, act => act.MapFrom(src => src.InvoiceType.Id))
               .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => Guid.NewGuid()))
               .ForMember(dest => dest.IsFullyPaid, act => act.MapFrom(src => !(src.DueAmount > 0)))
               .ForMember(dest => dest.DateOfOcurrance, act => act.MapFrom(src => DateTime.Now))
               .ForAllOtherMembers(act => act.Ignore());

            //----------------------------------Recievable-------------------------------------
            // Addition
            // InvoiceId, 
            CreateMap<SalesVM, Recievable>()
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForMember(dest => dest.Amount, act => act.MapFrom(src => src.DueAmount))
                .ForMember(dest => dest.Month, act => act.MapFrom(src => DateTime.Now.Month.ToString("MMM")))
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.CustomerVM.CustomerId))
                .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                .ForAllOtherMembers(act => act.Ignore());


            //-----------------------------------Purchase-------------------------------------
            // Addition
            // InvoiceId
            CreateMap<SalesItemVM, Sales>()
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForMember(dest => dest.Amount, act => act.MapFrom(src => (src.UnitPrice * src.Quantity)))
                .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.Item.Id))
                .ForMember(dest => dest.ItemCategoryId, act => act.MapFrom(src => src.ItemCategory.Id))
                .ForMember(dest => dest.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
                .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.CustomerVM.CustomerId))
                .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                .ForAllOtherMembers(act => act.Ignore());

            //-------------------------------------Stock-------------------------------------
            // Addition

            CreateMap<SalesItemVM, Stock>()
                .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.Item.Id))
                .ForMember(dest => dest.ItemStatusId, act => act.MapFrom(src => src.ItemStatus.Id))
                .ForAllOtherMembers(act => act.Ignore()); ;

            //-------------------------------------StockIn-------------------------------------
            // Addition
            // InvoiceId
            CreateMap<SalesItemVM, StockOut>()
                 .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                  .ForMember(dest => dest.ItemStatusId, act => act.MapFrom(src => src.ItemStatus.Id))
                  .ForMember(dest => dest.BatchNumber, act => act.MapFrom(src => Guid.NewGuid()))
                  .ForMember(dest => dest.ExpiryDate, act => act.MapFrom(src => src.ExpiryDate))
                  .ForMember(dest => dest.ItemId, act => act.MapFrom(src => src.Item.Id))
                  .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
                  .ForMember(dest => dest.BuyerId, act => act.MapFrom(src => src.CustomerVM.CustomerId))
                  .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                  .ForMember(dest => dest.ExecutorId, act => act.MapFrom(src => src.EmployeeId))
                  .ForAllOtherMembers(act => act.Ignore());



            //-------------------------------------Transaction-------------------------------------
            // Addition
            // Amount, InvoiceId , PaymentStatus ,TransactionType
            CreateMap<SalesVM, Transaction>()
                 .ForMember(dest => dest.FactoryId, act => act.MapFrom(src => src.FactoryId))
                 .ForMember(dest => dest.ClientId, act => act.MapFrom(src => src.CustomerVM.CustomerId))
                 .ForMember(dest => dest.ExecutorId, act => act.MapFrom(src => src.EmployeeId))
                 .ForMember(dest => dest.Month, act => act.MapFrom(src => DateTime.Now.Month.ToString("MMM")))
                 .ForMember(dest => dest.TransactionId, act => act.MapFrom(src => Guid.NewGuid()))
                 .ForMember(dest => dest.InvoiceId, act => act.MapFrom(src => src.InvoiceId))
                 .ForAllOtherMembers(act => act.Ignore());
        }

    }
}
