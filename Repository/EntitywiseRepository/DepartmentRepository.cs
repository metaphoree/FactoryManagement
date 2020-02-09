using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
namespace Repository.EntitywiseRepository
{
    public class DepartmentRepository : RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(FactoryManagementContext context) : base(context)
        {


        }
    }
}
