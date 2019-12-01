using System;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.house;
using Calculus.GraphQL.actionModel.output;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class HouseMutation : ObjectGraphType
    {
        public HouseMutation(IHouseRepository repository)
        {
            var mHouseRepository = repository;
            FieldAsync<HouseQueryType>(
                "addHouse",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<HouseCreateViewModel>>
                {
                    Name = "house"
                }),
                resolve: async context =>
                {
                    var house = context.GetArgument<House>("house");
                    return await context.TryAsyncResolve(async _ => await mHouseRepository.AddHouse(house));
                }
            );

            FieldAsync<HouseQueryType>(
                "removeHouse",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>>
                {
                    Name = "id"
                }),
                resolve: async context =>
                {
                    var id = context.GetArgument<string>("id");
                    return await context.TryAsyncResolve(
                        async _ => await mHouseRepository.RemoveHouse(Guid.Parse(id))
                    );
                }
            );
        }
    }
}