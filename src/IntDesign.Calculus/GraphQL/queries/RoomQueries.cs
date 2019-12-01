using System;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.room;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class RoomQueries : ObjectGraphType
    {
        public RoomQueries(IRoomRepository repository)
        {
            FieldAsync<ListRoomQueryModelType>(
                "search",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PagedRequestType>> {Name = "pagination"},
                    new QueryArgument<NonNullGraphType<OrderedRequestType>> {Name = "ordering"},
                    new QueryArgument<RoomFilteredRequestType> {Name = "filter", DefaultValue = new RoomFilter()}
                ),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<RoomFilter>("filter");
                    var pagination = context.GetArgument<PagedRequest>("pagination");
                    var ordering = context.GetArgument<OrderedRequest>("ordering");
                    var (count, rooms) = await repository.SearchAsync(filtering, pagination, ordering);
                    return new ListResult<Room>
                    {
                        TotalCount = count,
                        Items = rooms
                    };
                }
            );
        }
    }
}