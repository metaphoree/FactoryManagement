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
    [Route("api/[controller]")]
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
        [Route("getAllCustomer")]
        public async Task<ActionResult<IEnumerable<ListCustomerVM>>> GetCustomer(GetDataListVM customer)
        {
            var data = await _serviceWrapper.CustomerService.GetCustomerListPaged(customer);
            return Ok(data);
        }
        // GET: api/Customers/5
        [HttpPost]
        [Route("getCustomerById")]
        public async Task<ActionResult<UpdateCustomerViewModel>> GetSingleCustomer(Customer customerTemp)
        {
            //var customer = await _context.Customer.FindAsync(id);
            var customer = await _serviceWrapper.CustomerService.GetCustomer(customerTemp.Id, customerTemp.FactoryId);
            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(string id, [FromBody]UpdateCustomerViewModel customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            //_context.Entry(customer).State = EntityState.Modified;
            try
            {
                await _serviceWrapper.CustomerService.UpdateCustomer(id, customer);                           
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(customer.Name,customer.Email))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        // POST: api/Customers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer([FromBody]AddCustomerViewModel customerVM)
        {
            try
            {
                await _serviceWrapper.CustomerService.AddCustomer(customerVM);
                _logger.LogInfo("Customer Successfully Added");
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
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(string id)
        {
            var customerTask =  await _repositoryWrapper.Customer.FindByConditionAsync(x => x.Id == id);
            var customer = customerTask.ToList().FirstOrDefault();
            if (customer == null)
            {
                return NotFound();
            }
                _repositoryWrapper.Customer.Delete(customer);
                await _repositoryWrapper.SaveAsync();
            return customer;
        }
        private bool CustomerExists(string Name, string Email)
        {
            return _context.Customer.Any(e => e.Email == Email && e.Name == Name);
        }
    }
}
