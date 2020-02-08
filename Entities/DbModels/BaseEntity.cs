using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DbModels
{
    public class BaseEntity
    {
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public string Id { get; set; }
        public string FactoryId { get; set; }
        public string RowStatus { get; set; }
        public string UniqueId { get; set; }
    }
}
