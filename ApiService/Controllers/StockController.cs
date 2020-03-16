using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.Stock;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiService.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {

        private readonly FactoryManagementContext _context;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IServiceWrapper _serviceWrapper;
        private readonly ILoggerManager _logger;
        private readonly IUtilService _utilService;
        public StockController(FactoryManagementContext context, IRepositoryWrapper repositoryWrapper, IServiceWrapper serviceWrapper, ILoggerManager logger, IUtilService utilService)
        {
            _context = context;
            _repositoryWrapper = repositoryWrapper;
            _serviceWrapper = serviceWrapper;
            _logger = logger;
            _utilService = utilService;
        }


        #region Stock
        [HttpPost]
        [Route("getAll")]
        public async Task<ActionResult<WrapperStockListVM>> GetSupplier(GetDataListVM temp)
        {
            var data = await _serviceWrapper.StockService.GetListPaged(temp);
            _utilService.Log("Stock Successfully Getted");
            return Ok(data);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("update/{id}")]
        [HttpPost]
        public async Task<ActionResult<WrapperStockListVM>> PutSupplier(string id, [FromBody]StockVM temp)
        {
            WrapperStockListVM result = new WrapperStockListVM();
            result = await _serviceWrapper.StockService.Update(id, temp);
            _utilService.Log("Stock Successfully Updated");
            return Ok(result);
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        [Route("add")]
        [HttpPost]
        public async Task<ActionResult<WrapperStockListVM>> PostSupplier([FromBody]StockVM VM)
        {
            WrapperStockListVM result = new WrapperStockListVM();
            VM.ExpiryDate = VM.ExpiryDate.ToLocalTime();
            result = await _serviceWrapper.StockService.Add(VM);
            _utilService.Log("Stock Successfully Added");
            return Ok(result);
        }

        [HttpPost]
        [Route("delete")]
        public async Task<ActionResult<WrapperStockListVM>> DeleteSupplier([FromBody]StockVM Temp)
        {
            WrapperStockListVM vb = new WrapperStockListVM();
            vb = await _serviceWrapper.StockService.Delete(Temp);
            _utilService.Log("Stock Successfully Deleted");
            return vb;
        }

        #endregion
    }
}