using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.EntitywiseRepository
{
    public class PaymentStatusRepository : RepositoryBase<PaymentStatus>, IPaymentStatusRepository
    {
        public PaymentStatusRepository(FactoryManagementContext context) : base(context)
        { }
    }
}
