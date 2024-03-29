using Calculus.Core.GraphQl.enums;
using Calculus.GraphQL.mutation;
using Calculus.GraphQL.schemas;
using Calculus.GraphQL.schemas.models;
using Calculus.GraphQL.schemas.schemaGroups;
using Calculus.Handlers.implementations;
using Calculus.Handlers.models;
using Calculus.Repositories.implementation;
using Calculus.Repositories.model;
using GraphQL;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace Calculus.IoC
{
    public static class ServicesRegistry
    {
        public static void ResolveRepositories(IServiceCollection services)
        {
            services.AddScoped<IHouseRepository, HouseRepository>();
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IRoomWallObjectRepository, RoomWallObjectRepository>();
            services.AddScoped<IRoomJobRepository, RoomJobRepository>();
            services.AddScoped<IMaterialRepository, MaterialRepository>();
            services.AddScoped<IMaterialInformationRepository, MaterialInformationRepository>();
            services.AddScoped<IMaterialExpenditureRepository, MaterialExpenditureRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
        
        public static void ResolveHandlers(IServiceCollection services)
        {
            services.AddScoped<ILoginHandler, LoginHandler>();
     
        }

        public static void ResolveGraphQl(IServiceCollection services)
        {
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));

            // Add Here GraphQl Enums
            services.AddSingleton<OrderDirectionEnum>();
            services.AddSingleton<JobRequestTypeEnum>();
            services.AddSingleton<RoomTypeEnum>();
            services.AddSingleton<RoomWallObjectTypeEnum>();

            // Add Here New Schemas
            services.AddScoped<ISchemaGroup, HouseSchema>();
            services.AddScoped<ISchemaGroup, RoomSchema>();
            services.AddScoped<ISchemaGroup, RoomWallObjectSchema>();
            services.AddScoped<ISchemaGroup, RoomJobSchema>();
            services.AddScoped<ISchemaGroup, MaterialSchema>();
            services.AddScoped<ISchemaGroup, MaterialInformationSchema>();
            services.AddScoped<ISchemaGroup, MaterialExpenditureSchema>();
            services.AddScoped<ISchemaGroup, UserSchema>();
            services.AddScoped<ISchemaGroup, LoginSchema>();

            services.AddScoped<RootSchema>();
            services.AddScoped<RootMutation>();
            services.AddScoped<ISchema, RootSchema>();

            services.AddGraphQL(opt => { opt.ExposeExceptions = true; })
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddDataLoader();
        }
    }
}