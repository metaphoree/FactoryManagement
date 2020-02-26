using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.CustomerView
{
   public  class WrapperListCustomerVM
    {
        public long TotalRecoreds { get; set; }
        public List<ListCustomerVM> CustomerList { get; set; }

    }
}
