using CommonUtils;
using Contracts;
using Contracts.IBusinessServiceWrapper;
using Entities.DbModels;
using Entities.Enums;
using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using Entities.ViewModels.Payment;
using Entities.ViewModels.Staff;
using Entities.ViewModels.Supplier;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Service.BusinessServiceWrapper
{
    public class BusinessWrapperService : IBusinessWrapperService
    {
        private readonly IServiceWrapper _serviceWrapper;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IUtilService _utilService;

        public BusinessWrapperService(IServiceWrapper serviceWrapper, IRepositoryWrapper repositoryWrapper, IUtilService utilService)
        {
            this._repositoryWrapper = repositoryWrapper;
            this._serviceWrapper = serviceWrapper;
            this._utilService = utilService;
        }


        #region Payment
        #region Supplier
   
        #endregion
        #region Staff
     

        #endregion
        #region Customer
            #endregion 
        #endregion
        #region History
        #region Supplier
     
        #endregion

        #region Customer

        #endregion

        #region Staff
    
        #endregion

        #endregion



    }
}
