using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
    public class StockOutRepository : RepositoryBase<StockOut>, IStockOutRepository
    {
        public StockOutRepository(FactoryManagementContext context) : base(context)
        { }
    }
}
