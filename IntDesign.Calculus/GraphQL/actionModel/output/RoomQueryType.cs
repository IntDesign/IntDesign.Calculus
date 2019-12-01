using Calculus.Core.Models;
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
            Field(t => t.Type, false, typeof(StringGraphType)).Description("Room Type");
            Field(t => t.Afm, false, typeof(FloatGraphType)).Description("Room Afm");
            Field(t => t.SpecialAfm, false, typeof(FloatGraphType)).Description("Room Special Afm");
            Field(t => t.Asp, false, typeof(FloatGraphType)).Description("Room Asp");
            Field(t => t.EmptyAsp, false, typeof(FloatGraphType)).Description("Room Empty Asp");
            Field(t => t.Atv, false, typeof(FloatGraphType)).Description("Room Atv");
            Field(t => t.Pc, false, typeof(FloatGraphType)).Description("Room Pc");
            Field(t => t.CustomLenght, true, typeof(FloatGraphType)).Description("Room Custom Lenght (Ldat)");
            Field(t => t.CustomWidth, true, typeof(FloatGraphType)).Description("Room Custom Width (ldat)");
            Field(t => t.CustomHeightOne, true, typeof(FloatGraphType)).Description("Room Custom Height 1 (d1)");
            Field(t => t.CustomHeightTwo, true, typeof(FloatGraphType)).Description("Room Custom Height 2 (d2)");
            Field(t => t.WallRealCoefficient, false, typeof(FloatGraphType)).Description("Room Walls Real Coefficient (f)");
            Field(t => t.TilesParquetCoefficient, false, typeof(FloatGraphType)).Description("Room Parquet or Tiles Coefficient (g)");
            Field(t => t.SpecialTilesParquetCoefficient, false, typeof(FloatGraphType)).Description("Room Special Parquet or Tiles Coefficient (gspecial)");
            Field(t => t.HouseId, false, typeof(StringGraphType)).Description("The House id that contains this room");
        }
    }
}