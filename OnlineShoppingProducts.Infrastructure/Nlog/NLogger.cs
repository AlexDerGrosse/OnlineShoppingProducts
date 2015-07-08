using NLog;
using OnlineShoppingProducts.Infrastructure.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingProducts.Infrastructure.Nlog
{
    public class NLogger : ILogger
    {
        private Logger _logger;

        public NLogger()
        {
            _logger = LogManager.GetLogger("file");
        }

        public void Error(string nameAction, string errorMessage, string userName, Exception ex)
        {
            var message = FormatMessages.FormatLoggerInfoMessage(nameAction, errorMessage, userName);
            _logger.Error(message, ex);
        }

        public void Error(string nameAction, string responseStatusDescription, string response, string errorMessage, string userName)
        {
            throw new NotImplementedException();
        }

        public void Info(string nameAction, string infoMessage, string userName, Exception ex)
        {
            var message = FormatMessages.FormatLoggerInfoMessage(nameAction, infoMessage, userName);
            _logger.Info(message, ex);
        }

        public void Warn(string nameAction, string warningMessage, string userName, Exception ex)
        {
            var message = FormatMessages.FormatLoggerInfoMessage(nameAction, warningMessage, userName);
            _logger.Warn(message, ex);
        }
    }
}
