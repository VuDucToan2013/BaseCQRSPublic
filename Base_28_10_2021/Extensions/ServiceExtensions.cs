using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base_28_10_2021.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<SampleNetCoreAPIContext>(o => o.UseSqlServer(config.GetConnectionString("connectionString")));
        }
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.WithOrigins("http://localhost:4500")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    );
            });
        }
        public static void ConfigureMediatR(this IServiceCollection services)
        {
            //Register Assembly Where All Handlers Stored
            var assembly = AppDomain.CurrentDomain.Load("Application");
            services.AddMediatR(assembly);
        }
    }

}
