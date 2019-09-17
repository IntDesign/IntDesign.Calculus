using Calculus.Core.Models.GraphQl.enums;
using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class RoomWallObjectQueryType : ObjectGraphType<RoomWallObject>
    {
        public RoomWallObjectQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType)).Description("Wall Object ID");
            Field(t => t.Width, false, typeof(FloatGraphType)).Description("Wall Object ID");
            Field(t => t.Lenght, false, typeof(FloatGraphType)).Description("Wall Object ID");
            Field(t => t.Area, false, typeof(FloatGraphType)).Description("Wall Object ID");
            Field(t => t.RoomId, false, typeof(StringGraphType)).Description("The Room Id that contains this object");
            Field<RoomWallObjectTypeEnum>("WallObjectType", resolve: _ => _.Source.Type);
        }
    }
}