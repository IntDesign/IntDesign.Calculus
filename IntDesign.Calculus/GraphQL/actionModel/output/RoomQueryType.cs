using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class RoomQueryType : ObjectGraphType<Room>
    {
        public RoomQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType)).Description("Room ID");
            Field(t => t.Width, false, typeof(FloatGraphType)).Description("Room Width");
            Field(t => t.Height, false, typeof(FloatGraphType)).Description("Room Height");
            Field(t => t.Lenght, false, typeof(FloatGraphType)).Description("Room Lenght");
            Field(t => t.Afm, false, typeof(FloatGraphType)).Description("Room Afm");
            Field(t => t.SpecialAfm, false, typeof(FloatGraphType)).Description("Room Special Afm");
            Field(t => t.Asp, false, typeof(FloatGraphType)).Description("Room Asp");
            Field(t => t.EmptyAsp, false, typeof(FloatGraphType)).Description("Room Empty Asp");
            Field(t => t.Atv, false, typeof(FloatGraphType)).Description("Room Atv");
            Field(t => t.Pc, false, typeof(FloatGraphType)).Description("Room Pc");
            Field(t => t.HouseId, false, typeof(StringGraphType)).Description("he House id that contains this room");

        }
    }
}