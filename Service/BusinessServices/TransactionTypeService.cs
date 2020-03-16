﻿using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessServices
{
    public class TransactionTypeService : ITransactionTypeService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;
        private readonly IUtilService _utilService;

        public TransactionTypeService(IRepositoryWrapper repositoryWrapper, IMapper mapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._mapper = mapper;
            this._utilService = utilService;

        }
    }
}
