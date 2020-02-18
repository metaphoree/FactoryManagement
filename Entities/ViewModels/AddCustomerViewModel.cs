﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels
{
   public  class AddCustomerViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }

        public string CellNo { get; set; }
        public string AlternateCellNo { get; set; }
    }
}