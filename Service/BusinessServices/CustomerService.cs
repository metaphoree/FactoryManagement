using Contracts;
using Contracts.ServiceContracts;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessServices
{
  public  class CustomerService : ICustomerService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        public CustomerService(IRepositoryWrapper repositoryWrapper) {
            this._repositoryWrapper = repositoryWrapper;
        }

        public void AddCustomer(AddCustomerViewModel addCustomerViewModel)
        {
           // throw new NotImplementedException();
        }
    }
}
