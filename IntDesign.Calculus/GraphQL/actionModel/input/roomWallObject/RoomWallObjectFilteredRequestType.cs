using Calculus.Core.Models.GraphQl.filters;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.roomWallObject
{
    public class RoomWallObjectFilteredRequestType: InputObjectGraphType<RoomWallObjectFilter>
    {
        public RoomWallObjectFilteredRequestType()
        {
            Field(t => t.SearchTerm, true, typeof(StringGraphType));
            Field(t => t.Ids, true, typeof(ListGraphType<StringGraphType>));
        }
    }
}