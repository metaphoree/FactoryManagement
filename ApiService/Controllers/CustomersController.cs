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
        public CustomersController(FactoryManagementContext context,IRepositoryWrapper repositoryWrapper, IServiceWrapper serviceWrapper, ILoggerManager logger)
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
        [HttpPost]
        [Route("getById")]
        public async Task<ActionResult<UpdateCustomerViewModel>> GetSingleCustomer(Customer customerTemp)
        {
            //var customer = await _context.Customer.FindAsync(id);
            var customer = await _serviceWrapper.CustomerService.GetSingle(customerTemp.Id, customerTemp.FactoryId);
            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("update/{id}")]
        [HttpPost]        
        public async Task<ActionResult<WrapperListCustomerVM>> PutCustomer(string id, [FromBody]UpdateCustomerViewModel customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }
            bool result = false;
            //_context.Entry(customer).State = EntityState.Modified;
            try
            {
                result =   await _serviceWrapper.CustomerService.Update(id, customer);                           
            }
            catch (DbUpdateConcurrencyException exc)
            {
                _logger.LogError(exc.ToString());
                _logger.LogInfo("-----------------------------------------------------------------");
                _logger.LogInfo("-----------------------------------------------------------------");
                if (!CustomerExists(customer.Name,customer.Email))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
                 
            }
            var dataParam = new GetDataListVM()
            {
                FactoryId = customer.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperListCustomerVM data = await _serviceWrapper.CustomerService.GetListPaged(dataParam);
            return data;
        }
        // POST: api/Customers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("add")]
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer([FromBody]AddCustomerViewModel customerVM)
        {
            try
            {
                await _serviceWrapper.CustomerService.Add(customerVM);
                _logger.LogInfo("Customer Successfully Added");
              
            }
            catch (DbUpdateException ex)
            {
                _logger.LogInfo(ex.ToString());
                _logger.LogInfo("-----------------------------------------------------------------");
                _logger.LogInfo("-----------------------------------------------------------------");
                if (CustomerExists(customerVM.Name, customerVM.Email))
                {
                    _logger.LogInfo("Entity already exist");
                    return Conflict();
                }
                else
                {
                    throw new Exception("Error Saving");
                }
            }
            catch (Exception es) {
               
            }
            return Ok(true);
        }
        // DELETE: api/Customers/5
       [HttpPost]
       [Route("delete")]
        public async Task<ActionResult<WrapperListCustomerVM>> DeleteCustomer([FromBody]UpdateCustomerViewModel customerTemp)
        {
            return await _serviceWrapper.CustomerService.Delete(customerTemp);
        }
        private bool CustomerExists(string Name, string Email)
        {
            return _context.Customer.Any(e => e.Email == Email && e.Name == Name);
        }
    }
}
