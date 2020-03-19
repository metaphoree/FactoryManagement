using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
  public  class IncomeRepository : RepositoryBase<Income>, IIncomeRepository
    {
        public IncomeRepository(FactoryManagementContext context) : base(context)
        { 
        
        }
    }
}
