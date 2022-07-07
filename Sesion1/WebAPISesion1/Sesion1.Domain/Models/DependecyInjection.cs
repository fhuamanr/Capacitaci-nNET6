using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sesion1.Domain.Models.Context;

namespace Sesion1.Domain.Models
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(options =>
                      options.UseSqlServer(configuration.GetConnectionString("Sesion1DB"),
                      b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)), ServiceLifetime.Transient);

            services.AddScoped<IApplicationContext>(provider => provider.GetService<ApplicationContext>());
            return services;

        }
    }
}
