using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Item;
using Entities.ViewModels.ItemCategoryView;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class ItemCategoryService : IItemCategoryService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IUtilService _utilService;

        public ItemCategoryService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._utilService = utilService;

        }


        public async Task<WrapperItemCategoryListVM> GetListPaged(GetDataListVM dataListVM)
        {
            System.Linq.Expressions.Expression<Func<ItemCategory, bool>> globalFilterExpression = (x) => true;
            if (string.IsNullOrEmpty(dataListVM.GlobalFilter) || string.IsNullOrWhiteSpace(dataListVM.GlobalFilter))
            {
                globalFilterExpression = (x) => true;
            }
            else
            {
                globalFilterExpression = (x) =>
                x.Name.Contains(dataListVM.GlobalFilter);
            }


            var itemCatagoryList = await _repositoryWrapper.ItemCategory
                .FindAll()
                .Where(x => x.FactoryId == dataListVM.FactoryId)
                .Where(globalFilterExpression)
                .OrderByDescending(x => x.UpdatedDateTime)
                .Skip((dataListVM.PageNumber - 1) * (dataListVM.PageSize))
                .Take(dataListVM.PageSize) 
                .ToListAsync();

            var dataRowCount = await _repositoryWrapper.ItemCategory.NumOfRecord();
            List<ItemCategoryVM> itemCategoryVMLists = new List<ItemCategoryVM>();
            itemCategoryVMLists = _utilService.GetMapper().Map<List<ItemCategory>, List<ItemCategoryVM>>(itemCatagoryList);
            var wrapper = new WrapperItemCategoryListVM()
            {
                ListOfData = itemCategoryVMLists,
                TotalRecoreds = dataRowCount
            };
            this._utilService.LogInfo("Successful In Getting  Item Category");
            _utilService.LogInfo("----------------------" + DateTime.UtcNow.ToLongDateString() + "-------------------------------------------");
            _utilService.LogInfo("-----------------------------------------------------------------");
            return wrapper;
        }
        public async Task<WrapperItemCategoryListVM> Add(ItemCategoryVM vm)
        {
            var entityToAdd = _utilService.GetMapper().Map<ItemCategoryVM, ItemCategory>(vm);
            //string uniqueIdTask =await _repositoryWrapper.ItemCategory.GetUniqueId();

            //// Todo  need to aandle unique id from db
            //entityToAdd.UniqueId = uniqueIdTask;
            entityToAdd = _repositoryWrapper.ItemCategory.Create(entityToAdd);
            await _repositoryWrapper.ItemCategory.SaveChangesAsync();
            this._utilService.LogInfo("Successful In saving  Item Category");
            _utilService.LogInfo("-----------------------" + DateTime.UtcNow.ToLongDateString() + "-----------------");
            _utilService.LogInfo("-----------------------------------------------------------------");
            var dataParam = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperItemCategoryListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperItemCategoryListVM> Update(string id, ItemCategoryVM vm)
        {
            IEnumerable<ItemCategory> ItemDB = await _repositoryWrapper.ItemCategory.FindByConditionAsync(x => x.Id == id && x.FactoryId == vm.FactoryId);
            var ItemUpdated = _utilService.GetMapper().Map<ItemCategoryVM, ItemCategory>(vm, ItemDB.ToList().FirstOrDefault());
            _repositoryWrapper.ItemCategory.Update(ItemUpdated);
            await _repositoryWrapper.ItemCategory.SaveChangesAsync();
            this._utilService.LogInfo("Successful In Updating Item Cateory");
            _utilService.LogInfo("---------------------" + DateTime.UtcNow.ToLongDateString() + "-------------------");
            _utilService.LogInfo("-----------------------------------------------------------------");

            var dataParam = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperItemCategoryListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperItemCategoryListVM> Delete(ItemCategoryVM itemTemp)
        {
            IEnumerable<ItemCategory> itemTask = await _repositoryWrapper.ItemCategory.FindByConditionAsync(x => x.Id == itemTemp.Id && x.FactoryId == itemTemp.FactoryId);
            var item = itemTask.ToList().FirstOrDefault();
            if (item == null)
            {
                return new WrapperItemCategoryListVM();
            }
            _repositoryWrapper.ItemCategory.Delete(item);
            await _repositoryWrapper.ItemCategory.SaveChangesAsync();
            this._utilService.LogInfo("Successful In Deleting Item Cateory");
            _utilService.LogInfo("--------------------------" + DateTime.UtcNow.ToLongDateString() + "---------------------------------------");
            _utilService.LogInfo("-----------------------------------------------------------------");
            var dataParam = new GetDataListVM()
            {
                FactoryId = itemTemp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperItemCategoryListVM data = await GetListPaged(dataParam);
            return data;
        }


    }
}
