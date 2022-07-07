using Microsoft.EntityFrameworkCore;

namespace Sesion1.Domain.Models.Context
{
    public  interface IApplicationContext
    {
        DbSet<Developer> Developers { get; set; }
        DbSet<Project> Projects { get; set; }

        Task<int> SaveChangesAsync();

    }
}