using ApiWithRoles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace ApiWithRoles.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        //public DbSet<Login> Logins { get; set; }
        //public DbSet<Register> Registers { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }
    }
}
