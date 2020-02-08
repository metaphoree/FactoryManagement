using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Phone : BaseEntity
    {
     
        public string RelatedId { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
    }
}
