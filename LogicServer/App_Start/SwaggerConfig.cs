using System;
using System.Web.Http;
using LogicServer;
using Swashbuckle.Application;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace LogicServer
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "昊天企业端接口");
                        c.IncludeXmlComments(GetXmlCommentsPath(thisAssembly.GetName().Name));
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.InjectJavaScript(thisAssembly, "LogicServer.bearerAuth.BearerAuth.js");
                    });
        }

        protected static string GetXmlCommentsPath(string name)
        {
            return string.Format(@"{0}\bin\{1}.XML", AppDomain.CurrentDomain.BaseDirectory, name);
        }
    }
}