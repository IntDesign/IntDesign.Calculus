using System;
using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.MainModels;
using Calculus.GraphQL.actionModels.inputs.room;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.models;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class RoomQueries : ObjectGraphType
    {
        public RoomQueries(IRoomRepository roomRepository)
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
                    var (count, rooms) = await roomRepository.SearchAsync(filtering, pagination, ordering);
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