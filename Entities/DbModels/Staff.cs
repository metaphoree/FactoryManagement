using System;
using System.Collections.Generic;

namespace Entities.DbModels
{
    public  class Staff : BaseEntity
    {
    
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string DepartmentId { get; set; }
        public string Code { get; set; }
        public double? BasicSalary { get; set; }
        public string BirthRegistrationNo { get; set; }
        public string NationalIdNo { get; set; }
    }
}
