﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Supplier
{
   public  class WrapperSupplierListVM
    {
        public long TotalRecords { get; set; }
        public List<SupplierVM> ListOfData { get; set; }
    }
}
