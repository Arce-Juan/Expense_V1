using Core.Application.Interfaces;
using Infraestructure.Persistence.Contents;
using Infraestructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure.Persistence
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("LocalDbConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
            ));

            #region Repositories
            services.AddTransient(typeof(IRepositoryAsync<>), typeof(MyRepositoryAsync<>));
            #endregion

        }
    }
}
