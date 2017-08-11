using FairHR.OAuth.Auth;
using FairHR.OAuth.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Data.Entity;
using System.Web.Http;

[assembly:OwinStartup(typeof(FairHR.OAuth.Startup))]
namespace FairHR.OAuth
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            ConfigureOAth(app);
            UnityConfig.RegisterComponents(config); // Use unity as ioc container. Global 

            //这一行必须放在ConfigureOAth(app)之后
            app.UseWebApi(config);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AuthContext, Migrations.Configuration>());
        }

        public void ConfigureOAth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                Provider = new SimpleAuthorizationServerProvider(),

                RefreshTokenProvider = new SimpleRefreshTokenProvider()
            };


            //Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}