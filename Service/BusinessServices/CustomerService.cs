using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessServices
{
  public  class CustomerService : ICustomerService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        public CustomerService(IRepositoryWrapper repositoryWrapper,IMapper mapper) {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
        }

        public void AddCustomer(AddCustomerViewModel addCustomerViewModel)
        {
            var CustomerDT = _mapper.Map<AddCustomerViewModel, Customer>(addCustomerViewModel);
            var AddressDT  = _mapper.Map<AddCustomerViewModel, Address>(addCustomerViewModel);
            var PhoneDT = _mapper.Map<AddCustomerViewModel, Phone>(addCustomerViewModel);

            _repositoryWrapper.Customer.Create(CustomerDT);
            _repositoryWrapper.Address.Create(AddressDT);
            _repositoryWrapper.Phone.Create(PhoneDT);
            _repositoryWrapper.Save();
        }
    }
}
