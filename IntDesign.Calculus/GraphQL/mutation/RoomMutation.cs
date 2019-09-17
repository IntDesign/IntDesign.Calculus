using Calculus.Core.Models.MainModels;
using Calculus.GraphQL.actionModels.inputs.room;
using Calculus.GraphQL.actionModels.types;
using Calculus.Repositories.models;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class RoomMutation : ObjectGraphType
    {
        public RoomMutation(IRoomRepository roomRepository)
        {
            var mRoomRepository = roomRepository;
            FieldAsync<RoomQueryType>(
                "addRoom",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<RoomCreateViewModel>>
                {
                    Name = "room"
                }),
                resolve: async context =>
                {
                    var room = context.GetArgument<Room>("Room");
                    return await context.TryAsyncResolve(async c => await mRoomRepository.AddRoom(room));
                }
            );

        }
    }
}