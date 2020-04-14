﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
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
using Entities.ViewModels.Production;
using Entities.ViewModels.Stock;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiService.Controllers
{
    [Route("api")]
    [ApiController]
    public class MassCrudController : ControllerBase
    {
        private readonly FactoryManagementContext _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IServiceWrapper _serviceWrapper;
        private readonly ILoggerManager _logger;
        private readonly IUtilService _utilService;
        public MassCrudController(FactoryManagementContext context, IRepositoryWrapper repositoryWrapper, IServiceWrapper serviceWrapper, ILoggerManager logger,IUtilService utilService)
        {
            _context = context;
            _repositoryWrapper = repositoryWrapper;
            _serviceWrapper = serviceWrapper;
            _logger = logger;
            _utilService = utilService;
        }
        #region ExpenseType
        [HttpPost]
        [Route("ExpenseType/getAll")]
        public async Task<ActionResult<WrapperExpenseTypeListVM>> GetExpenseType([FromBody]GetDataListVM customer)
        {
            return await _serviceWrapper.ExpenseTypeService.GetListPaged(customer);
        }



        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("ExpenseType/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperExpenseTypeListVM>> PutExpenseType(string id, [FromBody]ExpenseTypeVM ExpenseType)
        {
            return await _serviceWrapper.ExpenseTypeService.Update(id, ExpenseType);
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        [Route("ExpenseType/add")]
        public async Task<ActionResult<WrapperExpenseTypeListVM>> PostExpenseType([FromBody]ExpenseTypeVM ExpenseType)
        {
            return await _serviceWrapper.ExpenseTypeService.Add(ExpenseType);
        }

        [HttpPost]
        [Route("ExpenseType/delete")]
        public async Task<ActionResult<WrapperExpenseTypeListVM>> DeleteExpenseType([FromBody]ExpenseTypeVM itemVM)
        {
            return await _serviceWrapper.ExpenseTypeService.Delete(itemVM);
        }

        #endregion
        #region IncomeType
        [HttpPost]
        [Route("IncomeType/getAll")]
        public async Task<ActionResult<WrapperIncomeTypeListVM>> GetCustomer([FromBody]GetDataListVM customer)
        {
            return await _serviceWrapper.IncomeTypeService.GetListPaged(customer);
        }



        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("IncomeType/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperIncomeTypeListVM>> PutIncomeType(string id, [FromBody]IncomeTypeVM IncomeType)
        {
            return await _serviceWrapper.IncomeTypeService.Update(id, IncomeType);
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        [Route("IncomeType/add")]
        public async Task<ActionResult<WrapperIncomeTypeListVM>> PostIncomeType([FromBody]IncomeTypeVM IncomeType)
        {
            return await _serviceWrapper.IncomeTypeService.Add(IncomeType);
        }

        [HttpPost]
        [Route("IncomeType/delete")]
        public async Task<ActionResult<WrapperIncomeTypeListVM>> DeleteIncomeType([FromBody]IncomeTypeVM itemVM)
        {
            return await _serviceWrapper.IncomeTypeService.Delete(itemVM);
        }

        #endregion
        #region InvoiceType
        [HttpPost]
        [Route("InvoiceType/getAll")]
        public async Task<ActionResult<WrapperInvoiceTypeListVM>> GetInvoiceType([FromBody]GetDataListVM customer)
        {
            return await _serviceWrapper.InvoiceTypeService.GetListPaged(customer);
        }



        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("InvoiceType/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperInvoiceTypeListVM>> PutInvoiceType(string id, [FromBody]InvoiceTypeVM InvoiceType)
        {
            return await _serviceWrapper.InvoiceTypeService.Update(id, InvoiceType);
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        [Route("InvoiceType/add")]
        public async Task<ActionResult<WrapperInvoiceTypeListVM>> PostInvoiceType([FromBody]InvoiceTypeVM InvoiceType)
        {
            return await _serviceWrapper.InvoiceTypeService.Add(InvoiceType);
        }

        [HttpPost]
        [Route("InvoiceType/delete")]
        public async Task<ActionResult<WrapperInvoiceTypeListVM>> DeleteInvoiceType([FromBody]InvoiceTypeVM itemVM)
        {
            return await _serviceWrapper.InvoiceTypeService.Delete(itemVM);
        }

        #endregion
        #region Department
        [HttpPost]
        [Route("Department/getAll")]
        public async Task<ActionResult<WrapperDepartmentListVM>> GetDepartment([FromBody]GetDataListVM customer)
        {
            return await _serviceWrapper.DepartmentService.GetListPaged(customer);
        }



        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("Department/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperDepartmentListVM>> PutDepartment(string id, [FromBody]DepartmentVM Department)
        {
            return await _serviceWrapper.DepartmentService.Update(id, Department);
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        [Route("Department/add")]
        public async Task<ActionResult<WrapperDepartmentListVM>> PostDepartment([FromBody]DepartmentVM Department)
        {
            return await _serviceWrapper.DepartmentService.Add(Department);
        }

        [HttpPost]
        [Route("Department/delete")]
        public async Task<ActionResult<WrapperDepartmentListVM>> DeleteDepartment([FromBody]DepartmentVM itemVM)
        {
            return await _serviceWrapper.DepartmentService.Delete(itemVM);
        }

        #endregion
        #region Equipment
        [HttpPost]
        [Route("Equipment/getAll")]
        public async Task<ActionResult<WrapperEquipmentListVM>> GetEquipment([FromBody]GetDataListVM customer)
        {
            return await _serviceWrapper.EquipmentService.GetListPaged(customer);
        }



        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("Equipment/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperEquipmentListVM>> PutEquipment(string id, [FromBody]EquipmentVM Equipment)
        {
            return await _serviceWrapper.EquipmentService.Update(id, Equipment);
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        [Route("Equipment/add")]
        public async Task<ActionResult<WrapperEquipmentListVM>> PostEquipment([FromBody]EquipmentVM Equipment)
        {
            return await _serviceWrapper.EquipmentService.Add(Equipment);
        }

        [HttpPost]
        [Route("Equipment/delete")]
        public async Task<ActionResult<WrapperEquipmentListVM>> DeleteEquipment([FromBody]EquipmentVM itemVM)
        {
            return await _serviceWrapper.EquipmentService.Delete(itemVM);
        }

        #endregion       
        #region EquipmentCategory
        [HttpPost]
        [Route("EquipmentCategory/getAll")]
        public async Task<ActionResult<WrapperEquipmentCategoryListVM>> GetEquipmentCategory([FromBody]GetDataListVM customer)
        {
            return await _serviceWrapper.EquipmentCategoryService.GetListPaged(customer);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("EquipmentCategory/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperEquipmentCategoryListVM>> PutEquipmentCategory(string id, [FromBody]EquipmentCategoryVM EquipmentCategory)
        {
            return await _serviceWrapper.EquipmentCategoryService.Update(id, EquipmentCategory);
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        [Route("EquipmentCategory/add")]
        public async Task<ActionResult<WrapperEquipmentCategoryListVM>> PostEquipmentCategory([FromBody]EquipmentCategoryVM EquipmentCategory)
        {
            return await _serviceWrapper.EquipmentCategoryService.Add(EquipmentCategory);
        }

        [HttpPost]
        [Route("EquipmentCategory/delete")]
        public async Task<ActionResult<WrapperEquipmentCategoryListVM>> DeleteEquipmentCategory([FromBody]EquipmentCategoryVM itemVM)
        {
            return await _serviceWrapper.EquipmentCategoryService.Delete(itemVM);
        }

        #endregion
        #region Production
        [HttpPost]
        [Route("Production/getAll")]
        public async Task<ActionResult<WrapperProductionListVM>> GetProduction([FromBody]GetDataListVM customer)
        {
            return await _serviceWrapper.ProductionService.GetListPaged(customer);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("Production/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperProductionListVM>> PutProduction(string id, [FromBody]EditProductionVM Production)
        {
            return await _serviceWrapper.ProductionService.Update(id, Production);
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [HttpPost]
        [Route("Production/add")]
        public async Task<ActionResult<WrapperProductionListVM>> PostProduction([FromBody]AddProductionVM Production)
        {
            return await _serviceWrapper.ProductionService.Add(Production);
        }

        [HttpPost]
        [Route("Production/delete")]
        public async Task<ActionResult<WrapperProductionListVM>> DeleteProduction([FromBody]AddProductionVM itemVM)
        {
            return await _serviceWrapper.ProductionService.Delete(itemVM);
        }

        #endregion
        #region Stock
        [HttpPost]
        [Route("stock/getAll")]
        public async Task<ActionResult<WrapperStockListVM>> GetSupplier(GetDataListVM temp)
        {
            var data = await _serviceWrapper.StockService.GetListPaged(temp);
            _utilService.Log("Stock Successfully Getted");
            return Ok(data);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("stock/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperStockListVM>> PutSupplier(string id, [FromBody]StockVM temp)
        {
            WrapperStockListVM result = new WrapperStockListVM();
            result = await _serviceWrapper.StockService.Update(id, temp);
            _utilService.Log("Stock Successfully Updated");
            return Ok(result);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("stock/add")]
        [HttpPost]
        public async Task<ActionResult<WrapperStockListVM>> PostSupplier([FromBody]StockVM VM)
        {
            WrapperStockListVM result = new WrapperStockListVM();
            VM.ExpiryDate = VM.ExpiryDate.ToLocalTime();
            result = await _serviceWrapper.StockService.Add(VM);
            _utilService.Log("Stock Successfully Added");
            return Ok(result);
        }

        [HttpPost]
        [Route("stock/delete")]
        public async Task<ActionResult<WrapperStockListVM>> DeleteSupplier([FromBody]StockVM Temp)
        {
            WrapperStockListVM vb = new WrapperStockListVM();
            vb = await _serviceWrapper.StockService.Delete(Temp);
            _utilService.Log("Stock Successfully Deleted");
            return vb;
        }

        #endregion
        #region ItemCategory
        // GET: api/ItemCategories
        [HttpPost]
        [Route("ItemCategory/getAll")]
        public async Task<ActionResult<WrapperItemCategoryListVM>> GetCustomer_2([FromBody]GetDataListVM customer)
        {
            return await _serviceWrapper.ItemCategoryService.GetListPaged(customer);
        }

        // GET: api/ItemCategories/5
        [HttpPost]
        [Route("ItemCategory/getById")]
        public async Task<ActionResult<ItemCategory>> GetItemCategory(string id)
        {
            //var itemCategory = await _context.ItemCategory.FindAsync(id);
            var enumerables = await _repositoryWrapper.ItemCategory.FindByConditionAsync(x => x.Id == id);
            var itemCategory = enumerables.ToList().FirstOrDefault();
            if (itemCategory == null)
            {
                return NotFound();
            }

            return itemCategory;
        }

        // PUT: api/ItemCategories/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("ItemCategory/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperItemCategoryListVM>> PutItemCategory(string id, [FromBody]ItemCategoryVM itemCategory)
        {
            return await _serviceWrapper.ItemCategoryService.Update(id, itemCategory);
        }

        // POST: api/ItemCategories
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        [Route("ItemCategory/add")]
        public async Task<ActionResult<WrapperItemCategoryListVM>> PostItemCategory([FromBody]ItemCategoryVM itemCategory)
        {
            return await _serviceWrapper.ItemCategoryService.Add(itemCategory);
        }

        // DELETE: api/ItemCategories/5
        [HttpPost]
        [Route("ItemCategory/delete")]
        public async Task<ActionResult<WrapperItemCategoryListVM>> DeleteItemCategory([FromBody]ItemCategoryVM itemVM)
        {
            return await _serviceWrapper.ItemCategoryService.Delete(itemVM);
        }

        private bool ItemCategoryExists(string name)
        {
            return _context.ItemCategory.Any(e => e.Name == name);
        }

        #endregion
        #region Item
        [HttpPost]
        [Route("Item/getAll")]
        public async Task<ActionResult<WrapperItemListVM>> GetCustomer_3([FromBody]GetDataListVM dataParam)
        {
            var data = await _serviceWrapper.ItemService.GetListPaged(dataParam);
            return Ok(data);
        }


        [HttpPost]
        [Route("Item/getById")]
        public async Task<ActionResult<Item>> GetItem(string id)
        {
            // var item = await _context.Item.FindAsync(id);
            var enumerables = await _repositoryWrapper.Item.FindByConditionAsync(x => x.Id == id);
            var item = enumerables.ToList().FirstOrDefault();
            if (item == null)
            {
                return NotFound();
            }

            return item;
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("Item/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperItemListVM>> PutItem(string id, [FromBody]ItemVM item)
        {
            return Ok(await _serviceWrapper.ItemService.Update(id, item));
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        [Route("Item/add")]
        public async Task<ActionResult<WrapperItemListVM>> PostItem([FromBody]ItemVM item)
        {

            return Ok(await _serviceWrapper.ItemService.Add(item));
        }


        [HttpPost]
        [Route("Item/delete")]
        public async Task<ActionResult<WrapperItemListVM>> DeleteItem([FromBody]ItemVM itemVM)
        {
            return Ok(await _serviceWrapper.ItemService.Delete(itemVM));
        }

        private bool ItemExists(string CategoryId, decimal? UnitPrice, string Name)
        {
            return _context.Item.Any(e => e.CategoryId == CategoryId && e.UnitPrice == UnitPrice && e.Name == Name);
        }


        #endregion
        #region ItemStatus

        [HttpPost]
        [Route("Item/status/getAll")]
        public async Task<ActionResult<WrapperItemStatusListVM>> GetItemStatus([FromBody]GetDataListVM dataParam)
        {
            var data = await _serviceWrapper.ItemStatusService.GetListPaged(dataParam);
            return Ok(data);
        }

        #endregion
        #region Customer
        // GET: api/Customers/ii
        [HttpPost]
        [Route("Customer/getAll")]
        public async Task<ActionResult<WrapperListCustomerVM>> GetCustomer_4(GetDataListVM customer)
        {
            var data = await _serviceWrapper.CustomerService.GetListPaged(customer);
            return Ok(data);
        }
        // GET: api/Customers/5
        //[HttpPost]
        //[Route("getById")]
        //public async Task<ActionResult<CustomerVM>> GetSingleCustomer(Customer customerTemp)
        //{
        //    //var customer = await _context.Customer.FindAsync(id);
        //    var customer = await _serviceWrapper.CustomerService.GetSingle(customerTemp.Id, customerTemp.FactoryId);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    return customer;
        //}

        // PUT: api/Customers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("Customer/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperListCustomerVM>> PutCustomer(string id, [FromBody]CustomerVM customer)
        {
            WrapperListCustomerVM result = new WrapperListCustomerVM();
            result = await _serviceWrapper.CustomerService.Update(id, customer);
            _logger.LogInfo("Customer Successfully Updated");
            return Ok(result);
        }
        // POST: api/Customers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("Customer/add")]
        [HttpPost]
        public async Task<ActionResult<WrapperListCustomerVM>> PostCustomer([FromBody]CustomerVM customerVM)
        {
            WrapperListCustomerVM result = new WrapperListCustomerVM();
            result = await _serviceWrapper.CustomerService.Add(customerVM);
            _logger.LogInfo("Customer Successfully Added");
            return Ok(result);
        }
        // DELETE: api/Customers/5
        [HttpPost]
        [Route("Customer/delete")]
        public async Task<ActionResult<WrapperListCustomerVM>> DeleteCustomer([FromBody]CustomerVM customerTemp)
        {
            return await _serviceWrapper.CustomerService.Delete(customerTemp);
        }
        private bool CustomerExists(string Name, string Email)
        {
            return _context.Customer.Any(e => e.Email == Email && e.Name == Name);
        }

        #endregion

    }
}