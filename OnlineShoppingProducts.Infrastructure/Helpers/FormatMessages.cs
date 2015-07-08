using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingProducts.Infrastructure.Helpers
{
    public static class FormatMessages
    {
        public static string FormatLoggerInfoMessage(string nameAction, string message, string userName)
        {
            StringBuilder formatMessage = new StringBuilder();
            formatMessage.AppendFormat("Action name: {0}, ", nameAction);
            formatMessage.AppendFormat("Message: {0}, ", message);
            formatMessage.AppendFormat("User name: {0}, ", userName);
            return formatMessage.ToString();
        }
    }
}
