﻿using AutoMapper;
using Contracts;
using Contracts.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.BusinessServices
{
    public class StockOutService : IStockOutService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly IUtilService _utilService;

        public StockOutService(IRepositoryWrapper repositoryWrapper,  IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
 
            this._utilService = utilService;

        }
    }
}
