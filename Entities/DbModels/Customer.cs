using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }
        public string Number { get; set; }
        public string AlternateNumber_1 { get; set; }
        public string AlternateNumber_2 { get; set; }
    }
}
