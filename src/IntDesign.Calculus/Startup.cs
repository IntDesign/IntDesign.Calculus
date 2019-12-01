using Calculus.Context;
using Calculus.Core.Tools;
using Calculus.IoC;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Calculus
{
    public class Startup
    {
        private readonly IConfiguration m_configuration;

        public Startup(IConfiguration configuration) => m_configuration = configuration;
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.Configure<AppSettings>(m_configuration.GetSection("AppSettings"));
            services.AddScoped<AppSettings>();
            services.AddDbContext<DataContext>();
            ServicesRegistry.ResolveRepositories(services);
            ServicesRegistry.ResolveGraphQl(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseGraphQL<ISchema>();
            app.Run(async context => { await context.Response.WriteAsync("Hello World!"); });
        }
    }
}