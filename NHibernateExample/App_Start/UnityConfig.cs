using NHibernateExample.Models;
using NHibernateExample.Repository;
using NHibernateExample.Repository.IRepository;
using NHibernateExample.Repository.IRepository.Helper;
using NHibernateExample.Service;
using NHibernateExample.Service.IService;
using NHibernateExample.Service.IService.Helper;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace NHibernateExample
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IOrderRepository, OrderRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<ISizeRepository, SizeRepository>();

            container.RegisterType<IRepositoryBasicGet<Size>, SizeRepository>();


            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IOrderService, OrderService>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<ISizeService, SizeService>();

            container.RegisterType<ISelectList, SizeService>("Size");

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}