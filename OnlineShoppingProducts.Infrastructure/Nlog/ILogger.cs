using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingProducts.Infrastructure.Nlog
{
    public interface ILogger
    {
        void Error(string nameAction, string errorMessage, string userName, Exception ex);

        void Error(string nameAction, string responseStatusDescription, string response, string errorMessage, string userName);

        void Info(string nameAction, string infoMessage, string userName, Exception ex);

        void Warn(string nameAction, string warningMessage, string userName, Exception ex);
    }
}
