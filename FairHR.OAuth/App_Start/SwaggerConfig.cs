using System.Web.Http;
using WebActivatorEx;
using FairHR.OAuth;
using Swashbuckle.Application;
using System;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace FairHR.OAuth
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {

                        c.SingleApiVersion("v1", "FairHR.OAuth");
                        
                        //c.BasicAuth("basic")
                        //    .Description("Basic HTTP Authentication");
                        //设置接口描述xml路径地址
                       // c.IncludeXmlComments(string.Format("{0}/bin/FairHR.OAuth.XML", System.AppDomain.CurrentDomain.BaseDirectory));
                        c.IncludeXmlComments(GetXmlCommentsPath(thisAssembly.GetName().Name));

                        //c.CustomProvider((defaultProvider) => new CachingSwaggerProvider(defaultProvider));
                        //控制器描述
                        c.CustomProvider((defaultProvider) => new Providers.CachingSwaggerProvider(defaultProvider));
                    })
                .EnableSwaggerUi(c =>
                    {

                        //c.InjectJavaScript(thisAssembly, "Swashbuckle.Dummy.SwaggerExtensions.testScript1.js");
                        //路径规则，项目命名空间.文件夹名称.js文件名称
                        c.InjectJavaScript(thisAssembly, "FairHR.OAuth.Scripts.swaggerui.swagger_lang.js");

                        //c.InjectJavaScript(thisAssembly, "FairHR.OAuth.Scripts.swaggerui.api-key-header-auth.js");

                        c.InjectJavaScript(thisAssembly, "FairHR.OAuth.Scripts.swaggerui.BearerAuth.js");
                    });
        }
        protected static string GetXmlCommentsPath(string name)
        {
            return string.Format(@"{0}\bin\{1}.XML", AppDomain.CurrentDomain.BaseDirectory, name);
        }
    }
}
