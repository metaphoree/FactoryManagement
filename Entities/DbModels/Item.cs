using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Item : BaseEntity
    {

        public string Name { get; set; }
        public string CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }

        public ItemCategory ItemCategory { get; set; }
    }
}
