using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModels.inputs.house
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
        }
    }
}