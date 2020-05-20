using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.Factory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class FactoryService : IFactoryService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;
        public FactoryService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;

            this._utilService = utilService;

        }

        public async Task<WrapperFactoryListVM> GetListPaged(GetDataListVM dataListVM)
        {
            var itemList = await _repositoryWrapper.Factory
                .FindAll()
                //.Where(x => x.FactoryId == dataListVM.FactoryId)
                .OrderByDescending(x => x.UpdatedDateTime)
                .Skip((dataListVM.PageNumber - 1) * (dataListVM.PageSize))
                .Take(dataListVM.PageSize)
                .ToListAsync();

            var dataRowCount = await _repositoryWrapper.Factory.NumOfRecord();
            List<FactoryVM> itemVMLists = new List<FactoryVM>();
            itemVMLists = this._utilService.Mapper.Map<List<Factory>, List<FactoryVM>>(itemList);
            var wrapper = new WrapperFactoryListVM()
            {
                ListOfData = itemVMLists,
                TotalRecords = dataRowCount
            };
            return wrapper;
        }
        public async Task<WrapperFactoryListVM> Add(FactoryVM vm)
        {
            var entityToAdd = _utilService.GetMapper().Map<FactoryVM, Factory>(vm);
            //string uniqueIdTask =await _repositoryWrapper.Factory.GetUniqueId();

            //// Todo  need to aandle unique id from db
            //entityToAdd.UniqueId = uniqueIdTask;
            entityToAdd = _repositoryWrapper.Factory.Create(entityToAdd);
            await _repositoryWrapper.Factory.SaveChangesAsync();

            var dataParam = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperFactoryListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperFactoryListVM> Update(string id, FactoryVM vm)
        {
            IEnumerable<Factory> ItemDB = await _repositoryWrapper.Factory.FindByConditionAsync(x => x.Id == id);
            var ItemUpdated = _utilService.GetMapper().Map<FactoryVM, Factory>(vm, ItemDB.ToList().FirstOrDefault());
            _repositoryWrapper.Factory.Update(ItemUpdated);
            await _repositoryWrapper.Factory.SaveChangesAsync();


            var dataParam = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperFactoryListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperFactoryListVM> Delete(FactoryVM itemTemp)
        {
            IEnumerable<Factory> itemTask = await _repositoryWrapper.Factory.FindByConditionAsync(x => x.Id == itemTemp.Id);
            var item = itemTask.ToList().FirstOrDefault();
            if (item == null)
            {
                return new WrapperFactoryListVM();
            }
            _repositoryWrapper.Factory.Delete(item);
            await _repositoryWrapper.Factory.SaveChangesAsync();

            var dataParam = new GetDataListVM()
            {
                FactoryId = itemTemp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperFactoryListVM data = await GetListPaged(dataParam);
            return data;
        }
    }
}
