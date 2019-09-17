using Calculus.Core.Models.GraphQl.enums;
using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.room
{
    public class RoomCreateViewModel: InputObjectGraphType<Room>
    {
        public RoomCreateViewModel()
        {
            Field(t => t.Lenght, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("The Room Lenght");
            Field(t => t.Height, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("The Room Height");
            Field(t => t.Width, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("The Room Width");
            Field(t => t.CustomLenght, true, typeof(NonNullGraphType<FloatGraphType>))
                .Description("The Room Custom Lenght (LDat)");
            Field(t => t.CustomWidth, true, typeof(NonNullGraphType<FloatGraphType>))
                .Description("The Room Custom Width (ldat)");
            Field(t => t.CustomHeightOne, true, typeof(NonNullGraphType<FloatGraphType>))
                .Description("The Room Custom Height 1 (d1)");
            Field(t => t.CustomHeightTwo, true, typeof(NonNullGraphType<FloatGraphType>))
                .Description("The Room Custom Height 2 (d1)");
            Field(t => t.Type, false, typeof(NonNullGraphType<RoomTypeEnum>));
            Field(t => t.HouseId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The House id that contains this room");
        }
    }
}