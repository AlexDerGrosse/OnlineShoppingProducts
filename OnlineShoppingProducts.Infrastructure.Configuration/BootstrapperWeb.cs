using OnlineShoppingProducts.Infrastructure.Configuration.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingProducts.Infrastructure.Configuration
{
   public class BootstrapperWeb
    {
       public static Assembly WebAppAssembly = Assembly.Load("OnlineShoppingProducts.Web");


        public static void Bootstrap()
        {
            AutofacWebConfiguration.RegisterComponents();
        }
    }
}
