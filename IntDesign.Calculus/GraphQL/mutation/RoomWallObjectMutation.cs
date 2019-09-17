using Calculus.Core.Models.MainModels;
using Calculus.GraphQL.actionModel.input.roomWallObject;
using Calculus.GraphQL.actionModel.output;
using Calculus.Repositories.model;
using GraphQL.Types;

namespace Calculus.GraphQL.mutation
{
    public class RoomWallObjectMutation : ObjectGraphType
    {
        
        public RoomWallObjectMutation(IRoomWallObjectRepository repository, IRoomRepository roomRepository)
        {
            FieldAsync<RoomWallObjectQueryType>(
                "addRoom",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<RoomWallObjectCreateViewModel>>
                {
                    Name = "WallObject"
                }),
                resolve: async context =>
                {
                    var wallObject = context.GetArgument<RoomWallObject>("WallObject");
                    return await context.TryAsyncResolve(async _ => await repository.AddWallObject(wallObject));
                }
            );
        }
    }
}