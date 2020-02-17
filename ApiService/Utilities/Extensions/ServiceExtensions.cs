using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Contracts;

using Service;
using Entities.DbModels;
using Repository;
using AutoMapper;

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
            opts.UseSqlServer(config.GetConnectionString("SqlConnection"),optionss => optionss.MigrationsAssembly("ApiService")));

        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
        public static void ConfigureServiceWrapper(this IServiceCollection services)
        {
            services.AddScoped<IServiceWrapper, ServiceWrapper>();
        }
        public static void ConfigureAutoMapper(this IServiceCollection services) {
            services.AddAutoMapper(typeof(Startup));
        }
    
    }
}
