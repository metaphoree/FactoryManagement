﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Stock
{
  public  class WrapperStockListVM
    {
        public long TotalRecords { get; set; }
        public List<StockVM> ListOfData { get; set; }
    }
}
