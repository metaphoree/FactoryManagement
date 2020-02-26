using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels
{
    public class GetDataListVM
    {
        public long PageSize { get; set; }
        public long PageNumber { get; set; }
        public long TotalRows { get; set; }
        public string FactoryId { get; set; }
    }
}
