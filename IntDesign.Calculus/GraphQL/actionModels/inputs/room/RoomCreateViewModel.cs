using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModels.inputs.room
{
    public class RoomCreateViewModel: InputObjectGraphType<Room>
    {
        public RoomCreateViewModel()
        {
            Field(t => t.Lenght, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The Room Lenght");
            Field(t => t.Height, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The Room Height");
            Field(t => t.Width, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The Room Width");
            Field(t => t.HouseId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The House id that contains this room");
        }
    }
}