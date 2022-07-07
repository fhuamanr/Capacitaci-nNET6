using Microsoft.EntityFrameworkCore;

namespace Sesion1.Domain.Models.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }

        public Task <int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
