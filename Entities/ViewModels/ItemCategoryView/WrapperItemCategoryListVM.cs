using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.ItemCategoryView
{
  public  class WrapperItemCategoryListVM
    {

        public long TotalRecords { get; set; }
        public List<ItemCategoryVM> ListOfData { get; set; }        
    }
}
