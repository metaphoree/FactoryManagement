using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.DbModels;
using Contracts;
using Entities.ViewModels.Item;
using Entities.ViewModels;

namespace ApiService.Controllers
{
    [Route("api/Item")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly FactoryManagementContext _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IServiceWrapper _serviceWrapper;
        private readonly ILoggerManager _logger;

        public ItemsController(FactoryManagementContext context, IRepositoryWrapper repositoryWrapper, IServiceWrapper serviceWrapper, ILoggerManager logger)
        {
            _context = context;
            _repositoryWrapper = repositoryWrapper;
            _serviceWrapper = serviceWrapper;
            _logger = logger;
        }

        // GET: api/Items
        [HttpPost]
        [Route("getAll")]
        public async Task<ActionResult<WrapperItemListVM>> GetCustomer(GetDataListVM dataParam)
        {
            var data = await _serviceWrapper.ItemService.GetListPaged(dataParam);
            return Ok(data);
        }

        // GET: api/Items/5
        [HttpPost]
        [Route("getById")]
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

        // PUT: api/Items/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("update/{id}")]
        [HttpPost]
        public async Task<IActionResult> PutItem(string id, [FromBody]ItemVM item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

           // _context.Entry(item).State = EntityState.Modified;

            try
            {
                //   await _context.SaveChangesAsync();
                await _serviceWrapper.ItemService.Update(id, item);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(item.CategoryId, item.UnitPrice, item.Name))
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

        // POST: api/Items
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Item>> PostItem([FromBody]ItemVM item)
        {
           // _context.Item.Add(item);
            try
            {
                //   await _context.SaveChangesAsync();
                await _serviceWrapper.ItemService.Add(item);
            }
            catch (DbUpdateException)
            {
                if (ItemExists(item.CategoryId,item.UnitPrice,item.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            // return CreatedAtAction("GetItem", new { id = item.Id }, item);
            return Ok(true);
        }

        // DELETE: api/Items/5
        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<WrapperItemListVM>> DeleteItem([FromBody]ItemVM itemVM)
        {
            return await _serviceWrapper.ItemService.Delete(itemVM);
        }

        private bool ItemExists(string CategoryId,decimal? UnitPrice,string Name)
        {
            return _context.Item.Any(e => e.CategoryId == CategoryId && e.UnitPrice == UnitPrice && e.Name == Name);
        }
    }
}
