using Calculus.Core.GraphQl.filters;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.roomJob
{
    public class RoomJobFilteredRequestType : InputObjectGraphType<RoomJobFilter>
    {
        public RoomJobFilteredRequestType()
        {
            Field(t => t.SearchTerm, true, typeof(StringGraphType));
            Field(t => t.Ids, true, typeof(ListGraphType<StringGraphType>));
        }
    }
}