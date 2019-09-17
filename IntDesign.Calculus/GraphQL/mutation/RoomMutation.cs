using Calculus.Core.Models.MainModels;
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
                    var room = context.GetArgument<Room>("Room");
                    return await context.TryAsyncResolve(async _ => await repository.AddRoom(room));
                }
            );

        }
    }
}