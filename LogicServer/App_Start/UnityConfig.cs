namespace LogicServer
{
    using System.Web.Http;
    using BLL;
    using DAL;
    using Interface;
    using Microsoft.Practices.Unity;
    using Unity.WebApi;

    /// <summary>
    /// Config unity container for IOC.
    /// </summary>
    public static class UnityConfig
    {
        /// <summary>
        /// This method is used to regist container components.
        /// </summary>
        /// <param name="config">Instance of HttpConfiguration which is used by current service.</param>
        public static void RegisterComponents(HttpConfiguration config)
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductBusinessHandler, ProductBusinessHandler>();
            container.RegisterType<ICustomerBll, CustomerBll>();
            container.RegisterType<ICustomerDal, CustomerDal>();
            container.RegisterType<IEmployeeDal, EmployeeDal>();
            container.RegisterType<IEmployeeBll, EmployeeBll>();
            container.RegisterType<IContractDal, ContractDal>();
            container.RegisterType<IContractBll, ContractBll>();
            container.RegisterType<ISocialSecurityDal, SocialSecurityDal>();
            container.RegisterType<ISocialSecurityBll, SocialSecurityBll>();
            // e.g. container.RegisterType<ITestService, TestService>();
            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}