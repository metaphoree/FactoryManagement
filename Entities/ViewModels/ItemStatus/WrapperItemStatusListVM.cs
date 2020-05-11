using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.ItemStatus
{
  public   class WrapperItemStatusListVM
    {
        public long TotalRecords { get; set; }
        public List<ItemStatusVM> ListOfData { get; set; }

    }
}
