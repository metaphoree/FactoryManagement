using Entities.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ServiceContracts
{
    public interface ISalesService
    {
        Task AddSalesAsync(SalesVM salesVM);
    }
}
