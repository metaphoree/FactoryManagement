using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Production
{
    public class WrapperProductionListVM
    {
        public long TotalRecoreds { get; set; }
        public List<AddProductionVM> ListOfData { get; set; }
    }
}
