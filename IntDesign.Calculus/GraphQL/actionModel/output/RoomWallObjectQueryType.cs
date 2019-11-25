using Calculus.Core.GraphQl.enums;
using Calculus.Core.Models;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class RoomWallObjectQueryType : ObjectGraphType<RoomWallObject>
    {
        public RoomWallObjectQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType)).Description("Wall Object ID");
            Field(t => t.Width, false, typeof(FloatGraphType)).Description("Wall Object Width");
            Field(t => t.Lenght, false, typeof(FloatGraphType)).Description("Wall Object Lenght");
            Field(t => t.Area, false, typeof(FloatGraphType)).Description("Wall Object Area");
            Field(t => t.Number, false, typeof(FloatGraphType)).Description("Wall Object Number in Room");
            Field(t => t.RoomId, false, typeof(StringGraphType)).Description("The Room Id that contains this object");
            Field<RoomWallObjectTypeEnum>("WallObjectType", resolve: _ => _.Source.Type);
        }
    }
}