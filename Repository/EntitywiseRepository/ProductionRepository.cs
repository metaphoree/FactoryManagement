using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
    public class ProductionRepository : RepositoryBase<Production>, IProductionRepository
    {
        public ProductionRepository(FactoryManagementContext context, IUtilService util) : base(context, util)
        { }
    }
}
