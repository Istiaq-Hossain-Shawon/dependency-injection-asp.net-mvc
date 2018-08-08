using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using DAL;
using Services;

namespace DependencyInjection
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<ICustomerService, CustomerService>();
        }
    }
}