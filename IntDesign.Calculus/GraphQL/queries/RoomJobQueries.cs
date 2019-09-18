using System;
using Calculus.Core.Models.GraphQl.filters;
using Calculus.Core.Models.GraphQl.requestHelpers;
using Calculus.Core.Models.MainModels;
using Calculus.GraphQL.actionModel.input.roomJob;
using Calculus.GraphQL.helpers;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.queries
{
    public class RoomJobQueries : ObjectGraphType
    {
        public RoomJobQueries(IRoomJobRepository repository)
        {
            FieldAsync<ListRoomJobQueryModelType>(
                "search",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PagedRequestType>> {Name = "pagination"},
                    new QueryArgument<NonNullGraphType<OrderedRequestType>> {Name = "ordering"},
                    new QueryArgument<RoomJobFilteredRequestType> {Name = "filter", DefaultValue = new RoomJobFilter()}
                ),
                resolve: async context =>
                {
                    var filtering = context.GetArgument<RoomJobFilter>("filter");
                    var pagination = context.GetArgument<PagedRequest>("pagination");
                    var ordering = context.GetArgument<OrderedRequest>("ordering");
                    var (count, rooms) = await repository.SearchAsync(filtering, pagination, ordering);
                    return new ListResult<RoomJob>
                    {
                        TotalCount = count,
                        Items = rooms
                    };
                }
            );
        }
    }
}