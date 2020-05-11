using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Item
{
   public class WrapperItemListVM
    {
        public long TotalRecords { get; set; }
        public List<ItemVM> ListOfData { get; set; }

    }
}
