﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Sales
{
    public class WrapperSalesListVM : CommonVM
    {
        public long TotalRecords { get; set; }
        public List<SalesVM> ListOfData { get; set; }
    }
}
