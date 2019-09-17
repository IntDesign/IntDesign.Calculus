using Calculus.Core.Models.Enums;
using GraphQL.Types;

namespace Calculus.Core.Models.GraphQl.enums
{
    public class MaterialTypeEnum : EnumerationGraphType<MaterialType>
    {
        public MaterialTypeEnum()
        {
            Description = "Material Type";
        }
    }

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
    
    public class JobTypeEnum : EnumerationGraphType<JobType>
    {
        public JobTypeEnum()
        {
            Description = "RoomJob Type";
        }
    }
}