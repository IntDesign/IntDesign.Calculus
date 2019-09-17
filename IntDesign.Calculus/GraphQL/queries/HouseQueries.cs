using System;
using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.MainModels;
using Calculus.GraphQL.actionModel.input.house;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class HouseQueries : ObjectGraphType
    {
        public HouseQueries(IHouseRepository houseRepository)
        {
            FieldAsync<ListHouseQueryModelType>(
                "search",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PagedRequestType>> {Name = "pagination"},
                    new QueryArgument<NonNullGraphType<OrderedRequestType>> {Name = "ordering"},
                    new QueryArgument<HouseFilteredRequestType> {Name = "filter", DefaultValue = new HouseFilter()}
                ),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<HouseFilter>("filter");
                    var pagination = context.GetArgument<PagedRequest>("pagination");
                    var ordering = context.GetArgument<OrderedRequest>("ordering");
                    var (count, houses) = await houseRepository.SearchAsync(filtering, pagination, ordering);
                    return new ListResult<House>
                    {
                        TotalCount = count,
                        Items = houses
                    };
                }
            );
        }
    }
}