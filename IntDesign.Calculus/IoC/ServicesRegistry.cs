using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.enums;
using Calculus.GraphQL.mutation;
using Calculus.GraphQL.schemas;
using Calculus.GraphQL.schemas.models;
using Calculus.GraphQL.schemas.schemaGroups;
using Calculus.Repositories.implementations;
using Calculus.Repositories.models;
using GraphQL;
using GraphQL.Server;
using GraphQL.Types;
using GraphQL.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Calculus.IoC
{
    public static class ServicesRegistry
    {
        public static void ResolveRepositories(IServiceCollection services)
        {
            services.AddScoped<IHouseRepository, HouseRepository>();
        }

        public static void ResolveGraphQl(IServiceCollection services)
        {
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            // Add Here New Schemas

            services.AddScoped<ISchemaGroup, HouseSchema>();
            services.AddSingleton<OrderDirectionEnum>();
            GraphTypeTypeRegistry.Register(typeof(OrderDirection), typeof(EnumerationGraphType<OrderDirection>));
            services.AddScoped<RootSchema>();
            services.AddScoped<RootMutation>();

            services.AddScoped<ISchema, RootSchema>();
            services.AddGraphQL(opt => { opt.ExposeExceptions = true; })
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddDataLoader();
        }
    }
}