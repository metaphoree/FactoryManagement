using Contracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly FactoryManagementContext _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IServiceWrapper _serviceWrapper;
        private readonly ILoggerManager _logger;
        public CustomersController(FactoryManagementContext context, IRepositoryWrapper repositoryWrapper, IServiceWrapper serviceWrapper, ILoggerManager logger)
        {
            _context = context;
            _repositoryWrapper = repositoryWrapper;
            _serviceWrapper = serviceWrapper;
            _logger = logger;
        }

        // GET: api/Customers/ii
        [HttpPost]
        [Route("getAll")]
        public async Task<ActionResult<WrapperListCustomerVM>> GetCustomer(GetDataListVM customer)
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
        [Route("update/{id}")]
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
        [Route("add")]
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
        [Route("delete")]
        public async Task<ActionResult<WrapperListCustomerVM>> DeleteCustomer([FromBody]CustomerVM customerTemp)
        {
            return await _serviceWrapper.CustomerService.Delete(customerTemp);
        }
        private bool CustomerExists(string Name, string Email)
        {
            return _context.Customer.Any(e => e.Email == Email && e.Name == Name);
        }
    }
}
