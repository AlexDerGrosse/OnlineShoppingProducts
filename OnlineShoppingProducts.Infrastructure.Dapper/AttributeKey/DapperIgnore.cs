using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingProducts.Infrastructure.Dapper.AttributeKey
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DapperIgnore : Attribute
    {
    }
}
