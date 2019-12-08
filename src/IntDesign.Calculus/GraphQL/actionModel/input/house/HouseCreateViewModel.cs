using Calculus.Core.Models;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.house
{
    public class HouseCreateViewModel : InputObjectGraphType<House>
    {
        public HouseCreateViewModel()
        {
            Field(t => t.HouseAddress, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("House Address");
            Field(t => t.OwnerName, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The Owner Name");
            Field(t => t.OwnerPhone, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The Owner Phone");
            Field(t => t.OwnerEmail, true, typeof(StringGraphType))
                .Description("The Owner email");
            Field(t => t.UserId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("The User Id that have this house");
        }
    }
}