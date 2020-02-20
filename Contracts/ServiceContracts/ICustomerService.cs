﻿using Entities.ViewModels;
using Entities.ViewModels.CustomerView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
   public interface ICustomerService
    {
        Task AddCustomer(AddCustomerViewModel addCustomerViewModel);
        Task UpdateCustomer(string id, UpdateCustomerViewModel updateCustomerViewModel);
        Task<List<ListCustomerVM>> GetCustomerList(string FactoryId);
        Task<UpdateCustomerViewModel> GetCustomer(string cusId, string FactoryId);
    }
}
