using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
    public class PayableRepository : RepositoryBase<Payable>, IPayableRepository
    {
        public PayableRepository(FactoryManagementContext context, IUtilService util) : base(context, util)
        { }
    }
}
