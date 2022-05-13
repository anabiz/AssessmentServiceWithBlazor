
using Application.Contracts;
using Application.Services;
using Infrastructure;
using Infrastructure.Contracts;
using Infrastructure.Data.DatabaseContext;
using Infrastructure.Utils.Logger;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Globalization;
using System.Text;


namespace BlazorApp1.Server.Extensions
{
    public static class ServiceExtensions
    {
        private static readonly ILoggerFactory ContextLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(opts =>
            {
                opts.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });
        }
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureRepositoryManager(this IServiceCollection serviceCollection) =>
            serviceCollection.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            //services.AddHttpClient<AssessmentService>();
        }
            

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(opts =>
                opts
                    .UseLoggerFactory(ContextLoggerFactory)
                    .UseSqlServer(configuration.GetConnectionString("DefaultConnection"), options => options.EnableRetryOnFailure()));
        }

    }
}
