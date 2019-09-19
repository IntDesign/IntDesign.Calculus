using Calculus.Core.Models.SecondaryModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.material
{
    public class MaterialCreateViewModel : InputObjectGraphType<Material>
    {
        public MaterialCreateViewModel()
        {
            Field(t => t.MaterialName, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("Material Name");
            Field(t => t.RoomJobId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("Material RoomJob Id that needs this material");
        }
    }
}