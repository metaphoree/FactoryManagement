using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class StaffService : IStaffService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        private readonly IUtilService _utilService;

        public StaffService(IRepositoryWrapper repositoryWrapper, IMapper mapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
            this._utilService = utilService;
        }
        public async Task<WrapperStaffListVM> Add(StaffVM ViewModel)
        {
            var itemToAdd = _utilService.GetMapper().Map<StaffVM, Staff>(ViewModel);
            itemToAdd = _repositoryWrapper.Staff.Create(itemToAdd);
            Task<int> t1 = _repositoryWrapper.Staff.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Adding Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = itemToAdd.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStaffListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperStaffListVM> Update(string id, StaffVM ViewModel)
        {
            if (id != ViewModel.Id)
            {
                new WrapperStaffListVM();
            }

            Task<IEnumerable<Staff>> itemsDB = _repositoryWrapper.Staff.FindByConditionAsync(x => x.Id == id && x.FactoryId == ViewModel.FactoryId);
            await Task.WhenAll(itemsDB);

            var itemUpdated = _utilService.GetMapper().Map<StaffVM, Staff>(ViewModel, itemsDB.Result.ToList().FirstOrDefault());
            _repositoryWrapper.Staff.Update(itemUpdated);

            Task<int> t1 = _repositoryWrapper.Staff.SaveChangesAsync();
            await Task.WhenAll(t1);
            this._utilService.Log("Successful In Updating Data");

            var dataParam = new GetDataListVM()
            {
                FactoryId = ViewModel.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStaffListVM data = await GetListPaged(dataParam);
            return data;
        }
        public async Task<WrapperStaffListVM> GetListPaged(GetDataListVM dataListVM)
        {
            IEnumerable<Staff> ListTask = await _repositoryWrapper.Staff.FindByConditionAsync(x => x.FactoryId == dataListVM.FactoryId);
            long noOfRecordTask = await _repositoryWrapper.Staff.NumOfRecord();

            List<Staff> List = ListTask.ToList().OrderByDescending(x => x.UpdatedDateTime).ToList();//.Skip((dataListVM.PageNumber - 1) * dataListVM.PageSize).Take(dataListVM.PageSize).OrderByDescending(x => x.CreatedDateTime).ToList();

            List<StaffVM> outputList = new List<StaffVM>();

            outputList = _utilService.GetMapper().Map<List<Staff>, List<StaffVM>>(List);

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
            var data = new WrapperStaffListVM();
            data.ListOfData = outputList;
            data.TotalRecoreds = noOfRecordTask;
            this._utilService.Log("Successful In Getting Data");
            return data;
        }
        public async Task<WrapperStaffListVM> Delete(StaffVM Temp)
        {
            var Task = await _repositoryWrapper.Staff.FindByConditionAsync(x => x.Id == Temp.Id && x.FactoryId == Temp.FactoryId);
            var datarow = Task.ToList().FirstOrDefault();
            if (datarow == null)
            {
                return new WrapperStaffListVM();
            }
            _repositoryWrapper.Staff.Delete(datarow);
            await _repositoryWrapper.Staff.SaveChangesAsync();
            this._utilService.Log("Successful In Deleting Data");
            var dataParam = new GetDataListVM()
            {
                FactoryId = Temp.FactoryId,
                PageNumber = 1,
                PageSize = 10,
                TotalRows = 0
            };
            WrapperStaffListVM data = await GetListPaged(dataParam);
            return data;
        }
  
    
    
    }
}
