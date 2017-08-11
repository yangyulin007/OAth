using System;
using System.IO;
using System.Reflection;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Swashbuckle.Application;

[assembly: OwinStartup(typeof(LogicServer.ResourceServer.Startup))]
namespace LogicServer.ResourceServer
{
    /// <summary>
    /// The assebmly should use owin middleware and start at running the Startup method.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Configuration
        /// </summary>
        /// <param name="app">app</param>
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.EnableSwagger("docs/{apiVersion}/swagger", c =>
            {
                c.SingleApiVersion("v1", "昊天企业端接口");
                var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                var fileName = Assembly
                        .GetExecutingAssembly()
                        .GetName()
                        .Name + ".XML";
                var commentsFile = Path.Combine(baseDirectory, "bin", fileName);
                c.IncludeXmlComments(commentsFile);
            }).EnableSwaggerUi(c =>
            {
                var thisAssembly = typeof(SwaggerConfig).Assembly;
                c.InjectJavaScript(thisAssembly, "LogicServer.bearerAuth.BearerAuth.js");
                c.DisableValidator();
            });
            ConfigureOAuth(app);                    // set api authentication schema.
            UnityConfig.RegisterComponents(config); // Use unity as ioc container. Global dependency resolver.
            WebApiConfig.Register(config);          // Setup web api route policy.
                                                    // SwaggerConfig.Register();
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);  // Use Cors in message handling.
            app.UseWebApi(config);
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            // Token Consumption
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions
            {
            });
        }
    }
}