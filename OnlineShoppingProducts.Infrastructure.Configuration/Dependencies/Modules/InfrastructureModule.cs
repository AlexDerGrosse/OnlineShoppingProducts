using Autofac;
using OnlineShoppingProducts.Infrastructure.Nlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingProducts.Infrastructure.Configuration.Dependencies.Modules
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(ILogger).Assembly).Where(x => typeof(ILogger).IsAssignableFrom(x)).AsImplementedInterfaces().SingleInstance();
        }
    }
}
