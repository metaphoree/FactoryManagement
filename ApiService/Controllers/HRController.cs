using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Staff;
using Entities.ViewModels.Supplier;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiService.Controllers
{
    [Route("api/hr")]
    [ApiController]
    public class HRController : ControllerBase
    {
        private readonly FactoryManagementContext _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IServiceWrapper _serviceWrapper;
        private readonly ILoggerManager _logger;
        private readonly IUtilService _utilService;
        public HRController(FactoryManagementContext context, IRepositoryWrapper repositoryWrapper, IServiceWrapper serviceWrapper, ILoggerManager logger, IUtilService utilService)
        {
            _context = context;
            _repositoryWrapper = repositoryWrapper;
            _serviceWrapper = serviceWrapper;
            _logger = logger;
            _utilService = utilService;
        }

        #region Customer
        [HttpPost]
        [Route("customer/getAll")]
        public async Task<ActionResult<WrapperListCustomerVM>> GetCustomer(GetDataListVM customer)
        {
            var data = await _serviceWrapper.CustomerService.GetListPaged(customer,true);
            _utilService.Log("Customer Successfully Getted");
            return Ok(data);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("customer/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperListCustomerVM>> PutCustomer(string id, [FromBody]CustomerVM customer)
        {
            WrapperListCustomerVM result = new WrapperListCustomerVM();
            result = await _serviceWrapper.CustomerService.Update(id, customer);
            _utilService.Log("Customer Successfully Updated");
            return Ok(result);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("customer/add")]
        [HttpPost]
        public async Task<ActionResult<WrapperListCustomerVM>> PostCustomer([FromBody]CustomerVM customerVM)
        {
            WrapperListCustomerVM result = new WrapperListCustomerVM();
            result = await _serviceWrapper.CustomerService.Add(customerVM);
            _utilService.Log("Customer Successfully Added");
            return Ok(result);
        }

        [HttpPost]
        [Route("customer/delete")]
        public async Task<ActionResult<WrapperListCustomerVM>> DeleteCustomer([FromBody]CustomerVM customerTemp)
        {
            WrapperListCustomerVM data = new WrapperListCustomerVM();
            data = await _serviceWrapper.CustomerService.Delete(customerTemp);
            _utilService.Log("Customer Successfully Deleted");
            return data;
        }

        #endregion

        #region Staff
        [HttpPost]
        [Route("staff/getAll")]
        public async Task<ActionResult<WrapperStaffListVM>> GetStaff(GetDataListVM temp)
        {
            var data = await _serviceWrapper.StaffService.GetListPaged(temp);
            _utilService.Log("Staff Successfully Getted");
            return Ok(data);
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("staff/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperStaffListVM>> PutStaff(string id, [FromBody]StaffVM temp)
        {
            WrapperStaffListVM result = new WrapperStaffListVM();
            result = await _serviceWrapper.StaffService.Update(id, temp);
            _utilService.Log("Staff Successfully Updated");
            return Ok(result);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("staff/add")]
        [HttpPost]
        public async Task<ActionResult<WrapperStaffListVM>> PostStaff([FromBody]StaffVM VM)
        {
            WrapperStaffListVM result = new WrapperStaffListVM();
            result = await _serviceWrapper.StaffService.Add(VM);
            _utilService.Log("Staff Successfully Added");
            return Ok(result);
        }

        [HttpPost]
        [Route("staff/delete")]
        public async Task<ActionResult<WrapperStaffListVM>> DeleteStaff([FromBody]StaffVM Temp)
        {
           WrapperStaffListVM data = await _serviceWrapper.StaffService.Delete(Temp);
            _utilService.Log("Staff Successfully Deleted");
            return data;
        }
        #endregion

        #region Supplier
        [HttpPost]
        [Route("supplier/getAll")]
        public async Task<ActionResult<WrapperSupplierListVM>> GetSupplier(GetDataListVM temp)
        {
            var data = await _serviceWrapper.SupplierService.GetListPaged(temp,true);
            _utilService.Log("Supplier Successfully Getted");
            return Ok(data);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("supplier/update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperSupplierListVM>> PutSupplier(string id, [FromBody]SupplierVM temp)
        {
            WrapperSupplierListVM result = new WrapperSupplierListVM();
            result = await _serviceWrapper.SupplierService.Update(id, temp);
            _utilService.Log("Supplier Successfully Updated");
            return Ok(result);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("supplier/add")]
        [HttpPost]
        public async Task<ActionResult<WrapperSupplierListVM>> PostSupplier([FromBody]SupplierVM VM)
        {
            WrapperSupplierListVM result = new WrapperSupplierListVM();
            result = await _serviceWrapper.SupplierService.Add(VM);
            _utilService.Log("Supplier Successfully Added");
            return Ok(result);
        }

        [HttpPost]
        [Route("supplier/delete")]
        public async Task<ActionResult<WrapperSupplierListVM>> DeleteSupplier([FromBody]SupplierVM Temp)
        {
            WrapperSupplierListVM vb = new WrapperSupplierListVM();
            vb = await _serviceWrapper.SupplierService.Delete(Temp);
            _utilService.Log("Supplier Successfully Deleted");
            return vb;
        }

        #endregion

    }
}