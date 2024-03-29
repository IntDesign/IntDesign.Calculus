using System;
using Calculus.Core.Models;
using Calculus.GraphQL.actionModel.input.room;
using Calculus.GraphQL.actionModel.output;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class RoomMutation : ObjectGraphType
    {
        public RoomMutation(IRoomRepository repository)
        {
            FieldAsync<RoomQueryType>(
                "addRoom",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<RoomCreateViewModel>>
                {
                    Name = "room"
                }),
                resolve: async context =>
                {
                    var room = context.GetArgument<Room>("room");
                    return await context.TryAsyncResolve(async _ => await repository.AddRoom(room));
                }
            );

            FieldAsync<RoomQueryType>(
                "updateRoomValues",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<StringGraphType>>
                {
                    Name = "roomId"
                }),
                resolve: async context =>
                {
                    Guid.TryParse(context.GetArgument<string>("roomId"), out var id);
                    return await context.TryAsyncResolve(async _ => await repository.UpdateRoomValues(id));
                }
            );
        }
    }
}