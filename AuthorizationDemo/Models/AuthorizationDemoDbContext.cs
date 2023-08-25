using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace AuthorizationDemo.Models
{
    public class AuthorizationDemoDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthorizationDemoDbContext(DbContextOptions options) : base(options) { }

    }

}