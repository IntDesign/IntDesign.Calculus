using Calculus.Core.Models.Enums;
using Calculus.Core.Models.GraphQl.requestHelpers;
using GraphQL.Types;

namespace Calculus.Core.Models.GraphQl.enums
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