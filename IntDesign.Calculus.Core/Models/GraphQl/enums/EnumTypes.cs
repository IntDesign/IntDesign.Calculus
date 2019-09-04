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

    public class RoomObjectTypeEnum : EnumerationGraphType<RoomObjectType>
    {
        public RoomObjectTypeEnum()
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
}