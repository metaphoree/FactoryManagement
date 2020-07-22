using Contracts;
using Contracts.EntitywiseContracts;
using Entities.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EntitywiseRepository
{
    public class ApiResourceMappingRepository : RepositoryBase<ApiResourceMapping>, IApiResourceMappingRepository
    {
        private readonly FactoryManagementContext _context;
        public ApiResourceMappingRepository(FactoryManagementContext context, IUtilService util) : base(context, util)
        {
            _context = context;

        }
    }
}
