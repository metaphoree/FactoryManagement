using AutoMapper;
using Contracts;
using Entities.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UtilService : IUtilService
    {

        private readonly FactoryManagementContext _context;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;


        public UtilService(FactoryManagementContext context, ILoggerManager loggerManager, IMapper mapper)
        {
            _context = context;
            _loggerManager = loggerManager;
            _mapper = mapper;

        }
        public async Task<string> GetUniqueId(string TableName)
        {
            long rowCount = 0;
            string output = "";

            switch (TableName)
            {
                case "Customer":
                    rowCount = await _context.Customer.AsQueryable().LongCountAsync();
                    output = "CUST" + rowCount.ToString();
                    break;
                case "Phone":
                    rowCount = await _context.Phone.AsQueryable().LongCountAsync();
                    output = "PH" + rowCount.ToString();
                    break;
                case "Address":
                    rowCount = await _context.Address.AsQueryable().LongCountAsync();
                    output = "ADD" + rowCount.ToString();
                    break;
                default:
                    output = "NOT_DEFINED";
                    break;

            }

            return output;

        }

        public IMapper GetMapper()
        {
            return _mapper;
        }
        public ILoggerManager GetLogger()
        {
            return _loggerManager;
        }
        public void Log(string message)
        {
            _loggerManager.LogInfo("---------------------------------------------------------------------------------------------------------");
            _loggerManager.LogInfo("--------------------------" + DateTime.Now.ToString() + "------------------------------------------------");
            _loggerManager.LogInfo(message);
        }



    }
}
