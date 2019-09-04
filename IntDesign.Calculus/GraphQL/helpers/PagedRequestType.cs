using Calculus.Core.Models.GraphQl;
using GraphQL.Types;

namespace Calculus.GraphQL.helpers
{
    public class PagedRequestType : InputObjectGraphType<PagedRequest>
    {
        public PagedRequestType()
        {
            Field(x => x.Take, true);
            Field(x => x.Offset, true);
        }
    }
}