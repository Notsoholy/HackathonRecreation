using Application.Interfaces;
using Infrastructure.Configurations;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
                                                           IConfiguration configuration)
        {
            services.AddDbContext<RecreationDbContext>(builder =>
                                                                   builder.UseNpgsql(
                                                                       configuration.GetConnectionString(
                                                                           ConnectionStringConfigSection
                                                                              .ConnectionStringSection),
                                                                       b =>
                                                                       {
                                                                           b.MigrationsAssembly("Infrastructure");
                                                                           b.SetPostgresVersion(12, 4);
                                                                           b.MigrationsHistoryTable("__RecreationServiceMigrationsHistory",
                                                                               "recreation_service");
                                                                       }));

            services.AddScoped<IRecreationDbContext>(
                provider => provider.GetService<RecreationDbContext>());

            return services;
        }
    }
}
