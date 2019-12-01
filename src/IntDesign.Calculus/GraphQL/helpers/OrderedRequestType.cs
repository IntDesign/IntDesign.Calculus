using Calculus.Core.GraphQl.enums;
using Calculus.Core.GraphQl.requestHelpers;
using GraphQL.Types;

namespace Calculus.GraphQL.helpers
{
    public class OrderedRequestType : InputObjectGraphType<OrderedRequest>
    {
        public OrderedRequestType()
        {
            Field(x => x.OrderBy, true).Description("Name of the Property to sort by");
            Field<OrderDirectionEnum>("orderDirection", resolve: _ => _.Source.OrderDirection);
        }
    }
}