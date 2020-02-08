using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Equipment : BaseEntity
    {

        public int Number { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string EquipmentCategoryId { get; set; }
    }
}
