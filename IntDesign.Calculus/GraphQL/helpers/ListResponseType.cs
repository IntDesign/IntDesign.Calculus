using System.Collections.Generic;
using Calculus.GraphQL.actionModel.output;
using GraphQL.Types;

namespace Calculus.GraphQL.helpers
{
    public class ListResponseType<T> : ObjectGraphType<object> where T : IGraphType
    {
        protected ListResponseType()
        {
            Field<IntGraphType>().Name("totalCount")
                .Description("A count of the total number of objects in this connection, ignoring pagination.");
            Field<ListGraphType<T>>().Name("items")
                .Description("A list of all of the objects returned in the connection.");
        }
    }

    public class ListResult<T>
    {
        public long TotalCount { get; set; }
        public IList<T> Items { get; set; }
    }

    public class ListHouseQueryModelType : ListResponseType<HouseQueryType>
    {
    }

    public class ListRoomQueryModelType : ListResponseType<RoomQueryType>
    {
    }
    
    public class ListRoomWallObjectQueryModelType : ListResponseType<RoomWallObjectQueryType>
    {
    }
    
    public class ListRoomJobQueryModelType : ListResponseType<RoomWallObjectQueryType>
    {
    }
}