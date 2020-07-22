using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.ApiResourceMapping
{
   public class WrapperApiResourceMappingListVM
    {
        public WrapperApiResourceMappingListVM()
        {
            ListOfData = new List<ApiResourceMappingVM>();
        }
        public long TotalRecords { get; set; }

        public List<ApiResourceMappingVM> ListOfData { get; set; }

    }
}
