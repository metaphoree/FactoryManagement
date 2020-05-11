using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.CustomerView
{
   public class WrapperCustomerHistory
    {
        public WrapperCustomerHistory() {
            ListOfData = new List<CustomerHistory>();
        }
        public long TotalRecords { get; set; }

        public List<CustomerHistory> ListOfData { get; set; }
    }
}
