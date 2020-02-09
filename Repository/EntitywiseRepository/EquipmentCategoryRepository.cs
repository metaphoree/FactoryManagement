using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
namespace Repository.EntitywiseRepository
{
    public class EquipmentCategoryRepository : RepositoryBase<EquipmentCategory>, IEquipmentCategoryRepository
    {
        public EquipmentCategoryRepository(FactoryManagementContext context) : base(context)
        {


        }
    }
}
