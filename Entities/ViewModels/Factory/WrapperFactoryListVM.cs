using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Factory
{
    public class WrapperFactoryListVM
    {
        public long TotalRecords { get; set; }
        public List<FactoryVM> ListOfData { get; set; }
    }
}
