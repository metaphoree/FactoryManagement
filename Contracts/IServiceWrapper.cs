using Contracts.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
   public  interface IServiceWrapper
    {
        ICustomerService CustomerService { get;}
    }
}
