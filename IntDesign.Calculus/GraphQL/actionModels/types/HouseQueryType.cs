using Calculus.Core.Models.MainModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModels.types
{
    public class HouseQueryType : ObjectGraphType<House>
    {
        public HouseQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType)).Description("House ID");
            Field(t => t.HouseAddress, false, typeof(StringGraphType)).Description("House ID");
            Field(t => t.OwnerName, false, typeof(StringGraphType)).Description("House ID");
            Field(t => t.OwnerEmail, true, typeof(StringGraphType)).Description("House ID");
            Field(t => t.OwnerPhone, false, typeof(StringGraphType)).Description("House ID");
        }
    }
}