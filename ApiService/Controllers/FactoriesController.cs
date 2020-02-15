using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.DbModels;

namespace ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoriesController : ControllerBase
    {
        private readonly FactoryManagementContext _context;

        public FactoriesController(FactoryManagementContext context)
        {
            _context = context;
        }

        // GET: api/Factories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Factory>>> GetFactory()
        {
            return await _context.Factory.ToListAsync();
        }

        // GET: api/Factories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Factory>> GetFactory(string id)
        {
            var factory = await _context.Factory.FindAsync(id);

            if (factory == null)
            {
                return NotFound();
            }

            return factory;
        }

        // PUT: api/Factories/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFactory(string id, Factory factory)
        {
            if (id != factory.Id)
            {
                return BadRequest();
            }

            _context.Entry(factory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FactoryExists(id))
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

        // POST: api/Factories
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Factory>> PostFactory(Factory factory)
        {
            _context.Factory.Add(factory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FactoryExists(factory.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFactory", new { id = factory.Id }, factory);
        }

        // DELETE: api/Factories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Factory>> DeleteFactory(string id)
        {
            var factory = await _context.Factory.FindAsync(id);
            if (factory == null)
            {
                return NotFound();
            }

            _context.Factory.Remove(factory);
            await _context.SaveChangesAsync();

            return factory;
        }

        private bool FactoryExists(string id)
        {
            return _context.Factory.Any(e => e.Id == id);
        }
    }
}
