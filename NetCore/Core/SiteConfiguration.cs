using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace NetCore.Core
{
    public static class SiteConfiguration
    {
        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                string commentsFileName = Assembly.GetExecutingAssembly().GetName().Name + ".xml";
                commentsFileName = Path.Combine(AppContext.BaseDirectory, commentsFileName);
                c.IncludeXmlComments(commentsFileName);
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Iberdrola 3P API", Version = "v1" });
            });

            return services;
        }
    }
}
