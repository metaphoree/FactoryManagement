﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Contracts;

using Service;
using Entities.DbModels;
using Repository;
using AutoMapper;
using ApiService.Utilities.ExceptionHandler;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using System.IO;
using Repository.EntitywiseRepository;
using Contracts.EntitywiseContracts;

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
        public static void ConfigureDBContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<FactoryManagementContext>(opts =>
            opts.UseSqlServer(config.GetConnectionString("SqlConnection"), optionss => optionss.MigrationsAssembly("ApiService")), ServiceLifetime.Transient);
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureRepository(this IServiceCollection services) {
                                
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<ICustomerRepository,CustomerRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEquipmentRepository, EquipmentRepository>();
            services.AddScoped<IEquipmentCategoryRepository, EquipmentCategoryRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<IExpenseTypeRepository, ExpenseTypeRepository>();
            services.AddScoped<IFactoryRepository, FactoryRepository>();
            services.AddScoped<IIncomeTypeRepository, IncomeTypeRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IInvoiceTypeRepository, InvoiceTypeRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IItemCategoryRepository, ItemCategoryRepository>();
            services.AddScoped<IItemStatusRepository, ItemStatusRepository>();
            services.AddScoped<IPayableRepository, PayableRepository>();
            services.AddScoped<IPaymentStatusRepository, PaymentStatusRepository>();
            services.AddScoped<IPhoneRepository, PhoneRepository>();
            services.AddScoped<IProductionRepository, ProductionRepository>();
            services.AddScoped<IPurchaseRepository, PurchaseRepository>();
            services.AddScoped<IPurchaseTypeRepository, PurchaseTypeRepository>();
            services.AddScoped<IRecievableRepository, RecievableRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ISalesRepository, SalesRepository>();
            services.AddScoped<IStaffRepository, StaffRepository>();
            services.AddScoped<IStockRepository, StockRepository>();
            services.AddScoped<IStockInRepository, StockInRepository>();
            services.AddScoped<IStockOutRepository, StockOutRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ITransactionTypeRepository, TransactionTypeRepository>();
            services.AddScoped<IUserAuthInfoRepository, UserAuthInfoRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
        }
        
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
        public static void ConfigureServiceWrapper(this IServiceCollection services)
        {
            services.AddScoped<IUtilService, UtilService>();
            services.AddScoped<IServiceWrapper, ServiceWrapper>();
        }
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
        }
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }
        public static void ConfigureCustomSwaggerGenerator(this IServiceCollection services) {
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Employee API",
                    Version = "v1",
                    Description = "An API to perform Employee operations",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "John Walkner",
                        Email = "John.Walkner@gmail.com",
                        Url = new Uri("https://twitter.com/jwalkner"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Employee API LICX",
                        Url = new Uri("https://example.com/license"),
                    }
                });
            });

        }
    }
    public static class MiddlewareExtension {
        public static void UseExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
