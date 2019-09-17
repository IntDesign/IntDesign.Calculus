using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModels.types
{
    public class RoomQueryType : ObjectGraphType<Room>
    {
        public RoomQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType)).Description("Room ID");
            Field(t => t.Width, false, typeof(StringGraphType)).Description("Room Width");
            Field(t => t.Height, false, typeof(StringGraphType)).Description("Room Height");
            Field(t => t.Lenght, false, typeof(StringGraphType)).Description("Room Lenght");
            Field(t => t.Afm, false, typeof(StringGraphType)).Description("Room Afm");
            Field(t => t.SpecialAfm, false, typeof(StringGraphType)).Description("Room Special Afm");
            Field(t => t.Asp, false, typeof(StringGraphType)).Description("Room Asp");
            Field(t => t.EmptyAsp, false, typeof(StringGraphType)).Description("Room Empty Asp");
            Field(t => t.Atv, false, typeof(StringGraphType)).Description("Room Pc");
            Field(t => t.Pc, false, typeof(StringGraphType)).Description("Room Atv");
        }
    }
}