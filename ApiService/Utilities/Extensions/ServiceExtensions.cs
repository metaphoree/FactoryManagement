using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Contracts;
using Entities.DbModels;
using LoggerService;

namespace ApiService.Utilities.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
        public static void ConfigureDBContext(this IServiceCollection services, IConfiguration config) {

            services.AddDbContext<FactoryManagementContext>(opts =>     
            opts.UseSqlServer(config.GetConnectionString("SqlConnection"),opts => opts.MigrationsAssembly("ApiService")));

        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
