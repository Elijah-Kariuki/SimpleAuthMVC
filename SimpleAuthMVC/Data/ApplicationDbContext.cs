using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleAuthMVC.Models;

namespace SimpleAuthMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SimpleAuthMVC.Models.RegisterViewModel> RegisterViewModel { get; set; } = default!;

     
    }
}
