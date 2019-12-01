using Calculus.Core.Models;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class HouseQueryType : ObjectGraphType<House>
    {
        public HouseQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType)).Description("House ID");
            Field(t => t.HouseAddress, false, typeof(StringGraphType)).Description("House Address");
            Field(t => t.OwnerName, false, typeof(StringGraphType)).Description("House Owner Name");
            Field(t => t.OwnerEmail, true, typeof(StringGraphType)).Description("House Owner Email");
            Field(t => t.OwnerPhone, false, typeof(StringGraphType)).Description("House Owner Phone");
            Field(t => t.UserId, false, typeof(StringGraphType)).Description("House User Id");
        }
    }
}