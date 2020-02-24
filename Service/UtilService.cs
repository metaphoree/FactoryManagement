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

        public UtilService(FactoryManagementContext context)
        {
            _context = context;

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
    }
}
