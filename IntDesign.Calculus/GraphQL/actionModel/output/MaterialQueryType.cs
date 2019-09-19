using Calculus.Core.Models.SecondaryModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.output
{
    public class MaterialQueryType : ObjectGraphType<Material>
    {
        public MaterialQueryType()
        {
            Field(t => t.Id, false, typeof(StringGraphType))
                .Description("Material ID");
            Field(t => t.MaterialName, false, typeof(StringGraphType))
                .Description("Material Name");
            Field(t => t.RoomJobId, false, typeof(StringGraphType))
                .Description("Room Job Id of the RoomJob that needs this material");
        }
    }
}