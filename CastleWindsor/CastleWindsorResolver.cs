using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MvcCoreCastleWindsor.Abstract;
using MvcCoreCastleWindsor.Concrete;
using System;

namespace MvcCoreCastleWindsor.CastleWindsor
{
    public class ServiceResolver
    {
        private static WindsorContainer container;
        public static IServiceProvider Load(IServiceCollection services)
        {
            container = new WindsorContainer();
            container.Register(Component.For<IProductService>().ImplementedBy<ProductService>().Named("productservice").LifestyleTransient());
            return WindsorRegistrationHelper.CreateServiceProvider(container, services);
        }
    }


    public class ContainerInstall
    {
        private static WindsorContainer container;
        public static IWindsorContainer Install()
        {
            container = new WindsorContainer();
            container.Register(Component.For<IProductService>().ImplementedBy<ProductService>().Named("productservice").LifestyleTransient());
            return container.Install();
        }
    }

}
