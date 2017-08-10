namespace FairHR.OAuth.Migrations
{
    using System.Data.Entity.Migrations;
    public sealed class Configuration : DbMigrationsConfiguration<FairHR.OAuth.Auth.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "OAuthPractice.ProtectedApi.Auth.AuthContext";
        }

        protected override void Seed(FairHR.OAuth.Auth.AuthContext context)
        {
           
        }
    }
}