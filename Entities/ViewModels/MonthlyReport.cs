using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels
{
    public class MonthlyReport : GetDataListVM
    {
        public string Month { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}
