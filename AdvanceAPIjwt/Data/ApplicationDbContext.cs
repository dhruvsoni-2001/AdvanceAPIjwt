using AdvanceAPIjwt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdvanceAPIjwt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) 
        { 
        }
        public DbSet<RegisterUser> registerUsers { get; set; }
    }
   
}
