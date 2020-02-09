using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
    public class ExpenseTypeRepository : RepositoryBase<ExpenseType>, IExpenseTypeRepository
    {
        public ExpenseTypeRepository(FactoryManagementContext context) : base(context)
        { }
    }
}
