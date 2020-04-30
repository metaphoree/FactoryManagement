using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Production
{
    public class WrapperProductionListVM
    {
        public WrapperProductionListVM()
        {
            ListOfData = new List<AddProductionVM>();
        }
        public long TotalRecoreds { get; set; }
        public List<AddProductionVM> ListOfData { get; set; }
    }

    //public class WrapperMonthPayableListVM
    //{
    //    public WrapperMonthPayableListVM()
    //    {
    //        ListOfData = new List<MonthlyProduction>();
    //    }

    //    public long TotalRecoreds { get; set; }
    //    public List<MonthlyProduction> ListOfData { get; set; }
    //}







}
