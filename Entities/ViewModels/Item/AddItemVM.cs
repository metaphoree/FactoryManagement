﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels.Item
{
   public class AddItemVM
    {
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string FactoryId { get; set; }
    }
}
