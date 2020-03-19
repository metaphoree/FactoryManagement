using Entities.ViewModels;
using Entities.ViewModels.Equipment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface IEquipmentService
    {
        Task<WrapperEquipmentListVM> GetListPaged(GetDataListVM dataListVM);
        Task<WrapperEquipmentListVM> Add(EquipmentVM vm);
        Task<WrapperEquipmentListVM> Update(string id, EquipmentVM vm);
        Task<WrapperEquipmentListVM> Delete(EquipmentVM itemTemp);
    }
}
