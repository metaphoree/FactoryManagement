using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.Production;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class ProductionService : IProductionService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;

        public ProductionService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;

            this._utilService = utilService;

        }
        public async Task<WrapperProductionListVM> GetListPaged(GetDataListVM dataListVM)
        {

            var dataList = await _repositoryWrapper.Production
                .FindAll()
                .Where(x => x.FactoryId == dataListVM.FactoryId)
                .ToListAsync();

            var dataRowCount = await _repositoryWrapper.Production.NumOfRecord();
            List<AddProductionVM> ProductionVMLists = new List<AddProductionVM>();
            ProductionVMLists = _utilService.GetMapper().Map<List<Production>, List<AddProductionVM>>(dataList);
            ProductionVMLists = 
                 ProductionVMLists
                .Where((x) =>
                    x.EquipmentName.Contains(dataListVM.GlobalFilter)
                    || x.ItemCategoryName.Contains(dataListVM.GlobalFilter)
                    || x.ItemName.Contains(dataListVM.GlobalFilter)
                    || x.StaffName.Contains(dataListVM.GlobalFilter))
                .OrderByDescending(x => x.UpdatedDateTime)
                .Skip((dataListVM.PageNumber - 1) * (dataListVM.PageSize))
                .Take(dataListVM.PageSize)
                .ToList();
             var wrapper = new WrapperProductionListVM()
            {
                ListOfData = ProductionVMLists,
                TotalRecoreds = dataRowCount
            };
            this._utilService.LogInfo("Successful In Getting  Item Category");

            return wrapper;
        }
        public async Task<WrapperProductionListVM> Add(AddProductionVM vm)
        {
            var entityToAdd = _utilService.GetMapper().Map<AddProductionVM, Production>(vm);
            //string uniqueIdTask =await _repositoryWrapper.Production.GetUniqueId();

            //// Todo  need to aandle unique id from db
            //entityToAdd.UniqueId = uniqueIdTask;
            entityToAdd = _repositoryWrapper.Production.Create(entityToAdd);
            await _repositoryWrapper.Production.SaveChangesAsync();
            this._utilService.LogInfo("Successful In saving  Item Category");

            var dataParam = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperProductionListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperProductionListVM> Update(string id, EditProductionVM vm)
        {
            IEnumerable<Production> ItemDB = await _repositoryWrapper.Production.FindByConditionAsync(x => x.Id == id && x.FactoryId == vm.FactoryId);
            var ItemUpdated = _utilService.GetMapper().Map<EditProductionVM, Production>(vm, ItemDB.ToList().FirstOrDefault());
            _repositoryWrapper.Production.Update(ItemUpdated);
            await _repositoryWrapper.Production.SaveChangesAsync();
            this._utilService.LogInfo("Successful In Updating Production");


            var dataParam = new GetDataListVM()
            {
                FactoryId = vm.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperProductionListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperProductionListVM> Delete(AddProductionVM itemTemp)
        {
            IEnumerable<Production> itemTask = await _repositoryWrapper.Production.FindByConditionAsync(x => x.Id == itemTemp.Id && x.FactoryId == itemTemp.FactoryId);
            var item = itemTask.ToList().FirstOrDefault();
            if (item == null)
            {
                return new WrapperProductionListVM();
            }
            _repositoryWrapper.Production.Delete(item);
            await _repositoryWrapper.Production.SaveChangesAsync();
            this._utilService.LogInfo("Successful In Deleting Item Cateory");

            var dataParam = new GetDataListVM()
            {
                FactoryId = itemTemp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperProductionListVM data = await GetListPaged(dataParam);
            return data;
        }

    }
}
