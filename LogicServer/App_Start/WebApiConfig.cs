namespace LogicServer
{
    using System.Linq;
    using System.Net.Http.Formatting;
    using System.Web.Http;
    using Newtonsoft.Json.Serialization;

    /// <summary>
    /// Class used to config web api features.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Regist web api functionality such as routing strategy and serialization settings.
        /// </summary>
        /// <param name="config">Current server http feature object.</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            // Regist dependencies into container overhere
            // var container = new UnityContainer();
            // container.RegisterType<IProductRepository, ProductRepository>();
            // container.RegisterType<IProductBusinessHandler, ProductBusinessHandler>();
            //config.Routes.MapHttpRoute(
            //   name: "DefaultApi",
            //   routeTemplate: "api/{controller}/{id}",
            //   defaults: new { id = RouteParameter.Optional });
        }
    }
}
