using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.Stock;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class StockService : IStockService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;

        public StockService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;

            this._utilService = utilService;
        }

        public async Task<WrapperStockListVM> Add(StockVM ViewModel)
        {
            var itemToAdd = _utilService.GetMapper().Map<StockVM, Stock>(ViewModel);
            itemToAdd = _repositoryWrapper.Stock.Create(itemToAdd);
            Task<int> t1 = _repositoryWrapper.Stock.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Adding Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = itemToAdd.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStockListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperStockListVM> Update(string id, StockVM ViewModel)
        {
            if (id != ViewModel.Id)
            {
                new WrapperStockListVM();
            }

            Task<IEnumerable<Stock>> itemsDB = _repositoryWrapper.Stock.FindByConditionAsync(x => x.Id == id && x.FactoryId == ViewModel.FactoryId);
            await Task.WhenAll(itemsDB);

            var itemUpdated = _utilService.GetMapper().Map<StockVM, Stock>(ViewModel, itemsDB.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Stock.Update(itemUpdated);

            Task<int> t1 = _repositoryWrapper.Stock.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Updating Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = ViewModel.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStockListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperStockListVM> GetListPaged(GetDataListVM dataListVM)
        {
            IEnumerable<Stock> ListTask = 
                await _repositoryWrapper.Stock
                .FindByCondition(x => x.FactoryId == dataListVM.FactoryId)
                .Include(x => x.Item)
                .Include(x => x.ItemStatus)
                .ToListAsync();
            long noOfRecordTask = await _repositoryWrapper.Stock.NumOfRecord();

            List<Stock> List = ListTask.ToList().OrderByDescending(x => x.UpdatedDateTime).ToList();//.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).OrderByDescending(x => x.CreatedDateTime).ToList();

            List<StockVM> outputList = new List<StockVM>();

            outputList = _utilService.GetMapper().Map<List<Stock>, List<StockVM>>(List);

            if (!string.IsNullOrEmpty(dataListVM.GlobalFilter) && !string.IsNullOrWhiteSpace(dataListVM.GlobalFilter))
            {
                outputList = outputList.Where(output =>
                output.ItemName != null ? output.ItemName.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                             || output.ItemStatus != null ? output.ItemStatus.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                             || output.Quantity.ToString() != null ? output.Quantity.ToString().Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false)
                                         .ToList();
                
                }

            outputList = outputList.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).ToList();
            var data = new WrapperStockListVM();
            data.ListOfData = outputList;
            data.TotalRecoreds = noOfRecordTask;
            this._utilService.Log("Successful In Getting Data");
            return data;
        }
        public async Task<WrapperStockListVM> Delete(StockVM Temp)
        {
            var Task = await _repositoryWrapper.Stock.FindByConditionAsync(x => x.Id == Temp.Id && x.FactoryId == Temp.FactoryId);
            var datarow = Task.ToList().FirstOrDefault();
            if (datarow == null)
            {
                return new WrapperStockListVM();
            }
            _repositoryWrapper.Stock.Delete(datarow);
            await _repositoryWrapper.Stock.SaveChangesAsync();
            this._utilService.Log("Successful In Deleting Data");
            var dataParam = new GetDataListVM()
            {
                FactoryId = Temp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStockListVM data = await GetListPaged(dataParam);
            return data;
        }




        public async Task<WrapperStockListVM> AddItemChangedStatus(StockVM ViewModel) {

            Task<IEnumerable<Stock>> itemsDB = _repositoryWrapper.Stock.FindByConditionAsync(x => x.Id == ViewModel.Id && x.FactoryId == ViewModel.FactoryId);
            await Task.WhenAll(itemsDB);

 

            Stock stock = itemsDB.Result.ToList().FirstOrDefault();

            if (stock.Quantity <= ViewModel.Quantity)
            {
                var dataParam6 = new GetDataListVM()
                {
                    FactoryId = ViewModel.FactoryId,
                    PageNumber = 1,
                    PageSize = 10,
                    TotalRows = 0
                };
                WrapperStockListVM data1 = await GetListPaged(dataParam6);
                return data1;
            }


            stock.Quantity -= ViewModel.Quantity;
            _repositoryWrapper.Stock.Update(stock);
            Task<int> t3 = _repositoryWrapper.Stock.SaveChangesAsync();
            await Task.WhenAll(t3);


            var itemToAdd = _utilService.GetMapper().Map<StockVM, Stock>(ViewModel);
            itemToAdd = _repositoryWrapper.Stock.Create(itemToAdd);
            Task<int> t1 = _repositoryWrapper.Stock.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Adding Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = itemToAdd.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStockListVM data = await GetListPaged(dataParam);
            return data;


        }


    }
}
