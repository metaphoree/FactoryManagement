using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Entities.DbModels;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        public async Task AddCustomer(AddCustomerViewModel addCustomerViewModel)
        {
            var CustomerDT = _mapper.Map<AddCustomerViewModel, Customer>(addCustomerViewModel);
            var AddressDT  = _mapper.Map<AddCustomerViewModel, Address>(addCustomerViewModel);
            var PhoneDT = _mapper.Map<AddCustomerViewModel, Phone>(addCustomerViewModel);
            CustomerDT.FactoryId = "3cd4dbc2-d0f7-443d-89b0-c8b4e8b3fd42";
            CustomerDT = _repositoryWrapper.Customer.Create(CustomerDT);
            AddressDT.FactoryId = "3cd4dbc2-d0f7-443d-89b0-c8b4e8b3fd42";
            AddressDT.RelatedId = CustomerDT.Id;
            AddressDT =  _repositoryWrapper.Address.Create(AddressDT);
            PhoneDT.RelatedId = CustomerDT.Id;
            PhoneDT.FactoryId = "3cd4dbc2-d0f7-443d-89b0-c8b4e8b3fd42";
            PhoneDT = _repositoryWrapper.Phone.Create(PhoneDT);
            await _repositoryWrapper.SaveAsync();
        }
    }
}
