using FairHR.OAuth.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace FairHR.OAuth.Auth
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base("AuthContext")
        {

        }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}