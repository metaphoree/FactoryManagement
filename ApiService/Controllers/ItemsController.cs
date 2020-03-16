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
using Entities.ViewModels.ItemStatus;

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


        [HttpPost]
        [Route("getAll")]
        public async Task<ActionResult<WrapperItemListVM>> GetCustomer([FromBody]GetDataListVM dataParam)
        {
            var data = await _serviceWrapper.ItemService.GetListPaged(dataParam);
            return Ok(data);
        }


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


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperItemListVM>> PutItem(string id, [FromBody]ItemVM item)
        {
           return Ok(await _serviceWrapper.ItemService.Update(id, item));            
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<WrapperItemListVM>> PostItem([FromBody]ItemVM item)
        {
            
            return Ok(await _serviceWrapper.ItemService.Add(item));
        }


        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<WrapperItemListVM>> DeleteItem([FromBody]ItemVM itemVM)
        {
            return Ok(await _serviceWrapper.ItemService.Delete(itemVM));
        }

        private bool ItemExists(string CategoryId,decimal? UnitPrice,string Name)
        {
            return _context.Item.Any(e => e.CategoryId == CategoryId && e.UnitPrice == UnitPrice && e.Name == Name);
        }





        #region ItemStatus

        [HttpPost]
        [Route("status/getAll")]
        public async Task<ActionResult<WrapperItemStatusListVM>> GetItemStatus([FromBody]GetDataListVM dataParam)
        {
            var data = await _serviceWrapper.ItemStatusService.GetListPaged(dataParam);
            return Ok(data);
        }

        #endregion







    }
}
