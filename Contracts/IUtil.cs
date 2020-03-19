using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUtilService
    {

        IMapper Mapper { get; }
        Task<string> GetUniqueId(string TableName);
        ILoggerManager GetLogger();
        IMapper GetMapper();
        void Log(string message);

        void LogInfo(string message);

        void LogDebug(string message);
        void LogWarn(string message);
        void LogError(string message);


    }
}
