using System;
using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.JobModels;
using Calculus.GraphQL.actionModels.inputs.house;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.models;
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
                    new QueryArgument<HouseFilteredRequestType> {Name = "filter", DefaultValue = new HouseFiltering()}
                ),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<HouseFiltering>("filter");
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