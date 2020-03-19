using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.Department;
using Entities.ViewModels.Equipment;
using Entities.ViewModels.EquipmentCategory;
using Entities.ViewModels.ExpenseType;
using Entities.ViewModels.IncomeType;
using Entities.ViewModels.InvoiceType;
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
        public MassCrudController(FactoryManagementContext context, IRepositoryWrapper repositoryWrapper, IServiceWrapper serviceWrapper, ILoggerManager logger)
        {
            _context = context;
            _repositoryWrapper = repositoryWrapper;
            _serviceWrapper = serviceWrapper;
            _logger = logger;
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
    }
}