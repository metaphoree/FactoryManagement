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
        public CustomerRepository(FactoryManagementContext context) : base(context)
        {


        }
    }
}
