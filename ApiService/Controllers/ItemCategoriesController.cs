using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.DbModels;
using Contracts;
using Entities.ViewModels.ItemCategoryView;
using Entities.ViewModels;

namespace ApiService.Controllers
{
    [Route("api/ItemCategory")]
    [ApiController]
    public class ItemCategoriesController : ControllerBase
    {
        private readonly FactoryManagementContext _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IServiceWrapper _serviceWrapper;
        private readonly ILoggerManager _logger;
        public ItemCategoriesController(FactoryManagementContext context, IRepositoryWrapper repositoryWrapper, IServiceWrapper serviceWrapper, ILoggerManager logger)
        {
            _context = context;
            _repositoryWrapper = repositoryWrapper;
            _serviceWrapper = serviceWrapper;
            _logger = logger;
        }

        // GET: api/ItemCategories
        [HttpPost]
        [Route("getAll")]
        public async Task<ActionResult<WrapperItemCategoryListVM>> GetCustomer(GetDataListVM customer)
        {
            var data = await _serviceWrapper.ItemCategoryService.GetListPaged(customer);
            return Ok(data);
        }

        // GET: api/ItemCategories/5
        [HttpPost]
        [Route("getById")]
        public async Task<ActionResult<ItemCategory>> GetItemCategory(string id)
        {
            //var itemCategory = await _context.ItemCategory.FindAsync(id);
            var enumerables = await _repositoryWrapper.ItemCategory.FindByConditionAsync(x=> x.Id == id);
            var itemCategory =  enumerables.ToList().FirstOrDefault();
            if (itemCategory == null)
            {
                return NotFound();
            }

            return itemCategory;
        }

        // PUT: api/ItemCategories/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("update/{id}")]
        [HttpPost]
        public async Task<IActionResult> PutItemCategory(string id, ItemCategoryVM itemCategory)
        {
            if (id != itemCategory.Id)
            {
                return BadRequest();
            }
           
            // _context.Entry(itemCategory).State = EntityState.Modified;
            try
            {
                await _serviceWrapper.ItemCategoryService.Update(id, itemCategory);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemCategoryExists(itemCategory.Name))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(true);
            //return NoContent();
        }

        // POST: api/ItemCategories
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<ItemCategory>> PostItemCategory([FromBody]ItemCategoryVM itemCategory)
        {
            try
            {
                await _serviceWrapper.ItemCategoryService.Add(itemCategory);
            }
            catch (DbUpdateException)
            {
                if (ItemCategoryExists(itemCategory.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            // return CreatedAtAction("GetItemCategory", new { id = itemCategory.Id }, itemCategory);
            return Ok(true);
        }

        // DELETE: api/ItemCategories/5
        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<WrapperItemCategoryListVM>> DeleteItemCategory([FromBody]ItemCategoryVM itemVM)
        {
            return await _serviceWrapper.ItemCategoryService.Delete(itemVM);
        }

        private bool ItemCategoryExists(string name)
        {
            return _context.ItemCategory.Any(e => e.Name == name);
        }
    }
}
