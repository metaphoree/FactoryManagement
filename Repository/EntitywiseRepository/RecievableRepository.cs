using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
    public class RecievableRepository : RepositoryBase<Recievable>, IRecievableRepository
    {
        public RecievableRepository(FactoryManagementContext context) : base(context)
        { }
    }
}
