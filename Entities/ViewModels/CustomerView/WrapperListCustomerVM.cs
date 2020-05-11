using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.CustomerView
{
   public  class WrapperListCustomerVM
    {
        public long TotalRecords { get; set; }
        public List<CustomerVM> ListOfData { get; set; }

    }
}
