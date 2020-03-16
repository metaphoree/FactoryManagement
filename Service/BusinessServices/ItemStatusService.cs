using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using Entities.ViewModels.ItemStatus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessServices
{
    public class ItemStatusService : IItemStatusService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        private readonly IUtilService _utilService;

        public ItemStatusService(IRepositoryWrapper repositoryWrapper, IMapper mapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
            this._utilService = utilService;

        }

        public async Task<WrapperItemStatusListVM> GetListPaged(GetDataListVM dataListVM)
        {
            var itemList = await _repositoryWrapper.ItemStatus
                .FindAll()
                .Where(x => x.FactoryId == dataListVM.FactoryId)
                .OrderByDescending(x => x.UpdatedDateTime)
                .Skip((dataListVM.PageNumber - 1) * (dataListVM.PageSize))
                .Take(dataListVM.PageSize)
                .ToListAsync();

            var dataRowCount = await _repositoryWrapper.ItemStatus.NumOfRecord();
            List<ItemStatusVM> itemVMLists = new List<ItemStatusVM>();
            itemVMLists = _mapper.Map<List<ItemStatus>, List<ItemStatusVM>>(itemList);
            var wrapper = new WrapperItemStatusListVM()
            {
                ListOfData = itemVMLists,
                TotalRecoreds = dataRowCount
            };
            this._utilService.Log("Successful In Getting  Item Status");
            return wrapper;
        }













    }
}
