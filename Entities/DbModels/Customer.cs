﻿using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
 
    }
}
