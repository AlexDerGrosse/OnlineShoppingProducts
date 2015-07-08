using Autofac;
using OnlineShoppingProducts.Infrastructure.Dapper.RepositoryHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingProducts.Infrastructure.Configuration.Dependencies.Modules
{
    public class DatabaseModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RepositoryDapper>().SingleInstance();
        }
    }
}
