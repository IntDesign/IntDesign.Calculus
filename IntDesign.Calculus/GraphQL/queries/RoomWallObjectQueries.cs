using System;
using Calculus.Core.GraphQl.filters;
using Calculus.Core.GraphQl.requestHelpers;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.roomWallObject;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class RoomWallObjectQueries : ObjectGraphType
    {
        public RoomWallObjectQueries(IRoomWallObjectRepository repository)
        {
            FieldAsync<ListRoomWallObjectQueryModelType>(
                "search",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PagedRequestType>> {Name = "pagination"},
                    new QueryArgument<NonNullGraphType<OrderedRequestType>> {Name = "ordering"},
                    new QueryArgument<RoomWallObjectFilteredRequestType> {Name = "filter", DefaultValue = new RoomWallObjectFilter()}
                ),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<RoomWallObjectFilter>("filter");
                    var pagination = context.GetArgument<PagedRequest>("pagination");
                    var ordering = context.GetArgument<OrderedRequest>("ordering");
                    var (count, roomWallObjects) = await repository.SearchAsync(filtering, pagination, ordering);
                    return new ListResult<RoomWallObject>
                    {
                        TotalCount = count,
                        Items = roomWallObjects
                    };
                }
            );
        }
    }
}