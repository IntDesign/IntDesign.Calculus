using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.roomWallObject
{
    public class RoomWallObjectCreateViewModel : InputObjectGraphType<RoomWallObject>
    {
        public RoomWallObjectCreateViewModel()
        {
            Field(t => t.Lenght, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The RoomWallObject Lenght");
            Field(t => t.Width, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The RoomWallObject Width");
            Field(t => t.RoomId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The RoomWallObject id that contains this room");
        }
    }
}