using AuthNew.Areas.Identity.Data;
using AuthNew.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthNew.Data;

public class AuthDbContext : IdentityDbContext<ApplicationUser>
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options)
        : base(options)
    {
    }


   public DbSet<Position> Positions { get; set; }
   public DbSet<Company> Companys { get; set; }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<ApplicationUser>applicationUsers { get; set; }
}
