using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Sales
{
    public class WrapperSalesListVM
    {
        public long TotalRecoreds { get; set; }
        public List<SalesVM> ListOfData { get; set; }
    }
}
