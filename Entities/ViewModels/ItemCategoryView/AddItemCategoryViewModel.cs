﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.ViewModels.ItemCategoryView
{
   public class AddItemCategoryViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string FactoryId { get; set; }
    }
}
