using Calculus.Core.Models.SecondaryModels;
using GraphQL.Types;

namespace Calculus.GraphQL.actionModel.input.materialInformation
{
    public class MaterialInformationCreateViewModel : InputObjectGraphType<MaterialInformation>
    {
        public MaterialInformationCreateViewModel()
        {
            Field(t => t.MaterialId, false, typeof(NonNullGraphType<StringGraphType>))
                .Description("Material Info Material Id");
            Field(t => t.ProviderId, true, typeof(StringGraphType))
                .Description("Material Info Provider Id");
            Field(t => t.ConsumptionX, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("Material Info Consumption x");
            Field(t => t.ConsumptionZ, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("Material Info Consumption Z");
            Field(t => t.AppliedLayers, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("Material Info Consumption x");
            Field(t => t.UnitCover, false, typeof(NonNullGraphType<FloatGraphType>))
                .Description("Material Info Consumption x");
        }
    }
}