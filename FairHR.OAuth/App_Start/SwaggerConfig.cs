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
                        //���ýӿ�����xml·����ַ
                       // c.IncludeXmlComments(string.Format("{0}/bin/FairHR.OAuth.XML", System.AppDomain.CurrentDomain.BaseDirectory));
                        c.IncludeXmlComments(GetXmlCommentsPath(thisAssembly.GetName().Name));

                        //c.CustomProvider((defaultProvider) => new CachingSwaggerProvider(defaultProvider));
                        //����������
                        c.CustomProvider((defaultProvider) => new Providers.CachingSwaggerProvider(defaultProvider));
                    })
                .EnableSwaggerUi(c =>
                    {

                        //c.InjectJavaScript(thisAssembly, "Swashbuckle.Dummy.SwaggerExtensions.testScript1.js");
                        //·��������Ŀ�����ռ�.�ļ�������.js�ļ�����
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
