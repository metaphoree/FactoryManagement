using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using Service.BusinessServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ServiceWrapper : IServiceWrapper
    {

        ICustomerService _CustomerService;
        IRepositoryWrapper _repositoryWrapper;
        IMapper _mapper;
        public ServiceWrapper(IRepositoryWrapper repositoryWrapper,IMapper mapper)
        {
            this._repositoryWrapper = repositoryWrapper; 
            this._mapper = mapper;
        }


        public ICustomerService CustomerService
        {
            get
            {
                if (_CustomerService == null)
                {
                    //return new AddressRepository(dbContext);
                    _CustomerService = new CustomerService(_repositoryWrapper, _mapper);
                }
                return _CustomerService;
            }
        }
    }
}
