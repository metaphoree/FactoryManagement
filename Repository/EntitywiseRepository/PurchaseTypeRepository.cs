using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
    public class PurchaseTypeRepository : RepositoryBase<PurchaseType>, IPurchaseTypeRepository
    {
        public PurchaseTypeRepository(FactoryManagementContext context) : base(context)
        { }
    }
}
