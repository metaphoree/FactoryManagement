using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
    public class AddressRepository : RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(FactoryManagementContext context) : base(context) { 
        
        
        }
        public void prit()
        {
            throw new NotImplementedException();
        }
    }
}
