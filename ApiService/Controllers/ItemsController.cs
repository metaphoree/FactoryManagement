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

namespace ApiService.Controllers
{
    [Route("api/[controller]")]
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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Item>>> GetItem()
        {

            var enumerables = await _repositoryWrapper.Item.FindAllAsync();
            return enumerables.ToList();
            //  return await _context.Item.ToListAsync();
        }

        // GET: api/Items/5
        [HttpGet("{id}")]
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
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(string id, [FromBody]UpdateItemVM item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

           // _context.Entry(item).State = EntityState.Modified;

            try
            {
                //   await _context.SaveChangesAsync();
                await _serviceWrapper.ItemService.UpdateItem(id, item);
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
        public async Task<ActionResult<Item>> PostItem([FromBody]AddItemVM item)
        {
           // _context.Item.Add(item);
            try
            {
                //   await _context.SaveChangesAsync();
                await _serviceWrapper.ItemService.AddItem(item);
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
        [HttpDelete("{id}")]
        public async Task<ActionResult<Item>> DeleteItem(string id)
        {
            var itemList = await _repositoryWrapper.Item.FindByConditionAsync(x => x.Id ==  id);
            var item = itemList.ToList().FirstOrDefault();
            if (item == null)
            {
                return NotFound();
            }

            _repositoryWrapper.Item.Delete(item);
            await _repositoryWrapper.SaveAsync();

            return item;
        }

        private bool ItemExists(string CategoryId,decimal? UnitPrice,string Name)
        {
            return _context.Item.Any(e => e.CategoryId == CategoryId && e.UnitPrice == UnitPrice && e.Name == Name);
        }
    }
}
