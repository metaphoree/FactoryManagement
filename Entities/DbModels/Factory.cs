using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Factory : BaseEntity
    {
        public Factory()
        {
            UserRole = new HashSet<UserRole>();
        }


        public DateTime? SubscriptionStart { get; set; }
        public DateTime? SubscriptionEnd { get; set; }
        public string LicenseNo { get; set; }
        public string RegNo { get; set; }
        public string VatRegNo { get; set; }
        public string Name { get; set; }

        public string ImageUrl { get; set; }
        public string RowStatus { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
