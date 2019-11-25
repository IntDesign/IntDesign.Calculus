using Calculus.Core.GraphQl.enums;
using Calculus.Core.Models;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.roomWallObject
{
    public class RoomWallObjectCreateViewModel : InputObjectGraphType<RoomWallObject>
    {
        public RoomWallObjectCreateViewModel()
        {
            Field(t => t.Lenght, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("The RoomWallObject Lenght");
            Field(t => t.Width, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("The RoomWallObject Width");
            Field(t => t.RoomId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The RoomWallObject id that contains this room");
            Field(t => t.Type, false, typeof(NonNullGraphType<RoomWallObjectTypeEnum>))
                .Description("The RoomWallObject id that contains this room");
            Field(t => t.Number, true, typeof(RoomWallObjectTypeEnum))
                .Description("The Number of objects in Room, default is 1").DefaultValue(1);
        }
    }
}