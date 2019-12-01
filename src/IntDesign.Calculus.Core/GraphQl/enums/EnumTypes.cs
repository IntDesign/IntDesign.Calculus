using Calculus.Core.Enums;
using Calculus.Core.GraphQl.requestHelpers;
using GraphQL.Types;

namespace Calculus.Core.GraphQl.enums
{
    public class OrderDirectionEnum : EnumerationGraphType<OrderDirection>
    {
        public OrderDirectionEnum()
        {
            Name = "Order Type";
        }
    }

    public class RoomWallObjectTypeEnum : EnumerationGraphType<RoomObjectType>
    {
        public RoomWallObjectTypeEnum()
        {
            Description = "Room Object Type";
        }
    }

    public class RoomTypeEnum : EnumerationGraphType<RoomType>
    {
        public RoomTypeEnum()
        {
            Description = "Room Type";
        }
    }
    
    public class JobRequestTypeEnum : EnumerationGraphType<JobRequestType>
    {
        public JobRequestTypeEnum()
        {
            Description = "RoomJob Type";
        }
    }
}