﻿using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessServices
{
    public class PayableService : IPayableService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        public PayableService(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
        }
    }
}