
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Core
{
    public static class SitePipeline
    {
        public static IApplicationBuilder AddSwaggerPipeline(this IApplicationBuilder app)
        {
            return app.UseSwagger(c => c.RouteTemplate = "docs/{documentName}/swagger.json")
                .UseSwaggerUI(c => c.SwaggerEndpoint("/docs/v1/swagger.json", "Iberdrola 3P"));
        }
    }
}
