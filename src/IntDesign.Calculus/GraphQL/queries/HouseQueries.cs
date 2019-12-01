using System;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.house;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class HouseQueries : ObjectGraphType
    {
        public HouseQueries(IHouseRepository repository)
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
                    var (count, houses) = await repository.SearchAsync(filtering, pagination, ordering);
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