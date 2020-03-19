using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;

        public SupplierService(IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;

            this._utilService = utilService;

        }
        public async Task<WrapperSupplierListVM> Add(SupplierVM ViewModel)
        {
            var itemToAdd = _utilService.GetMapper().Map<SupplierVM, Supplier>(ViewModel);
            itemToAdd = _repositoryWrapper.Supplier.Create(itemToAdd);
            Task<int> t1 = _repositoryWrapper.Supplier.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Adding Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = itemToAdd.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperSupplierListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperSupplierListVM> Update(string id, SupplierVM ViewModel)
        {
            if (id != ViewModel.Id)
            {
                new WrapperSupplierListVM();
            }

            Task<IEnumerable<Supplier>> itemsDB = _repositoryWrapper.Supplier.FindByConditionAsync(x => x.Id == id && x.FactoryId == ViewModel.FactoryId);
              await Task.WhenAll(itemsDB);

            var itemUpdated = _utilService.GetMapper().Map<SupplierVM, Supplier>(ViewModel, itemsDB.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Supplier.Update(itemUpdated);

            Task<int> t1 = _repositoryWrapper.Supplier.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Updating Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = ViewModel.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperSupplierListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperSupplierListVM> GetListPaged(GetDataListVM dataListVM)
        {
            IEnumerable<Supplier> ListTask = await _repositoryWrapper.Supplier.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);
            long noOfRecordTask = await _repositoryWrapper.Supplier.NumOfRecord();
            
            List<Supplier> List = ListTask.ToList().OrderByDescending(x => x.UpdatedDateTime).ToList();//.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).OrderByDescending(x => x.CreatedDateTime).ToList();
       
            List<SupplierVM> outputList = new List<SupplierVM>();

            outputList = _utilService.GetMapper().Map<List<Supplier>, List<SupplierVM>>(List);
       
            if (!string.IsNullOrEmpty(dataListVM.GlobalFilter) && !string.IsNullOrWhiteSpace(dataListVM.GlobalFilter))
            {
                outputList = outputList.Where(output =>
                output.AlternateCellNo != null ? output.AlternateCellNo.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                            || output.CellNo != null ? output.CellNo.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                            || output.Email != null ? output.Email.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                            || output.Name != null ? output.Name.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                             || output.PermanentAddress != null ? output.PermanentAddress.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false
                              || output.PresentAddress != null ? output.PresentAddress.Contains(dataListVM.GlobalFilter, StringComparison.OrdinalIgnoreCase) : false).ToList();
            }

            outputList = outputList.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).ToList();
            var data = new WrapperSupplierListVM();
            data.ListOfData = outputList;
            data.TotalRecoreds = noOfRecordTask;
            this._utilService.Log("Successful In Getting Data");
            return data;
        }
        public async Task<WrapperSupplierListVM> Delete(SupplierVM Temp)
        {
            var Task = await _repositoryWrapper.Supplier.FindByConditionAsync(x => x.Id == Temp.Id && x.FactoryId == Temp.FactoryId);
            var datarow = Task.ToList().FirstOrDefault();
            if (datarow == null)
            {
                return new WrapperSupplierListVM();
            }
            _repositoryWrapper.Supplier.Delete(datarow);
            await _repositoryWrapper.Supplier.SaveChangesAsync();
            this._utilService.Log("Successful In Deleting Data");
            var dataParam = new GetDataListVM()
            {
                FactoryId = Temp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperSupplierListVM data = await GetListPaged(dataParam);
            return data;
        } 
    }
}
