using Calculus.Core.Models.GraphQl;
using Calculus.Core.Models.GraphQl.enums;
using GraphQL.Types;

namespace Calculus.GraphQL.helpers
{
    public class OrderedRequestType : InputObjectGraphType<OrderedRequest>
    {
        public OrderedRequestType()
        {
            Field(x => x.OrderBy, true).Description("Name of the Property to sort by");
            Field<OrderDirectionEnum>("orderDirection", resolve: c => c.Source.OrderDirection);
        }
    }
}