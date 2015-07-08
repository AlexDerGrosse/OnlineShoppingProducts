using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineShoppingProducts.Infrastructure.Configuration.Dependencies
{
    public class AutofacWebConfiguration
    {

        public static IContainer RegisterComponents()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(BootstrapperWeb.WebAppAssembly);
            builder.RegisterFilterProvider();

            builder.RegisterAssemblyModules(typeof(AutofacWebConfiguration).Assembly);

            // Create the container
            var container = builder.Build();

            // Set the dependency resolver for MVC
            DependencyResolver.SetResolver(new Autofac.Integration.Mvc.AutofacDependencyResolver(container));

            return container;
        }
    }
}
