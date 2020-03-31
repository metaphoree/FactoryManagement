using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
    public class InvoiceRepository : RepositoryBase<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(FactoryManagementContext context) : base(context)
        { 
        }
    }
}
