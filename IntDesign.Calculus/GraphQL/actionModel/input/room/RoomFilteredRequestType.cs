using Calculus.Core.Models.GraphQl.filters;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.room
{
    public class RoomFilteredRequestType : InputObjectGraphType<RoomFilter>
    {
        public RoomFilteredRequestType()
        {
            Field(t => t.SearchTerm, true, typeof(StringGraphType));
            Field(t => t.Ids, true, typeof(ListGraphType<StringGraphType>));
        }
    }
}