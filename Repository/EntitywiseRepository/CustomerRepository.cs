using System;
using System.Collections.Generic;
using System.Text;
using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
namespace Repository.EntitywiseRepository
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        private readonly FactoryManagementContext _context;
        public CustomerRepository(FactoryManagementContext context, IUtilService util) : base(context, util)
        {
            _context = context;

        }
    }
}
