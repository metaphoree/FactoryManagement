using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.EquipmentCategory
{
    public class WrapperEquipmentCategoryListVM
    {
        public long TotalRecords { get; set; }
        public List<EquipmentCategoryVM> ListOfData { get; set; }
    }
}
