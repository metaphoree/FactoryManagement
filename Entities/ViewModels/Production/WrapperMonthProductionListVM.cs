using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Production
{
    public class WrapperMonthProductionListVM
    {
        public WrapperMonthProductionListVM()
        {
            ListOfData = new List<MonthlyProduction>();
        }
        public long TotalRecoreds { get; set; }
        public List<MonthlyProduction> ListOfData { get; set; }

    }
}
